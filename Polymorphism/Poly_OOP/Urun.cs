using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poly_OOP
{
    public class Urun
    {

        public string ProductName { get; set; }
        public double Price { get; set; }

        public virtual double Tax()
        {
            return Price * 1.08;

        }

        public Urun()
        {

        }

        public Urun(string ad , double fiyat)
        {
            ProductName = ad;
            Price = fiyat;

        }
    }
}
