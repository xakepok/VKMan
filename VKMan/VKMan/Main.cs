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
        public fmMain()
        {
            fmSettings.init(); //Инициализируем настройки
            InitializeComponent();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form S = new fmSettings();
            S.ShowDialog(this);
        }
    }
}
