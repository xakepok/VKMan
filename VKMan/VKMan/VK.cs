using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKMan
{
    class VK
    {
        public static string token = "";

        /* Запоминаем токен */
        public static void set_token(string url)
        {
            string tmp = url.Remove(0, url.IndexOf('=') + 1);
            token = tmp.Remove(85);
        }
    }
}
