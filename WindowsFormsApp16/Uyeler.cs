using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace WindowsFormsApp16
{
    public class Uyeler
    {
        
        public string Adsoyad;
        public int TcKimlikNo;
        public int TelNo;
        public int kutuphaneno;
        Random rnd = new Random();

        public string adisoyadi
        {
            get { return Adsoyad; }
            set { Adsoyad = value; }
        }

        public int tckimlikno
        {
            get { return TcKimlikNo; }
            set { TcKimlikNo = value; }
        }

        public int telno
        {     
            get { return TelNo; }
            set { TelNo = value ; }
        }

        public void kayit()
        {
           // Directory.CreateDirectory(@"C:\\Users\\Hp\\source\\repos\\kutuphane_otomasyonu\\Üyeler");
            
        }
        public void uye_kayit(string adsoyad, string telno, string tckimlikno)
        {
            Random rnd = new Random();
            int uyeid = rnd.Next(1, 98000);
            Directory.CreateDirectory(@"C:\\Users\\Hp\\source\\repos\\kutuphane_otomasyonu\\Odunckitap\\" + uyeid + "" + adsoyad + "");
            StreamWriter olustur = File.AppendText(@"C:\\Users\\Hp\\source\\repos\\kutuphane_otomasyonu\\Üyeler\\" + adsoyad + ".txt");
            olustur.WriteLine("ad soyad:" + adsoyad);
            olustur.WriteLine("telno:" + telno);
            olustur.WriteLine("tck:" + tckimlikno);
            //Directory.CreateDirectory(@"C:\\Users\\Hp\\source\\repos\\kutuphane_otomasyonu\\Üyeler\\" + adsoyad + ""); 
            //FileStream fs = File.Create(@"C:\\Users\\Hp\\source\\repos\\kutuphane_otomasyonu\\Üyeler\\" + adsoyad + ""+"\\kisibilgileri.txt");
            //StreamWriter writer = new StreamWriter(fs, Encoding.UTF8);
            //writer.WriteLine("Ad soyad:" + adsoyad);
            //writer.WriteLine("Telefon Numarası:" + telno);
            //writer.WriteLine("Tc Kimlik No:" + tckimlikno);

            olustur.Close();
            
        }
        

    }
}
