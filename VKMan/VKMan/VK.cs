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

namespace VKMan
{
    class VK
    {
        public static string token = "";
        public static bool connected = false; //Текущий статус подключения
        public static string api_url = "https://api.vk.com/method/"; //URL API
        public static string method = ""; //Текущий метод для запроса
        public static string data = ""; //Данные для запроса
        private static XmlDocument XML = new XmlDocument(); //Результат запроса
        private static string error = ""; //Текст исключения для загрузки из ВК
        private static bool proceed = false; //Метка завершения работы потока

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

        private static void getxml()
        {
            proceed = false;
            try
            {
                XML.Load(VK.api_url + VK.method + ".xml?access_token=" + VK.token + "&" + VK.data);
                try
                {
                    XML.Save(fmSettings.DirectoryTemp + @"\result.xml");
                }
                catch (Exception e2)
                {
                    VK.error = e2.Message;
                }
            }
            catch (Exception e)
            {
                VK.error = e.Message;
            }
            proceed = true;
        }

        public static string test()
        {
            var doc = new XmlDocument();
            int count = (fmSettings.VKQueryLimit == "Максимум") ? 200 : (fmSettings.VKQueryLimit == "Половина") ? 100 : (fmSettings.VKQueryLimit == "Минимум") ? 50 : 50;
            int offset = 0; //Смещение
            bool need = true; //Нужно ли запрашивать ещё
            VK.method = "groups.getBanned";
            Thread t = new Thread(getxml);
            string result = "";
            while (need == true)
            {
                VK.data = "group_id=" + fmSettings.VkIDGroup + "&offset=" + offset.ToString() + "&count=" + count.ToString();
                t.Start();
                if (VK.error == "")
                {
                    doc.Load(fmSettings.DirectoryTemp + @"\result.xml");
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
                        foreach (XmlNode noda in doc.DocumentElement)
                        {
                            if (noda.LocalName != "count")
                            {
                                foreach (XmlNode item in noda.ChildNodes)
                                {
                                    if (item.LocalName == "uid") result += item.InnerXml;
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }

        /* Бан-лист */
        public static List<string> ban_list()
        {
            var doc = new XmlDocument();
            int offset = 0; //Смещение
            int count = (fmSettings.VKQueryLimit == "Максимум") ? 200 : (fmSettings.VKQueryLimit == "Половина") ? 100 : (fmSettings.VKQueryLimit == "Минимум") ? 50 : 50;
            bool need = true; //Нужно ли запрашивать ещё
            List<string> result = new List<string>(); //Результат
            while (need == true)
            {
                doc.LoadXml(GET("groups.getBanned", "group_id=" + fmSettings.VkIDGroup + "&offset=" + offset.ToString() + "&count=" + count.ToString()));
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
                    foreach (XmlNode noda in doc.DocumentElement)
                    {
                        if (noda.LocalName != "count")
                        {
                            foreach (XmlNode item in noda.ChildNodes)
                            {
                                if (item.LocalName == "uid") result.Add(item.InnerXml);
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}
