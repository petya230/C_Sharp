using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listak
{
    public partial class Form1 : Form
    {
        string szoveg;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBeolvas_Click(object sender, EventArgs e)
        {
            DLGopen.Filter = "szöveges fájl|*.txt|minden fájl|*.*";
            if(DLGopen.ShowDialog() == DialogResult.OK)
            {
                string[] fileNev = File.ReadAllLines(DLGopen.FileName, Encoding.Default);
                for (int i = 0; i < fileNev.Length; i++)
                {
                    comboBox1.Items.Add(fileNev[i]);
                }
                richTextBox1.LoadFile(DLGopen.FileName, RichTextBoxStreamType.PlainText);
            }
        }
    }
}
