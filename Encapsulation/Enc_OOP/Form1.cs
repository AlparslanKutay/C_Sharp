using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enc_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Emlak emlak = new Emlak();
            emlak.Alan = int.Parse(txtAlan.Text);
            emlak.Semt = txtSemt.Text;
            emlak.Oda_Sayısı = int.Parse(txtOdaSay.Text);
            emlak.KatNo = int.Parse(txtKatNo.Text);

            ListViewItem kayit = new ListViewItem();
            kayit.Text = emlak.Semt;
            kayit.SubItems.Add(emlak.Oda_Sayısı.ToString());
            kayit.SubItems.Add(emlak.KatNo.ToString());
            kayit.SubItems.Add(emlak.Alan.ToString());

            listView1.Items.Add(kayit);

        }
    }
}
