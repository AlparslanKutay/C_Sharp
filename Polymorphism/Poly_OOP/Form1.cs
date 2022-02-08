using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poly_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            Sepet sepet = new Sepet();
            Ekmek ekm = new Ekmek("Uno",1,"Dümen",250);
            CepTelefonu telefon = new CepTelefonu("S20", 1, "Samsung");

            sepet.UrunEkle(ekm);

            MessageBox.Show(sepet.toplamTutar().ToString());

        }
    }
}
