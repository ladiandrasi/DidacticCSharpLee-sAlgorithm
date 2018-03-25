using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmul_Lui_Lee
{
    public partial class Form4 : Form
    {
        int[,] coada = new int[4, 2000];
        int i, j = 1;
        int marime;
        int x = 1;
        public Form4(int[,] coada3,int coada3marime)
        {
            InitializeComponent();
            this.AutoScroll = true;
            this.Left = 0;
            this.Top = 0;
            System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#293955");
            this.BackColor = col;
            Array.Copy(coada3, coada, coada3.Length);
            marime = coada3marime;
        }
        public RichTextBox[,] text = new RichTextBox[3, 5000];
        public void Ftext()
        {
            if (j <= marime)
            {
                i = 1;
                while (i <= 2)
                {
                    text[i, j] = new RichTextBox();
                    text[i, j].Parent = this;
                    text[i, j].Name = "text" + i.ToString() + j.ToString();
                    text[i, j].Left = j * 40;
                    text[i, j].Top = i * 40;
                    text[i, j].Multiline = true;
                    text[i, j].Height = 40;
                    text[i, j].Width = 40;
                    text[i, j].SelectionAlignment = HorizontalAlignment.Center;
                    text[i, j].Visible = true;
                    text[i, j].ReadOnly = true;
                    text[i, j].Font = new Font("Times New Roman", 15);
                    text[i, j].Font = new Font(text[i, j].Font, FontStyle.Bold);
                    text[i, j].BackColor = Color.Yellow;
                    if (i == 1)
                        text[i, j].Text = coada[1, j].ToString();
                    else
                        text[i, j].Text = coada[2, j].ToString();
                    i++;
                }
                j++;
            }
        }
    }
}
