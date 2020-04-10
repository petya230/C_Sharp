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

namespace Dolgozok
{
    public partial class Form1 : Form
    {
        static List<Emberek> emberek = new List<Emberek>();

        struct Emberek
        {
            public string nev;
            public int kor;
            public string nem;
            public int munkaEvek;
        }

        public void betolt()
        {
            string[] tmp;
            string[] adat = File.ReadAllLines(@"adat.csv");
            for (int i = 1; i < adat.Length; i++)
            {
                tmp = adat[i].Split(';');
                Emberek ember = new Emberek();
                ember.nev = tmp[0];
                ember.kor = int.Parse(tmp[1]);
                ember.nem = tmp[2];
                if(tmp.Length > 3)
                {
                    ember.munkaEvek = int.Parse(tmp[3]);
                }
                else
                {
                    ember.munkaEvek = 0;
                }
                emberek.Add(ember);
            }
            foreach (var ember in emberek)
            {
                if(ember.nem == "F")
                {
                    FiukCombo.Items.Add(ember.nev);
                }
                else
                {
                    LanyokCombo.Items.Add(ember.nev);
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            betolt();
            
        }

        private void legidosebbLBL_Click(object sender, EventArgs e)
        {

        }

        private void LanyokCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var ember in emberek)
            {
                if (LanyokCombo.Text == ember.nev)
                {
                    KorLBL.Text = "Kor: " + ember.kor;
                    miotaLBL.Text = "Mióta dolgozik: " + ember.munkaEvek;
                }
            }
        }

        private void FiukCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var ember in emberek)
            {
                if (FiukCombo.Text == ember.nev)
                {
                    KorLBL.Text = "Kor: " + ember.kor;
                    miotaLBL.Text = "Mióta dolgozik: " + ember.munkaEvek;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int max = int.MinValue;
            int osszes = 0;
            string nev = "";
            foreach (var ember in emberek)
            {
                if (ember.nem == "L")
                {
                    if (ember.kor > max)
                    {
                        max = ember.kor;
                    }
                    osszes += ember.kor;
                    if (ember.munkaEvek > 5)
                    {
                        nev = ember.nev;
                    }
                }
            }
            if (nev == "")
            {
                nev = "nincs";
            }
            legidosebbLBL.Text = "Legidősebb: " + max;
            OsszesKorLBL.Text = "Összes kor: " + osszes + " év";
            HatEveLBL.Text = "6 éve dolgozó: " + nev;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int max = int.MinValue;
            int osszes = 0;
            string nev = "";
            foreach (var ember in emberek)
            {
                if (ember.nem == "F")
                {
                    if (ember.kor > max)
                    {
                        max = ember.kor;
                    }
                    osszes += ember.kor;
                    if (ember.munkaEvek > 5)
                    {
                        nev = ember.nev;
                    }
                }
            }
            if (nev == "")
            {
                nev = "nincs";
            }
            legidosebbLBL.Text = "Legidősebb: " + max;
            OsszesKorLBL.Text = "Összes kor: " + osszes + " év";
            HatEveLBL.Text = "6 éve dolgozó: " + nev;
        }

        private void Mindekettonem_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void MentesBTN_Click(object sender, EventArgs e)
        {
            string mentes = "";
            int max = int.MinValue;
            int osszes = 0;
            string nev = "";
            if (radioButton1.Checked)
            {
                foreach (var ember in emberek)
                {

                    if (ember.nem == "L")
                    {
                        if (ember.kor > max)
                        {
                            max = ember.kor;
                        }
                        osszes += ember.kor;
                        if (ember.munkaEvek > 5)
                        {
                            nev = ember.nev;
                        }
                    }
                }
                mentes = "Lányok: \r\n";
            }
            if (radioButton2.Checked)
            {
                foreach (var ember in emberek)
                {
                    if (ember.nem == "F")
                    {
                        if (ember.kor > max)
                        {
                            max = ember.kor;
                        }
                        osszes += ember.kor;
                        if (ember.munkaEvek > 5)
                        {
                            nev = ember.nev;
                        }
                    }
                }
                mentes = "Fiúk: \r\n";
            }
            
            mentes += "Legidősebb: " + max + "\r\n";
            mentes += "Összes kor: " + osszes + " év" + "\r\n";
            mentes += "6 éve dolgozó: " + nev + "\r\n";

            if (Mindekettonem.Checked)
            {
                foreach (var ember in emberek)
                {
                    if (radioButton1.Checked)
                    {
                        if (ember.nem == "L")
                        {
                            if (ember.kor > max)
                            {
                                max = ember.kor;
                            }
                            osszes += ember.kor;
                            if (ember.munkaEvek > 5)
                            {
                                nev = ember.nev;
                            }
                        }
                    }
                    if (nev == "")
                    {
                        nev = "nincs";
                    }
                }
                mentes = "Lányok: \r\n";
                mentes += "Legidősebb: " + max + "\r\n";
                mentes += "Összes kor: " + osszes + " év" + "\r\n";
                mentes += "6 éve dolgozó: " + nev + "\r\n";

                foreach (var ember in emberek)
                {

                    if (radioButton2.Checked)
                    {
                        if (ember.nem == "F")
                        {
                            if (ember.kor > max)
                            {
                                max = ember.kor;
                            }
                            osszes += ember.kor;
                            if (ember.munkaEvek > 5)
                            {
                                nev = ember.nev;
                            }
                        }
                    }
                    if (nev == "")
            {
                nev = "nincs";
            }
                }
                mentes += "\r\n";
                mentes += "Fiúk: \r\n";
                mentes += "Legidősebb: " + max + "\r\n";
                mentes += "Összes kor: " + osszes + " év" + "\r\n";
                mentes += "6 éve dolgozó: " + nev + "\r\n";
                
            }
            File.WriteAllText(@"dolgozok.txt",mentes);
        }
    }
}
