using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const int normal = 12;

            int age = int.Parse(textBox1.Text);
            int price = 0;

            if (age > 5 && age <= 12)
            {
                price = normal / 2;
            }
            else if (age > 13 && age <= 54)
            {
                price = normal;
            }

            label3.Text = String.Format($"€ {price}");
        }
    }
}
