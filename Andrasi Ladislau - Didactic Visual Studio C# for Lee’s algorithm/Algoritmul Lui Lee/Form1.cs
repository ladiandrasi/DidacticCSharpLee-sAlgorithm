using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Windows.Forms.Integration;
using System.IO;

namespace Algoritmul_Lui_Lee
{
    public partial class Form1 : Form
    {
        int locstartx, locstarty;
        public Button[,] matr = new Button[500, 500];
        int n;
        int m;
        int nrcasute;
        int sem;
        int locfinalx, locfinaly;
        int nrblocaje;
        int sem2;
        int[,] traseu = new int[3, 2000];
        int semculoare1;
        int semculoare2;
        int ctcas = 1;
        int semrez;
        int iant, jant;
        int[] cord1 = new int[2000];
        int[] cord2 = new int[2000];
        int ct = 1;
        int semy, semb;
        ToolTip toolTip1 = new ToolTip();
        bool movement=true;
        public Form1()
        {
            InitializeComponent();
            panel1.Anchor = (AnchorStyles.Top | AnchorStyles.Left);

            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 500;

            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.button1, "Clean board.");
            toolTip1.SetToolTip(this.red, "Add/Remove blocked points.");
            toolTip1.SetToolTip(this.start, "Add/Modify starting point.");
            toolTip1.SetToolTip(this.end, "Add/Modify destination point.");
            toolTip1.SetToolTip(this.rezolv, "User's solution.");
            toolTip1.SetToolTip(this.aleatoriu, "Randomly generate board.");
            toolTip1.SetToolTip(this.button2, "Delete current solution.");
            toolTip1.SetToolTip(this.generare, "Generate empty board.");
            toolTip1.SetToolTip(this.label1, "Execution delay.");
            toolTip1.SetToolTip(this.timerms, "Execution delay.");
            toolTip1.SetToolTip(this.play, "Start execution.");
            toolTip1.SetToolTip(this.checkBox1, "Show queue.");
            toolTip1.SetToolTip(this.pause, "Pause/Resume execution.");
            toolTip1.SetToolTip(this.stop, "Stop execution.");
            toolTip1.SetToolTip(this.pas, "Step-by-step execution.");
            toolTip1.SetToolTip(this.algoritm, "Show Lee's algorithm.");
            toolTip1.SetToolTip(this.Rezolvare, "Show solution.");
            toolTip1.SetToolTip(this.english, "Change language to english.");
            toolTip1.SetToolTip(this.romanian, "Change language to romanian.");
            System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#293955");
            this.BackColor = col;

            english.Image = Properties.Resources.eng;
            romanian.Image = Properties.Resources.ro;

            menuStrip1.BackColor = col;
            openToolStripMenuItem.BackColor = Color.White;
            saveToolStripMenuItem.BackColor = Color.White;
            aboutToolStripMenuItem.BackColor = Color.White;

            openToolStripMenuItem.ForeColor = Color.Black;
            saveToolStripMenuItem.ForeColor = Color.Black;
            aboutToolStripMenuItem.ForeColor = Color.Black;

            saveToolStripMenuItem.Image = Properties.Resources.savefile;
            openToolStripMenuItem.Image = Properties.Resources.open;
            aboutToolStripMenuItem.Image = Properties.Resources.help;
            exitToolStripMenuItem.Image = Properties.Resources.exit;


            generare.FlatStyle = FlatStyle.Flat;
            generare.FlatAppearance.BorderColor = Color.White;

            aleatoriu.FlatStyle = FlatStyle.Flat;
            aleatoriu.FlatAppearance.BorderColor = Color.White;

            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderColor = Color.White;

            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderColor = Color.White;

            Rezolvare.FlatStyle = FlatStyle.Flat;
            Rezolvare.FlatAppearance.BorderColor = Color.White;

            Rezolvare.FlatStyle = FlatStyle.Flat;
            Rezolvare.FlatAppearance.BorderColor = Color.White;

            play.FlatStyle = FlatStyle.Flat;
            play.FlatAppearance.BorderColor = Color.White;

            pause.FlatStyle = FlatStyle.Flat;
            pause.FlatAppearance.BorderColor = Color.White;

            pas.FlatStyle = FlatStyle.Flat;
            pas.FlatAppearance.BorderColor = Color.White;

            algoritm.FlatStyle = FlatStyle.Flat;
            algoritm.FlatAppearance.BorderColor = Color.White;

            stop.FlatStyle = FlatStyle.Flat;
            stop.FlatAppearance.BorderColor = Color.White;

            play.Image = Properties.Resources.play_pressed;
            play.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;

            pause.Image = Properties.Resources.imageedit_3_9218150958;
            pause.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;

            stop.Image = Properties.Resources.stop;
            stop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;

            pas.Image = Properties.Resources.step2;
            pas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;

            button3.FlatStyle = FlatStyle.Flat;
            button3.BackColor = Color.Orange;
            button3.Enabled = false;

            button4.FlatStyle = FlatStyle.Flat;
            button4.BackColor = Color.MediumPurple;
            button4.Enabled = false;

