using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiUretmeVeNotHesaplama
{
    public partial class NotHesaplama : Form
    {
        public NotHesaplama()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int vize = 0;
            int final = 0;
            string adSoyad = txtAdSoyad.Text;

            try
            {
                vize = int.Parse(txtVize.Text);
                final = int.Parse(txtFinal.Text);
                if (vize < 0 || vize > 100 || final <0 || final >100)
                {
                    MessageBox.Show("Hatalı notlar girdiniz !!");
                }
                else
                {
                    double ortalama = (vize * 0.4) + (final * 0.6);
                    if (ortalama >= 60 && ortalama <= 100 && final >=50)
                    {
                        lbGecenler.Items.Add(adSoyad + " = " + ortalama.ToString());
                    }
                    else
                    {
                        lbKalanlar.Items.Add(adSoyad + " = " + ortalama.ToString());
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Sayılar Hatalı!!");
            }
        }
    }
}
