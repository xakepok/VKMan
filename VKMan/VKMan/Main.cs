using System;
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
            if (fmSettings.VKAutoConnect)
            {
                Form S = new fmSettings();
                if (args.Contains("/noConnect")) fmSettings.noConnect = true; //Запрет на автоподключение через параметры запуска
                fmSettings.need_close = true;
                S.ShowDialog(this);
            }
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form S = new fmSettings();
            
            S.ShowDialog(this);
        }
    }
}
