using System;
using System.Windows.Forms;

namespace Opdracht_7
{
    public partial class Form1 : Form
    {
        int[] dobbelsteen = new int[6];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                dobbelsteen[i] = 0;
            }

            Random random = new Random();

            for (int i = 0; i < 6000; i++)
            {
                int index = random.Next(1, 7);
                dobbelsteen[index - 1] += 1;
            }

            label1.Text = String.Format("Waarde 1 is {0} keer gegooid.", dobbelsteen[0]);
            label2.Text = String.Format("Waarde 2 is {0} keer gegooid.", dobbelsteen[1]);
            label3.Text = String.Format("Waarde 3 is {0} keer gegooid.", dobbelsteen[2]);
            label4.Text = String.Format("Waarde 4 is {0} keer gegooid.", dobbelsteen[3]);
            label5.Text = String.Format("Waarde 5 is {0} keer gegooid.", dobbelsteen[4]);
            label6.Text = String.Format("Waarde 6 is {0} keer gegooid.", dobbelsteen[5]);
        }
    }
}
