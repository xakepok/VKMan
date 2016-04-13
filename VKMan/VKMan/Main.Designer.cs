namespace VKMan
{
    public partial class fmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.sfdExport = new System.Windows.Forms.SaveFileDialog();
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiMainProgramm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMainSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMainAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMainGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMainExport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMainExportBan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMainExportUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMainExportWiki = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // sfdExport
            // 
            this.sfdExport.Filter = "Тестовые файлы|*.txt";
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMainProgramm,
            this.tsmiMainGroup});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(875, 24);
            this.msMainMenu.TabIndex = 0;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // tsmiMainProgramm
            // 
            this.tsmiMainProgramm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMainSettings,
            this.tsmiMainAbout});
            this.tsmiMainProgramm.Name = "tsmiMainProgramm";
            this.tsmiMainProgramm.Size = new System.Drawing.Size(84, 20);
            this.tsmiMainProgramm.Text = "Программа";
            // 
            // tsmiMainSettings
            // 
            this.tsmiMainSettings.Name = "tsmiMainSettings";
            this.tsmiMainSettings.Size = new System.Drawing.Size(149, 22);
            this.tsmiMainSettings.Text = "Настройки";
            this.tsmiMainSettings.Click += new System.EventHandler(this.tsmiMainSettings_Click);
            // 
            // tsmiMainAbout
            // 
            this.tsmiMainAbout.Name = "tsmiMainAbout";
            this.tsmiMainAbout.Size = new System.Drawing.Size(149, 22);
            this.tsmiMainAbout.Text = "О программе";
            this.tsmiMainAbout.Click += new System.EventHandler(this.tsmiMainAbout_Click);
            // 
            // tsmiMainGroup
            // 
            this.tsmiMainGroup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMainExport});
            this.tsmiMainGroup.Name = "tsmiMainGroup";
            this.tsmiMainGroup.Size = new System.Drawing.Size(58, 20);
            this.tsmiMainGroup.Text = "Группа";
            // 
            // tsmiMainExport
            // 
            this.tsmiMainExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMainExportBan,
            this.tsmiMainExportUsers,
            this.tsmiMainExportWiki});
            this.tsmiMainExport.Name = "tsmiMainExport";
            this.tsmiMainExport.Size = new System.Drawing.Size(119, 22);
            this.tsmiMainExport.Text = "Экспорт";
            // 
            // tsmiMainExportBan
            // 
            this.tsmiMainExportBan.Name = "tsmiMainExportBan";
            this.tsmiMainExportBan.Size = new System.Drawing.Size(156, 22);
            this.tsmiMainExportBan.Text = "Бан-лист";
            this.tsmiMainExportBan.Click += new System.EventHandler(this.tsmiMainExportBan_Click);
            // 
            // tsmiMainExportUsers
            // 
            this.tsmiMainExportUsers.Name = "tsmiMainExportUsers";
            this.tsmiMainExportUsers.Size = new System.Drawing.Size(156, 22);
            this.tsmiMainExportUsers.Text = "Пользователи";
            this.tsmiMainExportUsers.Click += new System.EventHandler(this.tsmiMainExportUsers_Click);
            // 
            // tsmiMainExportWiki
            // 
            this.tsmiMainExportWiki.Name = "tsmiMainExportWiki";
            this.tsmiMainExportWiki.Size = new System.Drawing.Size(156, 22);
            this.tsmiMainExportWiki.Text = "Wiki-страницы";
            this.tsmiMainExportWiki.Click += new System.EventHandler(this.tsmiMainExportWiki_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 474);
            this.Controls.Add(this.msMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VKManager";
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog sfdExport;
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiMainProgramm;
        private System.Windows.Forms.ToolStripMenuItem tsmiMainSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiMainAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiMainGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmiMainExport;
        private System.Windows.Forms.ToolStripMenuItem tsmiMainExportBan;
        private System.Windows.Forms.ToolStripMenuItem tsmiMainExportUsers;
        private System.Windows.Forms.ToolStripMenuItem tsmiMainExportWiki;
    }
}

