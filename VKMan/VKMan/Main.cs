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
using System.Threading;


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
                if (args.Contains("/Alco"))
                {
                    VK.alco();
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
            Thread t = new Thread(VK.ban_list);
            Thread w = new Thread(wait);
            t.Start();
            w.Start();
            t.Join();
            w.Abort();
            this.Activate();
            if (VK.error == "") MessageBox.Show("Данные успешно выгружены", "Операция завершена", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (VK.error != "") MessageBox.Show(VK.error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void wait()
        {
            Form wait = new fmWaiting();
            wait.ShowDialog();
        }
    }
}
