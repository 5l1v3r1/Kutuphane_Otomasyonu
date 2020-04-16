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
            string yolBegeler = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (!Directory.Exists(yolBegeler + "\\kutuphaneOtomasyonu\\"))
            {
                Directory.CreateDirectory(yolBegeler + "\\kutuphaneOtomasyonu\\");
            }

            Directory.CreateDirectory(yolBegeler + "\\kutuphaneOtomasyonu\\" + kitapadi +"");      
        }

        public void kitap_icerigi(string kitapadi, string kitap_yazari, string kitap_basimyili
           , string kitap_sayfasayisi)
        {
            string yolBegeler = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            FileStream fs = File.Create(yolBegeler + "\\kutuphaneOtomasyonu\\" + kitapadi +""+ "\\kitapbilgileri.txt");
            fs.Close();

            StreamWriter writer = File.AppendText(yolBegeler + "\\kutuphaneOtomasyonu\\" + kitapadi + "" + "\\kitapbilgileri.txt");
            writer.WriteLine("Sayfa Sayısı:" + kitap_sayfasayisi);
            writer.WriteLine("Kitap Yazarı:" + kitap_yazari);
            writer.WriteLine("Kitap basım yılı:" + kitap_basimyili);
            writer.Close();

            datalayer data = new datalayer();
            //Aşağıdaki fonksiyon yanlış olduğu için açıklama satırına alındı
            //data.Kitap_dizi(kitapadi, kitap_yazari, kitap_basimyili, kitap_sayfasayisi);
            
        }
        public void kitap_icerigi_goruntuleme(string kitapadi)
        {
            string yolBegeler = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            StreamReader reader = new StreamReader(File.OpenRead(yolBegeler + "\\kutuphaneOtomasyonu\\" + kitapadi + "" + "\\kitapbilgileri.txt"), Encoding.UTF8);
            string degerler = reader.ReadToEnd();
            reader.Close();          
        }

    }
}
