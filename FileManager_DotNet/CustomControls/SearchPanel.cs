using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace FileManager_DotNet.CustomControls
{
    /*******************************************************************************/
    public partial class SearchPanel : UserControl
    {
        private CancellationTokenSource cancellationTokenSource;
        TaskScheduler uiScheduler;
        FileSearcherIEnumerable fileSearcherIEnumerable;

        /*******************************************************************************/
        public SearchPanel()
        {
            InitializeComponent();

            uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();

            fileSearcherIEnumerable = new FileSearcherIEnumerable(uiScheduler);

            listView.ColumnClick += new ColumnClickEventHandler(ColumnClick);
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
                cancelSearch_button.Invoke(new Action(() => cancelSearch_button.Enabled = false));
                listView.Invoke(new Action(() => listView.HeaderStyle = ColumnHeaderStyle.Clickable));
            });
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

            startSearch_button.Enabled = true;
            cancelSearch_button.Enabled = false;

            searchDone_label.Text = string.Empty;
            searchCounter_label.Text = "0";
        }
    }
}
