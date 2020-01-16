using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            int seconden = int.Parse(textBox1.Text);

            int uren = seconden / 3600;
            seconden -= uren * 3600;

            int minuten = seconden / 60;
            seconden -= minuten * 60;

            label3.Text = String.Format("{0:00}:{1:00}:{2:00}", uren, minuten, seconden);
        }
    }
}
