using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaleriAdminEkranı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            cmbAraclar.Items.Add(txtAraclar.Text);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            string fiyatAraligi = lblFiyatAralıgı.Text;
            string aracMarkaAdi = cmbAraclar.SelectedItem.ToString();
            string txtArac = txtAraclar.Text;
            string mercedesFiyat = "175.000 - 350.000";
            string audiFiyat = "150.000 - 300.000";


            if (aracMarkaAdi == "Audi" && cbBeyaz.Checked)
            {
                fiyatAraligi = audiFiyat;
                lblFiyatAralıgı.Text = fiyatAraligi;
                lbAraclar.Items.Add(aracMarkaAdi + " - " + cbBeyaz.Text.ToString() + " - " + fiyatAraligi);
            }
            else if (aracMarkaAdi == "Audi" && cbKirmizi.Checked)
            {
                fiyatAraligi = audiFiyat;
                lblFiyatAralıgı.Text = fiyatAraligi;
                lbAraclar.Items.Add(aracMarkaAdi + " - " + cbKirmizi.Text.ToString() + " - " + fiyatAraligi);
            }
            else if (aracMarkaAdi == "Audi" && cbSiyah.Checked)
            {
                fiyatAraligi = audiFiyat;
                lblFiyatAralıgı.Text = fiyatAraligi;
                lbAraclar.Items.Add(aracMarkaAdi + " - " + cbSiyah.Text.ToString() + " - " + fiyatAraligi);
            }
            else if (aracMarkaAdi == "Mercedes" && cbKirmizi.Checked)
            {
                fiyatAraligi = mercedesFiyat;
                lblFiyatAralıgı.Text = fiyatAraligi;
                lbAraclar.Items.Add(aracMarkaAdi + " - " + cbKirmizi.Text.ToString() + " - " + fiyatAraligi);
            }
            else if (aracMarkaAdi == "Mercedes" && cbSiyah.Checked)
            {
                fiyatAraligi = mercedesFiyat;
                lblFiyatAralıgı.Text = fiyatAraligi;
                lbAraclar.Items.Add(aracMarkaAdi + " - " + cbSiyah.Text.ToString() + " - " + fiyatAraligi);
               
            }

            else if (aracMarkaAdi == "Mercedes" && cbBeyaz.Checked)
            {
                fiyatAraligi = mercedesFiyat;
                lblFiyatAralıgı.Text = fiyatAraligi;
                lbAraclar.Items.Add(aracMarkaAdi + " - " + cbBeyaz.Text.ToString() + " - " + fiyatAraligi);
            }

           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int index = lbAraclar.SelectedIndex;
            lbAraclar.Items.RemoveAt(index);
        }

     

        
    }
}