            button5.FlatStyle = FlatStyle.Flat;
            button5.BackColor = Color.DarkRed;
            button5.Enabled = false;

            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            generare.Enabled = false;
            textBox2.Enabled = false;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Show();
            generare.Show();
        }
        int generareok = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            textBox2.Enabled = false;
            try
            {
                m = Convert.ToInt32(textBox1.Text);
                if (m != 0)
                    textBox2.Enabled = true;
                if (m == 0)
                    generare.Enabled = false;
            }
            catch
            {
                if (textBox1.Text != "")
                {
                    textBox1.Text = "";
                    if(lang_english==true)
                        MessageBox.Show("Wrong character.", "Error");
                    else
                        MessageBox.Show("Caracter greșit.", "Eroare");
                }
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        private void generare_Click(object sender, EventArgs e)
        {
            nrcasute = 0;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            panel1.SuspendLayout();
            if (sem == 0)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matr[i, j] = new Button();
                        matr[i, j].Parent = panel1;
                        matr[i, j].Width = panel1.Width / n;
                        matr[i, j].Height = panel1.Height / m;
                        matr[i, j].Visible = true;
                        matr[i, j].FlatStyle = FlatStyle.Flat;
                        matr[i, j].FlatAppearance.BorderColor = Color.Azure;
                        matr[i, j].Name = "matr" + i.ToString() + j.ToString();
                        matr[i, j].BackColor = Color.LightGreen;
                        matr[i, j].Enabled = true;
                        //matr[i, j].Anchor = AnchorStyles.None;
                        //matr[i, j].Text = i.ToString() + "," + j.ToString();
                        matr[i, j].Tag = nrcasute++;
                        //matr[i, j].Text = matr[i, j].Tag.ToString();
                        matr[i, j].Click += MatriceClick;
                        matr[i, j].Font = new Font("Times New Roman", matr[i, j].Width / 5);
                        sem = 1;
                        matr[i, j].Location = new Point(j * matr[i, j].Width, i * matr[i, j].Height);
                        matr[i, j].Font = new Font(matr[i, j].Font, FontStyle.Bold);
                        toolTip1.SetToolTip(this.matr[i, j], "Line " + i.ToString() + Environment.NewLine + "Column " + j.ToString());
                    }
                }
                panel1.ResumeLayout();
                semrez = 0;
                Array.Clear(cord1, 0, cord1.Length);
                Array.Clear(cord2, 0, cord2.Length);
            }
            else
            {
                for (int index = panel1.Controls.Count - 1; index >= 0; index--)
                    panel1.Controls.RemoveAt(index);
                panel1.SuspendLayout();
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matr[i, j] = new Button();
                        matr[i, j].Parent = panel1;
                        matr[i, j].Width = panel1.Width / (n);
                        matr[i, j].Height = panel1.Height / (m);
                        matr[i, j].Visible = true;
                        matr[i, j].FlatStyle = FlatStyle.Flat;
                        matr[i, j].FlatAppearance.BorderColor = Color.Azure;
                        matr[i, j].Name = "matr" + i.ToString() + j.ToString();
                        matr[i, j].BackColor = Color.LightGreen;
                        //matr[i, j].BackgroundImage = Algoritmul_Lui_Lee.Properties.Resources.drum;
                        matr[i, j].Enabled = true;
                        //matr[i, j].Anchor = AnchorStyles.None;
                        //matr[i, j].Text = i.ToString() + j.ToString();
                        matr[i, j].Tag = nrcasute++;
                        //matr[i, j].Text = matr[i, j].Tag.ToString();
                        matr[i, j].Click += MatriceClick;
                        matr[i, j].Location = new Point(j * matr[i, j].Width, i * matr[i, j].Height);
                        matr[i, j].Font = new Font("Times New Roman", matr[i, j].Width / 5);
                        matr[i, j].Font = new Font(matr[i, j].Font, FontStyle.Bold);
                        toolTip1.SetToolTip(this.matr[i, j], "Line " + i.ToString() + Environment.NewLine + "Column " + j.ToString());
                        semy = 0;
                        semb = 0;

                    }
                }
                panel1.ResumeLayout();
                semrez = 0;
                Array.Clear(cord1, 0, cord1.Length);
                Array.Clear(cord2, 0, cord2.Length);
            }
        }
        private void MatriceClick(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                if (red.Checked)
                {
                    Button b = sender as Button;
                    if (b.BackColor == Color.LightGreen)
                        b.BackColor = Color.DarkRed;
                    else
                        if (b.BackColor != Color.Orange && b.BackColor != Color.MediumPurple)
                            b.BackColor = Color.LightGreen;
                }
                if (start.Checked)
                {
                    Button b = sender as Button;
                    int i, j;
                    for (i = 0; i < m; i++)
                        for (j = 0; j < n; j++)
                            if (matr[i, j].BackColor == Color.Orange)
                                semculoare1 = 1;
                    if (semculoare1 == 1 && b.BackColor != Color.Orange)
                    {
                        if (lang_english == true)
                            MessageBox.Show("There is already a starting point.", "Warning");
                        else
                            MessageBox.Show("Există deja un punct de start.", "Atenție");
                    }
                    if (b.BackColor == Color.LightGreen && semculoare1 == 0)
                    {
                        b.BackColor = Color.Orange;
                        semculoare1 = 1;
                    }
                    else
                    {
                        if (b.BackColor == Color.Orange)
                        {
                            b.BackColor = Color.LightGreen;
                            semculoare1 = 0;
                        }
                    }
                }
                if (end.Checked)
                {
                    Button b = sender as Button;
                    int i, j;
                    for (i = 0; i < m; i++)
                        for (j = 0; j < n; j++)
                            if (matr[i, j].BackColor == Color.MediumPurple)
                                semculoare2 = 1;
                    if (semculoare2 == 1 && b.BackColor != Color.MediumPurple)
                    {
                        if (lang_english == true)
                            MessageBox.Show("There is already a destination point.", "Warning");
                        else
                            MessageBox.Show("Există deja un punct de final.", "Atenție");
                    }
                    if (b.BackColor == Color.LightGreen && semculoare2 == 0)
                    {
                        b.BackColor = Color.MediumPurple;
                        semculoare2 = 1;
                    }
                    else
                    {
                        if (b.BackColor == Color.MediumPurple)
                        {
                            b.BackColor = Color.LightGreen;
                            semculoare2 = 0;
                        }
                    }
                }
                if (rezolv.Checked)
                {
                    Ort.Enabled = false;
                    Diag.Enabled = false;
                    if (semrez == 0)
                    {
                        try
                        {
                            // incarcare di
                            di[0] = -1;
                            di[1] = 0;
                            di[2] = 1;
                            di[3] = 0;
                            //incarcare dj
                            dj[0] = 0;
                            dj[1] = 1;
                            dj[2] = 0;
                            dj[3] = -1;
                            //incarcare did
                            did[0] = -1;
                            did[1] = -1;
                            did[2] = -1;
                            did[3] = 0;
                            did[4] = 1;
                            did[5] = 1;
                            did[6] = 1;
                            did[7] = 0;
                            //incarcaje djd
                            djd[0] = -1;
                            djd[1] = 0;
                            djd[2] = 1;
                            djd[3] = 1;
                            djd[4] = 1;
                            djd[5] = 0;
                            djd[6] = -1;
                            djd[7] = -1;

                            int k, gata, inou, jnou, valnoua;
                            p = u = 1;
                            for (int i = 0; i < m; i++)
                                for (int j = 0; j < n; j++)
                                {
                                    if (matr[i, j].BackColor == Color.Azure)
                                        matr[i, j].BackColor = Color.LightGreen;
                                    if (matr[i, j].BackColor == Color.Orange)
                                    {
                                        locstartx = i;
                                        locstarty = j;
                                    }
                                    if (matr[i, j].BackColor == Color.MediumPurple)
                                    {
                                        locfinalx = i;
                                        locfinaly = j;
                                    }
                                }
                            coada[1, 1] = locstartx; // se porneste din locstart(generat random)
                            coada[2, 1] = locstarty;

                            coada[3, 1] = 1;
                            selectat[locstartx, locstarty] = 1;

                            gata = 0;
                            while (gata == 0)
                            {
                                for (k = 0; k < 4 && movement == true; k++)
                                {
                                    inou = coada[1, p] + di[k];
                                    jnou = coada[2, p] + dj[k];
                                    valnoua = coada[3, p] + 1;

                                    if (inou >= 0 && inou < m && jnou < n && jnou >= 0)
                                    {
                                        if (selectat[inou, jnou] == 0 && matr[inou, jnou].BackColor != Color.DarkRed)
                                        {
                                            insereaza(inou, jnou, valnoua);
                                            //matr[inou, jnou].Text = (p).ToString();
                                            selectat[inou, jnou] = 1;
                                            if (inou == locfinalx && jnou == locfinaly)
                                            {
                                                SMIN = valnoua;
                                                gata = 1;
                                            }
                                        }
                                    }
                                }
                                for (k = 0; k < 8 && movement == false; k++)
                                {
                                    inou = coada[1, p] + did[k];
                                    jnou = coada[2, p] + djd[k];
                                    valnoua = coada[3, p] + 1;

                                    if (inou >= 0 && inou < m && jnou < n && jnou >= 0)
                                    {
                                        if (selectat[inou, jnou] == 0 && matr[inou, jnou].BackColor != Color.DarkRed)
                                        {
                                            insereaza(inou, jnou, valnoua);
                                            //matr[inou, jnou].Text = (p).ToString();
                                            selectat[inou, jnou] = 1;
                                            if (inou == locfinalx && jnou == locfinaly)
                                            {
                                                SMIN = valnoua;
                                                gata = 1;
                                            }
                                        }
                                    }
                                }
                                p++;
                            }
                            SMIN = SMIN - 1;
                            //label1.Text = SMIN.ToString();
                            Array.Clear(coada, 0, coada.Length);
                            Array.Clear(selectat, 0, selectat.Length);
                            Array.Clear(traseu, 0, traseu.Length);
                            semrez = 1;
                            iant = locstartx;
                            jant = locstarty;
                        }
                        catch
                        {
                            int i, j;
                            for (i = 0; i < m; i++)
                                for (j = 0; j < n; j++)
                                    matr[i, j].Text = "";
                            if(lang_english==true)
                                MessageBox.Show("This configuration has no solution.", "Warning");
                            else
                                MessageBox.Show("Această configurație nu are soluție.", "Atenție");
                            Array.Clear(coada, 0, coada.Length);
                            Array.Clear(selectat, 0, selectat.Length);
                            Array.Clear(traseu, 0, traseu.Length);
                            semrez = 0;
                        }

                    }
                    Button b = sender as Button;
                    int x, indice, inou1, jnou1, semaforre = 0, xcord = 0, ycord = 0;

                    cord1[1] = locstartx;
                    cord2[1] = locstarty;
                    if (b.BackColor == Color.LightGreen)
                    {
                        x = Convert.ToInt32(b.Tag);
                        if (x % n == 0)
                        {
                            xcord = x / n;
                            ycord = 0;
                        }
                        else
                        {
                            xcord = (x / n);
                            ycord = x % n;
                        }
                        //textBox3.Text = xcord.ToString();
                        //textBox4.Text = ycord.ToString();
                        for (indice = 0; indice < 4 && movement==true; indice++)
                        {
                            inou1 = xcord + di[indice];
                            jnou1 = ycord + dj[indice];
                            if (inou1 == iant && jnou1 == jant)
                            {
                                semaforre = 1;
                                iant = xcord;
                                jant = ycord;
                            }
                        }
                        for (indice = 0; indice < 8 && movement == false; indice++)
                        {
                            inou1 = xcord + did[indice];
                            jnou1 = ycord + djd[indice];
                            if (inou1 == iant && jnou1 == jant)
                            {
                                semaforre = 1;
                                iant = xcord;
                                jant = ycord;
                            }
                        }
                        if (semaforre == 1)
                        {
                            b.BackColor = Color.Azure;
                            b.Text = ctcas.ToString();
                            ctcas++;
                            cord1[ctcas] = xcord;
                            cord2[ctcas] = ycord;
                        }
                        else
                            if (lang_english == true)
                                MessageBox.Show("Forbidden move.", "Error");
                            else
                                MessageBox.Show("Mișcare interzisă.", "Eroare");
                    }
                    else
                    {
                        if (b.BackColor == Color.Azure && b.Text == (ctcas - 1).ToString())
                        {
                            iant = cord1[ctcas - 1];
                            jant = cord2[ctcas - 1];
                            ctcas--;
                            b.BackColor = Color.LightGreen;
                            b.Text = "";
                        }
                    }
                    int solcorect = 0;
                    if (ctcas == SMIN && b.BackColor == Color.MediumPurple)
                    {
                        for (indice = 0; indice < 4 && movement==true; indice++)
                        {
                            inou1 = locfinalx + di[indice];
                            jnou1 = locfinaly + dj[indice];
                            if (inou1 == cord1[ctcas] && jnou1 == cord2[ctcas])
                            {
                                solcorect = 1;
                            }
                        }
                        for (indice = 0; indice < 8 && movement == false; indice++)
                        {
                            inou1 = locfinalx + did[indice];
                            jnou1 = locfinaly + djd[indice];
                            if (inou1 == cord1[ctcas] && jnou1 == cord2[ctcas])
                            {
                                solcorect = 1;
                            }
                        }
                        if (solcorect == 1)
                            if (lang_english == true)
                                MessageBox.Show("Correct solution.", "Solution");
                            else
                                MessageBox.Show("Soluție corectă.", "Soluție");
                        else
                            if (lang_english == true)
                                MessageBox.Show("Forbidden move.", "Error");
                            else
                                MessageBox.Show("Mișcare interzisă.", "Eroare");
                    }
                    int ok = 0;
                    if (ctcas > SMIN && b.BackColor == Color.MediumPurple && solcorect == 0)
                    {
                        for (indice = 0; indice < 4 && movement==true; indice++)
                        {
                            inou1 = locfinalx + di[indice];
                            jnou1 = locfinaly + dj[indice];
                            if (inou1 == cord1[ctcas] && jnou1 == cord2[ctcas])
                            {
                                ok = 1;
                                if (lang_english == true)
                                    MessageBox.Show("You used too many moves.", "Warning");
                                else
                                    MessageBox.Show("Ai folosit prea multe mișcări.", "Atenție");
                            }
                        }
                        for (indice = 0; indice < 8 && movement == false; indice++)
                        {
                            inou1 = locfinalx + did[indice];
                            jnou1 = locfinaly + djd[indice];
                            if (inou1 == cord1[ctcas] && jnou1 == cord2[ctcas])
                            {
                                ok = 1;
                                if(lang_english==true)
                                    MessageBox.Show("You used too many moves.", "Warning");
                                else
                                    MessageBox.Show("Ai folosit prea multe mișcări.", "Atenție");
                            }
                        }
                        if (ok == 0)
                            if(lang_english==true)
                                MessageBox.Show("Forbidden move.", "Error");
                            else
                                MessageBox.Show("Mișcare interzisă.", "Eroare");
                    }

                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            generare.Enabled = false;
            try
            {
                n = Convert.ToInt32(textBox2.Text);
                if (n != 0)
                    generare.Enabled = true;
            }
            catch
            {
                if (textBox2.Text != "")
                {
                    textBox2.Text = "";
                    if(lang_english==true)
                        MessageBox.Show("Wrong character.", "Error");
                    else
                        MessageBox.Show("Caracter greșit.", "Eroare");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)//Curatare Tabla
        {
            int i, j;
            for (i = 0; i < m; i++)
                for (j = 0; j < n; j++)
                {
                    matr[i, j].BackColor = Color.LightGreen;
                    matr[i, j].Text = "";
                }
            semculoare1 = 0;
            semculoare2 = 0;
            semy = 0;
            semb = 0;
            ctcas = 1;
            SMIN = 0;
            Array.Clear(coada, 0, coada.Length);
            Array.Clear(selectat, 0, selectat.Length);
            Array.Clear(traseu, 0, traseu.Length);
            Array.Clear(cord1, 0, cord1.Length);
            Array.Clear(cord2, 0, cord2.Length);
            Array.Clear(coada2, 0, coada2.Length);
            Array.Clear(coada3, 0, coada3.Length);
            coadai.Text = "";
            coadaj.Text = "";
        }

        private void aleatoriu_Click(object sender, EventArgs e)//Generare aleatorie
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matr[i, j].BackColor == Color.MediumPurple)
                    {
                        semy = 0;
                        matr[i, j].BackColor = Color.LightGreen;
                    }
                    if (matr[i, j].BackColor == Color.Orange)
                    {
                        semb = 0;
                        matr[i, j].BackColor = Color.LightGreen;
                    }
                    if (matr[i, j].BackColor != Color.MediumPurple && matr[i, j].BackColor != Color.Orange)
                    {
                        matr[i, j].BackColor = Color.LightGreen;
                        matr[i, j].Text = "";
                    }
                    matr[i, j].FlatAppearance.BorderColor = Color.White;
                }
            }
            Array.Clear(cord1, 0, cord1.Length);
            Array.Clear(cord2, 0, cord2.Length);
            Array.Clear(coada3, 0, coada3.Length);
            semrez = 0;
            ctcas = 1;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matr[i, j].BackColor == Color.MediumPurple)
                        semy = 1;
                    if (matr[i, j].BackColor == Color.Orange)
                        semb = 1;
                }
            }
            Random r = new Random();
            if (semb == 0)
            {
                locstartx = r.Next(0, m);
                locstarty = r.Next(0, n);
                matr[locstartx, locstarty].BackColor = Color.Orange;
                matr[locstartx, locstarty].Text = "";
            }
            if (semy == 0)
            {
                locfinalx = r.Next(0, m);
                locfinaly = r.Next(0, n);
                while (locstartx == locfinalx && locstarty == locfinaly)
                {
                    locfinalx = r.Next(0, m);
                    locfinaly = r.Next(0, n);
                }
                matr[locfinalx, locfinaly].BackColor = Color.MediumPurple;
                matr[locfinalx, locfinaly].Text = "";
            }

            //matr[locstartx, locstarty].BackgroundImage = Lee.Properties.Resources.start;//adaugare imagine
            //matr[locfinalx, locfinaly].BackgroundImage = Lee.Properties.Resources.final;//adaugare imagine
            if (m > (m * n) / 2)
                nrblocaje = r.Next(m * n / 2, m);
            else
                nrblocaje = r.Next(m, m * n / 2);
            int ct = 0;
            int x, y;
            while (ct < nrblocaje)
            {
                x = r.Next(0, m);
                y = r.Next(0, n);
                if (matr[x, y].BackColor != Color.Orange && matr[x, y].BackColor != Color.MediumPurple && matr[x, y].BackColor != Color.DarkRed)
                {
                    matr[x, y].BackColor = Color.DarkRed;
                    ct++;
                }
            }
            sem2 = 1;
            semy = 1;
            semb = 1;
            indicepas = 1;//resetam indicele pentru excutia pas cu pas
            coadai.Text = "";
            coadaj.Text = "";
        }

        int[,] coada = new int[4, 2000];
        // coada[1]-indice linie
        // coada[2]-indice coloana
        // coada[3]-suma minima acumulata
        public int[,] coada2 = new int[4, 2000]; // coada pentru PLAY
        public int[,] coada3 = new int[4, 2000];// coada pentru pas cu pas
        private int coada2marime;

        int[,] selectat = new int[500, 500];
        int p;      // indice element curent
        int u;    // numarul de elemente introduse in coada
        int SMIN;
        int[] di = new int[5];
        int[] dj = new int[5];
        int[] did = new int[10];
        int[] djd = new int[10];

        // Gasire traseu
        void drum(int i, int j, int ct)
        {
            int k = 0;
            int inou, jnou;
            int x, y;
            int i2 = 0, j2 = 0;
            int minimul = 9999999;
            // incarcare di
            di[0] = -1;
            di[1] = 0;
            di[2] = 1;
            di[3] = 0;
            //incarcare dj
            dj[0] = 0;
            dj[1] = 1;
            dj[2] = 0;
            dj[3] = -1;
            //incarcare did
            did[0] = -1;
            did[1] = -1;
            did[2] = -1;
            did[3] = 0;
            did[4] = 1;
            did[5] = 1;
            did[6] = 1;
            did[7] = 0;
            //incarcaje djd
            djd[0] = -1;
            djd[1] = 0;
            djd[2] = 1;
            djd[3] = 1;
            djd[4] = 1;
            djd[5] = 0;
            djd[6] = -1;
            djd[7] = -1;
            for (k = 0; k < 4 && movement==true; k++)
            {
                inou = i + di[k];
                jnou = j + dj[k];
                if (inou >= 0 && jnou >= 0 && inou < m && jnou < n)
                {
                    if (matr[inou, jnou].Text != "" && matr[i, j].Text != "")
                    {
                        x = Convert.ToInt32(matr[inou, jnou].Text);
                        y = Convert.ToInt32(matr[i, j].Text);
                        if (x < y)
                        {
                            if (minimul > x)
                            {
                                minimul = x;
                                i2 = inou;
                                traseu[1, ct] = inou;
                                j2 = jnou;
                                traseu[2, ct] = jnou;
                            }
                        }
                    }
                }
            }
            for (k = 0; k < 8 && movement==false; k++)
            {
                inou = i + did[k];
                jnou = j + djd[k];
                if (inou >= 0 && jnou >= 0 && inou < m && jnou < n)
                {
                    if (matr[inou, jnou].Text != "" && matr[i, j].Text != "")
                    {
                        x = Convert.ToInt32(matr[inou, jnou].Text);
                        y = Convert.ToInt32(matr[i, j].Text);
                        if (x < y)
                        {
                            if (minimul > x)
                            {
                                minimul = x;
                                i2 = inou;
                                traseu[1, ct] = inou;
                                j2 = jnou;
                                traseu[2, ct] = jnou;
                            }
                        }
                    }
                }
            }
            ct++;

            if (ct < SMIN)
                drum(i2, j2, ct);
            else
            {
                for (i = 0; i < m; i++)
                    for (j = 0; j < n; j++)
                        matr[i, j].Text = "";

            }
        }
        //Sfarsit gasire traseu


        private void Rezolvare_Click(object sender, EventArgs e)
        {
            try
            {
                // incarcare di
                di[0] = -1;
                di[1] = 0;
                di[2] = 1;
                di[3] = 0;
                //incarcare dj
                dj[0] = 0;
                dj[1] = 1;
                dj[2] = 0;
                dj[3] = -1;
                //incarcare did
                did[0] = -1;
                did[1] = -1;
                did[2] = -1;
                did[3] = 0;
                did[4] = 1;
                did[5] = 1;
                did[6] = 1;
                did[7] = 0;
                //incarcaje djd
                djd[0] = -1;
                djd[1] = 0;
                djd[2] = 1;
                djd[3] = 1;
                djd[4] = 1;
                djd[5] = 0;
                djd[6] = -1;
                djd[7] = -1;

                Array.Clear(traseu, 0, traseu.Length);
                int k, gata, inou, jnou, valnoua;
                p = u = 1;
                for (int i = 0; i < m; i++)
                    for (int j = 0; j < n; j++)
                    {
                        if (matr[i, j].BackColor == Color.Azure || matr[i, j].BackColor == Color.LightSkyBlue)
                            matr[i, j].BackColor = Color.LightGreen;
                        if (matr[i, j].BackColor == Color.Orange)
                        {
                            locstartx = i;
                            locstarty = j;
                        }
                        if (matr[i, j].BackColor == Color.MediumPurple)
                        {
                            locfinalx = i;
                            locfinaly = j;
                        }
                    }
                coada[1, 1] = locstartx; // se porneste din locstart
                coada[2, 1] = locstarty;

                coada[3, 1] = 1;
                selectat[locstartx, locstarty] = 1;
                SMIN = 0;
                gata = 0;
                while (gata == 0)
                {
                    for (k = 0; k < 4 && movement==true; k++)
                    {
                        inou = coada[1, p] + di[k];
                        jnou = coada[2, p] + dj[k];
                        valnoua = coada[3, p] + 1;

                        if (inou >= 0 && inou < m && jnou < n && jnou >= 0)
                        {
                            if (selectat[inou, jnou] == 0 && matr[inou, jnou].BackColor != Color.DarkRed)
                            {
                                insereaza(inou, jnou, valnoua);
                                matr[inou, jnou].Text = (p).ToString();
                                selectat[inou, jnou] = 1;
                                if (inou == locfinalx && jnou == locfinaly)
                                {
                                    SMIN = valnoua;
                                    gata = 1;
                                }
                            }
                        }
                    }
                    for (k = 0; k < 8 && movement == false; k++)
                    {
                        inou = coada[1, p] + did[k];
                        jnou = coada[2, p] + djd[k];
                        valnoua = coada[3, p] + 1;

                        if (inou >= 0 && inou < m && jnou < n && jnou >= 0)
                        {
                            if (selectat[inou, jnou] == 0 && matr[inou, jnou].BackColor != Color.DarkRed)
                            {
                                insereaza(inou, jnou, valnoua);
                                matr[inou, jnou].Text = (p).ToString();
                                selectat[inou, jnou] = 1;
                                if (inou == locfinalx && jnou == locfinaly)
                                {
                                    SMIN = valnoua;
                                    gata = 1;
                                }
                            }
                        }
                    }
                    p++;
                }
                SMIN = SMIN - 1;
                drum(locfinalx, locfinaly, 1);

                for (int i = 1; i < SMIN; i++)
                {
                    matr[traseu[1, i], traseu[2, i]].Text = (SMIN - i).ToString();
                    matr[traseu[1, i], traseu[2, i]].BackColor = Color.Azure;
                }
                matr[locfinalx, locfinaly].Text = SMIN.ToString();
                Array.Clear(coada, 0, coada.Length);
                Array.Clear(selectat, 0, selectat.Length);
                Array.Clear(traseu, 0, traseu.Length);
            }
            catch
            {
                int i, j;
                for (i = 0; i < m; i++)
                    for (j = 0; j < n; j++)
                    {
                        matr[i, j].Text = "";
                    }
                if(lang_english==true)
                    MessageBox.Show("This configuration has no solution.", "Warning");
                else
                    MessageBox.Show("Această configurație nu are soluție.", "Atenție");
                Array.Clear(coada, 0, coada.Length);
                Array.Clear(selectat, 0, selectat.Length);
                Array.Clear(traseu, 0, traseu.Length);
            }

        }
        void insereaza(int inou, int jnou, int valnoua)
        {
            int k;
            k = u;
            while (k > p && valnoua < coada[3, k])
            {
                coada[1, k + 1] = coada[1, k];
                coada[2, k + 1] = coada[2, k];
                coada[3, k + 1] = coada[3, k];
                k--;
            }
            coada2[1, k + 1] = inou;
            coada2[2, k + 1] = jnou;
            coada3[1, k + 1] = inou;
            coada3[2, k + 1] = jnou;
            coada[1, k + 1] = inou;
            coada[2, k + 1] = jnou;
            coada[3, k + 1] = valnoua;
            u++;
            coada2marime = u;
        }
        // LEE gata

        private void button2_Click(object sender, EventArgs e)//Curatare solutie
        {
            int i, j;
            Ort.Enabled = true;
            Diag.Enabled = true;
            for (i = 0; i < m; i++)
                for (j = 0; j < n; j++)
                {
                    if (matr[i, j].BackColor == Color.Azure || matr[i, j].BackColor == Color.LightSkyBlue)
                    {
                        if (i == locstartx && j == locstarty)
                        {
                            matr[i, j].BackColor = Color.Orange;
                            matr[i, j].Text = "";
                        }
                        else
                        {
                            if (i == locfinalx && j == locfinaly)
                            {
                                matr[i, j].BackColor = Color.MediumPurple;
                                matr[i, j].Text = "";
                            }
                            else
                            {
                                matr[i, j].BackColor = Color.LightGreen;
                                matr[i, j].Text = "";
                            }
                        }
                    }
                    matr[i, j].FlatAppearance.BorderColor = Color.White;
                }

            ctcas = 1;
            semrez = 0;
            Array.Clear(cord1, 0, cord1.Length);
            Array.Clear(cord2, 0, cord2.Length);
            Array.Clear(coada3, 0, coada3.Length);
            indicepas = 1;
            SMIN = 0;
            coadai.Text = "";
            coadaj.Text = "";
            matr[locstartx, locstarty].Text = "";
            matr[locfinalx, locfinaly].Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (frm3 != null)
                frm3.Close();
            try
            {

                // incarcare di
                di[0] = -1;
                di[1] = 0;
                di[2] = 1;
                di[3] = 0;
                //incarcare dj
                dj[0] = 0;
                dj[1] = 1;
                dj[2] = 0;
                dj[3] = -1;
                //incarcare did
                did[0] = -1;
                did[1] = -1;
                did[2] = -1;
                did[3] = 0;
                did[4] = 1;
                did[5] = 1;
                did[6] = 1;
                did[7] = 0;
                //incarcaje djd
                djd[0] = -1;
                djd[1] = 0;
                djd[2] = 1;
                djd[3] = 1;
                djd[4] = 1;
                djd[5] = 0;
                djd[6] = -1;
                djd[7] = -1;
                int k, gata, inou, jnou, valnoua;
                p = u = 1;
                for (int i = 0; i < m; i++)
                    for (int j = 0; j < n; j++)
                    {
                        if (matr[i, j].BackColor == Color.Azure || matr[i, j].BackColor == Color.LightSkyBlue)
                            matr[i, j].BackColor = Color.LightGreen;
                        if (matr[i, j].BackColor == Color.Orange)
                        {
                            locstartx = i;
                            locstarty = j;
                        }
                        if (matr[i, j].BackColor == Color.MediumPurple)
                        {
                            locfinalx = i;
                            locfinaly = j;
                        }
                        matr[i, j].FlatAppearance.BorderColor = Color.White;
                    }
                coada[1, 1] = locstartx; // se porneste din locstart(generat random)
                coada[2, 1] = locstarty;

                coada[3, 1] = 1;
                selectat[locstartx, locstarty] = 1;

                gata = 0;
                while (gata == 0)
                {
                    for (k = 0; k < 4 && movement==true; k++)
                    {
                        inou = coada[1, p] + di[k];
                        jnou = coada[2, p] + dj[k];
                        valnoua = coada[3, p] + 1;

                        if (inou >= 0 && inou < m && jnou < n && jnou >= 0)
                        {
                            if (selectat[inou, jnou] == 0 && matr[inou, jnou].BackColor != Color.DarkRed)
                            {
                                insereaza(inou, jnou, valnoua);
                                matr[inou, jnou].Text = (p).ToString();
                                selectat[inou, jnou] = 1;
                                if (inou == locfinalx && jnou == locfinaly)
                                {
                                    SMIN = valnoua;
                                    gata = 1;
                                }
                            }
                        }
                    }
                    for (k = 0; k < 8 && movement == false; k++)
                    {
                        inou = coada[1, p] + did[k];
                        jnou = coada[2, p] + djd[k];
                        valnoua = coada[3, p] + 1;

                        if (inou >= 0 && inou < m && jnou < n && jnou >= 0)
                        {
                            if (selectat[inou, jnou] == 0 && matr[inou, jnou].BackColor != Color.DarkRed)
                            {
                                insereaza(inou, jnou, valnoua);
                                matr[inou, jnou].Text = (p).ToString();
                                selectat[inou, jnou] = 1;
                                if (inou == locfinalx && jnou == locfinaly)
                                {
                                    SMIN = valnoua;
                                    gata = 1;
                                }
                            }
                        }
                    }
                    p++;
                }
                SMIN = SMIN - 1;
                drum(locfinalx, locfinaly, 1);
                try
                {
                    timer1.Interval = Convert.ToInt32(timerms.Text);
                    timerms.Enabled = false;
                    timer1.Enabled = true;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    timerms.Enabled = false;
                    play.Enabled = false;
                    Rezolvare.Enabled = false;
                    pas.Enabled = false;
                    algoritm.Enabled = false;
                    checkBox1.Enabled = false;
                }
                catch
                {
                    if (lang_english == true)
                        MessageBox.Show("Wrong number for the timer.", "Error");
                    else
                        MessageBox.Show("Număr greșit pentru timer.", "Eroare");
                }

            }
            catch
            {
                int i, j;
                for (i = 0; i < m; i++)
                    for (j = 0; j < n; j++)
                    {
                        matr[i, j].Text = "";
                    }
                if(lang_english==true)
                    MessageBox.Show("This configuration has no solution.", "Warning");
                else
                    MessageBox.Show("Această configurație nu are soluție.", "Atenție");
                Array.Clear(coada, 0, coada.Length);
                Array.Clear(selectat, 0, selectat.Length);
                Array.Clear(traseu, 0, traseu.Length);

            }
        }

        int indicetimp = 1;
        Form3 frm3;
        void Form3_FormClosed(object sender, FormClosedEventArgs e) // inchidere form 3 => oprire timer 
        {
            timer1.Enabled = false;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            timerms.Enabled = true;
            play.Enabled = true;
            Rezolvare.Enabled = true;
            pas.Enabled = true;
            algoritm.Enabled = true;
            checkBox1.Enabled = true;
            int i, j;
            SMIN = 0;
            for (i = 0; i < m; i++)
                for (j = 0; j < n; j++)
                {
                    if (matr[i, j].BackColor == Color.Azure || matr[i, j].BackColor == Color.LightSkyBlue)
                    {
                        if (i == locstartx && j == locstarty)
                        {
                            matr[i, j].BackColor = Color.Orange;
                            matr[i, j].Text = "";
                        }
                        else
                        {
                            if (i == locfinalx && j == locfinaly)
                            {
                                matr[i, j].BackColor = Color.MediumPurple;
                                matr[i, j].Text = "";
                            }
                            else
                            {
                                matr[i, j].BackColor = Color.LightGreen;
                                matr[i, j].Text = "";
                            }
                        }
                    }
                    matr[i, j].FlatAppearance.BorderColor = Color.White;
                }

            ctcas = 1;
            semrez = 0;
            Array.Clear(cord1, 0, cord1.Length);
            Array.Clear(cord2, 0, cord2.Length);
            Array.Clear(coada3, 0, coada3.Length);
            Array.Clear(coada, 0, coada.Length);
            Array.Clear(selectat, 0, selectat.Length);
            Array.Clear(traseu, 0, traseu.Length);
            indicepas = 1;
            coadai.Text = "";
            coadaj.Text = "";
            matr[locstartx, locstarty].Text = "";
            matr[locfinalx, locfinaly].Text = "";
            indicetimp = 1;
        }
        private void timer1_Tick(object sender, EventArgs e)//PLAY
        {
            coada2[1, 1] = locstartx;
            coada2[2, 1] = locstarty;

            matr[coada2[1, indicetimp - 1], coada2[2, indicetimp - 1]].FlatAppearance.BorderColor = Color.White;

            matr[coada2[1, indicetimp], coada2[2, indicetimp]].FlatAppearance.BorderColor = Color.Red;

            if (indicetimp == 1 && checkBox1.Checked == true)
            {
                frm3 = new Form3(coada2, coada2marime, Convert.ToInt32(timerms.Text));
                frm3.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);// Event pentru inchidere form
                frm3.Show();
            }
            if (indicetimp != 1 && matr[coada2[1, indicetimp], coada2[2, indicetimp]].BackColor != Color.MediumPurple)
                matr[coada2[1, indicetimp], coada2[2, indicetimp]].BackColor = Color.LightSkyBlue;
            matr[coada2[1, indicetimp], coada2[2, indicetimp]].Text = coada2[1, indicetimp].ToString() + "," + coada2[2, indicetimp].ToString();
            if (checkBox1.Checked == true)
                frm3.Ftext();
            if (indicetimp == u)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                timerms.Enabled = true;
                play.Enabled = true;
                Rezolvare.Enabled = true;
                pas.Enabled = true;
                algoritm.Enabled = true;
                checkBox1.Enabled = true;
                timer1.Enabled = false;
                indicetimp = 0;
                timerms.Enabled = true;
                if (checkBox1.Checked == true)
                {
                    for (int i = 1; i <= u; i++)
                    {
                        for (int j = 1; j < SMIN; j++)
                            if (frm3.text[1, i].Text == traseu[1, j].ToString() && frm3.text[2, i].Text == traseu[2, j].ToString())
                            {
                                frm3.text[1, i].BackColor = Color.Azure;
                                frm3.text[2, i].BackColor = Color.Azure;
                            }
                    }
                    for (int i = u; i >= 1; i--)
                    {
                        if (frm3.text[1, i].Text == locfinalx.ToString() && frm3.text[2, i].Text == locfinaly.ToString())
                        {
                            frm3.text[1, i].BackColor = Color.Azure;
                            frm3.text[2, i].BackColor = Color.Azure;
                            break;
                        }
                    }
                }
                for (int i = 1; i < SMIN; i++)// colorare traseu corect
                    matr[traseu[1, i], traseu[2, i]].BackColor = Color.Azure;

                Array.Clear(coada2, 0, coada2.Length);
                Array.Clear(coada, 0, coada.Length);
                Array.Clear(selectat, 0, selectat.Length);
                Array.Clear(traseu, 0, traseu.Length);
                if(lang_english==true)
                    MessageBox.Show("The path has " + SMIN.ToString() + " cells.", "Solution");
                else
                    MessageBox.Show("Calea are " + SMIN.ToString() + " celule.", "Soluție");
                SMIN = 0;
            }
            indicetimp++;
        }
        int semstop = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            if (semstop == 0)
            {
                semstop = 1;
                timer1.Enabled = false;

            }
            else
            {
                timer1.Enabled = true;
                semstop = 0;
            }
        }
        int indicepas = 1;
        Form4 frm4;
        public int coada3marime;
        void Form4_FormClosed(object sender, FormClosedEventArgs e) // inchidere form 3 => oprire timer 
        {
            timer1.Enabled = false;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            timerms.Enabled = true;
            play.Enabled = true;
            Rezolvare.Enabled = true;
            pas.Enabled = true;
            algoritm.Enabled = true;
            checkBox1.Enabled = true;
            pause.Enabled = true;
            int i, j;
            for (i = 0; i < m; i++)
                for (j = 0; j < n; j++)
                    if (matr[i, j].BackColor == Color.Azure || matr[i, j].BackColor == Color.LightSkyBlue)
                    {
                        if (i == locstartx && j == locstarty)
                        {
                            matr[i, j].BackColor = Color.Orange;
                            matr[i, j].Text = "";
                        }
                        else
                        {
                            if (i == locfinalx && j == locfinaly)
                            {
                                matr[i, j].BackColor = Color.MediumPurple;
                                matr[i, j].Text = "";
                            }
                            else
                            {
                                matr[i, j].BackColor = Color.LightGreen;
                                matr[i, j].Text = "";
                            }
                        }
                        matr[i, j].FlatAppearance.BorderColor = Color.White;
                    }
            ctcas = 1;
            semrez = 0;
            Array.Clear(cord1, 0, cord1.Length);
            Array.Clear(cord2, 0, cord2.Length);
            Array.Clear(coada3, 0, coada3.Length);
            Array.Clear(coada, 0, coada.Length);
            Array.Clear(selectat, 0, selectat.Length);
            Array.Clear(traseu, 0, traseu.Length);
            indicepas = 1;
            coadai.Text = "";
            coadaj.Text = "";
            matr[locstartx, locstarty].Text = "";
            matr[locfinalx, locfinaly].Text = "";
            indicetimp = 1;
            SMIN = 0;
        }
        private void pas_Click(object sender, EventArgs e)
        {
            if (indicepas == 1)
            {
                if (frm4 != null)
                    frm4.Close();
                Array.Clear(coada, 0, coada.Length);
                Array.Clear(selectat, 0, selectat.Length);
                Array.Clear(traseu, 0, traseu.Length);
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                timerms.Enabled = false;
                play.Enabled = false;
                Rezolvare.Enabled = false;
                algoritm.Enabled = false;
                checkBox1.Enabled = false;
                pause.Enabled = false;
                try
                {
                    // incarcare di
                    di[0] = -1;
                    di[1] = 0;
                    di[2] = 1;
                    di[3] = 0;
                    //incarcare dj
                    dj[0] = 0;
                    dj[1] = 1;
                    dj[2] = 0;
                    dj[3] = -1;
                    //incarcare did
                    did[0] = -1;
                    did[1] = -1;
                    did[2] = -1;
                    did[3] = 0;
                    did[4] = 1;
                    did[5] = 1;
                    did[6] = 1;
                    did[7] = 0;
                    //incarcaje djd
                    djd[0] = -1;
                    djd[1] = 0;
                    djd[2] = 1;
                    djd[3] = 1;
                    djd[4] = 1;
                    djd[5] = 0;
                    djd[6] = -1;
                    djd[7] = -1;

                    int k, gata, inou, jnou, valnoua;
                    p = u = 1;
                    for (int i = 0; i < m; i++)
                        for (int j = 0; j < n; j++)
                        {
                            if (matr[i, j].BackColor == Color.Azure || matr[i, j].BackColor == Color.LightSkyBlue)
                                matr[i, j].BackColor = Color.LightGreen;
                            if (matr[i, j].BackColor == Color.Orange)
                            {
                                locstartx = i;
                                locstarty = j;
                            }
                            if (matr[i, j].BackColor == Color.MediumPurple)
                            {
                                locfinalx = i;
                                locfinaly = j;
                            }
                            matr[i, j].FlatAppearance.BorderColor = Color.White;
                        }
                    coada[1, 1] = locstartx; // se porneste din locstart(generat random)
                    coada[2, 1] = locstarty;

                    coada[3, 1] = 1;
                    selectat[locstartx, locstarty] = 1;

                    gata = 0;
                    while (gata == 0)
                    {
                        ct = 0;
                        for (k = 0; k < 4 && movement==true; k++)
                        {
                            inou = coada[1, p] + di[k];
                            jnou = coada[2, p] + dj[k];
                            valnoua = coada[3, p] + 1;

                            if (inou >= 0 && inou < m && jnou < n && jnou >= 0)
                            {
                                if (selectat[inou, jnou] == 0 && matr[inou, jnou].BackColor != Color.DarkRed)
                                {
                                    insereaza(inou, jnou, valnoua);
                                    matr[inou, jnou].Text = (p).ToString();
                                    selectat[inou, jnou] = 1;
                                    if (inou == locfinalx && jnou == locfinaly)
                                    {
                                        SMIN = valnoua;
                                        gata = 1;
                                    }
                                }
                            }
                        }
                        for (k = 0; k < 8 && movement == false; k++)
                        {
                            inou = coada[1, p] + did[k];
                            jnou = coada[2, p] + djd[k];
                            valnoua = coada[3, p] + 1;

                            if (inou >= 0 && inou < m && jnou < n && jnou >= 0)
                            {
                                if (selectat[inou, jnou] == 0 && matr[inou, jnou].BackColor != Color.DarkRed)
                                {
                                    insereaza(inou, jnou, valnoua);
                                    matr[inou, jnou].Text = (p).ToString();
                                    selectat[inou, jnou] = 1;
                                    if (inou == locfinalx && jnou == locfinaly)
                                    {
                                        SMIN = valnoua;
                                        gata = 1;
                                    }
                                }
                            }
                        }
                        p++;
                    }
                    SMIN = SMIN - 1;
                    coada3marime = u;
                    drum(locfinalx, locfinaly, 1);
                }
                catch
                {
                    int i, j;
                    for (i = 0; i < m; i++)
                        for (j = 0; j < n; j++)
                        {
                            matr[i, j].Text = "";
                        }
                    if(lang_english==true)
                        MessageBox.Show("This configuration has no solution.", "Warning");
                    else
                        MessageBox.Show("Această configurație nu are soluție.", "Atenție");
                }
            }
            coada3[1, 1] = locstartx;
            coada3[2, 1] = locstarty;
            matr[coada3[1, indicepas - 1], coada3[2, indicepas - 1]].FlatAppearance.BorderColor = Color.White;
            matr[coada3[1, indicepas], coada3[2, indicepas]].FlatAppearance.BorderColor = Color.Red;
            if (indicepas == 1 && checkBox1.Checked == true)
            {
                frm4 = new Form4(coada3, coada3marime);
                frm4.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);// Event pentru inchidere form
                frm4.Show();
            }
            if (indicepas <= u)
            {
                //ct=1;
                if (indicepas != 1 && matr[coada3[1, indicepas], coada3[2, indicepas]].BackColor != Color.MediumPurple)
                    matr[coada3[1, indicepas], coada3[2, indicepas]].BackColor = Color.LightSkyBlue;
                matr[coada3[1, indicepas], coada3[2, indicepas]].Text = coada3[1, indicepas].ToString() + "," + coada3[2, indicepas].ToString();
                if (checkBox1.Checked == true)
                    frm4.Ftext();
                indicepas++;
            }
            else
            {
                if (checkBox1.Checked == true)
                {
                    for (int i = 1; i <= u; i++)
                    {
                        for (int j = 1; j < SMIN; j++)
                            if (frm4.text[1, i].Text == traseu[1, j].ToString() && frm4.text[2, i].Text == traseu[2, j].ToString())
                            {
                                frm4.text[1, i].BackColor = Color.Azure;
                                frm4.text[2, i].BackColor = Color.Azure;
                            }
                    }
                    for (int i = u; i >= 1; i--)
                    {
                        if (frm4.text[1, i].Text == locfinalx.ToString() && frm4.text[2, i].Text == locfinaly.ToString())
                        {
                            frm4.text[1, i].BackColor = Color.Azure;
                            frm4.text[2, i].BackColor = Color.Azure;
                            break;
                        }
                    }
                }

                for (int i = 1; i < SMIN; i++)// colorare traseu corect
                    matr[traseu[1, i], traseu[2, i]].BackColor = Color.Azure;

                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                timerms.Enabled = true;
                play.Enabled = true;
                Rezolvare.Enabled = true;
                algoritm.Enabled = true;
                checkBox1.Enabled = true;
                pause.Enabled = true;
                if(lang_english==true)
                    MessageBox.Show("The path has " + SMIN.ToString() + " cells.", "Solution");
                else
                    MessageBox.Show("Calea are " + SMIN.ToString() + " celule.", "Soluție");
                Array.Clear(coada3, 0, coada3.Length);
                Array.Clear(coada, 0, coada.Length);
                Array.Clear(selectat, 0, selectat.Length);
                Array.Clear(traseu, 0, traseu.Length);
                SMIN = 0;
                indicepas = 1;
            }
        }

        private void algoritm_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            timerms.Enabled = true;
            play.Enabled = true;
            Rezolvare.Enabled = true;
            pas.Enabled = true;
            algoritm.Enabled = true;
            checkBox1.Enabled = true;
            pause.Enabled = true;
            timer1.Enabled = false;
            SMIN = 0;
            int i, j;
            for (i = 0; i < m; i++)
                for (j = 0; j < n; j++)
                    if (matr[i, j].BackColor == Color.Azure || matr[i, j].BackColor == Color.LightSkyBlue)
                    {
                        if (i == locstartx && j == locstarty)
                        {
                            matr[i, j].BackColor = Color.Orange;
                            matr[i, j].Text = "";
                        }
                        else
                        {
                            if (i == locfinalx && j == locfinaly)
                            {
                                matr[i, j].BackColor = Color.MediumPurple;
                                matr[i, j].Text = "";
                            }
                            else
                            {
                                matr[i, j].BackColor = Color.LightGreen;
                                matr[i, j].Text = "";
                            }
                        }
                        matr[i, j].FlatAppearance.BorderColor = Color.White;
                    }
            if (frm4 != null)
                if (frm4.Visible == true)
                    frm4.Close();
            if (frm3 != null)
                if (frm3.Visible == true)
                    frm3.Close();
            ctcas = 1;
            semrez = 0;
            Array.Clear(cord1, 0, cord1.Length);
            Array.Clear(cord2, 0, cord2.Length);
            Array.Clear(coada3, 0, coada3.Length);
            Array.Clear(coada2, 0, coada2.Length);
            Array.Clear(coada, 0, coada.Length);
            Array.Clear(selectat, 0, selectat.Length);
            Array.Clear(traseu, 0, traseu.Length);
            indicepas = 1;
            coadai.Text = "";
            coadaj.Text = "";
            matr[locstartx, locstarty].Text = "";
            matr[locfinalx, locfinaly].Text = "";
            indicetimp = 1;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {

            panel1.Height = this.Height - 50;
            panel1.Width = this.Width - 300;

            int i, j;
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    matr[i, j].Width = panel1.Width / (n);
                    matr[i, j].Height = panel1.Height / (m);
                    matr[i, j].Location = new Point(j * matr[i, j].Width, i * matr[i, j].Height);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)// OPEN
        {
            int readerct = 0;
            int i = 0, j = 0;
            int starting = 0, ending = 0;
            string str = "";
            openFileDialog1.FileName = "";
            //you can add .jpeg , etc.
            openFileDialog1.Filter = "Text Documents (*.txt)|*.txt";
            openFileDialog1.Title = "Choose a text file";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader reader;
                reader = new StreamReader(openFileDialog1.FileName);
                textBox1.Text = "";
                textBox2.Text = "";
                do
                {
                    char ch;

                    ch = (char)reader.Read();
                    if (char.IsDigit(ch) || char.IsLetter(ch)) //VERIFICARE FISIER
                    {
                        if (char.IsLetter(ch))
                            str += ch;
                        if (readerct == 0)
                        {
                            while (char.IsDigit(ch))
                            {
                                textBox1.Text += ch.ToString();
                                ch = (char)reader.Read();
                            }
                        }
                        if (readerct == 1)
                        {
                            while (char.IsDigit(ch))
                            {
                                textBox2.Text += ch.ToString();
                                ch = (char)reader.Read();
                            }
                        }
                        if (ch == 'e')
                            ending++;
                        if (ch == 's')
                            starting++;
                        readerct++;
                    }
                } while (!reader.EndOfStream);

                if (starting == 1 && ending == 1 && readerct == (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text) + 2))
                {
                    readerct = 0;
                    generare_Click(sender, e);
                    while (i < m && j < n)
                    {
                        if (str[readerct] == 'r')//RED
                            matr[i, j].BackColor = Color.DarkRed;
                        if (str[readerct] == 'g')//GREEN
                            matr[i, j].BackColor = Color.LightGreen;
                        if (str[readerct] == 'e')//END
                            matr[i, j].BackColor = Color.MediumPurple;
                        if (str[readerct] == 's')//START
                            matr[i, j].BackColor = Color.Orange;
                        j++;
                        if (j == n)
                        {
                            i++;
                            j = 0;
                        }
                        readerct++;
                    }
                }
                else
                    if(lang_english==true)
                        MessageBox.Show("Wrong entry file.","Error");
                    else
                        MessageBox.Show("Fișier de intrare greșit.","Eroare");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) // SAVE
        {
            int i = 0, j = 0;

            savefile.FileName = "TextDocument.txt";
            savefile.Title = "Save configuration";
            savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(savefile.FileName))
                {
                    sw.WriteLine(m.ToString() + ' ' + n.ToString());
                    for (i = 0; i < m; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            if (matr[i, j].BackColor == Color.LightGreen)
                                sw.Write('g');
                            if (matr[i, j].BackColor == Color.DarkRed)
                                sw.Write('r');
                            if (matr[i, j].BackColor == Color.Orange)
                                sw.Write('s');
                            if (matr[i, j].BackColor == Color.MediumPurple)
                                sw.Write('e');
                            sw.Write(' ');
                        }
                        sw.Write(Environment.NewLine);
                    }
                }
            }
        }

        private void fileToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            fileToolStripMenuItem.ForeColor = Color.White;
        }

        private void fileToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            fileToolStripMenuItem.ForeColor = Color.Black;
        }

        private void helpToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            helpToolStripMenuItem.ForeColor = Color.White;
        }

        private void helpToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            helpToolStripMenuItem.ForeColor = Color.Black;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ort_CheckedChanged(object sender, EventArgs e)
        {
            movement = true;//Ort
        }

        private void Diag_CheckedChanged(object sender, EventArgs e)
        {
            movement = false;//Diag
        }

        private void rezolv_CheckedChanged(object sender, EventArgs e)
        {
            Ort.Enabled = true;
            Diag.Enabled = true;
        }
        bool lang_english = true;
        bool lang_romanian = false;
        private void english_Click(object sender, EventArgs e)
        {
            lang_english = true;
            lang_romanian = false;
            groupBox1.Text = "Dimension";
            groupBox2.Text = "Controls";
            groupBox3.Text = "Execution";
            groupBox4.Text = "Legend";
            label2.Text = "Number of lines";
            label3.Text = "Number of columns";
            Ort.Text = "Orthogonal movement";
            Diag.Text = "Diagonal movement";
            generare.Text = "Generate matrix";
            start.Text = "Starting point";
            end.Text = "Destination point";
            red.Text = "Blocked point";
            rezolv.Text = "User solution";
            aleatoriu.Text = "Random generation";
            button1.Text = "Clean board";
            button2.Text = "Erase solution";
            label1.Text = "Time(ms)";
            checkBox1.Text = "Show queue";
            play.Text = "Start execution";
            pause.Text = "Pause";
            stop.Text = "Stop execution";
            pas.Text = "Step-by-step execution";
            algoritm.Text = "Show Lee's algorithm";
            Rezolvare.Text = "Show solution";
            label5.Text = "- Starting point";
            label6.Text = "- Destination point";
            label7.Text = "- Blocked point";
            fileToolStripMenuItem.Text = "File";
            helpToolStripMenuItem.Text = "Help";
            openToolStripMenuItem.Text = "Open";
            saveToolStripMenuItem.Text = "Save";
            exitToolStripMenuItem.Text = "Exit";
            aboutToolStripMenuItem.Text = "About";

            toolTip1.SetToolTip(this.button1, "Clean board.");
            toolTip1.SetToolTip(this.red, "Add/Remove blocked points.");
            toolTip1.SetToolTip(this.start, "Add/Modify starting point.");
            toolTip1.SetToolTip(this.end, "Add/Modify destination point.");
            toolTip1.SetToolTip(this.rezolv, "User's solution.");
            toolTip1.SetToolTip(this.aleatoriu, "Randomly generate board.");
            toolTip1.SetToolTip(this.button2, "Delete current solution.");
            toolTip1.SetToolTip(this.generare, "Generate empty board.");
            toolTip1.SetToolTip(this.label1, "Execution delay.");
            toolTip1.SetToolTip(this.timerms, "Execution delay.");
            toolTip1.SetToolTip(this.play, "Start execution.");
            toolTip1.SetToolTip(this.checkBox1, "Show queue.");
            toolTip1.SetToolTip(this.pause, "Pause/Resume execution.");
            toolTip1.SetToolTip(this.stop, "Stop execution.");
            toolTip1.SetToolTip(this.pas, "Step-by-step execution.");
            toolTip1.SetToolTip(this.algoritm, "Show Lee's algorithm.");
            toolTip1.SetToolTip(this.Rezolvare, "Show solution.");
            toolTip1.SetToolTip(this.english, "Change language to english.");
            toolTip1.SetToolTip(this.romanian, "Change language to romanian.");
            toolTip1.SetToolTip(this.Ort, "Orthogonal movement.");
            toolTip1.SetToolTip(this.Diag, "Diagonal movement.");
        }

        private void romanian_Click(object sender, EventArgs e)
        {
            lang_english = false;
            lang_romanian = true;
            groupBox1.Text = "Dimensiuni";
            groupBox2.Text = "Configurație";
            groupBox3.Text = "Rulare";
            groupBox4.Text = "Legendă";
            label2.Text = "Număr de linii";
            label3.Text = "Număr de coloane";
            Ort.Text = "Mișcare ortogonală";
            Diag.Text = "Mișcare diagonală";
            generare.Text = "Generare matrice";
            start.Text = "Celulă start";
            end.Text = "Celulă final";
            red.Text = "Celulă blocată";
            rezolv.Text = "Soluție utilizator";
            aleatoriu.Text = "Generare aleatorie";
            button1.Text = "Șterge tablă";
            button2.Text = "Șterge soluție";
            label1.Text = "Timp(ms)";
            checkBox1.Text = "Arată coadă";
            play.Text = "Start execuție";
            pause.Text = "Pauză";
            stop.Text = "Stop execuție";
            pas.Text = "Execuție pas cu pas";
            algoritm.Text = "Arată algoritmul lui Lee";
            Rezolvare.Text = "Arată soluție";
            label5.Text = "- Celulă start";
            label6.Text = "- Celulă final";
            label7.Text = "- Celulă blocată";
            fileToolStripMenuItem.Text = "Fișier";
            helpToolStripMenuItem.Text = "Ajutor";
            openToolStripMenuItem.Text = "Deschide";
            saveToolStripMenuItem.Text = "Salvează";
            exitToolStripMenuItem.Text = "Ieșire";
            aboutToolStripMenuItem.Text = "Despre";

            toolTip1.SetToolTip(this.button1, "Șterge tabla.");
            toolTip1.SetToolTip(this.red, "Adaugă/Șterge punct blocat.");
            toolTip1.SetToolTip(this.start, "Adaugă/Schimbă celula de start.");
            toolTip1.SetToolTip(this.end, "Adaugă/Schimbă celula de final.");
            toolTip1.SetToolTip(this.rezolv, "Soluția utilizatorului.");
            toolTip1.SetToolTip(this.aleatoriu, "Tablă generată aleatoriu.");
            toolTip1.SetToolTip(this.button2, "Șterge soluția curentă.");
            toolTip1.SetToolTip(this.generare, "Generează tablă goală.");
            toolTip1.SetToolTip(this.label1, "Viteză de execuție.");
            toolTip1.SetToolTip(this.timerms, "Viteză de execuție.");
            toolTip1.SetToolTip(this.play, "Pornește execuția.");
            toolTip1.SetToolTip(this.checkBox1, "Arată coadă.");
            toolTip1.SetToolTip(this.pause, "Pauză/Reluare execuție.");
            toolTip1.SetToolTip(this.stop, "Oprește execuția.");
            toolTip1.SetToolTip(this.pas, "Execuție pas cu pas.");
            toolTip1.SetToolTip(this.algoritm, "Arată algoritmul lui Lee.");
            toolTip1.SetToolTip(this.Rezolvare, "Arată soluție.");
            toolTip1.SetToolTip(this.english, "Schimbă limba în engleză.");
            toolTip1.SetToolTip(this.romanian, "Schimbă limba în română.");
            toolTip1.SetToolTip(this.Ort, "Mișcare ortogonală.");
            toolTip1.SetToolTip(this.Diag, "Mișcare diagonală.");
        }
    }
}


