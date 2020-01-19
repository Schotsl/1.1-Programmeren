using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            label5.Text = "0.00";
            label7.Text = "0.00";
            label9.Text = "0.00";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double priceKM = double.Parse(textBox3.Text);

            int startKM = int.Parse(textBox1.Text);
            int endKM = int.Parse(textBox2.Text);

            int remainingKM = endKM - startKM;
            
            double price = remainingKM * priceKM;

            double btw = price * 0.21;
            double total = btw + price;

            label5.Text = price.ToString();
            label7.Text = btw.ToString();
            label9.Text = total.ToString();
        }
    }
}
