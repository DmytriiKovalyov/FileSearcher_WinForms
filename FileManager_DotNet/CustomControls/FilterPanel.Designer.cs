namespace FileManager_DotNet.CustomControls
{
    partial class FilterPanel
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
            this.searchGroupbox = new System.Windows.Forms.GroupBox();
            this.fileName_groupBox = new System.Windows.Forms.GroupBox();
            this.enterName_textBox = new System.Windows.Forms.TextBox();
            this.enterName_label = new System.Windows.Forms.Label();
            this.fileType_groupBox = new System.Windows.Forms.GroupBox();
            this.enterExtension_textBox = new System.Windows.Forms.TextBox();
            this.enterExtension_label = new System.Windows.Forms.Label();
            this.fileSize_groupBox = new System.Windows.Forms.GroupBox();
            this.sizeKb_label2 = new System.Windows.Forms.Label();
            this.sizeKb_label1 = new System.Windows.Forms.Label();
            this.maxSize_label = new System.Windows.Forms.Label();
            this.minSize_label = new System.Windows.Forms.Label();
            this.maxSize_textBox = new System.Windows.Forms.TextBox();
            this.minSize_textBox = new System.Windows.Forms.TextBox();
            this.enterSize_label = new System.Windows.Forms.Label();
            this.pickFilters_label = new System.Windows.Forms.Label();
            this.searchGroupbox.SuspendLayout();
            this.fileName_groupBox.SuspendLayout();
            this.fileType_groupBox.SuspendLayout();
            this.fileSize_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchGroupbox
            // 
            this.searchGroupbox.Controls.Add(this.fileName_groupBox);
            this.searchGroupbox.Controls.Add(this.fileType_groupBox);
            this.searchGroupbox.Controls.Add(this.fileSize_groupBox);
            this.searchGroupbox.Controls.Add(this.pickFilters_label);
            this.searchGroupbox.Location = new System.Drawing.Point(2, -4);
            this.searchGroupbox.Name = "searchGroupbox";
            this.searchGroupbox.Size = new System.Drawing.Size(186, 371);
            this.searchGroupbox.TabIndex = 9;
            this.searchGroupbox.TabStop = false;
            // 
            // fileName_groupBox
            // 
            this.fileName_groupBox.Controls.Add(this.enterName_textBox);
            this.fileName_groupBox.Controls.Add(this.enterName_label);
            this.fileName_groupBox.Location = new System.Drawing.Point(7, 38);
            this.fileName_groupBox.Name = "fileName_groupBox";
            this.fileName_groupBox.Size = new System.Drawing.Size(173, 110);
            this.fileName_groupBox.TabIndex = 6;
            this.fileName_groupBox.TabStop = false;
            // 
            // enterName_textBox
            // 
            this.enterName_textBox.Location = new System.Drawing.Point(10, 36);
            this.enterName_textBox.Multiline = true;
            this.enterName_textBox.Name = "enterName_textBox";
            this.enterName_textBox.Size = new System.Drawing.Size(156, 68);
            this.enterName_textBox.TabIndex = 3;
            this.enterName_textBox.Leave += new System.EventHandler(this.enterName_textBox_Leave);
            // 
            // enterName_label
            // 
            this.enterName_label.AutoSize = true;
            this.enterName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterName_label.Location = new System.Drawing.Point(7, 13);
            this.enterName_label.Name = "enterName_label";
            this.enterName_label.Size = new System.Drawing.Size(162, 17);
            this.enterName_label.TabIndex = 2;
            this.enterName_label.Text = "Имя файла (его часть):";
            // 
            // fileType_groupBox
            // 
            this.fileType_groupBox.Controls.Add(this.enterExtension_textBox);
            this.fileType_groupBox.Controls.Add(this.enterExtension_label);
            this.fileType_groupBox.Location = new System.Drawing.Point(7, 149);
            this.fileType_groupBox.Name = "fileType_groupBox";
            this.fileType_groupBox.Size = new System.Drawing.Size(173, 110);
            this.fileType_groupBox.TabIndex = 5;
            this.fileType_groupBox.TabStop = false;
            // 
            // enterExtension_textBox
            // 
            this.enterExtension_textBox.Location = new System.Drawing.Point(10, 36);
            this.enterExtension_textBox.Multiline = true;
            this.enterExtension_textBox.Name = "enterExtension_textBox";
            this.enterExtension_textBox.Size = new System.Drawing.Size(156, 68);
            this.enterExtension_textBox.TabIndex = 4;
            this.enterExtension_textBox.Leave += new System.EventHandler(this.enterExtension_textBox_Leave);
            // 
            // enterExtension_label
            // 
            this.enterExtension_label.AutoSize = true;
            this.enterExtension_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterExtension_label.Location = new System.Drawing.Point(15, 13);
            this.enterExtension_label.Name = "enterExtension_label";
            this.enterExtension_label.Size = new System.Drawing.Size(142, 17);
            this.enterExtension_label.TabIndex = 3;
            this.enterExtension_label.Text = "Расширение файла:";
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
            this.fileSize_groupBox.Location = new System.Drawing.Point(7, 261);
            this.fileSize_groupBox.Name = "fileSize_groupBox";
            this.fileSize_groupBox.Size = new System.Drawing.Size(173, 110);
            this.fileSize_groupBox.TabIndex = 4;
            this.fileSize_groupBox.TabStop = false;
            // 
            // sizeKb_label2
            // 
            this.sizeKb_label2.AutoSize = true;
            this.sizeKb_label2.Location = new System.Drawing.Point(145, 81);
            this.sizeKb_label2.Name = "sizeKb_label2";
            this.sizeKb_label2.Size = new System.Drawing.Size(21, 13);
            this.sizeKb_label2.TabIndex = 10;
            this.sizeKb_label2.Text = "KB";
            // 
            // sizeKb_label1
            // 
            this.sizeKb_label1.AutoSize = true;
            this.sizeKb_label1.Location = new System.Drawing.Point(145, 51);
            this.sizeKb_label1.Name = "sizeKb_label1";
            this.sizeKb_label1.Size = new System.Drawing.Size(21, 13);
            this.sizeKb_label1.TabIndex = 9;
            this.sizeKb_label1.Text = "KB";
            // 
            // maxSize_label
            // 
            this.maxSize_label.AutoSize = true;
            this.maxSize_label.Location = new System.Drawing.Point(7, 81);
            this.maxSize_label.Name = "maxSize_label";
            this.maxSize_label.Size = new System.Drawing.Size(25, 13);
            this.maxSize_label.TabIndex = 8;
            this.maxSize_label.Text = "До:";
            // 
            // minSize_label
            // 
            this.minSize_label.AutoSize = true;
            this.minSize_label.Location = new System.Drawing.Point(6, 51);
            this.minSize_label.Name = "minSize_label";
            this.minSize_label.Size = new System.Drawing.Size(23, 13);
            this.minSize_label.TabIndex = 7;
            this.minSize_label.Text = "От:";
            // 
            // maxSize_textBox
            // 
            this.maxSize_textBox.Location = new System.Drawing.Point(38, 78);
            this.maxSize_textBox.Name = "maxSize_textBox";
            this.maxSize_textBox.Size = new System.Drawing.Size(103, 20);
            this.maxSize_textBox.TabIndex = 6;
            this.maxSize_textBox.Leave += new System.EventHandler(this.maxSize_textBox_Leave);
            // 
            // minSize_textBox
            // 
            this.minSize_textBox.Location = new System.Drawing.Point(39, 48);
            this.minSize_textBox.Name = "minSize_textBox";
            this.minSize_textBox.Size = new System.Drawing.Size(102, 20);
            this.minSize_textBox.TabIndex = 5;
            this.minSize_textBox.Leave += new System.EventHandler(this.minSize_textBox_Leave);
            // 
            // enterSize_label
            // 
            this.enterSize_label.AutoSize = true;
            this.enterSize_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterSize_label.Location = new System.Drawing.Point(10, 13);
            this.enterSize_label.Name = "enterSize_label";
            this.enterSize_label.Size = new System.Drawing.Size(153, 17);
            this.enterSize_label.TabIndex = 4;
            this.enterSize_label.Text = "Граничные значения:";
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
            // FilterPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchGroupbox);
            this.Name = "FilterPanel";
            this.Size = new System.Drawing.Size(190, 369);
            this.searchGroupbox.ResumeLayout(false);
            this.searchGroupbox.PerformLayout();
            this.fileName_groupBox.ResumeLayout(false);
            this.fileName_groupBox.PerformLayout();
            this.fileType_groupBox.ResumeLayout(false);
            this.fileType_groupBox.PerformLayout();
            this.fileSize_groupBox.ResumeLayout(false);
            this.fileSize_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox searchGroupbox;
        private System.Windows.Forms.GroupBox fileName_groupBox;
        private System.Windows.Forms.TextBox enterName_textBox;
        private System.Windows.Forms.Label enterName_label;
        private System.Windows.Forms.GroupBox fileType_groupBox;
        private System.Windows.Forms.TextBox enterExtension_textBox;
        private System.Windows.Forms.Label enterExtension_label;
        private System.Windows.Forms.GroupBox fileSize_groupBox;
        private System.Windows.Forms.Label sizeKb_label2;
        private System.Windows.Forms.Label sizeKb_label1;
        private System.Windows.Forms.Label maxSize_label;
        private System.Windows.Forms.Label minSize_label;
        private System.Windows.Forms.TextBox maxSize_textBox;
        private System.Windows.Forms.TextBox minSize_textBox;
        private System.Windows.Forms.Label enterSize_label;
        private System.Windows.Forms.Label pickFilters_label;
    }
}
