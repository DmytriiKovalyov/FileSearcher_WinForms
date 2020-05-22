using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager_DotNet.CustomControls
{
    public partial class FolderPanel : UserControl
    {
        public FolderPanel()
        {
            InitializeComponent();

            webBrowser.Url = new Uri(@"C:/");
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
    }
}