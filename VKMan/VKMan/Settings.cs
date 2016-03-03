using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace VKMan
{
    public partial class fmSettings : Form
    {
        private static RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);

        public fmSettings()
        {
            InitializeComponent();
        }

        public static void init()
        {
            reg.CreateSubKey("VKMan");
        }
    }
}
