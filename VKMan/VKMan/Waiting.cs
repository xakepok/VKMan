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
    public partial class fmWaiting : Form
    {
        public static int progress = 0; //Текущий прогресс
        public static int count_all = 0; //Общее колисество элементов
        public static int count_current = 0; //Текущее смещение
        public static bool stop = false; //Остановка

        public fmWaiting()
        {
            InitializeComponent();
        }

        private void fmWaiting_Shown(object sender, EventArgs e)
        {
            pbProcess.Value = 0;
            tmrProgress.Enabled = true;
        }

        private void tmrProgress_Tick(object sender, EventArgs e)
        {
            try
            {
                progress = 100 * count_current / count_all;
                if (progress == 100) tmrProgress.Enabled = false;
            }
            catch (Exception ep)
            {
                progress = 0;
            }
            try
            {
                lblCountAll.Text = "Всего элементов: " + count_all.ToString();
                lblCountCurrent.Text = "Получено элементов: " + count_current.ToString();
                lblCountNo.Text = "Оставшиеся элементы: " + (count_all - count_current).ToString();
            }
            catch (Exception ep)
            {

            }
            lblProgress.Text = "Прогресс: " + progress.ToString() + @"%";
            pbProcess.Value = progress;
        }

        /* Подсчитываем размер полченных данных */
        private static void downloadSize()
        {

        }

        /* Команда на остановку получения данных */
        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            stop = true;
        }
    }
}
