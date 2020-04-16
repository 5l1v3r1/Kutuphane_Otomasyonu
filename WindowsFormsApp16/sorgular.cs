using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace WindowsFormsApp16
{
    class sorgular
    {
        public void teslim_klasorolustur()
        {
            Directory.CreateDirectory(@"C:\Alınan Kitaplar");
        }
        public void kitap_alımı(string kisi_ad)
        {
            Directory.CreateDirectory(@"C:\Alınan Kitaplar\" + kisi_ad);
        }
        public void bilgi_girisi(string kitapadi)
        {
            Directory.CreateDirectory(@"C:\Alınan Kitaplar\" + kitapadi + "\\Alınan kitap.txt");

        }
    }
}
