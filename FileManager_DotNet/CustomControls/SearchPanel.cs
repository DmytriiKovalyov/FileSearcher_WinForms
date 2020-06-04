using System;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Concurrency;

namespace FileManager_DotNet.CustomControls
{
    /*******************************************************************************/
    public partial class SearchPanel : UserControl
    {
        FileSearcher fileSearcher;

        IObservable<IList<FileInfo>> bufferedResult;
        IObservable<IList<FileInfo>> bufferedWithTimer;
        IDisposable subscription;

        /*******************************************************************************/
        public SearchPanel()
        {
            InitializeComponent();

            fileSearcher = new FileSearcher();

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
            SwitchFormComponentsBeforeSearch();

            var folderPath = FilterOptions.FolderPath;
            var searchPattern = FilterOptions.FileName + FilterOptions.FileExtension;
            var minSize = FilterOptions.FileMinSize;
            var maxSize = FilterOptions.FileMaxSize;

            bufferedResult =
                fileSearcher.SearchResults(folderPath, searchPattern, minSize, maxSize)
                .ToObservable(NewThreadScheduler.Default)
                .Buffer(300);

            bufferedWithTimer =
                Observable.Interval(TimeSpan.FromSeconds(1), NewThreadScheduler.Default)
                .Zip(bufferedResult, (a, b) => b)
                .ObserveOn(SynchronizationContext.Current);

            subscription = bufferedWithTimer.Subscribe(OutputResults);
        }

        /***********************************************************/
        void OutputResults(IEnumerable<FileInfo> results)
        {
            listView.BeginUpdate();

            foreach (var file in results)
            {
                ListViewAddItem(file);
            }

            listView.EndUpdate();

            if (listView.Items.Count == FilterOptions.FilesCount)
            {
                SwitchFormComponentsAfterSearch();
            }
        }

        /*******************************************************************************/
        private void ListViewAddItem(FileInfo file)
        {
            var fileName = file.Name;
            var folderName = file.FullName;
            var fileType = file.Extension;
            var fileSize = file.Length / 1024;
            var fileSizetoKB = (fileSize < 1) ? 1.ToString() : fileSize.ToString();

            ListViewItem lvi = new ListViewItem(fileName);

            lvi.SubItems.Add(folderName);
            lvi.SubItems.Add(fileType);
            lvi.SubItems.Add(fileSizetoKB);
            listView.Items.Add(lvi);

            searchCounter_label.Text = listView.Items.Count.ToString();
        }


        /*******************************************************************************/
        private void cancelSearch_button_Click(object sender, EventArgs e)
        {
            subscription.Dispose();
            subscription = null;

            SwitchFormComponentsAfterSearch();
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
        public void SwitchFormComponentsBeforeSearch()
        {
            startSearch_button.Enabled = false;
            cancelSearch_button.Enabled = true;

            listView.Items.Clear();

            listView.HeaderStyle = ColumnHeaderStyle.Nonclickable;

            searchDone_label.Text = string.Empty;
            searchCounter_label.Text = "0";
        }

        /*******************************************************************************/
        public void SwitchFormComponentsAfterSearch()
        {
            searchDone_label.Text = "Поиск завершен";

            listView.HeaderStyle = ColumnHeaderStyle.Clickable; 

            startSearch_button.Enabled = true;
            cancelSearch_button.Enabled = false;

            FilterOptions.FilesCount = 0;
        }
    }
}