using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApp16
{
    public partial class kitap_ekle : Form
    {
        public kitap_ekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kitap_ekle ekle = new kitap_ekle();
            this.Hide();
            ekle.Show();

            kitap_ekleme_islemleri ktp;
            string kad = txt_kitapad.Text;
            string k_sayfa= txt_kitapsayfasi.Text;
            string k_basımy= txt_basimyili.Text;
            string k_yazar = txt_kitapyazari.Text;

            ktp.kitap_ekle(kad);

            ktp.kitap_icerigi(kad, k_yazar, k_basımy, k_sayfa);
            MessageBox.Show("içerik eklendi");

        }
        private void btn_icerikgor(object sender, EventArgs e )
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }

}
