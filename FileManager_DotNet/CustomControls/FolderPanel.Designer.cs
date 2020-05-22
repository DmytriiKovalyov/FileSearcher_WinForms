namespace FileManager_DotNet.CustomControls
{
    partial class FolderPanel
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
            this.chosenFolder_textBox = new System.Windows.Forms.TextBox();
            this.chosenFolder_label = new System.Windows.Forms.Label();
            this.goForward_button = new System.Windows.Forms.Button();
            this.goBack_button = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.choosePath_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chosenFolder_textBox
            // 
            this.chosenFolder_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chosenFolder_textBox.Location = new System.Drawing.Point(4, 551);
            this.chosenFolder_textBox.Multiline = true;
            this.chosenFolder_textBox.Name = "chosenFolder_textBox";
            this.chosenFolder_textBox.ReadOnly = true;
            this.chosenFolder_textBox.Size = new System.Drawing.Size(270, 41);
            this.chosenFolder_textBox.TabIndex = 18;
            // 
            // chosenFolder_label
            // 
            this.chosenFolder_label.AutoSize = true;
            this.chosenFolder_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chosenFolder_label.Location = new System.Drawing.Point(61, 531);
            this.chosenFolder_label.Name = "chosenFolder_label";
            this.chosenFolder_label.Size = new System.Drawing.Size(130, 17);
            this.chosenFolder_label.TabIndex = 17;
            this.chosenFolder_label.Text = "Выбранная папка:";
            // 
            // goForward_button
            // 
            this.goForward_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goForward_button.Location = new System.Drawing.Point(64, 5);
            this.goForward_button.Name = "goForward_button";
            this.goForward_button.Size = new System.Drawing.Size(57, 31);
            this.goForward_button.TabIndex = 16;
            this.goForward_button.Text = ">>";
            this.goForward_button.UseVisualStyleBackColor = true;
            this.goForward_button.Click += new System.EventHandler(this.goForward_button_Click);
            // 
            // goBack_button
            // 
            this.goBack_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBack_button.Location = new System.Drawing.Point(4, 5);
            this.goBack_button.Name = "goBack_button";
            this.goBack_button.Size = new System.Drawing.Size(57, 31);
            this.goBack_button.TabIndex = 15;
            this.goBack_button.Text = "<<";
            this.goBack_button.UseVisualStyleBackColor = true;
            this.goBack_button.Click += new System.EventHandler(this.goBack_button_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(3, 42);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(271, 486);
            this.webBrowser.TabIndex = 14;
            this.webBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser_Navigated);
            // 
            // choosePath_button
            // 
            this.choosePath_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choosePath_button.Location = new System.Drawing.Point(127, 5);
            this.choosePath_button.Name = "choosePath_button";
            this.choosePath_button.Size = new System.Drawing.Size(115, 31);
            this.choosePath_button.TabIndex = 13;
            this.choosePath_button.Text = "Выбрать путь";
            this.choosePath_button.UseVisualStyleBackColor = true;
            this.choosePath_button.Click += new System.EventHandler(this.choosePath_button_Click);
            // 
            // FolderPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chosenFolder_textBox);
            this.Controls.Add(this.chosenFolder_label);
            this.Controls.Add(this.goForward_button);
            this.Controls.Add(this.goBack_button);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.choosePath_button);
            this.Name = "FolderPanel";
            this.Size = new System.Drawing.Size(279, 598);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox chosenFolder_textBox;
        private System.Windows.Forms.Label chosenFolder_label;
        private System.Windows.Forms.Button goForward_button;
        private System.Windows.Forms.Button goBack_button;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button choosePath_button;
    }
}
