namespace FileManager_DotNet
{
    partial class FileSearchForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchPanel1 = new FileManager_DotNet.CustomControls.SearchPanel();
            this.folderPanel1 = new FileManager_DotNet.CustomControls.FolderPanel();
            this.filterPanel1 = new FileManager_DotNet.CustomControls.FilterPanel();
            this.SuspendLayout();
            // 
            // searchPanel1
            // 
            this.searchPanel1.Location = new System.Drawing.Point(290, 4);
            this.searchPanel1.Name = "searchPanel1";
            this.searchPanel1.Size = new System.Drawing.Size(895, 596);
            this.searchPanel1.TabIndex = 7;
            // 
            // folderPanel1
            // 
            this.folderPanel1.Location = new System.Drawing.Point(6, 6);
            this.folderPanel1.Name = "folderPanel1";
            this.folderPanel1.Size = new System.Drawing.Size(278, 593);
            this.folderPanel1.TabIndex = 15;
            // 
            // filterPanel1
            // 
            this.filterPanel1.Location = new System.Drawing.Point(293, 49);
            this.filterPanel1.Name = "filterPanel1";
            this.filterPanel1.Size = new System.Drawing.Size(190, 369);
            this.filterPanel1.TabIndex = 16;
            // 
            // FileSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 604);
            this.Controls.Add(this.filterPanel1);
            this.Controls.Add(this.searchPanel1);
            this.Controls.Add(this.folderPanel1);
            this.Name = "FileSearchForm";
            this.Text = "FileSearch";
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.FolderPanel folderPanel1;
        private CustomControls.SearchPanel searchPanel1;
        private CustomControls.FilterPanel filterPanel1;
    }
}

