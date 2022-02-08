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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSayiUret_Click(object sender, EventArgs e)
        {
            SayiUretme sayiUretme = new SayiUretme();
            sayiUretme.Show();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            NotHesaplama notHesaplama = new NotHesaplama();
            notHesaplama.Show();
        }
    }
}
