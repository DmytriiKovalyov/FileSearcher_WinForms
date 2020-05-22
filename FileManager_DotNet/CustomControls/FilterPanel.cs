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
    public partial class FilterPanel : UserControl
    {
        public FilterPanel()
        {
            InitializeComponent();
        }

        /*******************************************************************************/
        private void enterName_textBox_Leave(object sender, EventArgs e)
        {
            FilterOptions.SetSearchedFileNames(
                string.IsNullOrWhiteSpace(enterName_textBox.Text),
                enterName_textBox.Text);
        }

        /*******************************************************************************/
        private void enterExtension_textBox_Leave(object sender, EventArgs e)
        {
            FilterOptions.SetSearchedFileExtensions(
                string.IsNullOrWhiteSpace(enterExtension_textBox.Text),
                enterExtension_textBox.Text);
        }

        /*******************************************************************************/
        private void minSize_textBox_Leave(object sender, EventArgs e)
        {
            FilterOptions.SetSearchedFileSizes(
                string.IsNullOrWhiteSpace(minSize_textBox.Text),
                minSize_textBox.Text,
                maxSize_textBox.Text);
        }

        /*******************************************************************************/
        private void maxSize_textBox_Leave(object sender, EventArgs e)
        {
            FilterOptions.SetSearchedFileSizes(
                string.IsNullOrWhiteSpace(maxSize_textBox.Text),
                minSize_textBox.Text,
                maxSize_textBox.Text);
        }
    }
}
