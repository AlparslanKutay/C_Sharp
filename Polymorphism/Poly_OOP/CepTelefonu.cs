using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poly_OOP
{
     public class CepTelefonu : Urun
    {
        public string Ozellikler { get; set; }
        public string Marka { get; set; }

        public CepTelefonu(string ad, double fiyat,string marka)
        {
            ProductName = ad;
            Price = fiyat;
            Marka = marka;

        }
    }
}
