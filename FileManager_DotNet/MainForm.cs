using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager_DotNet
{
    public partial class FileSearchForm : Form
    {
        /*******************************************************************************/
        public FileSearchForm()
        {
            InitializeComponent();

            webBrowser.Url = new Uri(@"C:/");

            listView.ColumnClick += new ColumnClickEventHandler(ColumnClick);
        }


        /*******************************************************************************/
        private void choosePath_button_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog() { Description = "Выберите путь..." })
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    FilterOptions.FolderPath = folderBrowserDialog.SelectedPath;

                    webBrowser.Url = new Uri(FilterOptions.FolderPath);

                    chosenFolder_textBox.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }


        /*******************************************************************************/
        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            chosenFolder_textBox.Text = webBrowser.Url.LocalPath.ToString();

            FilterOptions.FolderPath = chosenFolder_textBox.Text;
        }


        /*******************************************************************************/
        private void startSearch_button_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();

            FileSearcherAsync.ClearFoundFilesList();

            CollectSearchedData();

            SwitchFiltersToDefault();

            FileSearcherAsync.StartFileSearchAsync();
        }


        /*******************************************************************************/
        public void CollectSearchedData()
        {
            FilterOptions.SetSearchedFileNames(
                nameSearch_checkBox.Checked,
                enterName_textBox.Text);

            FilterOptions.SetSearchedFileExtensions(
                typeSearch_checkBox.Checked,
                enterExtension_textBox.Text);

            FilterOptions.SetSearchedFileSizes(
                sizeSearch_checkBox.Checked,
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
        private void FillingListView()
        {
            foreach (var item in FileSearcherAsync.FoundFiles)
            {
                var fileName = Path.GetFileName(item);
                var folderName = Path.GetFullPath(item);
                var fileType = Path.GetExtension(item);
                var fileSize = (new FileInfo(item).Length / 1024);
                var fileSizetoKB = (fileSize < 1) ? 1.ToString() : fileSize.ToString();

                if (fileSize >= FilterOptions.FileMinSize && fileSize <= FilterOptions.FileMaxSize)
                {
                    ListViewItem lvi = new ListViewItem(fileName);

                    lvi.SubItems.Add(folderName);
                    lvi.SubItems.Add(fileType);
                    lvi.SubItems.Add(fileSizetoKB);
                    listView.Items.Add(lvi);
                }
            }
        }

        /*******************************************************************************/
        private void showResult_button_Click(object sender, EventArgs e)
        {
            FillingListView();

            FilterOptions.SetSizesToDefault();

            var itemsInListView = listView.Items.Count.ToString();

            searchCounter_label.Text = itemsInListView;
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
        private void nameSearch_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            enterName_label.Enabled = !enterName_label.Enabled;
            enterName_textBox.Enabled = !enterName_textBox.Enabled;
        }

        /*******************************************************************************/
        private void typeSearch_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            enterExtension_label.Enabled = !enterExtension_label.Enabled;
            enterExtension_textBox.Enabled = !enterExtension_textBox.Enabled;
        }

        /*******************************************************************************/
        private void sizeSearch_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            enterSize_label.Enabled = !enterSize_label.Enabled;
            minSize_label.Enabled = !minSize_label.Enabled;
            maxSize_label.Enabled = !maxSize_label.Enabled;
            minSize_textBox.Enabled = !minSize_textBox.Enabled;
            maxSize_textBox.Enabled = !maxSize_textBox.Enabled;
            sizeKb_label1.Enabled = !sizeKb_label1.Enabled;
            sizeKb_label2.Enabled = !sizeKb_label2.Enabled;
        }

        /*******************************************************************************/
        public void SwitchFiltersToDefault()
        {
            nameSearch_checkBox.Checked = false;
            typeSearch_checkBox.Checked = false;
            sizeSearch_checkBox.Checked = false;

            enterName_label.Enabled = false;
            enterName_textBox.Enabled = false;
            enterExtension_label.Enabled = false;
            enterExtension_textBox.Enabled = false;
            enterSize_label.Enabled = false;
            minSize_label.Enabled = false;
            maxSize_label.Enabled = false;
            minSize_textBox.Enabled = false;
            maxSize_textBox.Enabled = false;
            sizeKb_label1.Enabled = false;
            sizeKb_label2.Enabled = false;

            enterName_textBox.Text = string.Empty;
            enterExtension_textBox.Text = string.Empty;
            minSize_textBox.Text = string.Empty;
            maxSize_textBox.Text = string.Empty;
        }
    }
}
