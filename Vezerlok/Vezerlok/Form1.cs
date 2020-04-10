using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vezerlok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] szamok = new int[] { 21, 33, 49, 57, 83 };
            int.TryParse(textBox1.Text, out int tipp);
            string valasz = "Nem talált, tippelj megint!";
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] == tipp)
                {
                    valasz = "Nyertél!";
                    break;
                }
            }
            MessageBox.Show(valasz);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!label1.Visible)
            {
                label1.Visible = true;
                button1.Text = "Elrejt";
            }
            else
            {
                label1.Visible = false;
                button1.Text = "Mutat";
            }
        }
    }
}
