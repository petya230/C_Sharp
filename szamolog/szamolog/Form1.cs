using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szamolog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nullaBTN_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void egyBTN_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void kettoBTN_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void haromBTN_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void negyBTN_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void otBTN_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void hatBTN_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void hetBTN_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void nyolcBTN_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void kilencBTN_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void perBTN_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void pluszBTN_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void minuszBTN_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string szam = textBox1.Text; //"52*61/-8+";
            string[] szamok = new string[szam.Length];
            for (int i = 0; i < szam.Length; i++)
            {
                szamok[i] = szam[i].ToString();
            }
            double elso, masodik;
            Stack<double> verem = new Stack<double>();
            for (int i = 0; i < szamok.Length; i++)
            {
                if (!double.TryParse(szamok[i], out double eredmeny))
                {
                    switch (szamok[i])
                    {
                        case "+":
                            masodik = verem.Pop();
                            elso = verem.Pop();
                            verem.Push(elso + masodik);
                            break;
                        case "-":
                            masodik = verem.Pop();
                            elso = verem.Pop();
                            verem.Push(elso - masodik);
                            break;
                        case "/":
                            masodik = verem.Pop();
                            elso = verem.Pop();
                            verem.Push(elso / masodik);
                            break;
                        case "*":
                            masodik = verem.Pop();
                            elso = verem.Pop();
                            verem.Push(elso * masodik);
                            break;
                    }
                }
                else
                {
                    verem.Push(double.Parse(szamok[i]));
                }
            }
            textBox1.Text = verem.Pop().ToString();
        }
    }
}
