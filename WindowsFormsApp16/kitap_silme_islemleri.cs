using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace WindowsFormsApp16
{
    struct kitap_silme_islemleri
    {
        public string kitap_sil(string kitapadi)
        {
            Directory.Delete(@"\\Users\\Hp\\source\\repos\\kutuphane_otomasyonu\\Kitaplar\\" + kitapadi+"");
            return kitapadi+ "silindi";
        }
    }
}
