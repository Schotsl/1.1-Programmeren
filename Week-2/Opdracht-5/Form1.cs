using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            int numberOne = int.Parse(textBox1.Text);
            int numberTwo = int.Parse(textBox2.Text);
            int numberThree = int.Parse(textBox3.Text);

            double numberAverage = (numberOne + numberTwo + numberThree) / (double)3;
            label5.Text = numberAverage.ToString();
        }
    }
}
