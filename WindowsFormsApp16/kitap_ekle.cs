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
            String kad = Convert.ToString(txt_kitapad);
            String k_sayfa= Convert.ToString(txt_kitapsayfasi);
            String k_basımy= Convert.ToString(txt_basimyili);
            String k_yazar = Convert.ToString(txt_kitapyazari);

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
