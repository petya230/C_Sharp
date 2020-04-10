using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace telefonszamok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            betolt();
        }
        public void betolt()
        {
            string[] adat = File.ReadAllLines(@"telefonszamok.txt");
            foreach ( var szam in adat)
            {
                if (szam.Length == 13)
                {
                    if (szam.Contains('/'))
                    {
                        joSzamok.Items.Add(szam.Substring(3));
                    }
                    else
                        rosszSzamok.Items.Add(szam);
                }
                else
                {
                    if (szam.Contains('/') && szam.Length == 10)
                    {
                        joSzamok.Items.Add(szam);
                    }
                    else
                        rosszSzamok.Items.Add(szam);
                }
                
            }
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void egyBTN_Click(object sender, EventArgs e)
        {
            szamBOX.Text += "1";
        }

        private void kettoBTN_Click(object sender, EventArgs e)
        {
            szamBOX.Text += "2";
        }

        private void haromBTN_Click(object sender, EventArgs e)
        {
            szamBOX.Text += "3";
        }

        private void negyBTN_Click(object sender, EventArgs e)
        {
            szamBOX.Text += "4";
        }

        private void otBTN_Click(object sender, EventArgs e)
        {
            szamBOX.Text += "5";
        }

        private void hatBTN_Click(object sender, EventArgs e)
        {
            szamBOX.Text += "6";
        }

        private void hetBTN_Click(object sender, EventArgs e)
        {
            szamBOX.Text += "7";
        }

        private void nyolcBTN_Click(object sender, EventArgs e)
        {
            szamBOX.Text += "8";
        }

        private void kilencBTN_Click(object sender, EventArgs e)
        {
            szamBOX.Text += "9";
        }

        private void perBTN_Click(object sender, EventArgs e)
        {
            szamBOX.Text += "/";
        }

        private void nullaBTN_Click(object sender, EventArgs e)
        {
            szamBOX.Text += "0";
        }

        private void pluszBTN_Click(object sender, EventArgs e)
        {
            szamBOX.Text += "+";
        }

        private void torolBTN_Click(object sender, EventArgs e)
        {
            if (szamBOX.Text != "")
            {
                szamBOX.Text = szamBOX.Text.Remove(szamBOX.Text.Length - 1);
            }
        }

        private void rogzitBTN_Click(object sender, EventArgs e)
        {
            string telszam = szamBOX.Text;
            if(telszam.Length == 13)
            {
                if (telszam.IndexOf('/') == 5)
                {
                    joSzamok.Items.Add(telszam.Substring(3));
                }
                else
                {
                    rosszSzamok.Items.Add(telszam);
                }
            }
            else
            {
                if (telszam.IndexOf('/') == 3 && telszam.Length == 10 && !telszam.Contains("+36"))
                {
                    joSzamok.Items.Add(telszam);
                }
                else
                {
                    rosszSzamok.Items.Add(telszam);
                }
            }
        }
        public void ellenoriz()
        {
            string szam = szamBOX.Text;
            if (szam.Length == 13)
            {
                if (szam.IndexOf('/') == 5)
                {
                    formazBTN.Enabled = true;
                    rogzitBTN.Enabled = true;
                }
                else
                {
                    formazBTN.Enabled = false;
                    rogzitBTN.Enabled = false;
                }
            }
            else
            {
                if (szam.IndexOf('/') == 3 && szam.Length == 10 && !szam.Contains("+36"))
                {
                    formazBTN.Enabled = true;
                    rogzitBTN.Enabled = true;
                }
                else
                {
                    formazBTN.Enabled = false;
                    rogzitBTN.Enabled = false;
                }
            }
        }

        private void szamBOX_TextChanged(object sender, EventArgs e)
        {
            ellenoriz();
        }

        private void formazBTN_Click(object sender, EventArgs e)
        {
        }
    }
}
