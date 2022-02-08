using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enc_OOP
{
    public class Emlak
    {

        public string semt;
        public string Semt { get { return semt; } set { semt = value.ToUpper(); } }


        public int Oda_sayısı;
        public int Oda_Sayısı { get { return Oda_sayısı; } set { Oda_sayısı = Math.Abs(value); } }

        public int Katno;
        public int KatNo { get { return Katno; } set { Katno = Math.Abs(value); } }

        public int alan;
       // public string m_square = "m^2";
        public int Alan { get { return alan ; } set { alan = Math.Abs(value);  } }

       // public string Field{ get { return alan.ToString() + m_square; } set { alan= Math.Abs(value); }; }

    }
}
