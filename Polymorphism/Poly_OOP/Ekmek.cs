using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poly_OOP
{
    public class Ekmek : Urun
    {
        public string  EkmekTuru{ get; set; }
        public int Gramaj { get; set; }

        public override double Tax()
        {
            return Price * 1.01;
        }
        public Ekmek(string ad,double fiyat,string ekmekTuru, int gramaj)
        {
            ProductName = ad;
            Gramaj = gramaj;
            EkmekTuru = ekmekTuru;
            Price = fiyat;
        }

    }
}
