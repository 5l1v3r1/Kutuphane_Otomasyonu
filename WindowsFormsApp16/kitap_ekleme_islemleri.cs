using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using kitaplar_datalyr;

namespace WindowsFormsApp16
{
    struct kitap_ekleme_islemleri
    {


        public void kitap_ekle(string kitapadi)
        {
            Directory.CreateDirectory(@"C:\\Users\\Hp\\source\\repos\\kutuphane_otomasyonu\\Kitaplar\\" + kitapadi +"");      
        }

        public void kitap_icerigi(string kitapadi, string kitap_yazari, string kitap_basimyili
           , string kitap_sayfasayisi)
        {
            FileStream fs = File.Create(@"C:\\Users\\Hp\\source\\repos\\kutuphane_otomasyonu\\Kitaplar\\" + kitapadi +""+ "\\kitapbilgileri.txt");
            StreamWriter writer = File.AppendText(@"C:\\Users\\Hp\\source\\repos\\kutuphane_otomasyonu\\Kitaplar\\" + kitapadi + "" + "\\kitapbilgileri.txt");
            writer.WriteLine("Sayfa Sayısı:" + kitap_sayfasayisi);
            writer.WriteLine("Kitap Yazarı:" + kitap_yazari);
            writer.WriteLine("Kitap basım yılı:" + kitap_basimyili);
            writer.Close();

            datalayer data = new datalayer();
            data.Kitap_dizi(kitapadi, kitap_yazari, kitap_basimyili, kitap_sayfasayisi);
            
        }
        public void kitap_icerigi_goruntuleme(string kitapadi)
        {
            StreamReader reader = new StreamReader(File.OpenRead(@"C:\\Users\\Hp\\source\\repos\\kutuphane_otomasyonu\\Kitaplar\\" + kitapadi +""+"\\kitapbilgileri.txt"), Encoding.UTF8);
            string degerler = reader.ReadToEnd();
            reader.Close();          
        }

    }
}
