using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Csatlakozáshoz szükséges kiegészítők meghívása
using System.IO;
using System.Net;
using System.Text;
using System.Net.Sockets;

namespace SocketClientGUI
{
    public partial class Form1 : Form
    {
        TcpClient tcpclnt = null;
        ASCIIEncoding asciikodolas = new ASCIIEncoding();
        StreamWriter stm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Csatlakozas_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (tcpclnt == null)
                {
                    tcpclnt = new TcpClient();
                    tcpclnt.Connect(IpBE_textBox.Text, int.Parse(PortBE_textBox.Text));
                    stm = new StreamWriter(tcpclnt.GetStream());
                    csatlakozva_label.Text = "Csatlakozva";
                }
            }
            catch (Exception kiv)
            {
                MessageBox.Show(kiv.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PortBE_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PortBE_textBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Lecsatlakozas_btn_Click(object sender, EventArgs e)
        {
            try
            {

                if (tcpclnt != null)
                {
                    tcpclnt.Close();
                    tcpclnt = null;
                }

            }
            catch (Exception kiv)
            {
                MessageBox.Show(kiv.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kuld_btn_Click(object sender, EventArgs e)
        {
            byte[] adat_kuldes = asciikodolas.GetBytes(SajatSzoveg_textBox.Text);
            try
            {
                //stm.Write(adat_kuldes, 0, adat_kuldes.Length);
                stm.Write(SajatSzoveg_textBox.Text); //saját szöveg elküldése a kliens-nek
                stm.Flush();
               // tcpclnt.Close();
                //Csatlakozas_btn_Click(sender, e);
            }
            catch (Exception kiv)
            {
                MessageBox.Show(kiv.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kilep_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztos ki akarsz lépni?", "Kilép", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Lecsatlakozas_btn_Click(sender, e);
                Application.Exit();
            }
        }
    }
}
