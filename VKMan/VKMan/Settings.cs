using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Microsoft.Win32;

namespace VKMan
{
    public partial class fmSettings : Form
    {
        private static RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);

        public static string VkAppID = ""; //ID приложения
        public static string VkAppCode = ""; //Защищенный ключ
        public static bool VKAutoConnect = false; //Автосоединение при запуске программы
        public static bool noConnect = false; //Запрет на автоподключение несмотря на галочку в настройках
        public static bool need_close = false; //Нужно ли автоматически закрывать форму после показа

        public fmSettings()
        {
            InitializeComponent();
        }

        public static void init()
        {
            reg = reg.CreateSubKey("VKMan");
            /* Инициализируем параметры */
            VkAppID = (reg.GetValue("VkAppID") == null) ? setParam("VkAppID", "") : checkVkAppId(reg.GetValue("VkAppID").ToString());
            VkAppCode = (reg.GetValue("VkAppCode") == null) ? setParam("VkAppCode", "") : checkVkAppCode(reg.GetValue("VkAppCode").ToString());
            if (reg.GetValue("VKAutoConnect") == null) {
                setParam("VKAutoConnect", "0");
                VKAutoConnect = false;
            } else {
                VKAutoConnect = (checkVkBool(reg.GetValue("VKAutoConnect").ToString()) == "0") ? false : true;
            }
        }

        public static string setParam(string param, string value)
        {
            reg.SetValue(param, value);
            return value;
        }

        private static string checkVkAppId(string id)
        {
            int number;
            return (Int32.TryParse(id, out number)) ? id : "";
        }

        private static string checkVkAppCode(string code)
        {
            return (code.Length == 20) ? code : "";
        }

        private static string checkVkBool(string value)
        {
            return (value == "0" || value == "1") ? value : "0";
        }

        private void btnSetVkConnect_Click(object sender, EventArgs e)
        {
            wb.Visible = true;
            wb.Navigate("https://oauth.vk.com/authorize?client_id=" + VkAppID + "&display=mobile&response_type=token&redirect_uri=https://oauth.vk.com/blank.html");
        }

        private void tbSetVkAppID_TextChanged(object sender, EventArgs e)
        {
            if (checkVkAppId(tbSetVkAppID.Text) != "")
            {
                VkAppID = tbSetVkAppID.Text;
                setParam("VkAppID", VkAppID);
                if (checkVkAppId(tbSetVkAppID.Text) != "" && checkVkAppCode(tbSetVkAppCode.Text) != "") btnSetVkConnect.Enabled = true; else btnSetVkConnect.Enabled = false;
            } else
            {
                btnSetVkConnect.Enabled = false;
            }
        }

        private void tbSetVkAppCode_TextChanged(object sender, EventArgs e)
        {
            if (checkVkAppCode(tbSetVkAppCode.Text) != "")
            {
                VkAppCode = tbSetVkAppCode.Text;
                setParam("VkAppCode", VkAppCode);
                if (checkVkAppId(tbSetVkAppID.Text) != "" && checkVkAppCode(tbSetVkAppCode.Text) != "") btnSetVkConnect.Enabled = true; else btnSetVkConnect.Enabled = false;
            }
            else
            {
                btnSetVkConnect.Enabled = false;
            }
        }

        private void fmSettings_Load(object sender, EventArgs e)
        {
            if (VkAppID != "") tbSetVkAppID.Text = VkAppID;
            if (VkAppCode != "") tbSetVkAppCode.Text = VkAppCode;
            cbSetAutoConnect.Checked = (VKAutoConnect) ? true : false;
            if (VKAutoConnect && !noConnect)
            {
                wb.Visible = true;
                wb.Navigate("https://oauth.vk.com/authorize?client_id=" + VkAppID + "&display=mobile&response_type=token&redirect_uri=https://oauth.vk.com/blank.html");
            }
        }

        private void cbSetAutoConnect_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSetAutoConnect.Checked == true)
            {
                setParam("VKAutoConnect", "1");
                VKAutoConnect = true;
            } else
            {
                setParam("VKAutoConnect", "0");
                VKAutoConnect = false;
            }
        }

        private void wb_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            if (wb.Url.AbsoluteUri.IndexOf('#') != -1)
            {
                VK.set_token(wb.Url.AbsoluteUri);
                lblSetVKStatus.Text = "Подключено";
                wb.Visible = false;
                btnSetVkConnect.Enabled = false;
                VK.connected = true;
                if (VKAutoConnect && need_close)
                {
                    need_close = false;
                    this.Close();
                }
            } else
            {
                MessageBox.Show("Вы не дали разрешение на авторизацию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
