namespace VKMan
{
    partial class fmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmSettings));
            this.gbSetApp = new System.Windows.Forms.GroupBox();
            this.cbLogType = new System.Windows.Forms.ComboBox();
            this.lblLogType = new System.Windows.Forms.Label();
            this.tbSetDirectoryTemp = new System.Windows.Forms.TextBox();
            this.lblSetDirectoryTemp = new System.Windows.Forms.Label();
            this.gbSetVk = new System.Windows.Forms.GroupBox();
            this.tbSetVkTimeout = new System.Windows.Forms.TextBox();
            this.lblSetVkTimeout = new System.Windows.Forms.Label();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.cbSetVKQueryLimit = new System.Windows.Forms.ComboBox();
            this.lblSetVKQueryLimit = new System.Windows.Forms.Label();
            this.tbSetVkIDGroup = new System.Windows.Forms.TextBox();
            this.lblSetVKIDGroup = new System.Windows.Forms.Label();
            this.cbSetAutoConnect = new System.Windows.Forms.CheckBox();
            this.wb = new System.Windows.Forms.WebBrowser();
            this.btnSetVkConnect = new System.Windows.Forms.Button();
            this.lblSetVKStatus = new System.Windows.Forms.Label();
            this.tbSetVkAppCode = new System.Windows.Forms.TextBox();
            this.lblSetVkAppCode = new System.Windows.Forms.Label();
            this.tbSetVkAppID = new System.Windows.Forms.TextBox();
            this.lblSetVkAppID = new System.Windows.Forms.Label();
            this.gbSetApp.SuspendLayout();
            this.gbSetVk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSetApp
            // 
            this.gbSetApp.Controls.Add(this.cbLogType);
            this.gbSetApp.Controls.Add(this.lblLogType);
            this.gbSetApp.Controls.Add(this.tbSetDirectoryTemp);
            this.gbSetApp.Controls.Add(this.lblSetDirectoryTemp);
            this.gbSetApp.Location = new System.Drawing.Point(12, 12);
            this.gbSetApp.Name = "gbSetApp";
            this.gbSetApp.Size = new System.Drawing.Size(290, 470);
            this.gbSetApp.TabIndex = 0;
            this.gbSetApp.TabStop = false;
            this.gbSetApp.Text = "Настройки программы";
            // 
            // cbLogType
            // 
            this.cbLogType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLogType.FormattingEnabled = true;
            this.cbLogType.Items.AddRange(new object[] {
            "Стандартный",
            "Полный"});
            this.cbLogType.Location = new System.Drawing.Point(9, 70);
            this.cbLogType.Name = "cbLogType";
            this.cbLogType.Size = new System.Drawing.Size(275, 21);
            this.cbLogType.TabIndex = 18;
            this.cbLogType.SelectedIndexChanged += new System.EventHandler(this.cbLogType_SelectedIndexChanged);
            // 
            // lblLogType
            // 
            this.lblLogType.AutoSize = true;
            this.lblLogType.Location = new System.Drawing.Point(6, 55);
            this.lblLogType.Name = "lblLogType";
            this.lblLogType.Size = new System.Drawing.Size(26, 13);
            this.lblLogType.TabIndex = 17;
            this.lblLogType.Text = "Лог";
            // 
            // tbSetDirectoryTemp
            // 
            this.tbSetDirectoryTemp.Enabled = false;
            this.tbSetDirectoryTemp.Location = new System.Drawing.Point(9, 32);
            this.tbSetDirectoryTemp.Name = "tbSetDirectoryTemp";
            this.tbSetDirectoryTemp.Size = new System.Drawing.Size(275, 20);
            this.tbSetDirectoryTemp.TabIndex = 1;
            this.tbSetDirectoryTemp.Text = "%AppData%\\VKMan";
            // 
            // lblSetDirectoryTemp
            // 
            this.lblSetDirectoryTemp.AutoSize = true;
            this.lblSetDirectoryTemp.Location = new System.Drawing.Point(6, 16);
            this.lblSetDirectoryTemp.Name = "lblSetDirectoryTemp";
            this.lblSetDirectoryTemp.Size = new System.Drawing.Size(161, 13);
            this.lblSetDirectoryTemp.TabIndex = 0;
            this.lblSetDirectoryTemp.Text = "Папка для временных файлов";
            // 
            // gbSetVk
            // 
            this.gbSetVk.Controls.Add(this.tbSetVkTimeout);
            this.gbSetVk.Controls.Add(this.lblSetVkTimeout);
            this.gbSetVk.Controls.Add(this.pbLoading);
            this.gbSetVk.Controls.Add(this.cbSetVKQueryLimit);
            this.gbSetVk.Controls.Add(this.lblSetVKQueryLimit);
            this.gbSetVk.Controls.Add(this.tbSetVkIDGroup);
            this.gbSetVk.Controls.Add(this.lblSetVKIDGroup);
            this.gbSetVk.Controls.Add(this.cbSetAutoConnect);
            this.gbSetVk.Controls.Add(this.wb);
            this.gbSetVk.Controls.Add(this.btnSetVkConnect);
            this.gbSetVk.Controls.Add(this.lblSetVKStatus);
            this.gbSetVk.Controls.Add(this.tbSetVkAppCode);
            this.gbSetVk.Controls.Add(this.lblSetVkAppCode);
            this.gbSetVk.Controls.Add(this.tbSetVkAppID);
            this.gbSetVk.Controls.Add(this.lblSetVkAppID);
            this.gbSetVk.Location = new System.Drawing.Point(308, 12);
            this.gbSetVk.Name = "gbSetVk";
            this.gbSetVk.Size = new System.Drawing.Size(1132, 607);
            this.gbSetVk.TabIndex = 1;
            this.gbSetVk.TabStop = false;
            this.gbSetVk.Text = "Настройки ВК";
            // 
            // tbSetVkTimeout
            // 
            this.tbSetVkTimeout.Location = new System.Drawing.Point(9, 166);
            this.tbSetVkTimeout.MaxLength = 4;
            this.tbSetVkTimeout.Name = "tbSetVkTimeout";
            this.tbSetVkTimeout.Size = new System.Drawing.Size(168, 20);
            this.tbSetVkTimeout.TabIndex = 16;
            this.tbSetVkTimeout.TextChanged += new System.EventHandler(this.tbSetVkTimeout_TextChanged);
            // 
            // lblSetVkTimeout
            // 
            this.lblSetVkTimeout.AutoSize = true;
            this.lblSetVkTimeout.Location = new System.Drawing.Point(6, 150);
            this.lblSetVkTimeout.Name = "lblSetVkTimeout";
            this.lblSetVkTimeout.Size = new System.Drawing.Size(124, 13);
            this.lblSetVkTimeout.TabIndex = 15;
            this.lblSetVkTimeout.Text = "Таймаут (300-2000 мс.)";
            // 
            // pbLoading
            // 
            this.pbLoading.Image = global::VKMan.Properties.Resources.ajax_loader;
            this.pbLoading.Location = new System.Drawing.Point(1058, 484);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(66, 66);
            this.pbLoading.TabIndex = 13;
            this.pbLoading.TabStop = false;
            this.pbLoading.Visible = false;
            // 
            // cbSetVKQueryLimit
            // 
            this.cbSetVKQueryLimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSetVKQueryLimit.FormattingEnabled = true;
            this.cbSetVKQueryLimit.Items.AddRange(new object[] {
            "Максимум",
            "Половина",
            "Минимум"});
            this.cbSetVKQueryLimit.Location = new System.Drawing.Point(188, 32);
            this.cbSetVKQueryLimit.Name = "cbSetVKQueryLimit";
            this.cbSetVKQueryLimit.Size = new System.Drawing.Size(168, 21);
            this.cbSetVKQueryLimit.TabIndex = 12;
            this.cbSetVKQueryLimit.SelectedIndexChanged += new System.EventHandler(this.cbSetVKQueryLimit_SelectedIndexChanged);
            // 
            // lblSetVKQueryLimit
            // 
            this.lblSetVKQueryLimit.AutoSize = true;
            this.lblSetVKQueryLimit.Location = new System.Drawing.Point(185, 16);
            this.lblSetVKQueryLimit.Name = "lblSetVKQueryLimit";
            this.lblSetVKQueryLimit.Size = new System.Drawing.Size(259, 13);
            this.lblSetVKQueryLimit.TabIndex = 11;
            this.lblSetVKQueryLimit.Text = "Количество получаемых результатов за 1 запрос";
            // 
            // tbSetVkIDGroup
            // 
            this.tbSetVkIDGroup.Location = new System.Drawing.Point(188, 71);
            this.tbSetVkIDGroup.Name = "tbSetVkIDGroup";
            this.tbSetVkIDGroup.Size = new System.Drawing.Size(168, 20);
            this.tbSetVkIDGroup.TabIndex = 9;
            this.tbSetVkIDGroup.TextChanged += new System.EventHandler(this.tbSetVkIDGroup_TextChanged);
            // 
            // lblSetVKIDGroup
            // 
            this.lblSetVKIDGroup.AutoSize = true;
            this.lblSetVKIDGroup.Location = new System.Drawing.Point(185, 55);
            this.lblSetVKIDGroup.Name = "lblSetVKIDGroup";
            this.lblSetVKIDGroup.Size = new System.Drawing.Size(58, 13);
            this.lblSetVKIDGroup.TabIndex = 8;
            this.lblSetVKIDGroup.Text = "ID Группы";
            // 
            // cbSetAutoConnect
            // 
            this.cbSetAutoConnect.AutoSize = true;
            this.cbSetAutoConnect.Location = new System.Drawing.Point(188, 114);
            this.cbSetAutoConnect.Name = "cbSetAutoConnect";
            this.cbSetAutoConnect.Size = new System.Drawing.Size(244, 17);
            this.cbSetAutoConnect.TabIndex = 7;
            this.cbSetAutoConnect.Text = "Автоматически подключаться при запуске";
            this.cbSetAutoConnect.UseVisualStyleBackColor = true;
            this.cbSetAutoConnect.CheckedChanged += new System.EventHandler(this.cbSetAutoConnect_CheckedChanged);
            // 
            // wb
            // 
            this.wb.Location = new System.Drawing.Point(450, 16);
            this.wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(674, 462);
            this.wb.TabIndex = 6;
            this.wb.Visible = false;
            this.wb.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wb_DocumentCompleted);
            this.wb.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.wb_Navigated);
            this.wb.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.wb_Navigating);
            // 
            // btnSetVkConnect
            // 
            this.btnSetVkConnect.Location = new System.Drawing.Point(9, 110);
            this.btnSetVkConnect.Name = "btnSetVkConnect";
            this.btnSetVkConnect.Size = new System.Drawing.Size(168, 23);
            this.btnSetVkConnect.TabIndex = 5;
            this.btnSetVkConnect.Text = "Соединиться";
            this.btnSetVkConnect.UseVisualStyleBackColor = true;
            this.btnSetVkConnect.Click += new System.EventHandler(this.btnSetVkConnect_Click);
            // 
            // lblSetVKStatus
            // 
            this.lblSetVKStatus.AutoSize = true;
            this.lblSetVKStatus.Location = new System.Drawing.Point(6, 94);
            this.lblSetVKStatus.Name = "lblSetVKStatus";
            this.lblSetVKStatus.Size = new System.Drawing.Size(139, 13);
            this.lblSetVKStatus.TabIndex = 4;
            this.lblSetVKStatus.Text = "Подключение отсутствует";
            // 
            // tbSetVkAppCode
            // 
            this.tbSetVkAppCode.Location = new System.Drawing.Point(9, 71);
            this.tbSetVkAppCode.Name = "tbSetVkAppCode";
            this.tbSetVkAppCode.Size = new System.Drawing.Size(168, 20);
            this.tbSetVkAppCode.TabIndex = 3;
            this.tbSetVkAppCode.TextChanged += new System.EventHandler(this.tbSetVkAppCode_TextChanged);
            // 
            // lblSetVkAppCode
            // 
            this.lblSetVkAppCode.AutoSize = true;
            this.lblSetVkAppCode.Location = new System.Drawing.Point(6, 55);
            this.lblSetVkAppCode.Name = "lblSetVkAppCode";
            this.lblSetVkAppCode.Size = new System.Drawing.Size(88, 13);
            this.lblSetVkAppCode.TabIndex = 2;
            this.lblSetVkAppCode.Text = "Защитный ключ";
            // 
            // tbSetVkAppID
            // 
            this.tbSetVkAppID.Location = new System.Drawing.Point(9, 32);
            this.tbSetVkAppID.Name = "tbSetVkAppID";
            this.tbSetVkAppID.Size = new System.Drawing.Size(168, 20);
            this.tbSetVkAppID.TabIndex = 1;
            this.tbSetVkAppID.TextChanged += new System.EventHandler(this.tbSetVkAppID_TextChanged);
            // 
            // lblSetVkAppID
            // 
            this.lblSetVkAppID.AutoSize = true;
            this.lblSetVkAppID.Location = new System.Drawing.Point(6, 16);
            this.lblSetVkAppID.Name = "lblSetVkAppID";
            this.lblSetVkAppID.Size = new System.Drawing.Size(91, 13);
            this.lblSetVkAppID.TabIndex = 0;
            this.lblSetVkAppID.Text = "ИД Приложения";
            // 
            // fmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 626);
            this.Controls.Add(this.gbSetVk);
            this.Controls.Add(this.gbSetApp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.fmSettings_Load);
            this.gbSetApp.ResumeLayout(false);
            this.gbSetApp.PerformLayout();
            this.gbSetVk.ResumeLayout(false);
            this.gbSetVk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSetApp;
        private System.Windows.Forms.GroupBox gbSetVk;
        private System.Windows.Forms.Label lblSetVkAppID;
        private System.Windows.Forms.TextBox tbSetVkAppCode;
        private System.Windows.Forms.Label lblSetVkAppCode;
        private System.Windows.Forms.Button btnSetVkConnect;
        private System.Windows.Forms.Label lblSetVKStatus;
        private System.Windows.Forms.WebBrowser wb;
        public System.Windows.Forms.TextBox tbSetVkAppID;
        private System.Windows.Forms.CheckBox cbSetAutoConnect;
        private System.Windows.Forms.TextBox tbSetVkIDGroup;
        private System.Windows.Forms.Label lblSetVKIDGroup;
        private System.Windows.Forms.ComboBox cbSetVKQueryLimit;
        private System.Windows.Forms.Label lblSetVKQueryLimit;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.TextBox tbSetDirectoryTemp;
        private System.Windows.Forms.Label lblSetDirectoryTemp;
        private System.Windows.Forms.Label lblSetVkTimeout;
        private System.Windows.Forms.TextBox tbSetVkTimeout;
        private System.Windows.Forms.ComboBox cbLogType;
        private System.Windows.Forms.Label lblLogType;
    }
}