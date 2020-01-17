using System;
using System.Windows.Forms;

namespace Opdracht_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numberOne = int.Parse(textBox1.Text);
            int numberTwo = int.Parse(textBox2.Text);

            if (numberOne > numberTwo)
            {
                label8.Text = numberOne.ToString();
            }
            else
            {
                label8.Text = numberTwo.ToString();
            }

            double average = (numberOne + numberTwo) / (double)2;
            label7.Text = average.ToString();

            label6.Text = Math.Abs(numberOne - numberTwo).ToString();
        }
    }
}
