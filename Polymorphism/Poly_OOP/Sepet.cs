using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poly_OOP
{
    public class Sepet
    {
        private List<Urun> urunler = new List<Urun>();

        public double toplamTutar()
        {
            double toplamFiyat = 0;
            foreach (Urun item in urunler)
            {
                toplamFiyat += item.Tax();
            }
            return toplamFiyat;

        }

        public void UrunEkle(Urun yeniUrun)
        {
            urunler.Add(yeniUrun);
        }
    }
}
