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
using System.Diagnostics;

namespace VKMan
{
    class VK
    {
        public static string token = "";
        public static bool connected = false; //Текущий статус подключения
        public static string api_url = "https://api.vk.com/method/"; //URL API
        public static int offset = 0; //Смещение
        public static string error = ""; //Текст исключения для загрузки из ВК
        private static string fname = ""; //Имя файла для сохранения
        private static XmlDocument XML = new XmlDocument(); //Результат запроса

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
            WebRequest req = WebRequest.Create(WebUtility.UrlDecode(url));
            WebResponse resp = req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string Out = sr.ReadToEnd();
            sr.Close();
            return Out;
        }

        private static void getxml(string method, string data)
        {
            VK.error = "";
            if (!VK.connected) { VK.error = "Вы не соединены с ВК."; return; }
            checkStopped();
            int error_code = 0; //Код ошибки ВК
            string error_msg = ""; //Текст ошибки ВК
            while (true)
            {
                try
                {
                    XML.Load(VK.api_url + method + ".xml?access_token=" + VK.token + "&" + data);
                    try
                    {
                        if (XML.DocumentElement.LocalName == "error") //Проверяем результат запроса
                        {
                            foreach (XmlNode en in XML.DocumentElement.ChildNodes)
                            {
                                if (en.LocalName == "error_code")
                                {
                                    error_code = Int32.Parse(en.InnerText);
                                }
                                if (en.LocalName == "error_msg")
                                {
                                    error_msg = en.InnerText;
                                }
                            }
                            if (error_code == 6 || error_code == 10) //Сканируем ошибку
                            {
                                if (fmSettings.full_log)
                                {
                                    Thread t = new Thread(delegate () { log(error_msg, EventLogEntryType.Warning, error_code); });
                                    t.Start();
                                }
                                Thread.Sleep(error_code == 6 ? 500 : fmSettings.VKTimeout); //Таймаут
                            }
                            else //Глобальная ошибка, требующая завершения получения
                            {
                                Thread t = new Thread(delegate () { log(error_msg, EventLogEntryType.Error, error_code); });
                                t.Start();
                                VK.error = error_msg;
                                return;
                            }
                        }
                        else //Запрос прошёл без ошибок
                        {
                            if (fmSettings.full_log) //Пишем лог
                            {
                                Thread t = new Thread(delegate () { log("VkSuccess: " + method + ", " + data, EventLogEntryType.Warning, error_code); });
                                t.Start();
                            }
                            if (offset == 0) //Получаем общее количество элементов
                            {
                                foreach (XmlNode en in XML.DocumentElement.ChildNodes)
                                {
                                    if (en.LocalName == "count")
                                    {
                                        fmWaiting.count_all = Int32.Parse(en.InnerText);
                                        break;
                                    }
                                }
                            }
                            XML.Save(fname);
                            break;
                        }
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
            catch (Exception e)
            {

            }
        }

        /* Wiki-страницы */
        public static void wiki()
        {
            offset = -1; //Убираем смещение
            var doc = new XmlDocument();
            if (VK.error == "" && fmSettings.deleteOld) deleteOldFiles("page"); //Удаляем старые файлы
            fname = fmSettings.DirectoryTemp + @"\" + @"pages-" + fmSettings.VkIDGroup + @".xml";
            getxml("pages.getTitles", "group_id=" + fmSettings.VkIDGroup);
            if (VK.error == "")
            {
                try
                {
                    doc.Load(fname);
                    fmWaiting.count_all = doc.DocumentElement.ChildNodes.Count;
                    fmWaiting.count_current = 0;
                    foreach (XmlNode xn1 in doc.DocumentElement)
                    {
                        if (xn1.LocalName == "page")
                        {
                            foreach (XmlNode xn in xn1.ChildNodes)
                            {
                                if (xn.LocalName == "pid")
                                {
                                    fname = fmSettings.DirectoryTemp + @"\" + @"page-" + fmSettings.VkIDGroup + @"_" + xn.InnerText + ".xml";
                                    getxml("pages.get", "owner_id=-" + fmSettings.VkIDGroup + "&page_id=" + xn.InnerText + "&need_html=1");
                                    if (VK.error != "")
                                    {
                                        return;
                                    }
                                    fmWaiting.count_current++;
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    VK.error = e.Message;
                    return;
                }
            }
            else
            {
                return;
            }
        }

        /* Юзер-лист */
        public static void users_list()
        {
            var doc = new XmlDocument();
            int count = (fmSettings.VKQueryLimit == "Максимум") ? 1000 : (fmSettings.VKQueryLimit == "Половина") ? 500 : (fmSettings.VKQueryLimit == "Минимум") ? 250 : 250;
            offset = 0; //Смещение
            if (VK.error == "" && fmSettings.deleteOld) deleteOldFiles("users"); //Удаляем старые файлы
            while (true)
            {
                fname = fmSettings.DirectoryTemp + @"\" + @"users-" + fmSettings.VkIDGroup + @"_" + offset.ToString() + @".xml";
                getxml("groups.getMembers", "group_id=" + fmSettings.VkIDGroup + "&sort=time_desc&fields=sex,bdate,city,country,photo_50,photo_100,photo_200_orig,photo_200,photo_400_orig,photo_max,photo_max_orig,online,online_mobile,lists,domain,has_mobile,contacts,connections,site,education,universities,schools,can_post,can_see_all_posts,can_see_audio,can_write_private_message,status,last_seen,common_count,relation,relatives,counters&offset=" + offset.ToString() + "&count=" + count.ToString());
                if (VK.error == "")
                {
                    try
                    {
                        doc.Load(fname);
                        int cnt = 0;
                        foreach (XmlNode xn1 in doc.DocumentElement)
                        {
                            if (xn1.LocalName == "users") { cnt = xn1.ChildNodes.Count; break; }
                        }
                        if (cnt < count)
                        {
                            break;
                        }
                        else
                        {
                            offset = offset + count;
                            fmWaiting.count_current = offset;
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

        /* Бан-лист */
        public static void ban_list()
        {
            var doc = new XmlDocument();
            int count = (fmSettings.VKQueryLimit == "Максимум") ? 200 : (fmSettings.VKQueryLimit == "Половина") ? 100 : (fmSettings.VKQueryLimit == "Минимум") ? 50 : 50;
            offset = 0; //Смещение
            if (VK.error == "" && fmSettings.deleteOld) deleteOldFiles("ban"); //Удаляем старые файлы
            while (true)
            {
                fname = fmSettings.DirectoryTemp + @"\" + @"ban-" + fmSettings.VkIDGroup + @"_" + offset.ToString() + @".xml";
                getxml("groups.getBanned", "group_id=" + fmSettings.VkIDGroup + "&offset=" + offset.ToString() + "&count=" + count.ToString() + "&fields=sex,bdate,city,country,photo_50,photo_100,photo_200_orig,photo_200,photo_400_orig,photo_max,photo_max_orig,online,online_mobile,lists,domain,has_mobile,contacts,connections,site,education,universities,schools,can_post,can_see_all_posts,can_see_audio,can_write_private_message,status,last_seen,common_count,relation,relatives,counters");
                if (VK.error == "")
                {
                    try
                    {
                        doc.Load(fname);
                        if (doc.DocumentElement.ChildNodes.Count < count + 1)
                        {
                            break;
                        }
                        else
                        {
                            offset = offset + count;
                            fmWaiting.count_current = offset;
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

        /* Удаление файлов с прежними данными */
        public static void deleteOldFiles(string name)
        {
            FileInfo[] path = new DirectoryInfo(fmSettings.DirectoryTemp).GetFiles(name + @"-" + fmSettings.VkIDGroup + "_*.xml", SearchOption.AllDirectories);
            foreach (FileInfo f in path)
            {
                try
                {
                    f.Delete();
                }
                catch (Exception del_e)
                {
                    VK.error = del_e.Message;
                    return;
                }
            }
        }

        /* Логирование */
        private static void log(string message, EventLogEntryType level, int code)
        {
            string sSource = "VKMan";
            if (!EventLog.SourceExists(sSource)) EventLog.CreateEventSource(sSource, "Application");
            EventLog.WriteEntry(sSource, message, level, code);
        }

        /* Проверка не остановил ли пользователь получение данных */
        private static void checkStopped()
        {
            if (fmWaiting.stop)
            {
                fmWaiting.stop = false;
                try
                {
                    VK.error = "Операция прервана пользователем";
                    Thread.CurrentThread.Abort();
                }
                catch (Exception e) { }
                return;
            }
        }
    }
}
