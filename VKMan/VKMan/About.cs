using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace VKMan
{
    public partial class fmAbout : Form
    {
        public fmAbout()
        {
            InitializeComponent();
            lblProductName.Text = "Название: " + Application.ProductName;
            lblProductVersion.Text = "Версия: " + Application.ProductVersion;
            FileVersionInfo my = FileVersionInfo.GetVersionInfo(Application.ExecutablePath);
            lblAuthor.Text = my.LegalCopyright;
            lblBrand.Text = my.LegalTrademarks;
        }
    }
}
