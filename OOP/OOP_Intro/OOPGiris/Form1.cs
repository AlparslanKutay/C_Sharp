using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Otomobil otomobil = new Otomobil();
            otomobil.Marka = "Mersoo";
            otomobil.Seri = "C200d";
            otomobil.Renk = "Siyah";
            otomobil.ModelYılı = 2021;
            otomobil.VitesTipi = "Otomatik";

            lbMarka.Text = otomobil.Marka;
            lbSeri.Text = otomobil.Seri;
            lbModel.Text = otomobil.ModelYılı.ToString();
            lbRenk.Text = otomobil.Renk;
            lbVites.Text = otomobil.VitesTipi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Otomobil oto = new Otomobil();
            oto.Marka = textBox1.Text;
            oto.Seri = textBox2.Text;
            oto.ModelYılı = int.Parse(textBox3.Text);
            oto.Renk = (textBox4.Text);
            oto.VitesTipi = textBox5.Text;

            MessageBox.Show(oto.Marka + "  " + oto.Seri + "  " + oto.Renk + "  " + oto.ModelYılı+ "  " + oto.VitesTipi);

        }
    }
}
