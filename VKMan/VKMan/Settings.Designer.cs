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
            this.gbSetApp = new System.Windows.Forms.GroupBox();
            this.gbSetVk = new System.Windows.Forms.GroupBox();
            this.btnSetVkConnect = new System.Windows.Forms.Button();
            this.lblSetVKStatus = new System.Windows.Forms.Label();
            this.tbSetVkAppCode = new System.Windows.Forms.TextBox();
            this.lblSetVkAppCode = new System.Windows.Forms.Label();
            this.tbSetVkAppID = new System.Windows.Forms.TextBox();
            this.lblSetVkAppID = new System.Windows.Forms.Label();
            this.wb = new System.Windows.Forms.WebBrowser();
            this.cbSetAutoConnect = new System.Windows.Forms.CheckBox();
            this.gbSetVk.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSetApp
            // 
            this.gbSetApp.Location = new System.Drawing.Point(12, 12);
            this.gbSetApp.Name = "gbSetApp";
            this.gbSetApp.Size = new System.Drawing.Size(290, 194);
            this.gbSetApp.TabIndex = 0;
            this.gbSetApp.TabStop = false;
            this.gbSetApp.Text = "Настройки программы";
            // 
            // gbSetVk
            // 
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
            this.gbSetVk.Size = new System.Drawing.Size(706, 607);
            this.gbSetVk.TabIndex = 1;
            this.gbSetVk.TabStop = false;
            this.gbSetVk.Text = "Настройки ВК";
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
            // wb
            // 
            this.wb.Location = new System.Drawing.Point(9, 139);
            this.wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(691, 462);
            this.wb.TabIndex = 6;
            this.wb.Visible = false;
            this.wb.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.wb_Navigated);
            // 
            // cbSetAutoConnect
            // 
            this.cbSetAutoConnect.AutoSize = true;
            this.cbSetAutoConnect.Location = new System.Drawing.Point(188, 16);
            this.cbSetAutoConnect.Name = "cbSetAutoConnect";
            this.cbSetAutoConnect.Size = new System.Drawing.Size(244, 17);
            this.cbSetAutoConnect.TabIndex = 7;
            this.cbSetAutoConnect.Text = "Автоматически подключаться при запуске";
            this.cbSetAutoConnect.UseVisualStyleBackColor = true;
            this.cbSetAutoConnect.CheckedChanged += new System.EventHandler(this.cbSetAutoConnect_CheckedChanged);
            // 
            // fmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 626);
            this.Controls.Add(this.gbSetVk);
            this.Controls.Add(this.gbSetApp);
            this.Name = "fmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.fmSettings_Load);
            this.gbSetVk.ResumeLayout(false);
            this.gbSetVk.PerformLayout();
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
    }
}