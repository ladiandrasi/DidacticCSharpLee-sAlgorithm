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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            this.Left = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Left;
            this.Top = 0;
            this.Height = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;
            //this.Width = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width / 4;
            //richTextBox1.Width = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width / 4 - 40;
            richTextBox1.Height = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - 60;
            System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#293955");
            this.BackColor = col;

        }

        private void Form2_SizeChanged(object sender, EventArgs e)
        {
            richTextBox1.Height = this.Height - 60;
            richTextBox1.Width = this.Width - 40;
        }
    }
}
