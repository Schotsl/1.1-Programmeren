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
            string square = "";

            int size = int.Parse(textBox1.Text);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j == 0 || j == size - 1 || i == 0 || i == size - 1)
                    {
                        square += "X";
                    }
                    else
                    {
                        square += " ";
                    }
                }

                square += "\n";
            }

            label2.Text = square;
        }
    }
}
