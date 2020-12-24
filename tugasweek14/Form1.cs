using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugasweek14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void masukkanhuruf_Click(object sender, EventArgs e)
        {
            
            
        }

        private void textboxkalimat_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textboxhuruf_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textboxmenjadi_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void tombolkonversi_Click(object sender, EventArgs e)
        {
            
            string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] hrf = alfabet.ToCharArray();
            textboxkalimat.CharacterCasing = CharacterCasing.Upper;
                    
            char huruf1 = Convert.ToChar(textboxhuruf.Text);
            char huruf2 = Convert.ToChar(textboxmenjadi.Text);
            int selisih = huruf2 - huruf1;

            char[] inputkalimat = textboxkalimat.Text.ToCharArray();
            char[] inputhuruf = textboxhuruf.Text.ToCharArray();
            char[] inputmenjadi = textboxmenjadi.Text.ToCharArray();

            string inidia = "";

            if (selisih<0)
            {
                selisih = selisih + 26;
            }
            for (int i=0;i<textboxkalimat.Text.Length;i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (inputkalimat[i] == hrf[j])
                    {
                        int aa = selisih + j;
                        if (aa >= 26)
                        {
                            aa = aa - 26;
                        }
                        inputkalimat[i] = hrf[aa];
                        inidia = inidia + inputkalimat[i];
                        inputkalimat[i] = 'c';
                    }
                    else if (inputkalimat[i] == ' ')
                    {
                        inidia = inidia + " ";
                        inputkalimat[i] = ' ';
                        inputkalimat[i] = 'c';
                    }              
                }
            }
            hasilbeneran.Text = inidia;
        }

        private void hasilbeneran_Click(object sender, EventArgs e)
        {

            
        }
    }
}
