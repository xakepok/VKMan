using System;
using System.IO;
using Microsoft.Win32;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VKMan
{
    public partial class fmMain : Form
    {
        public fmMain(string[] args)
        {
            fmSettings.init(); //Инициализируем настройки
            InitializeComponent();
            if (fmSettings.VKAutoConnect) //Автоподключение
            {
                Form S = new fmSettings();
                if (args.Contains("/noConnect")) fmSettings.noConnect = true; //Запрет на автоподключение через параметры запуска
                fmSettings.need_close = true;
                S.ShowDialog(this);
                if (args.Contains("/Vizil"))
                {
                    string res = VK.GET("messages.send", "chat_id=28&message=Визиль порвался");
                    Environment.Exit(0);
                }
            }
        }

        private void tsmiMainSettings_Click(object sender, EventArgs e)
        {
            Form S = new fmSettings();
            S.ShowDialog(this);
        }

        private void tsmiMainAbout_Click(object sender, EventArgs e)
        {
            Form About = new fmAbout();
            About.ShowDialog(this);
        }

        private void tsmiMainExportBan_Click(object sender, EventArgs e)
        {
            List<string> ban = VK.ban_list();
            if (ban.Count > 0)
            {
                sfdExport.FileName = "ban-" + fmSettings.VkIDGroup + ".txt";
                sfdExport.ShowDialog();
                if (sfdExport.FileName != "")
                {
                    StreamWriter write_text;
                    FileInfo file = new FileInfo(sfdExport.FileName);
                    write_text = file.CreateText();
                    foreach (string str in ban)
                    {
                        write_text.WriteLine(str);
                    }
                    write_text.Close();
                }
            }
        }

        private void btnTest1_Click(object sender, EventArgs e)
        {
            pbLoading.Visible = true;
            textBox1.Text = VK.test();
            pbLoading.Visible = false;
        }
    }
}
