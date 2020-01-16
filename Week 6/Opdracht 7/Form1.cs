using System;
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
            float graden = float.Parse(textBox1.Text);

            if (radioButton1.Checked)
            {
                graden = Celsius2Kelvin(graden);
            } 
            else if (radioButton2.Checked)
            {
                graden = Celsius2Fahrenheit(graden);
            } 
            else
            {
                graden = Fahrenheit2Celsius(graden);
            }

            label3.Text = graden.ToString();
        }

        static float Celsius2Kelvin(float graden)
        {
            graden += 273;
            return graden;
        }

        static float Celsius2Fahrenheit(float graden)
        {
            graden = (graden * 9 / 5) + 32;
            return graden;
        }

        static float Fahrenheit2Celsius(float graden)
        {
            graden = (graden - 32) * 5 / 9;
            return graden;
        }
    }
}
