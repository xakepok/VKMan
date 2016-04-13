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
using System.IO;

namespace VKMan
{
    public partial class fmSettings : Form
    {
        private static RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);

        public static string VkAppID = ""; //ID приложения
        public static string VkAppCode = ""; //Защищенный ключ
        public static string VkIDGroup = ""; //ID Группы ВК
        public static string VKQueryLimit = ""; //Максимум результатов за 1 запрос
        public static string DirectoryTemp = Environment.ExpandEnvironmentVariables("%AppData%") + @"\" + "VKMan"; //Временный каталог
        public static bool VKAutoConnect = false; //Автосоединение при запуске программы
        public static bool noConnect = false; //Запрет на автоподключение несмотря на галочку в настройках
        public static bool need_close = false; //Нужно ли автоматически закрывать форму после показа
        public static bool deleteOld = true; //Нужно ли удалять старые файлы перед запросом
        public static bool full_log = true; //Полный лог
        public static int VKTimeout = 2000; //Таймаут при соединении

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
            VkIDGroup = (reg.GetValue("VkIDGroup") == null) ? setParam("VkIDGroup", "") : checkVkAppId(reg.GetValue("VkIDGroup").ToString());
            VKQueryLimit = (reg.GetValue("VKQueryLimit") == null) ? setParam("VKQueryLimit", "Максимум") : checkVkQueryLimit(reg.GetValue("VKQueryLimit").ToString());
            VKTimeout = (reg.GetValue("VKTimeout") == null) ? Int32.Parse(setParam("VKTimeout", VKTimeout.ToString())) : checkVKTimeout(reg.GetValue("VKTimeout").ToString());
            full_log = (reg.GetValue("Log") == null) ? setParam("Log", full_log ? "full" : "standart") == "full" ? true : false : checkLogType(reg.GetValue("log").ToString());

            if (reg.GetValue("VKAutoConnect") == null) {
                setParam("VKAutoConnect", "0");
                VKAutoConnect = false;
            } else {
                VKAutoConnect = (checkVkBool(reg.GetValue("VKAutoConnect").ToString()) == "0") ? false : true;
            }
            DirectoryInfo tmp = new DirectoryInfo(DirectoryTemp);
            if (!tmp.Exists) tmp.Create();
        }

        private void fmSettings_Load(object sender, EventArgs e)
        {
            if (VkAppID != "") tbSetVkAppID.Text = VkAppID;
            if (VkAppCode != "") tbSetVkAppCode.Text = VkAppCode;
            if (VkIDGroup != "") tbSetVkIDGroup.Text = VkIDGroup;
            if (VKQueryLimit != "") cbSetVKQueryLimit.Text = VKQueryLimit;
            cbLogType.Text = full_log ? "Полный" : "Стандартный";
            tbSetVkTimeout.Text = VKTimeout.ToString();
            cbSetAutoConnect.Checked = (VKAutoConnect) ? true : false;

            if (VKAutoConnect && !noConnect && !VK.connected)
            {
                wb.Visible = true;
                wb.Navigate("https://oauth.vk.com/authorize?client_id=" + VkAppID + "&scope=groups,pages,messages&display=mobile&response_type=token&redirect_uri=https://oauth.vk.com/blank.html");
            }
            if (VK.connected)
            {
                btnSetVkConnect.Enabled = false;
                lblSetVKStatus.Text = "Подключено. Токен: " + VK.token;
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

        private static string checkVkQueryLimit(string limit)
        {
            return (limit == "Максимум" || limit == "Половина" || limit == "Минимум") ? limit : "Максимум";
        }

        private static string checkVkBool(string value)
        {
            return (value == "0" || value == "1") ? value : "0";
        }

        private static int checkVKTimeout(string timeout)
        {
            try
            {
                int t = Int32.Parse(timeout);
                return (t <= 300 || t > 2000) ? VKTimeout : t;
            }
            catch (Exception e)
            {
                return VKTimeout;
            }
        }

        private static bool checkLogType(string logType)
        {
            return logType == "full" ? true : logType == "Полный" ? true : false;
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
                lblSetVKStatus.Text = "Подключено. Токен: " + VK.token;
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

        private void tbSetVkIDGroup_TextChanged(object sender, EventArgs e)
        {
            if (checkVkAppId(tbSetVkIDGroup.Text) != "")
            {
                VkIDGroup = tbSetVkIDGroup.Text;
                setParam("VkIDGroup", VkIDGroup);
            }
        }

        private void cbSetVKQueryLimit_SelectedIndexChanged(object sender, EventArgs e)
        {
            VKQueryLimit = cbSetVKQueryLimit.Text;
            setParam("VKQueryLimit", cbSetVKQueryLimit.Text);
        }

        private void wb_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            pbLoading.Visible = true;
        }

        private void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            pbLoading.Visible = false;
        }

        private void tbSetVkTimeout_TextChanged(object sender, EventArgs e)
        {
            if (tbSetVkTimeout.Text.Length > 2)
            {
                VKTimeout = checkVKTimeout(tbSetVkTimeout.Text);
                setParam("VKTimeout", tbSetVkTimeout.Text);
            }
        }

        private void cbLogType_SelectedIndexChanged(object sender, EventArgs e)
        {
            full_log = cbLogType.Text == "Полный" ? true : false;
            setParam("Log", full_log ? "full" : "standart");
        }
    }
}
