namespace Algoritmul_Lui_Lee
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.generare = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Diag = new System.Windows.Forms.RadioButton();
            this.Ort = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.aleatoriu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.red = new System.Windows.Forms.RadioButton();
            this.start = new System.Windows.Forms.RadioButton();
            this.end = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.rezolv = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.play = new System.Windows.Forms.Button();
            this.Rezolvare = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.pas = new System.Windows.Forms.Button();
            this.timerms = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.algoritm = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.stop = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.coadai = new System.Windows.Forms.Label();
            this.coadaj = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.savefile = new System.Windows.Forms.SaveFileDialog();
            this.romanian = new System.Windows.Forms.Button();
            this.english = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // generare
            // 
            this.generare.Location = new System.Drawing.Point(167, 81);
            this.generare.Name = "generare";
            this.generare.Size = new System.Drawing.Size(85, 46);
            this.generare.TabIndex = 2;
            this.generare.Text = "Generate matrix";
            this.generare.UseVisualStyleBackColor = true;
            this.generare.Click += new System.EventHandler(this.generare_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Number of lines";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Number of columns";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Diag);
            this.groupBox1.Controls.Add(this.Ort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.generare);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(4, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 136);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dimension";
            // 
            // Diag
            // 
            this.Diag.Location = new System.Drawing.Point(4, 107);
            this.Diag.Name = "Diag";
            this.Diag.Size = new System.Drawing.Size(158, 20);
            this.Diag.TabIndex = 0;
            this.Diag.Text = "Diagonal movement";
            this.Diag.UseVisualStyleBackColor = true;
            this.Diag.CheckedChanged += new System.EventHandler(this.Diag_CheckedChanged);
            // 
            // Ort
            // 
            this.Ort.AutoSize = true;
            this.Ort.Checked = true;
            this.Ort.Location = new System.Drawing.Point(3, 81);
            this.Ort.Name = "Ort";
            this.Ort.Size = new System.Drawing.Size(158, 20);
            this.Ort.TabIndex = 13;
            this.Ort.TabStop = true;
            this.Ort.Text = "Orthogonal movement";
            this.Ort.UseVisualStyleBackColor = true;
            this.Ort.CheckedChanged += new System.EventHandler(this.Ort_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // aleatoriu
            // 
            this.aleatoriu.Location = new System.Drawing.Point(169, 22);
            this.aleatoriu.Name = "aleatoriu";
            this.aleatoriu.Size = new System.Drawing.Size(85, 46);
            this.aleatoriu.TabIndex = 7;
            this.aleatoriu.Text = "Random generation";
            this.aleatoriu.UseVisualStyleBackColor = true;
            this.aleatoriu.Click += new System.EventHandler(this.aleatoriu_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Clean board";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // red
            // 
            this.red.AutoSize = true;
            this.red.Location = new System.Drawing.Point(5, 98);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(108, 20);
            this.red.TabIndex = 3;
            this.red.TabStop = true;
            this.red.Text = "Blocked point";
            this.red.UseVisualStyleBackColor = true;
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Location = new System.Drawing.Point(6, 24);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(103, 20);
            this.start.TabIndex = 4;
            this.start.TabStop = true;
            this.start.Text = "Starting point";
            this.start.UseVisualStyleBackColor = true;
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.Location = new System.Drawing.Point(6, 63);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(125, 20);
            this.end.TabIndex = 5;
            this.end.TabStop = true;
            this.end.Text = "Destination point";
            this.end.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 42);
            this.button2.TabIndex = 9;
            this.button2.Text = "Erase solution";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rezolv
            // 
            this.rezolv.AutoSize = true;
            this.rezolv.Location = new System.Drawing.Point(6, 133);
            this.rezolv.Name = "rezolv";
            this.rezolv.Size = new System.Drawing.Size(104, 20);
            this.rezolv.TabIndex = 6;
            this.rezolv.TabStop = true;
            this.rezolv.Text = "User solution";
            this.rezolv.UseVisualStyleBackColor = true;
            this.rezolv.CheckedChanged += new System.EventHandler(this.rezolv_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rezolv);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.end);
            this.groupBox2.Controls.Add(this.start);
            this.groupBox2.Controls.Add(this.red);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.aleatoriu);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(4, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 180);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controls";
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(9, 74);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(127, 41);
            this.play.TabIndex = 23;
            this.play.Text = "Start execution";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.button3_Click);
            // 
            // Rezolvare
            // 
            this.Rezolvare.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Rezolvare.Location = new System.Drawing.Point(146, 169);
            this.Rezolvare.Name = "Rezolvare";
            this.Rezolvare.Size = new System.Drawing.Size(115, 43);
            this.Rezolvare.TabIndex = 10;
            this.Rezolvare.Text = "Show solution";
            this.Rezolvare.UseVisualStyleBackColor = true;
            this.Rezolvare.Click += new System.EventHandler(this.Rezolvare_Click);
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(146, 74);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(115, 41);
            this.pause.TabIndex = 24;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.button4_Click);
            // 
            // pas
            // 
            this.pas.Location = new System.Drawing.Point(146, 121);
            this.pas.Name = "pas";
            this.pas.Size = new System.Drawing.Size(115, 43);
            this.pas.TabIndex = 25;
            this.pas.Text = "Step-by-step execution";
            this.pas.UseVisualStyleBackColor = true;
            this.pas.Click += new System.EventHandler(this.pas_Click);
            // 
            // timerms
            // 
            this.timerms.Location = new System.Drawing.Point(77, 26);
            this.timerms.Name = "timerms";
            this.timerms.Size = new System.Drawing.Size(100, 22);
            this.timerms.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Time(ms)";
            // 
            // algoritm
            // 
            this.algoritm.Location = new System.Drawing.Point(9, 169);
            this.algoritm.Name = "algoritm";
            this.algoritm.Size = new System.Drawing.Size(127, 43);
            this.algoritm.TabIndex = 28;
            this.algoritm.Text = "Show Lee\'s algorithm";
            this.algoritm.UseVisualStyleBackColor = true;
            this.algoritm.Click += new System.EventHandler(this.algoritm_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.stop);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.algoritm);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.timerms);
            this.groupBox3.Controls.Add(this.pas);
            this.groupBox3.Controls.Add(this.pause);
            this.groupBox3.Controls.Add(this.Rezolvare);
            this.groupBox3.Controls.Add(this.play);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(4, 360);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 223);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Execution";
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(9, 121);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(127, 43);
            this.stop.TabIndex = 30;
            this.stop.Text = "Stop execution";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 54);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 20);
            this.checkBox1.TabIndex = 29;
            this.checkBox1.Text = "Show queue";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // coadai
            // 
            this.coadai.AutoSize = true;
            this.coadai.Location = new System.Drawing.Point(31, 599);
            this.coadai.Name = "coadai";
            this.coadai.Size = new System.Drawing.Size(0, 13);
            this.coadai.TabIndex = 21;
            // 
            // coadaj
            // 
            this.coadaj.AutoSize = true;
            this.coadaj.Location = new System.Drawing.Point(31, 628);
            this.coadaj.Name = "coadaj";
            this.coadaj.Size = new System.Drawing.Size(0, 13);
            this.coadaj.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(277, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 706);
            this.panel1.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 25);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 25);
            this.button4.TabIndex = 0;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(15, 82);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 25);
            this.button5.TabIndex = 0;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(4, 589);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(267, 122);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Legend";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "- Blocked point";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "- Destination point";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "- Starting point";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 25);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.DropDownClosed += new System.EventHandler(this.fileToolStripMenuItem_DropDownClosed);
            this.fileToolStripMenuItem.DropDownOpening += new System.EventHandler(this.fileToolStripMenuItem_DropDownOpening);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.DropDownClosed += new System.EventHandler(this.helpToolStripMenuItem_DropDownClosed);
            this.helpToolStripMenuItem.DropDownOpening += new System.EventHandler(this.helpToolStripMenuItem_DropDownOpening);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // romanian
            // 
            this.romanian.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.romanian.Location = new System.Drawing.Point(154, 6);
            this.romanian.Name = "romanian";
            this.romanian.Size = new System.Drawing.Size(30, 20);
            this.romanian.TabIndex = 26;
            this.romanian.UseVisualStyleBackColor = true;
            this.romanian.Click += new System.EventHandler(this.romanian_Click);
            // 
            // english
            // 
            this.english.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.english.Location = new System.Drawing.Point(118, 6);
            this.english.Name = "english";
            this.english.Size = new System.Drawing.Size(30, 20);
            this.english.TabIndex = 25;
            this.english.UseVisualStyleBackColor = true;
            this.english.Click += new System.EventHandler(this.english_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 715);
            this.Controls.Add(this.romanian);
            this.Controls.Add(this.english);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.coadaj);
            this.Controls.Add(this.coadai);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 726);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lee\'s algorithm- © Andrasi Ladislau";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button generare;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button aleatoriu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton red;
        private System.Windows.Forms.RadioButton start;
        private System.Windows.Forms.RadioButton end;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rezolv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button Rezolvare;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.TextBox timerms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button algoritm;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label coadai;
        private System.Windows.Forms.Label coadaj;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button pas;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog savefile;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.RadioButton Ort;
        private System.Windows.Forms.RadioButton Diag;
        private System.Windows.Forms.Button english;
        private System.Windows.Forms.Button romanian;
    }
}

