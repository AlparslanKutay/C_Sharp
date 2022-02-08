using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string arac_ismi;

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Mercedes");
            comboBox1.Items.Add("BMW");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            arac_ismi = textBox1.Text;

            comboBox1.Items.Add(arac_ismi);




        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                listBox1.Items.Add("Seçilen araba:" + arac_ismi + "Motor Hacmi" + checkBox1.Text);
            }
            else if (checkBox2.Checked)
            {
                listBox1.Items.Add("Seçilen araba:" + arac_ismi + "Motor Hacmi" + checkBox2.Text);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
