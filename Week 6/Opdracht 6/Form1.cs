using System;
using System.Windows.Forms;

namespace Opdracht_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int getal = int.Parse(textBox1.Text);
            KwadraatByReference(ref getal);

            label3.Text = getal.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int getal = int.Parse(textBox1.Text);
            KwadraatByReferenceOut(getal, out int kwadraat);

            label3.Text = kwadraat.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int getal = int.Parse(textBox1.Text);
            getal = KwadraatByValue(getal);

            label3.Text = getal.ToString();
        }

        static void KwadraatByReference(ref int getal)
        {
            getal *= getal;
        }

        static void KwadraatByReferenceOut(int getal, out int kwadraat)
        {
            kwadraat = getal * getal;
        }

        static int KwadraatByValue(int getal)
        {
            return (getal * getal);
        }
    }
}
