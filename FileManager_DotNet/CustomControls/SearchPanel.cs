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
        FileSearcher fileSearcher;

        /*******************************************************************************/
        public SearchPanel()
        {
            InitializeComponent();

            uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();

            fileSearcher = new FileSearcher(uiScheduler);

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

            Task.Factory.StartNew(() => fileSearcher.StartFileSearch(
                folderPath,
                searchPattern,
                minSize,
                maxSize,
                listView,
                searchCounter_label,
                FileSearcher.CurrentFileToListView,
                cancellationToken), cancellationToken)

            .ContinueWith(x =>
            {
                searchDone_label.Text = "Поиск завершен!";
                startSearch_button.Enabled = true;
                cancelSearch_button.Enabled = false;
                listView.HeaderStyle = ColumnHeaderStyle.Clickable;
            }, TaskScheduler.FromCurrentSynchronizationContext());
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
