using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager_DotNet
{
    /*******************************************************************************/
    public partial class FileSearchForm : Form
    {
        private CancellationTokenSource cancellationTokenSource;
        TaskScheduler uiScheduler;
        FileSearcherIEnumerable fileSearcherIEnumerable;

        /*******************************************************************************/
        public FileSearchForm()
        {
            InitializeComponent();

            uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();
            fileSearcherIEnumerable = new FileSearcherIEnumerable(uiScheduler);

            listView.ColumnClick += new ColumnClickEventHandler(ColumnClick);
        }

        /*******************************************************************************/
        public void CollectSearchedData()
        {
            FilterOptions.SetSearchedFileNames(
                string.IsNullOrWhiteSpace(enterName_textBox.Text),
                enterName_textBox.Text);

            FilterOptions.SetSearchedFileExtensions(
                string.IsNullOrWhiteSpace(enterExtension_textBox.Text),
                enterExtension_textBox.Text);

            FilterOptions.SetSearchedFileSizes(
                string.IsNullOrWhiteSpace(maxSize_textBox.Text),
                minSize_textBox.Text,
                maxSize_textBox.Text);
        }

        /*******************************************************************************/
        private void ColumnClick(object o, ColumnClickEventArgs e)
        {
            ColumnHeader currentColumn = listView.Columns[e.Column];

            var sortOrder = ListViewSorter.SetSortingOrder(currentColumn);

            listView.ListViewItemSorter = new ListViewSorter(e.Column, sortOrder);

            listView.Sort();
        }

        /*******************************************************************************/
        private void startSearch_button_Click(object sender, EventArgs e)
        {
            CollectSearchedData();
            SwitchFormComponentsToDefault();

            startSearch_button.Enabled = false;
            cancelSearch_button.Enabled = true;

            cancellationTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellationTokenSource.Token;

            var folderPath = FilterOptions.FolderPath;
            var searchPattern = FilterOptions.FileName + FilterOptions.FileExtension;
            var minSize = FilterOptions.FileMinSize;
            var maxSize = FilterOptions.FileMaxSize;

            Task.Factory.StartNew(() => fileSearcherIEnumerable.StartFileSearch(
                folderPath,
                searchPattern,
                minSize,
                maxSize,
                listView,
                searchCounter_label,
                FileSearcherIEnumerable.CurrentFileToListView,
                cancellationToken), cancellationToken)

            .ContinueWith(x =>
            {
                searchDone_label.Invoke(new Action(() => searchDone_label.Text = "Поиск завершен!"));

                startSearch_button.Invoke(new Action(() => startSearch_button.Enabled = true));

                listView.Invoke(new Action(() => listView.HeaderStyle = ColumnHeaderStyle.Clickable));
            });

            FilterOptions.SetSizesToDefault();
        }

        /*******************************************************************************/
        private void cancelSearch_button_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel();

            SwitchFormComponentsToDefault();
        }

        /*******************************************************************************/
        private void listView_ItemActivate(object sender, EventArgs e)
        {
            string currentFile = listView.SelectedItems[0].SubItems[1].Text;

            if (File.Exists(currentFile))
            {
                try
                {
                    Process.Start(currentFile);
                }
                catch (Exception) { }
            }
        }

        /*******************************************************************************/
        public void SwitchFormComponentsToDefault()
        {
            listView.Items.Clear();
            listView.HeaderStyle = ColumnHeaderStyle.Nonclickable;

            enterName_textBox.Text = string.Empty;
            enterExtension_textBox.Text = string.Empty;
            minSize_textBox.Text = string.Empty;
            maxSize_textBox.Text = string.Empty;

            startSearch_button.Enabled = true;
            cancelSearch_button.Enabled = false;
            searchDone_label.Text = string.Empty;
            searchCounter_label.Text = "0";
        }
    }
}
