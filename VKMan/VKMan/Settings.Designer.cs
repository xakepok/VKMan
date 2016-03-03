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
            this.lblSetVkID = new System.Windows.Forms.Label();
            this.tbSetVkID = new System.Windows.Forms.TextBox();
            this.lblSetVkKey = new System.Windows.Forms.Label();
            this.tbSetVkKey = new System.Windows.Forms.TextBox();
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
            this.gbSetVk.Controls.Add(this.tbSetVkKey);
            this.gbSetVk.Controls.Add(this.lblSetVkKey);
            this.gbSetVk.Controls.Add(this.tbSetVkID);
            this.gbSetVk.Controls.Add(this.lblSetVkID);
            this.gbSetVk.Location = new System.Drawing.Point(308, 12);
            this.gbSetVk.Name = "gbSetVk";
            this.gbSetVk.Size = new System.Drawing.Size(358, 194);
            this.gbSetVk.TabIndex = 1;
            this.gbSetVk.TabStop = false;
            this.gbSetVk.Text = "Настройки ВК";
            // 
            // lblSetVkID
            // 
            this.lblSetVkID.AutoSize = true;
            this.lblSetVkID.Location = new System.Drawing.Point(6, 16);
            this.lblSetVkID.Name = "lblSetVkID";
            this.lblSetVkID.Size = new System.Drawing.Size(91, 13);
            this.lblSetVkID.TabIndex = 0;
            this.lblSetVkID.Text = "ИД Приложения";
            // 
            // tbSetVkID
            // 
            this.tbSetVkID.Location = new System.Drawing.Point(9, 32);
            this.tbSetVkID.Name = "tbSetVkID";
            this.tbSetVkID.Size = new System.Drawing.Size(168, 20);
            this.tbSetVkID.TabIndex = 1;
            // 
            // lblSetVkKey
            // 
            this.lblSetVkKey.AutoSize = true;
            this.lblSetVkKey.Location = new System.Drawing.Point(6, 55);
            this.lblSetVkKey.Name = "lblSetVkKey";
            this.lblSetVkKey.Size = new System.Drawing.Size(88, 13);
            this.lblSetVkKey.TabIndex = 2;
            this.lblSetVkKey.Text = "Защитный ключ";
            // 
            // tbSetVkKey
            // 
            this.tbSetVkKey.Location = new System.Drawing.Point(9, 71);
            this.tbSetVkKey.Name = "tbSetVkKey";
            this.tbSetVkKey.Size = new System.Drawing.Size(168, 20);
            this.tbSetVkKey.TabIndex = 3;
            // 
            // fmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 459);
            this.Controls.Add(this.gbSetVk);
            this.Controls.Add(this.gbSetApp);
            this.Name = "fmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.gbSetVk.ResumeLayout(false);
            this.gbSetVk.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSetApp;
        private System.Windows.Forms.GroupBox gbSetVk;
        private System.Windows.Forms.TextBox tbSetVkID;
        private System.Windows.Forms.Label lblSetVkID;
        private System.Windows.Forms.TextBox tbSetVkKey;
        private System.Windows.Forms.Label lblSetVkKey;
    }
}