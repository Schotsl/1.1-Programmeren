using System;
using System.Windows.Forms;

namespace Opdracht_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int weight = int.Parse(textBox2.Text);
            int length = int.Parse(textBox1.Text);
            double bmi = weight / Math.Pow((length / (double)100), 2);

            int minBmi = 20;
            int maxBmi = 25;

            double minWeight = minBmi * Math.Pow((length / (double)100), 2);
            double maxWeight = maxBmi * Math.Pow((length / (double)100), 2);

            label6.Text = bmi.ToString();
            label7.Text = String.Format($"{minBmi} t/m {maxBmi}");
            label8.Text = String.Format($"{minWeight} t/m {maxWeight}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int weight = int.Parse(textBox2.Text);
            int length = int.Parse(textBox1.Text);
            double bmi = weight / Math.Pow((length / (double)100), 2);

            int minBmi = 19;
            int maxBmi = 24;

            double minWeight = minBmi * Math.Pow((length / (double)100), 2);
            double maxWeight = maxBmi * Math.Pow((length / (double)100), 2);

            label6.Text = bmi.ToString();
            label7.Text = String.Format($"{minBmi} t/m {maxBmi}");
            label8.Text = String.Format($"{minWeight} t/m {maxWeight}");
        }
    }
}
