using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poly_OOP
{
    public class Tekstil  :Urun
    {
        public string KumasTuru { get; set; }
        public int Beden { get; set; }
        public string UreticiFirma { get; set; }
        public Tekstil(string ad, double fiyat,string kumasTuru,int beden)
        {
            ProductName = ad;
            Price = fiyat;
            KumasTuru = kumasTuru;
            Beden = beden;

        }
    }
}
