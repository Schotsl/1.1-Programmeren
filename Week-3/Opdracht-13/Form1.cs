using System;
using System.Windows.Forms;

namespace Opdracht_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dayCount = int.Parse(textBox1.Text);
            int dayMiles = dayCount * 100;

            double dayPrice = dayCount * 55;

            int gasCount = int.Parse(textBox2.Text);
            double gasPrice = 0;

            if (gasCount > dayMiles)
            {
                gasPrice = 0.25 * (gasCount - dayMiles); 
            }

            int extraCount = int.Parse(textBox3.Text);
            double extraPrice = 0;

            if (checkBox1.Checked)
            {
                extraPrice = extraCount * 2.20;
            }

            label5.Text = String.Format($"€ {dayPrice + gasPrice + extraPrice}");
        }
    }
}
