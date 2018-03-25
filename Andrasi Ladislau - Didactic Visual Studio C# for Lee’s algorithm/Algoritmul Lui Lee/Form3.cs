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
    public partial class Form3 : Form
    {
        int timpint;
        int[,] coada = new int[4,2000];
        int i, j=1;
        int marime;
        public int x;
        public int semafor = 0;
        FlowLayoutPanel flp = new FlowLayoutPanel() { Dock = DockStyle.Fill, AutoScroll = true };

        public Form3(int[,] coada2,int coada2marime ,int interval)
        {
            InitializeComponent();
            this.Left = 0;
            this.Top = 0;
            System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#293955");
            this.BackColor = col;
            Array.Copy(coada2, coada, coada2.Length);
            timpint = interval;
            marime = coada2marime;

        }
        public TextBox[,] text = new TextBox[3, 5000];
        public void Ftext()
        {
            if (j <= marime)
            {
                
                i = 1;
                while (i <= 2)
                {
                    text[i, j] = new TextBox();
                    text[i, j].Parent = this;
                    text[i, j].Name = "text" + i.ToString() + j.ToString();
                    text[i, j].Location = new Point(j * 40, i * 40);
                    text[i, j].Multiline = true;
                    text[i, j].Height = 40;
                    text[i, j].Width = 40;
                    //text[i, j].SelectionAlignment = HorizontalAlignment.Center;
                    text[i, j].Visible = true;
                    text[i, j].ReadOnly = true;
                    text[i, j].Font = new Font("Times New Roman", 15);
                    text[i, j].Font = new Font(text[i, j].Font, FontStyle.Bold);
                    text[i, j].BackColor = Color.Yellow;
                    if (i == 1)
                        text[i, j].Text = coada[1, j].ToString();
                    else
                        text[i, j].Text = coada[2, j].ToString();
                    //this.text[i, j].Focus();
                    i++;
                }
                j++;
            }
        }
    }
}
