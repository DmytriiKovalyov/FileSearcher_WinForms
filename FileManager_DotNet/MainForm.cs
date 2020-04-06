using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager_DotNet
{
    /*******************************************************************************/
    public partial class FileSearchForm : Form
    {
        TaskScheduler uiScheduler;
        FileSearcherIEnumerable fileSearcherIEnumerable;

        /*******************************************************************************/
        public FileSearchForm()
        {
            InitializeComponent();

            uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();
            fileSearcherIEnumerable = new FileSearcherIEnumerable(uiScheduler);

            webBrowser.Url = new Uri(@"C:/");

            listView.ColumnClick += new ColumnClickEventHandler(ColumnClick);
        }

        /*******************************************************************************/
        private void choosePath_button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog() { Description = "Выберите путь..." };

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                FilterOptions.FolderPath = folderBrowserDialog.SelectedPath;

                webBrowser.Url = new Uri(FilterOptions.FolderPath);

                chosenFolder_textBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        /*******************************************************************************/
        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            chosenFolder_textBox.Text = webBrowser.Url.LocalPath.ToString();

            FilterOptions.FolderPath = chosenFolder_textBox.Text;
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
                FileSearcherIEnumerable.CurrentFileToListView))

            .ContinueWith(x =>
            {
                searchDone_label.Invoke(new Action(() => searchDone_label.Text = "Поиск завершен!"));

                startSearch_button.Invoke(new Action(() => startSearch_button.Enabled = true));

                listView.Invoke(new Action(() => listView.HeaderStyle = ColumnHeaderStyle.Clickable));
            });

            FilterOptions.SetSizesToDefault();
        }

        /*******************************************************************************/
        private void goBack_button_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoBack)
                webBrowser.GoBack();
        }

        /*******************************************************************************/
        private void goForward_button_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoForward)
                webBrowser.GoForward();
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

            searchDone_label.Text = string.Empty;
            startSearch_button.Enabled = false;
        }
    }
}
