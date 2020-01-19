using System;
using System.Windows.Forms;

namespace Opdracht_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contribution = 0;
            int discount = 0;

            if (radioButton1.Checked)
            {
                contribution = 175;
            }
            else
            {
                contribution = 225;
            }

            if (int.Parse(textBox1.Text) > 40)
            {
                discount += 25;
            }

            if (int.Parse(textBox2.Text) > 10)
            {
                discount += 20;
            }

            double price = contribution - discount;

            label5.Text = String.Format($"€ {price}");
        }
    }
}
