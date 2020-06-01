namespace FileManager_DotNet.CustomControls
{
    partial class SearchPanel
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancelSearch_button = new System.Windows.Forms.Button();
            this.searchDone_label = new System.Windows.Forms.Label();
            this.searchCounter_label = new System.Windows.Forms.Label();
            this.dogGif_pictureBox = new System.Windows.Forms.PictureBox();
            this.filesFound_label = new System.Windows.Forms.Label();
            this.listView = new FileManager_DotNet.ListViewNoFlickering();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startSearch_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dogGif_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelSearch_button
            // 
            this.cancelSearch_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelSearch_button.Location = new System.Drawing.Point(198, 6);
            this.cancelSearch_button.Name = "cancelSearch_button";
            this.cancelSearch_button.Size = new System.Drawing.Size(187, 31);
            this.cancelSearch_button.TabIndex = 10;
            this.cancelSearch_button.Text = "Отмена";
            this.cancelSearch_button.UseVisualStyleBackColor = true;
            this.cancelSearch_button.Click += new System.EventHandler(this.cancelSearch_button_Click);
            // 
            // searchDone_label
            // 
            this.searchDone_label.AutoSize = true;
            this.searchDone_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchDone_label.Location = new System.Drawing.Point(464, 13);
            this.searchDone_label.Name = "searchDone_label";
            this.searchDone_label.Size = new System.Drawing.Size(64, 17);
            this.searchDone_label.TabIndex = 19;
            this.searchDone_label.Text = "_______";
            // 
            // searchCounter_label
            // 
            this.searchCounter_label.AutoSize = true;
            this.searchCounter_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchCounter_label.Location = new System.Drawing.Point(848, 13);
            this.searchCounter_label.Name = "searchCounter_label";
            this.searchCounter_label.Size = new System.Drawing.Size(16, 17);
            this.searchCounter_label.TabIndex = 18;
            this.searchCounter_label.Text = "0";
            // 
            // dogGif_pictureBox
            // 
            this.dogGif_pictureBox.Image = global::FileManager_DotNet.Properties.Resources.tenor;
            this.dogGif_pictureBox.Location = new System.Drawing.Point(5, 419);
            this.dogGif_pictureBox.Name = "dogGif_pictureBox";
            this.dogGif_pictureBox.Size = new System.Drawing.Size(187, 174);
            this.dogGif_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dogGif_pictureBox.TabIndex = 17;
            this.dogGif_pictureBox.TabStop = false;
            // 
            // filesFound_label
            // 
            this.filesFound_label.AutoSize = true;
            this.filesFound_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filesFound_label.Location = new System.Drawing.Point(729, 13);
            this.filesFound_label.Name = "filesFound_label";
            this.filesFound_label.Size = new System.Drawing.Size(124, 17);
            this.filesFound_label.TabIndex = 16;
            this.filesFound_label.Text = "Найдено файлов:";
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView.ForeColor = System.Drawing.Color.Black;
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(198, 43);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(694, 550);
            this.listView.TabIndex = 15;
            this.listView.TabStop = false;
            this.listView.TileSize = new System.Drawing.Size(2, 2);
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.ItemActivate += new System.EventHandler(this.listView_ItemActivate);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Имя";
            this.columnHeader1.Width = 190;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Папка";
            this.columnHeader2.Width = 248;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Тип";
            this.columnHeader3.Width = 122;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Размер";
            this.columnHeader4.Width = 130;
            // 
            // startSearch_button
            // 
            this.startSearch_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startSearch_button.Location = new System.Drawing.Point(5, 6);
            this.startSearch_button.Name = "startSearch_button";
            this.startSearch_button.Size = new System.Drawing.Size(187, 31);
            this.startSearch_button.TabIndex = 9;
            this.startSearch_button.Text = "Начать поиск";
            this.startSearch_button.UseVisualStyleBackColor = true;
            this.startSearch_button.Click += new System.EventHandler(this.startSearch_button_Click);
            // 
            // SearchPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.startSearch_button);
            this.Controls.Add(this.cancelSearch_button);
            this.Controls.Add(this.searchDone_label);
            this.Controls.Add(this.searchCounter_label);
            this.Controls.Add(this.dogGif_pictureBox);
            this.Controls.Add(this.filesFound_label);
            this.Controls.Add(this.listView);
            this.Name = "SearchPanel";
            this.Size = new System.Drawing.Size(895, 596);
            ((System.ComponentModel.ISupportInitialize)(this.dogGif_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelSearch_button;
        private System.Windows.Forms.Label searchDone_label;
        private System.Windows.Forms.Label searchCounter_label;
        private System.Windows.Forms.PictureBox dogGif_pictureBox;
        private System.Windows.Forms.Label filesFound_label;
        private ListViewNoFlickering listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button startSearch_button;
    }
}
