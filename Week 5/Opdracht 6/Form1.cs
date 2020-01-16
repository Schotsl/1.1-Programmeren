using System;
using System.Windows.Forms;

namespace Opdracht_6
{
    public partial class Form1 : Form
    {
        int[] vooraf = new int[20];
        int[] achteraf = new int[20];

        public Form1()
        {
            InitializeComponent();
            Random random = new Random();

            for (int i = 0; i < vooraf.Length; i++)
            {
                vooraf[i] = random.Next(500);
                Control currentLabel = Controls["label" + (i + 1)];
                currentLabel.Text = String.Format("Element {0} = {1}", i.ToString().PadLeft(2, '0'), vooraf[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i ++)
            {
                int vergelijking = int.Parse(textBox1.Text);

                if (vooraf[i] >= vergelijking)
                {
                    achteraf[i] = vooraf[i] + 10;
                }
                else
                {
                    achteraf[i] = vooraf[i] - 5;
                }

                Control currentLabel = Controls["label" + (i + 21)];
                currentLabel.Text = String.Format("Element {0} = {1}", i.ToString().PadLeft(2, '0'), achteraf[i]);
            }

            button1.Enabled = false;
        }
    }
}
