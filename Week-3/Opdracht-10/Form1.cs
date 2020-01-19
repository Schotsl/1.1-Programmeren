using System;
using System.Windows.Forms;

namespace Opdracht_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int salary = int.Parse(textBox1.Text);

            double raise = salary * 0.05;

            if (raise < 75)
            {
                raise = 75;
            }

            label3.Text = String.Format($"€ {raise}");
            label5.Text = String.Format($"€ {raise + salary}");
        }
    }
}
