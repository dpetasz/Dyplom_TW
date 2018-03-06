namespace Dyplom_Dariusz_Petasz_Z709.ScenaObrotowa
{
    partial class ObrotowkaPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxPredkoscObrotowka = new System.Windows.Forms.TextBox();
            this.textBoxPozycjaZadanaObrotowka = new System.Windows.Forms.TextBox();
            this.textBoxPozycjaObrotowka = new System.Windows.Forms.TextBox();
            this.panelSterowanie = new System.Windows.Forms.Panel();
            this.trackBarJoystick = new System.Windows.Forms.TrackBar();
            this.buttonPrawo = new System.Windows.Forms.Button();
            this.buttonLewo = new System.Windows.Forms.Button();
            this.buttonJazdaDoPozycji = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonJazdaTechniczna = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.buttonJazdaProgramowa = new System.Windows.Forms.Button();
            this.pokazFxObrotowkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tWDataSet = new Dyplom_Dariusz_Petasz_Z709.TWDataSet();
            this.pokazAktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokazPrzedstawienieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokazPrzedstawienieTableAdapter = new Dyplom_Dariusz_Petasz_Z709.TWDataSetTableAdapters.pokazPrzedstawienieTableAdapter();
            this.pokazAktTableAdapter = new Dyplom_Dariusz_Petasz_Z709.TWDataSetTableAdapters.pokazAktTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pokazFxObrotowkaTableAdapter = new Dyplom_Dariusz_Petasz_Z709.TWDataSetTableAdapters.pokazFxObrotowkaTableAdapter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelWynikDodajFX_Ob = new System.Windows.Forms.Label();
            this.textBoxNazwaFX = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonZapiszFX = new System.Windows.Forms.Button();
            this.comboBoxAkt = new System.Windows.Forms.ComboBox();
            this.comboBoxPrzedstawienie = new System.Windows.Forms.ComboBox();
            this.richTextBoxOpisZapisFx = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlBazaDanych = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelSterowanie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarJoystick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokazFxObrotowkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tWDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokazAktBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokazPrzedstawienieBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControlBazaDanych.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(30, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(630, 630);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBoxPredkoscObrotowka);
            this.panel2.Controls.Add(this.textBoxPozycjaZadanaObrotowka);
            this.panel2.Controls.Add(this.textBoxPozycjaObrotowka);
            this.panel2.Location = new System.Drawing.Point(684, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 160);
            this.panel2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Moccasin;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(21, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(98, 25);
            this.textBox3.TabIndex = 25;
            this.textBox3.Text = "Prędkość";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Moccasin;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(21, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(98, 25);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "Pozycja zadana";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Moccasin;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(21, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(98, 25);
            this.textBox2.TabIndex = 23;
            this.textBox2.Text = "Pozycja";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPredkoscObrotowka
            // 
            this.textBoxPredkoscObrotowka.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPredkoscObrotowka.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBoxPredkoscObrotowka.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxPredkoscObrotowka.Location = new System.Drawing.Point(135, 104);
            this.textBoxPredkoscObrotowka.Name = "textBoxPredkoscObrotowka";
            this.textBoxPredkoscObrotowka.Size = new System.Drawing.Size(126, 26);
            this.textBoxPredkoscObrotowka.TabIndex = 6;
            // 
            // textBoxPozycjaZadanaObrotowka
            // 
            this.textBoxPozycjaZadanaObrotowka.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPozycjaZadanaObrotowka.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBoxPozycjaZadanaObrotowka.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxPozycjaZadanaObrotowka.Location = new System.Drawing.Point(135, 63);
            this.textBoxPozycjaZadanaObrotowka.Name = "textBoxPozycjaZadanaObrotowka";
            this.textBoxPozycjaZadanaObrotowka.ReadOnly = true;
            this.textBoxPozycjaZadanaObrotowka.Size = new System.Drawing.Size(126, 26);
            this.textBoxPozycjaZadanaObrotowka.TabIndex = 5;
            // 
            // textBoxPozycjaObrotowka
            // 
            this.textBoxPozycjaObrotowka.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPozycjaObrotowka.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBoxPozycjaObrotowka.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxPozycjaObrotowka.Location = new System.Drawing.Point(135, 23);
            this.textBoxPozycjaObrotowka.Name = "textBoxPozycjaObrotowka";
            this.textBoxPozycjaObrotowka.ReadOnly = true;
            this.textBoxPozycjaObrotowka.Size = new System.Drawing.Size(126, 26);
            this.textBoxPozycjaObrotowka.TabIndex = 4;
            // 
            // panelSterowanie
            // 
            this.panelSterowanie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.panelSterowanie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSterowanie.Controls.Add(this.trackBarJoystick);
            this.panelSterowanie.Controls.Add(this.buttonPrawo);
            this.panelSterowanie.Controls.Add(this.buttonLewo);
            this.panelSterowanie.Controls.Add(this.buttonJazdaDoPozycji);
            this.panelSterowanie.Controls.Add(this.label13);
            this.panelSterowanie.Controls.Add(this.label6);
            this.panelSterowanie.Controls.Add(this.label11);
            this.panelSterowanie.Controls.Add(this.label10);
            this.panelSterowanie.Controls.Add(this.buttonJazdaTechniczna);
            this.panelSterowanie.Controls.Add(this.label9);
            this.panelSterowanie.Controls.Add(this.buttonStartStop);
            this.panelSterowanie.Controls.Add(this.buttonJazdaProgramowa);
            this.panelSterowanie.Location = new System.Drawing.Point(684, 297);
            this.panelSterowanie.Name = "panelSterowanie";
            this.panelSterowanie.Size = new System.Drawing.Size(288, 363);
            this.panelSterowanie.TabIndex = 7;
            // 
            // trackBarJoystick
            // 
            this.trackBarJoystick.Location = new System.Drawing.Point(201, 13);
            this.trackBarJoystick.Maximum = 100;
            this.trackBarJoystick.Minimum = -100;
            this.trackBarJoystick.Name = "trackBarJoystick";
            this.trackBarJoystick.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarJoystick.Size = new System.Drawing.Size(45, 332);
            this.trackBarJoystick.TabIndex = 21;
            this.trackBarJoystick.TickFrequency = 10;
            this.trackBarJoystick.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarJoystick.Scroll += new System.EventHandler(this.trackBarJoystick_Scroll);
            this.trackBarJoystick.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarJoystick_MouseUp);
            // 
            // buttonPrawo
            // 
            this.buttonPrawo.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonPrawo.BackgroundImage = global::Dyplom_Dariusz_Petasz_Z709.Properties.Resources.P;
            this.buttonPrawo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPrawo.Location = new System.Drawing.Point(103, 174);
            this.buttonPrawo.Name = "buttonPrawo";
            this.buttonPrawo.Size = new System.Drawing.Size(54, 52);
            this.buttonPrawo.TabIndex = 20;
            this.buttonPrawo.UseVisualStyleBackColor = false;
            this.buttonPrawo.Click += new System.EventHandler(this.buttonPrawo_Click);
            // 
            // buttonLewo
            // 
            this.buttonLewo.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonLewo.BackgroundImage = global::Dyplom_Dariusz_Petasz_Z709.Properties.Resources.L;
            this.buttonLewo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLewo.Location = new System.Drawing.Point(43, 174);
            this.buttonLewo.Name = "buttonLewo";
            this.buttonLewo.Size = new System.Drawing.Size(54, 52);
            this.buttonLewo.TabIndex = 19;
            this.buttonLewo.UseVisualStyleBackColor = false;
            this.buttonLewo.Click += new System.EventHandler(this.buttonLewo_Click);
            // 
            // buttonJazdaDoPozycji
            // 
            this.buttonJazdaDoPozycji.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonJazdaDoPozycji.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonJazdaDoPozycji.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonJazdaDoPozycji.Location = new System.Drawing.Point(18, 72);
            this.buttonJazdaDoPozycji.Name = "buttonJazdaDoPozycji";
            this.buttonJazdaDoPozycji.Size = new System.Drawing.Size(161, 35);
            this.buttonJazdaDoPozycji.TabIndex = 15;
            this.buttonJazdaDoPozycji.Text = "Jazda do pozycji";
            this.buttonJazdaDoPozycji.UseVisualStyleBackColor = false;
            this.buttonJazdaDoPozycji.Click += new System.EventHandler(this.buttonJazdaDoPozycji_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label13.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(162, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 24);
            this.label13.TabIndex = 11;
            this.label13.Text = "P";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(17, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "L";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(252, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "- 0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(252, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "- 100";
            // 
            // buttonJazdaTechniczna
            // 
            this.buttonJazdaTechniczna.BackColor = System.Drawing.Color.IndianRed;
            this.buttonJazdaTechniczna.Enabled = false;
            this.buttonJazdaTechniczna.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonJazdaTechniczna.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonJazdaTechniczna.Location = new System.Drawing.Point(20, 13);
            this.buttonJazdaTechniczna.Name = "buttonJazdaTechniczna";
            this.buttonJazdaTechniczna.Size = new System.Drawing.Size(161, 35);
            this.buttonJazdaTechniczna.TabIndex = 5;
            this.buttonJazdaTechniczna.Text = "Jazda techniczna";
            this.buttonJazdaTechniczna.UseVisualStyleBackColor = false;
            this.buttonJazdaTechniczna.Click += new System.EventHandler(this.buttonJazdaTechniczna_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(252, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "- 100";
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.BackColor = System.Drawing.Color.Green;
            this.buttonStartStop.Enabled = false;
            this.buttonStartStop.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.buttonStartStop.FlatAppearance.BorderSize = 3;
            this.buttonStartStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.buttonStartStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonStartStop.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonStartStop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonStartStop.Location = new System.Drawing.Point(18, 232);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(161, 112);
            this.buttonStartStop.TabIndex = 2;
            this.buttonStartStop.Text = "START";
            this.buttonStartStop.UseVisualStyleBackColor = false;
            this.buttonStartStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonStartStop_MouseDown);
            this.buttonStartStop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonStartStop_MouseUp);
            // 
            // buttonJazdaProgramowa
            // 
            this.buttonJazdaProgramowa.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonJazdaProgramowa.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonJazdaProgramowa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonJazdaProgramowa.Location = new System.Drawing.Point(18, 131);
            this.buttonJazdaProgramowa.Name = "buttonJazdaProgramowa";
            this.buttonJazdaProgramowa.Size = new System.Drawing.Size(161, 35);
            this.buttonJazdaProgramowa.TabIndex = 0;
            this.buttonJazdaProgramowa.Text = "Jazda programowa";
            this.buttonJazdaProgramowa.UseVisualStyleBackColor = false;
            this.buttonJazdaProgramowa.Click += new System.EventHandler(this.buttonJazdaProgramowa_Click);
            // 
            // pokazFxObrotowkaBindingSource
            // 
            this.pokazFxObrotowkaBindingSource.DataMember = "pokazFxObrotowka";
            this.pokazFxObrotowkaBindingSource.DataSource = this.tWDataSet;
            this.pokazFxObrotowkaBindingSource.CurrentChanged += new System.EventHandler(this.pokazFxObrotowkaBindingSource_CurrentChanged);
            // 
            // tWDataSet
            // 
            this.tWDataSet.DataSetName = "TWDataSet";
            this.tWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pokazAktBindingSource
            // 
            this.pokazAktBindingSource.DataMember = "pokazAkt";
            this.pokazAktBindingSource.DataSource = this.tWDataSet;
            this.pokazAktBindingSource.CurrentChanged += new System.EventHandler(this.pokazAktBindingSource_CurrentChanged);
            // 
            // pokazPrzedstawienieBindingSource
            // 
            this.pokazPrzedstawienieBindingSource.DataMember = "pokazPrzedstawienie";
            this.pokazPrzedstawienieBindingSource.DataSource = this.tWDataSet;
            this.pokazPrzedstawienieBindingSource.CurrentChanged += new System.EventHandler(this.pokazPrzedstawienieBindingSource_CurrentChanged);
            // 
            // pokazPrzedstawienieTableAdapter
            // 
            this.pokazPrzedstawienieTableAdapter.ClearBeforeFill = true;
            // 
            // pokazAktTableAdapter
            // 
            this.pokazAktTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pokazFxObrotowkaTableAdapter
            // 
            this.pokazFxObrotowkaTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(70)))));
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.labelWynikDodajFX_Ob);
            this.tabPage2.Controls.Add(this.textBoxNazwaFX);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.buttonZapiszFX);
            this.tabPage2.Controls.Add(this.comboBoxAkt);
            this.tabPage2.Controls.Add(this.comboBoxPrzedstawienie);
            this.tabPage2.Controls.Add(this.richTextBoxOpisZapisFx);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.richTextBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(329, 598);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dodaj FX";
            // 
            // labelWynikDodajFX_Ob
            // 
            this.labelWynikDodajFX_Ob.AutoSize = true;
            this.labelWynikDodajFX_Ob.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelWynikDodajFX_Ob.ForeColor = System.Drawing.Color.Salmon;
            this.labelWynikDodajFX_Ob.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelWynikDodajFX_Ob.Location = new System.Drawing.Point(7, 14);
            this.labelWynikDodajFX_Ob.Name = "labelWynikDodajFX_Ob";
            this.labelWynikDodajFX_Ob.Size = new System.Drawing.Size(65, 19);
            this.labelWynikDodajFX_Ob.TabIndex = 33;
            this.labelWynikDodajFX_Ob.Text = "Dodano: ";
            // 
            // textBoxNazwaFX
            // 
            this.textBoxNazwaFX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.textBoxNazwaFX.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBoxNazwaFX.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxNazwaFX.Location = new System.Drawing.Point(112, 143);
            this.textBoxNazwaFX.Name = "textBoxNazwaFX";
            this.textBoxNazwaFX.Size = new System.Drawing.Size(203, 26);
            this.textBoxNazwaFX.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label16.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(39, 146);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 19);
            this.label16.TabIndex = 31;
            this.label16.Text = "Nazwa";
            // 
            // buttonZapiszFX
            // 
            this.buttonZapiszFX.Location = new System.Drawing.Point(221, 192);
            this.buttonZapiszFX.Name = "buttonZapiszFX";
            this.buttonZapiszFX.Size = new System.Drawing.Size(94, 32);
            this.buttonZapiszFX.TabIndex = 30;
            this.buttonZapiszFX.Text = "Zapisz";
            this.buttonZapiszFX.UseVisualStyleBackColor = true;
            this.buttonZapiszFX.Click += new System.EventHandler(this.buttonZapiszFX_Click);
            // 
            // comboBoxAkt
            // 
            this.comboBoxAkt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.comboBoxAkt.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pokazAktBindingSource, "idakt", true));
            this.comboBoxAkt.DataSource = this.pokazAktBindingSource;
            this.comboBoxAkt.DisplayMember = "nazwa";
            this.comboBoxAkt.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBoxAkt.ForeColor = System.Drawing.Color.LightGray;
            this.comboBoxAkt.FormattingEnabled = true;
            this.comboBoxAkt.Location = new System.Drawing.Point(112, 93);
            this.comboBoxAkt.Name = "comboBoxAkt";
            this.comboBoxAkt.Size = new System.Drawing.Size(203, 27);
            this.comboBoxAkt.TabIndex = 29;
            this.comboBoxAkt.ValueMember = "idakt";
            // 
            // comboBoxPrzedstawienie
            // 
            this.comboBoxPrzedstawienie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.comboBoxPrzedstawienie.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pokazPrzedstawienieBindingSource, "idprzed", true));
            this.comboBoxPrzedstawienie.DataSource = this.pokazPrzedstawienieBindingSource;
            this.comboBoxPrzedstawienie.DisplayMember = "nazwa";
            this.comboBoxPrzedstawienie.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBoxPrzedstawienie.ForeColor = System.Drawing.Color.LightGray;
            this.comboBoxPrzedstawienie.FormattingEnabled = true;
            this.comboBoxPrzedstawienie.Location = new System.Drawing.Point(112, 48);
            this.comboBoxPrzedstawienie.Name = "comboBoxPrzedstawienie";
            this.comboBoxPrzedstawienie.Size = new System.Drawing.Size(203, 27);
            this.comboBoxPrzedstawienie.TabIndex = 28;
            this.comboBoxPrzedstawienie.ValueMember = "idprzed";
            // 
            // richTextBoxOpisZapisFx
            // 
            this.richTextBoxOpisZapisFx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.richTextBoxOpisZapisFx.ForeColor = System.Drawing.Color.LightGray;
            this.richTextBoxOpisZapisFx.Location = new System.Drawing.Point(11, 253);
            this.richTextBoxOpisZapisFx.Name = "richTextBoxOpisZapisFx";
            this.richTextBoxOpisZapisFx.Size = new System.Drawing.Size(304, 331);
            this.richTextBoxOpisZapisFx.TabIndex = 27;
            this.richTextBoxOpisZapisFx.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label14.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(74, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 19);
            this.label14.TabIndex = 25;
            this.label14.Text = "Akt";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label15.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(7, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 19);
            this.label15.TabIndex = 23;
            this.label15.Text = "Przedstawienie: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label12.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(7, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 19);
            this.label12.TabIndex = 22;
            this.label12.Text = "Opis ";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(-313, -171);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(304, 392);
            this.richTextBox2.TabIndex = 21;
            this.richTextBox2.Text = "";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(60)))));
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.comboBox3);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(329, 598);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Jazda Programowa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(8, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Opis ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.richTextBox1.ForeColor = System.Drawing.Color.LightGray;
            this.richTextBox1.Location = new System.Drawing.Point(12, 193);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(304, 378);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.comboBox3.DataSource = this.pokazFxObrotowkaBindingSource;
            this.comboBox3.DisplayMember = "nazwa";
            this.comboBox3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBox3.ForeColor = System.Drawing.Color.LightGray;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(113, 105);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(203, 27);
            this.comboBox3.TabIndex = 18;
            this.comboBox3.ValueMember = "idfx_obrotowka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(-1, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "FX_Obrotówka";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.comboBox2.DataSource = this.pokazAktBindingSource;
            this.comboBox2.DisplayMember = "nazwa";
            this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBox2.ForeColor = System.Drawing.Color.LightGray;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(113, 62);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(203, 27);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.ValueMember = "idakt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(75, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Akt";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.comboBox1.DataSource = this.pokazPrzedstawienieBindingSource;
            this.comboBox1.DisplayMember = "nazwa";
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBox1.ForeColor = System.Drawing.Color.LightGray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 27);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "idprzed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Przedstawienie: ";
            // 
            // tabControlBazaDanych
            // 
            this.tabControlBazaDanych.Controls.Add(this.tabPage1);
            this.tabControlBazaDanych.Controls.Add(this.tabPage2);
            this.tabControlBazaDanych.Controls.Add(this.tabPage3);
            this.tabControlBazaDanych.Enabled = false;
            this.tabControlBazaDanych.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControlBazaDanych.Location = new System.Drawing.Point(996, 30);
            this.tabControlBazaDanych.Name = "tabControlBazaDanych";
            this.tabControlBazaDanych.SelectedIndex = 0;
            this.tabControlBazaDanych.Size = new System.Drawing.Size(337, 630);
            this.tabControlBazaDanych.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(329, 598);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Aktualizuj FX";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ObrotowkaPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.tabControlBazaDanych);
            this.Controls.Add(this.panelSterowanie);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ObrotowkaPanel";
            this.Size = new System.Drawing.Size(1350, 705);
            this.Load += new System.EventHandler(this.ObrotowkaPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelSterowanie.ResumeLayout(false);
            this.panelSterowanie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarJoystick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokazFxObrotowkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tWDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokazAktBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokazPrzedstawienieBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControlBazaDanych.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxPredkoscObrotowka;
        private System.Windows.Forms.TextBox textBoxPozycjaZadanaObrotowka;
        private System.Windows.Forms.TextBox textBoxPozycjaObrotowka;
        private System.Windows.Forms.Panel panelSterowanie;
        private System.Windows.Forms.Button buttonJazdaDoPozycji;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonJazdaTechniczna;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.Button buttonJazdaProgramowa;
        private System.Windows.Forms.BindingSource pokazAktBindingSource;
        private TWDataSet tWDataSet;
        private System.Windows.Forms.BindingSource pokazPrzedstawienieBindingSource;
        private TWDataSetTableAdapters.pokazPrzedstawienieTableAdapter pokazPrzedstawienieTableAdapter;
        private TWDataSetTableAdapters.pokazAktTableAdapter pokazAktTableAdapter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource pokazFxObrotowkaBindingSource;
        private TWDataSetTableAdapters.pokazFxObrotowkaTableAdapter pokazFxObrotowkaTableAdapter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlBazaDanych;
        private System.Windows.Forms.Button buttonZapiszFX;
        private System.Windows.Forms.ComboBox comboBoxAkt;
        private System.Windows.Forms.ComboBox comboBoxPrzedstawienie;
        private System.Windows.Forms.RichTextBox richTextBoxOpisZapisFx;
        private System.Windows.Forms.Label labelWynikDodajFX_Ob;
        private System.Windows.Forms.TextBox textBoxNazwaFX;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonLewo;
        private System.Windows.Forms.Button buttonPrawo;
        private System.Windows.Forms.TrackBar trackBarJoystick;
        private System.Windows.Forms.TabPage tabPage3;
    }
}
