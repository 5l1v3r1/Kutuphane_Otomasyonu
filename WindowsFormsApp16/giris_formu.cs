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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_kitap_ekleme_Click(object sender, EventArgs e)
        {
            kitap_ekle ekle = new kitap_ekle();
            this.Hide();
            ekle.Show();
        }

        private void btn_kitap_sil_Click(object sender, EventArgs e)
        {
            kitap_silme silme = new kitap_silme();
            this.Hide();
            silme.Show();
        }

        private void btn_uye_kaydi_Click(object sender, EventArgs e)
        {
            Uye_Ekle uekle = new Uye_Ekle();
            this.Hide();
            uekle.Show();
        }

        private void btn_kitap_sorgusu_Click(object sender, EventArgs e)
        {
            kitap_sorgu sorgu = new kitap_sorgu();
            this.Hide();
            sorgu.Show();
        }
    }
}
