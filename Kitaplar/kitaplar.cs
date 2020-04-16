using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplar
{
    class kitaplar
    {
      public string Kitap_dizi(string ad,string yazar,string basimy,string sayfas)
      {
            string[,] kitapdizi;
            kitapdizi= new string[5, 4]; //5 kitap üzerinden yapılmıştır.örnek açısından

            for (int i = 0;; i++)
            {  
               kitapdizi[i, 0] = ad;
               kitapdizi[i, 1] = yazar;
               kitapdizi[i, 2] = basimy;
               kitapdizi[i, 3] = sayfas;      
            }
      }  
    }
}
