using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label7.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int shirtPrice = int.Parse(textBox1.Text) * 30;
            int pantPrice = int.Parse(textBox2.Text) * 100;

            int price = shirtPrice + pantPrice;

            double btw = price * 0.21;
            double total = price + btw;

            label8.Text = String.Format("€ {0}", price.ToString());
            label9.Text = String.Format("€ {0}", btw.ToString());
            label10.Text = String.Format("€ {0}", total.ToString());
        }
    }
}
