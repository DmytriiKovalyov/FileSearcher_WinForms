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
            this.choosePath_button = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filesFound_label = new System.Windows.Forms.Label();
            this.showResult_button = new System.Windows.Forms.Button();
            this.goBack_button = new System.Windows.Forms.Button();
            this.goForward_button = new System.Windows.Forms.Button();
            this.dogGif_pictureBox = new System.Windows.Forms.PictureBox();
            this.searchGroupbox = new System.Windows.Forms.GroupBox();
            this.fileName_groupBox = new System.Windows.Forms.GroupBox();
            this.enterName_textBox = new System.Windows.Forms.TextBox();
            this.enterName_label = new System.Windows.Forms.Label();
            this.nameSearch_checkBox = new System.Windows.Forms.CheckBox();
            this.fileType_groupBox = new System.Windows.Forms.GroupBox();
            this.enterExtension_textBox = new System.Windows.Forms.TextBox();
            this.enterExtension_label = new System.Windows.Forms.Label();
            this.typeSearch_checkBox = new System.Windows.Forms.CheckBox();
            this.fileSize_groupBox = new System.Windows.Forms.GroupBox();
            this.sizeKb_label2 = new System.Windows.Forms.Label();
            this.sizeKb_label1 = new System.Windows.Forms.Label();
            this.maxSize_label = new System.Windows.Forms.Label();
            this.minSize_label = new System.Windows.Forms.Label();
            this.maxSize_textBox = new System.Windows.Forms.TextBox();
            this.minSize_textBox = new System.Windows.Forms.TextBox();
            this.enterSize_label = new System.Windows.Forms.Label();
            this.sizeSearch_checkBox = new System.Windows.Forms.CheckBox();
            this.pickFilters_label = new System.Windows.Forms.Label();
            this.searchCounter_label = new System.Windows.Forms.Label();
            this.startSearch_button = new System.Windows.Forms.Button();
            this.chosenFolder_label = new System.Windows.Forms.Label();
            this.chosenFolder_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dogGif_pictureBox)).BeginInit();
            this.searchGroupbox.SuspendLayout();
            this.fileName_groupBox.SuspendLayout();
            this.fileType_groupBox.SuspendLayout();
            this.fileSize_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // choosePath_button
            // 
            this.choosePath_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choosePath_button.Location = new System.Drawing.Point(137, 5);
            this.choosePath_button.Name = "choosePath_button";
            this.choosePath_button.Size = new System.Drawing.Size(115, 31);
            this.choosePath_button.TabIndex = 0;
            this.choosePath_button.Text = "Выбрать путь";
            this.choosePath_button.UseVisualStyleBackColor = true;
            this.choosePath_button.Click += new System.EventHandler(this.choosePath_button_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(13, 42);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(271, 486);
            this.webBrowser.TabIndex = 1;
            this.webBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser_Navigated);
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
            this.listView.Location = new System.Drawing.Point(483, 42);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(694, 550);
            this.listView.TabIndex = 2;
            this.listView.TileSize = new System.Drawing.Size(2, 2);
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
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
            // filesFound_label
            // 
            this.filesFound_label.AutoSize = true;
            this.filesFound_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filesFound_label.Location = new System.Drawing.Point(1014, 12);
            this.filesFound_label.Name = "filesFound_label";
            this.filesFound_label.Size = new System.Drawing.Size(124, 17);
            this.filesFound_label.TabIndex = 3;
            this.filesFound_label.Text = "Найдено файлов:";
            // 
            // showResult_button
            // 
            this.showResult_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showResult_button.Location = new System.Drawing.Point(823, 5);
            this.showResult_button.Name = "showResult_button";
            this.showResult_button.Size = new System.Drawing.Size(185, 31);
            this.showResult_button.TabIndex = 4;
            this.showResult_button.Text = "Показать результаты";
            this.showResult_button.UseVisualStyleBackColor = true;
            this.showResult_button.Click += new System.EventHandler(this.showResult_button_Click);
            // 
            // goBack_button
            // 
            this.goBack_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBack_button.Location = new System.Drawing.Point(14, 5);
            this.goBack_button.Name = "goBack_button";
            this.goBack_button.Size = new System.Drawing.Size(57, 31);
            this.goBack_button.TabIndex = 5;
            this.goBack_button.Text = "<<";
            this.goBack_button.UseVisualStyleBackColor = true;
            this.goBack_button.Click += new System.EventHandler(this.goBack_button_Click);
            // 
            // goForward_button
            // 
            this.goForward_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goForward_button.Location = new System.Drawing.Point(74, 5);
            this.goForward_button.Name = "goForward_button";
            this.goForward_button.Size = new System.Drawing.Size(57, 31);
            this.goForward_button.TabIndex = 6;
            this.goForward_button.Text = ">>";
            this.goForward_button.UseVisualStyleBackColor = true;
            this.goForward_button.Click += new System.EventHandler(this.goForward_button_Click);
            // 
            // dogGif_pictureBox
            // 
            this.dogGif_pictureBox.Image = global::FileManager_DotNet.Properties.Resources.tenor;
            this.dogGif_pictureBox.Location = new System.Drawing.Point(290, 418);
            this.dogGif_pictureBox.Name = "dogGif_pictureBox";
            this.dogGif_pictureBox.Size = new System.Drawing.Size(187, 174);
            this.dogGif_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dogGif_pictureBox.TabIndex = 7;
            this.dogGif_pictureBox.TabStop = false;
            // 
            // searchGroupbox
            // 
            this.searchGroupbox.Controls.Add(this.fileName_groupBox);
            this.searchGroupbox.Controls.Add(this.fileType_groupBox);
            this.searchGroupbox.Controls.Add(this.fileSize_groupBox);
            this.searchGroupbox.Controls.Add(this.pickFilters_label);
            this.searchGroupbox.Location = new System.Drawing.Point(291, 41);
            this.searchGroupbox.Name = "searchGroupbox";
            this.searchGroupbox.Size = new System.Drawing.Size(186, 371);
            this.searchGroupbox.TabIndex = 8;
            this.searchGroupbox.TabStop = false;
            // 
            // fileName_groupBox
            // 
            this.fileName_groupBox.Controls.Add(this.enterName_textBox);
            this.fileName_groupBox.Controls.Add(this.enterName_label);
            this.fileName_groupBox.Controls.Add(this.nameSearch_checkBox);
            this.fileName_groupBox.Location = new System.Drawing.Point(7, 38);
            this.fileName_groupBox.Name = "fileName_groupBox";
            this.fileName_groupBox.Size = new System.Drawing.Size(173, 110);
            this.fileName_groupBox.TabIndex = 6;
            this.fileName_groupBox.TabStop = false;
            // 
            // enterName_textBox
            // 
            this.enterName_textBox.Enabled = false;
            this.enterName_textBox.Location = new System.Drawing.Point(10, 54);
            this.enterName_textBox.Multiline = true;
            this.enterName_textBox.Name = "enterName_textBox";
            this.enterName_textBox.Size = new System.Drawing.Size(156, 50);
            this.enterName_textBox.TabIndex = 3;
            // 
            // enterName_label
            // 
            this.enterName_label.AutoSize = true;
            this.enterName_label.Enabled = false;
            this.enterName_label.Location = new System.Drawing.Point(5, 37);
            this.enterName_label.Name = "enterName_label";
            this.enterName_label.Size = new System.Drawing.Size(167, 13);
            this.enterName_label.TabIndex = 2;
            this.enterName_label.Text = "Введите имя файла (его часть):";
            // 
            // nameSearch_checkBox
            // 
            this.nameSearch_checkBox.AutoSize = true;
            this.nameSearch_checkBox.Location = new System.Drawing.Point(29, 16);
            this.nameSearch_checkBox.Name = "nameSearch_checkBox";
            this.nameSearch_checkBox.Size = new System.Drawing.Size(108, 17);
            this.nameSearch_checkBox.TabIndex = 1;
            this.nameSearch_checkBox.Text = "Поиск по имени";
            this.nameSearch_checkBox.UseVisualStyleBackColor = true;
            this.nameSearch_checkBox.CheckedChanged += new System.EventHandler(this.nameSearch_checkBox_CheckedChanged);
            // 
            // fileType_groupBox
            // 
            this.fileType_groupBox.Controls.Add(this.enterExtension_textBox);
            this.fileType_groupBox.Controls.Add(this.enterExtension_label);
            this.fileType_groupBox.Controls.Add(this.typeSearch_checkBox);
            this.fileType_groupBox.Location = new System.Drawing.Point(7, 149);
            this.fileType_groupBox.Name = "fileType_groupBox";
            this.fileType_groupBox.Size = new System.Drawing.Size(173, 110);
            this.fileType_groupBox.TabIndex = 5;
            this.fileType_groupBox.TabStop = false;
            // 
            // enterExtension_textBox
            // 
            this.enterExtension_textBox.Enabled = false;
            this.enterExtension_textBox.Location = new System.Drawing.Point(10, 54);
            this.enterExtension_textBox.Multiline = true;
            this.enterExtension_textBox.Name = "enterExtension_textBox";
            this.enterExtension_textBox.Size = new System.Drawing.Size(156, 50);
            this.enterExtension_textBox.TabIndex = 4;
            // 
            // enterExtension_label
            // 
            this.enterExtension_label.AutoSize = true;
            this.enterExtension_label.Enabled = false;
            this.enterExtension_label.Location = new System.Drawing.Point(15, 37);
            this.enterExtension_label.Name = "enterExtension_label";
            this.enterExtension_label.Size = new System.Drawing.Size(152, 13);
            this.enterExtension_label.TabIndex = 3;
            this.enterExtension_label.Text = "Введите расширение файла:";
            // 
            // typeSearch_checkBox
            // 
            this.typeSearch_checkBox.AutoSize = true;
            this.typeSearch_checkBox.Location = new System.Drawing.Point(19, 16);
            this.typeSearch_checkBox.Name = "typeSearch_checkBox";
            this.typeSearch_checkBox.Size = new System.Drawing.Size(140, 17);
            this.typeSearch_checkBox.TabIndex = 2;
            this.typeSearch_checkBox.Text = "Поиск по расширению";
            this.typeSearch_checkBox.UseVisualStyleBackColor = true;
            this.typeSearch_checkBox.CheckedChanged += new System.EventHandler(this.typeSearch_checkBox_CheckedChanged);
            // 
            // fileSize_groupBox
            // 
            this.fileSize_groupBox.Controls.Add(this.sizeKb_label2);
            this.fileSize_groupBox.Controls.Add(this.sizeKb_label1);
            this.fileSize_groupBox.Controls.Add(this.maxSize_label);
            this.fileSize_groupBox.Controls.Add(this.minSize_label);
            this.fileSize_groupBox.Controls.Add(this.maxSize_textBox);
            this.fileSize_groupBox.Controls.Add(this.minSize_textBox);
            this.fileSize_groupBox.Controls.Add(this.enterSize_label);
            this.fileSize_groupBox.Controls.Add(this.sizeSearch_checkBox);
            this.fileSize_groupBox.Location = new System.Drawing.Point(7, 261);
            this.fileSize_groupBox.Name = "fileSize_groupBox";
            this.fileSize_groupBox.Size = new System.Drawing.Size(173, 110);
            this.fileSize_groupBox.TabIndex = 4;
            this.fileSize_groupBox.TabStop = false;
            // 
            // sizeKb_label2
            // 
            this.sizeKb_label2.AutoSize = true;
            this.sizeKb_label2.Enabled = false;
            this.sizeKb_label2.Location = new System.Drawing.Point(144, 87);
            this.sizeKb_label2.Name = "sizeKb_label2";
            this.sizeKb_label2.Size = new System.Drawing.Size(21, 13);
            this.sizeKb_label2.TabIndex = 10;
            this.sizeKb_label2.Text = "KB";
            // 
            // sizeKb_label1
            // 
            this.sizeKb_label1.AutoSize = true;
            this.sizeKb_label1.Enabled = false;
            this.sizeKb_label1.Location = new System.Drawing.Point(145, 60);
            this.sizeKb_label1.Name = "sizeKb_label1";
            this.sizeKb_label1.Size = new System.Drawing.Size(21, 13);
            this.sizeKb_label1.TabIndex = 9;
            this.sizeKb_label1.Text = "KB";
            // 
            // maxSize_label
            // 
            this.maxSize_label.AutoSize = true;
            this.maxSize_label.Enabled = false;
            this.maxSize_label.Location = new System.Drawing.Point(7, 87);
            this.maxSize_label.Name = "maxSize_label";
            this.maxSize_label.Size = new System.Drawing.Size(25, 13);
            this.maxSize_label.TabIndex = 8;
            this.maxSize_label.Text = "До:";
            // 
            // minSize_label
            // 
            this.minSize_label.AutoSize = true;
            this.minSize_label.Enabled = false;
            this.minSize_label.Location = new System.Drawing.Point(7, 60);
            this.minSize_label.Name = "minSize_label";
            this.minSize_label.Size = new System.Drawing.Size(23, 13);
            this.minSize_label.TabIndex = 7;
            this.minSize_label.Text = "От:";
            // 
            // maxSize_textBox
            // 
            this.maxSize_textBox.Enabled = false;
            this.maxSize_textBox.Location = new System.Drawing.Point(38, 84);
            this.maxSize_textBox.Name = "maxSize_textBox";
            this.maxSize_textBox.Size = new System.Drawing.Size(100, 20);
            this.maxSize_textBox.TabIndex = 6;
            // 
            // minSize_textBox
            // 
            this.minSize_textBox.Enabled = false;
            this.minSize_textBox.Location = new System.Drawing.Point(39, 57);
            this.minSize_textBox.Name = "minSize_textBox";
            this.minSize_textBox.Size = new System.Drawing.Size(100, 20);
            this.minSize_textBox.TabIndex = 5;
            // 
            // enterSize_label
            // 
            this.enterSize_label.AutoSize = true;
            this.enterSize_label.Enabled = false;
            this.enterSize_label.Location = new System.Drawing.Point(7, 36);
            this.enterSize_label.Name = "enterSize_label";
            this.enterSize_label.Size = new System.Drawing.Size(159, 13);
            this.enterSize_label.TabIndex = 4;
            this.enterSize_label.Text = "Введите граничные значения:";
            // 
            // sizeSearch_checkBox
            // 
            this.sizeSearch_checkBox.AutoSize = true;
            this.sizeSearch_checkBox.Location = new System.Drawing.Point(19, 16);
            this.sizeSearch_checkBox.Name = "sizeSearch_checkBox";
            this.sizeSearch_checkBox.Size = new System.Drawing.Size(119, 17);
            this.sizeSearch_checkBox.TabIndex = 3;
            this.sizeSearch_checkBox.Text = "Поиск по размеру";
            this.sizeSearch_checkBox.UseVisualStyleBackColor = true;
            this.sizeSearch_checkBox.CheckedChanged += new System.EventHandler(this.sizeSearch_checkBox_CheckedChanged);
            // 
            // pickFilters_label
            // 
            this.pickFilters_label.AutoSize = true;
            this.pickFilters_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pickFilters_label.Location = new System.Drawing.Point(23, 16);
            this.pickFilters_label.Name = "pickFilters_label";
            this.pickFilters_label.Size = new System.Drawing.Size(141, 17);
            this.pickFilters_label.TabIndex = 0;
            this.pickFilters_label.Text = "Выберите фильтры:";
            // 
            // searchCounter_label
            // 
            this.searchCounter_label.AutoSize = true;
            this.searchCounter_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchCounter_label.Location = new System.Drawing.Point(1133, 12);
            this.searchCounter_label.Name = "searchCounter_label";
            this.searchCounter_label.Size = new System.Drawing.Size(16, 17);
            this.searchCounter_label.TabIndex = 9;
            this.searchCounter_label.Text = "0";
            // 
            // startSearch_button
            // 
            this.startSearch_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startSearch_button.Location = new System.Drawing.Point(291, 5);
            this.startSearch_button.Name = "startSearch_button";
            this.startSearch_button.Size = new System.Drawing.Size(186, 31);
            this.startSearch_button.TabIndex = 10;
            this.startSearch_button.Text = "Начать поиск";
            this.startSearch_button.UseVisualStyleBackColor = true;
            this.startSearch_button.Click += new System.EventHandler(this.startSearch_button_Click);
            // 
            // chosenFolder_label
            // 
            this.chosenFolder_label.AutoSize = true;
            this.chosenFolder_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chosenFolder_label.Location = new System.Drawing.Point(71, 531);
            this.chosenFolder_label.Name = "chosenFolder_label";
            this.chosenFolder_label.Size = new System.Drawing.Size(130, 17);
            this.chosenFolder_label.TabIndex = 11;
            this.chosenFolder_label.Text = "Выбранная папка:";
            // 
            // chosenFolder_textBox
            // 
            this.chosenFolder_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chosenFolder_textBox.Location = new System.Drawing.Point(14, 551);
            this.chosenFolder_textBox.Multiline = true;
            this.chosenFolder_textBox.Name = "chosenFolder_textBox";
            this.chosenFolder_textBox.ReadOnly = true;
            this.chosenFolder_textBox.Size = new System.Drawing.Size(270, 41);
            this.chosenFolder_textBox.TabIndex = 12;
            // 
            // FileSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 604);
            this.Controls.Add(this.chosenFolder_textBox);
            this.Controls.Add(this.chosenFolder_label);
            this.Controls.Add(this.startSearch_button);
            this.Controls.Add(this.searchCounter_label);
            this.Controls.Add(this.searchGroupbox);
            this.Controls.Add(this.dogGif_pictureBox);
            this.Controls.Add(this.goForward_button);
            this.Controls.Add(this.goBack_button);
            this.Controls.Add(this.showResult_button);
            this.Controls.Add(this.filesFound_label);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.choosePath_button);
            this.Name = "FileSearchForm";
            this.Text = "FileSearch";
            ((System.ComponentModel.ISupportInitialize)(this.dogGif_pictureBox)).EndInit();
            this.searchGroupbox.ResumeLayout(false);
            this.searchGroupbox.PerformLayout();
            this.fileName_groupBox.ResumeLayout(false);
            this.fileName_groupBox.PerformLayout();
            this.fileType_groupBox.ResumeLayout(false);
            this.fileType_groupBox.PerformLayout();
            this.fileSize_groupBox.ResumeLayout(false);
            this.fileSize_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button choosePath_button;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label filesFound_label;
        private System.Windows.Forms.Button showResult_button;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button goBack_button;
        private System.Windows.Forms.Button goForward_button;
        private System.Windows.Forms.PictureBox dogGif_pictureBox;
        private System.Windows.Forms.GroupBox searchGroupbox;
        private System.Windows.Forms.Label pickFilters_label;
        private System.Windows.Forms.Label searchCounter_label;
        private System.Windows.Forms.CheckBox sizeSearch_checkBox;
        private System.Windows.Forms.CheckBox typeSearch_checkBox;
        private System.Windows.Forms.CheckBox nameSearch_checkBox;
        private System.Windows.Forms.GroupBox fileName_groupBox;
        private System.Windows.Forms.GroupBox fileType_groupBox;
        private System.Windows.Forms.GroupBox fileSize_groupBox;
        private System.Windows.Forms.Label enterName_label;
        private System.Windows.Forms.Label enterExtension_label;
        private System.Windows.Forms.Label enterSize_label;
        private System.Windows.Forms.TextBox enterName_textBox;
        private System.Windows.Forms.TextBox enterExtension_textBox;
        private System.Windows.Forms.Label sizeKb_label2;
        private System.Windows.Forms.Label sizeKb_label1;
        private System.Windows.Forms.Label maxSize_label;
        private System.Windows.Forms.Label minSize_label;
        private System.Windows.Forms.TextBox maxSize_textBox;
        private System.Windows.Forms.TextBox minSize_textBox;
        private System.Windows.Forms.Button startSearch_button;
        private System.Windows.Forms.Label chosenFolder_label;
        private System.Windows.Forms.TextBox chosenFolder_textBox;
    }
}

