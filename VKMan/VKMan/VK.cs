using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Xml;
using System.IO;
using System.Timers;

namespace VKMan
{
    class VK
    {
        public static string token = "";
        public static bool connected = false; //Текущий статус подключения
        public static string api_url = "https://api.vk.com/method/"; //URL API
        private static XmlDocument XML = new XmlDocument(); //Результат запроса
        public static string error = ""; //Текст исключения для загрузки из ВК

        /* Запоминаем токен */
        public static void set_token(string url)
        {
            string tmp = url.Remove(0, url.IndexOf('=') + 1);
            token = tmp.Remove(85);
        }

        /* Запрос к ВК */
        public static string GET(string method, string Data)
        {
            var url = WebUtility.UrlEncode(api_url + method + ".xml?access_token=" + token + "&" + Data);
            System.Net.WebRequest req = System.Net.WebRequest.Create(WebUtility.UrlDecode(url));
            System.Net.WebResponse resp = req.GetResponse();
            System.IO.Stream stream = resp.GetResponseStream();
            System.IO.StreamReader sr = new System.IO.StreamReader(stream);
            string Out = sr.ReadToEnd();
            sr.Close();
            return Out;
        }

        private static void getxml(string method, string data, string fname)
        {
            //Thread.Sleep(350);
            try
            {
                XML.Load(VK.api_url + method + ".xml?access_token=" + VK.token + "&" + data);
                try
                {
                    XML.Save(fmSettings.DirectoryTemp + @"\" + fname + ".xml");
                }
                catch (Exception e2)
                {
                    VK.error = e2.Message;
                    return;
                }
            }
            catch (Exception e)
            {
                VK.error = e.Message;
                return;
            }
        }

        public static void alco()
        {
            try
            {
                string[] arr = File.ReadAllLines(fmSettings.DirectoryTemp + @"\Alko.txt");
                Random r = new Random();
                bool need = true;
                while (need)
                {
                    int i = r.Next(arr.Length);
                    if (arr[i] != "")
                    {
                        string res = VK.GET("messages.send", "chat_id=63&message=" + arr[i]);
                        //res = VK.GET("messages.send", "chat_id=28&message=" + arr[i]);
                        need = false;
                    }
                }
            }
            catch (Exception e3)
            {

            }
        }

        /* Бан-лист */
        public static void ban_list()
        {
            VK.error = "";
            if (!VK.connected) { VK.error = "Вы не соединены с ВК."; return; }
            var doc = new XmlDocument();
            int count = (fmSettings.VKQueryLimit == "Максимум") ? 200 : (fmSettings.VKQueryLimit == "Половина") ? 100 : (fmSettings.VKQueryLimit == "Минимум") ? 50 : 50;
            int offset = 0; //Смещение
            bool need = true; //Нужно ли запрашивать ещё
            while (need)
            {
                getxml("groups.getBanned", "group_id=" + fmSettings.VkIDGroup + "&offset=" + offset.ToString() + "&count=" + count.ToString(), "ban_" + offset.ToString());
                if (VK.error == "")
                {
                    try
                    {
                        doc.Load(fmSettings.DirectoryTemp + @"\ban_" + offset.ToString() + ".xml");
                        if (doc.DocumentElement.LocalName == "response")
                        {
                            if (doc.DocumentElement.ChildNodes.Count < count + 1)
                            {
                                need = false;
                            }
                            else
                            {
                                offset = offset + count;
                                need = true;
                            }
                        }
                        if (doc.DocumentElement.LocalName == "error")
                        {
                            foreach (XmlNode en in doc.DocumentElement.ChildNodes)
                            {
                                if (en.LocalName == "error_msg") VK.error = en.InnerText;
                            }
                            need = false;
                            return;
                        }
                    }
                    catch (Exception ban_e)
                    {
                        VK.error = ban_e.Message;
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
        }
    }
}
