namespace VKMan
{
    partial class fmWaiting
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmWaiting));
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.pbProcess = new System.Windows.Forms.ProgressBar();
            this.tmrProgress = new System.Windows.Forms.Timer(this.components);
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblCountAll = new System.Windows.Forms.Label();
            this.lblCountCurrent = new System.Windows.Forms.Label();
            this.lblCountNo = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLoading
            // 
            this.pbLoading.Image = global::VKMan.Properties.Resources.ajax_loader;
            this.pbLoading.Location = new System.Drawing.Point(277, 12);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(66, 66);
            this.pbLoading.TabIndex = 3;
            this.pbLoading.TabStop = false;
            // 
            // pbProcess
            // 
            this.pbProcess.Location = new System.Drawing.Point(12, 84);
            this.pbProcess.Name = "pbProcess";
            this.pbProcess.Size = new System.Drawing.Size(592, 23);
            this.pbProcess.TabIndex = 4;
            // 
            // tmrProgress
            // 
            this.tmrProgress.Tick += new System.EventHandler(this.tmrProgress_Tick);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProgress.Location = new System.Drawing.Point(9, 12);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(72, 13);
            this.lblProgress.TabIndex = 5;
            this.lblProgress.Text = "Прогресс: ";
            // 
            // lblCountAll
            // 
            this.lblCountAll.AutoSize = true;
            this.lblCountAll.Location = new System.Drawing.Point(9, 25);
            this.lblCountAll.Name = "lblCountAll";
            this.lblCountAll.Size = new System.Drawing.Size(101, 13);
            this.lblCountAll.TabIndex = 6;
            this.lblCountAll.Text = "Всего элементов: ";
            // 
            // lblCountCurrent
            // 
            this.lblCountCurrent.AutoSize = true;
            this.lblCountCurrent.Location = new System.Drawing.Point(9, 38);
            this.lblCountCurrent.Name = "lblCountCurrent";
            this.lblCountCurrent.Size = new System.Drawing.Size(119, 13);
            this.lblCountCurrent.TabIndex = 7;
            this.lblCountCurrent.Text = "Получено элементов: ";
            // 
            // lblCountNo
            // 
            this.lblCountNo.AutoSize = true;
            this.lblCountNo.Location = new System.Drawing.Point(9, 51);
            this.lblCountNo.Name = "lblCountNo";
            this.lblCountNo.Size = new System.Drawing.Size(130, 13);
            this.lblCountNo.TabIndex = 8;
            this.lblCountNo.Text = "Оставшиеся элементы: ";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(511, 51);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(93, 23);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Отмена";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // fmWaiting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(616, 113);
            this.ControlBox = false;
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblCountNo);
            this.Controls.Add(this.lblCountCurrent);
            this.Controls.Add(this.lblCountAll);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.pbProcess);
            this.Controls.Add(this.pbLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmWaiting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Waiting";
            this.Shown += new System.EventHandler(this.fmWaiting_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.ProgressBar pbProcess;
        private System.Windows.Forms.Timer tmrProgress;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblCountAll;
        private System.Windows.Forms.Label lblCountCurrent;
        private System.Windows.Forms.Label lblCountNo;
        private System.Windows.Forms.Button btnStop;
    }
}