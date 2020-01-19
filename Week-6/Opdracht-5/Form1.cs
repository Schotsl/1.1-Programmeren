using System;
using System.Windows.Forms;

namespace Opdracht_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double firstNumber = double.Parse(textBox1.Text);
            double secondNumber = double.Parse(textBox2.Text);

            double solution = firstNumber + secondNumber;
            label4.Text = solution.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double firstNumber = double.Parse(textBox1.Text);
            double secondNumber = double.Parse(textBox2.Text);

            double solution = firstNumber - secondNumber;
            label4.Text = solution.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double firstNumber = double.Parse(textBox1.Text);
            double secondNumber = double.Parse(textBox2.Text);

            double solution = firstNumber * secondNumber;
            label4.Text = solution.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double firstNumber = double.Parse(textBox1.Text);
            double secondNumber = double.Parse(textBox2.Text);

            double solution = firstNumber / secondNumber;
            label4.Text = solution.ToString();
        }
    }
}
