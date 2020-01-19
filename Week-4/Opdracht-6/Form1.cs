using System;
using System.Windows.Forms;

namespace Opdracht_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float bedrag = float.Parse(textBox1.Text);

            for (int i = 0; i < 5; i ++)
            {
                bedrag = bedrag * (float)1.05;
            }

            label3.Text = "€ " + Math.Round(bedrag, 2).ToString();
        }
    }
}
