using System;
using System.Windows.Forms;

namespace Opdracht_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int som = 0;
            int formule = 0;

            int n = int.Parse(textBox1.Text);

            for (int i = 1; i <= n; i++)
            {
                som += i;
            }

            formule = n * (n + 1) / 2;

            label5.Text = som.ToString();
            label6.Text = formule.ToString();

            if (som == formule)
            {
                label4.Text = "De som en formule zijn gelijk";
            }
            else
            {
                label4.Text = "De som en formule zijn niet gelijk";
            }
        }
    }
}
