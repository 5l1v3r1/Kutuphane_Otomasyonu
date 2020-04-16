using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class kitap_silme : Form
    {
        public kitap_silme()
        {
            InitializeComponent();
        }

        private void btn_kitap_sil_Click(object sender, EventArgs e)
        {
            kitap_silme_islemleri sil = new kitap_silme_islemleri();
            string k_ad = Convert.ToString(txt_kitap_sil);
            sil.kitap_sil(k_ad);
        }
    }
}
