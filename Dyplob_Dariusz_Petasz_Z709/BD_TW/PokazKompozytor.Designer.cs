namespace Dyplom_Dariusz_Petasz_Z709.BD_TW
{
    partial class PokazKompozytor
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
            this.pokazPrzedstawienieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tWDataSet = new Dyplom_Dariusz_Petasz_Z709.TWDataSet();
            this.pokazPrzedstawienieTableAdapter = new Dyplom_Dariusz_Petasz_Z709.TWDataSetTableAdapters.pokazPrzedstawienieTableAdapter();
            this.pokazAktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokazAktTableAdapter = new Dyplom_Dariusz_Petasz_Z709.TWDataSetTableAdapters.pokazAktTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelWynikDodajAkt = new System.Windows.Forms.Label();
            this.dateTimePickerDodajDlugosc = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNazwaAktDodaj = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBoxDodajOpisAkt = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelWynikAktualizujAkt = new System.Windows.Forms.Label();
            this.dateTimePickerDlugoscAktualizuj = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxNazwaAktualizuj = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBoxOpisAktualizuj = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pokazPrzedstawienieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tWDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokazAktBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pokazPrzedstawienieBindingSource
            // 
            this.pokazPrzedstawienieBindingSource.DataMember = "pokazPrzedstawienie";
            this.pokazPrzedstawienieBindingSource.DataSource = this.tWDataSet;
            this.pokazPrzedstawienieBindingSource.CurrentChanged += new System.EventHandler(this.pokazPrzedstawienieBindingSource_CurrentChanged);
            // 
            // tWDataSet
            // 
            this.tWDataSet.DataSetName = "TWDataSet";
            this.tWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pokazPrzedstawienieTableAdapter
            // 
            this.pokazPrzedstawienieTableAdapter.ClearBeforeFill = true;
            // 
            // pokazAktBindingSource
            // 
            this.pokazAktBindingSource.DataMember = "pokazAkt";
            this.pokazAktBindingSource.DataSource = this.tWDataSet;
            // 
            // pokazAktTableAdapter
            // 
            this.pokazAktTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(950, 381);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(42)))));
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(942, 348);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Akt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(515, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 51;
            this.label4.Text = "Opis ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pokazAktBindingSource, "opis", true));
            this.richTextBox1.ForeColor = System.Drawing.Color.LightGray;
            this.richTextBox1.Location = new System.Drawing.Point(519, 53);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(400, 265);
            this.richTextBox1.TabIndex = 50;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(136, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 49;
            this.label3.Text = "Długość";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pokazAktBindingSource, "dlugosc", true));
            this.textBox5.ForeColor = System.Drawing.Color.LightGray;
            this.textBox5.Location = new System.Drawing.Point(202, 218);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(286, 26);
            this.textBox5.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(155, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 47;
            this.label2.Text = "Akt: ";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pokazPrzedstawienieBindingSource, "idprzed", true));
            this.comboBox2.DataSource = this.pokazAktBindingSource;
            this.comboBox2.DisplayMember = "nazwa";
            this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBox2.ForeColor = System.Drawing.Color.LightGray;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(202, 136);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(286, 27);
            this.comboBox2.TabIndex = 46;
            this.comboBox2.ValueMember = "idakt";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.comboBox1.DataSource = this.pokazPrzedstawienieBindingSource;
            this.comboBox1.DisplayMember = "nazwa";
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBox1.ForeColor = System.Drawing.Color.LightGray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(202, 54);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(286, 27);
            this.comboBox1.TabIndex = 45;
            this.comboBox1.ValueMember = "idprzed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(88, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "Przedstawienie: ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.tabPage2.Controls.Add(this.labelWynikDodajAkt);
            this.tabPage2.Controls.Add(this.dateTimePickerDodajDlugosc);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBoxNazwaAktDodaj);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.richTextBoxDodajOpisAkt);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.comboBox4);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(942, 348);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dodaj Akt";
            // 
            // labelWynikDodajAkt
            // 
            this.labelWynikDodajAkt.AutoSize = true;
            this.labelWynikDodajAkt.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelWynikDodajAkt.ForeColor = System.Drawing.Color.Red;
            this.labelWynikDodajAkt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelWynikDodajAkt.Location = new System.Drawing.Point(88, 13);
            this.labelWynikDodajAkt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWynikDodajAkt.Name = "labelWynikDodajAkt";
            this.labelWynikDodajAkt.Size = new System.Drawing.Size(48, 19);
            this.labelWynikDodajAkt.TabIndex = 63;
            this.labelWynikDodajAkt.Text = "Wynik";
            // 
            // dateTimePickerDodajDlugosc
            // 
            this.dateTimePickerDodajDlugosc.CalendarForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dateTimePickerDodajDlugosc.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dateTimePickerDodajDlugosc.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerDodajDlugosc.Location = new System.Drawing.Point(202, 216);
            this.dateTimePickerDodajDlugosc.Name = "dateTimePickerDodajDlugosc";
            this.dateTimePickerDodajDlugosc.ShowUpDown = true;
            this.dateTimePickerDodajDlugosc.Size = new System.Drawing.Size(286, 26);
            this.dateTimePickerDodajDlugosc.TabIndex = 62;
            this.dateTimePickerDodajDlugosc.Value = new System.DateTime(2018, 1, 31, 1, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 35);
            this.button1.TabIndex = 61;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNazwaAktDodaj
            // 
            this.textBoxNazwaAktDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.textBoxNazwaAktDodaj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pokazAktBindingSource, "nazwa", true));
            this.textBoxNazwaAktDodaj.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxNazwaAktDodaj.Location = new System.Drawing.Point(202, 140);
            this.textBoxNazwaAktDodaj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNazwaAktDodaj.Name = "textBoxNazwaAktDodaj";
            this.textBoxNazwaAktDodaj.Size = new System.Drawing.Size(286, 26);
            this.textBoxNazwaAktDodaj.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label5.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(515, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 19);
            this.label5.TabIndex = 59;
            this.label5.Text = "Opis ";
            // 
            // richTextBoxDodajOpisAkt
            // 
            this.richTextBoxDodajOpisAkt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.richTextBoxDodajOpisAkt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pokazAktBindingSource, "opis", true));
            this.richTextBoxDodajOpisAkt.ForeColor = System.Drawing.Color.LightGray;
            this.richTextBoxDodajOpisAkt.Location = new System.Drawing.Point(519, 53);
            this.richTextBoxDodajOpisAkt.Name = "richTextBoxDodajOpisAkt";
            this.richTextBoxDodajOpisAkt.Size = new System.Drawing.Size(400, 265);
            this.richTextBoxDodajOpisAkt.TabIndex = 58;
            this.richTextBoxDodajOpisAkt.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label6.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(136, 222);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 57;
            this.label6.Text = "Długość";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label7.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(109, 144);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 19);
            this.label7.TabIndex = 55;
            this.label7.Text = "Nazwa Aktu";
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.comboBox4.DataSource = this.pokazPrzedstawienieBindingSource;
            this.comboBox4.DisplayMember = "nazwa";
            this.comboBox4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBox4.ForeColor = System.Drawing.Color.LightGray;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(202, 54);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(286, 27);
            this.comboBox4.TabIndex = 53;
            this.comboBox4.ValueMember = "idprzed";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label8.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(88, 57);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 19);
            this.label8.TabIndex = 52;
            this.label8.Text = "Przedstawienie: ";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.tabPage3.Controls.Add(this.labelWynikAktualizujAkt);
            this.tabPage3.Controls.Add(this.dateTimePickerDlugoscAktualizuj);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.comboBox5);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.textBoxNazwaAktualizuj);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.richTextBoxOpisAktualizuj);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.comboBox3);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(942, 348);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Aktualizuj Akt";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // labelWynikAktualizujAkt
            // 
            this.labelWynikAktualizujAkt.AutoSize = true;
            this.labelWynikAktualizujAkt.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelWynikAktualizujAkt.ForeColor = System.Drawing.Color.Red;
            this.labelWynikAktualizujAkt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelWynikAktualizujAkt.Location = new System.Drawing.Point(26, 12);
            this.labelWynikAktualizujAkt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWynikAktualizujAkt.Name = "labelWynikAktualizujAkt";
            this.labelWynikAktualizujAkt.Size = new System.Drawing.Size(48, 19);
            this.labelWynikAktualizujAkt.TabIndex = 74;
            this.labelWynikAktualizujAkt.Text = "Wynik";
            // 
            // dateTimePickerDlugoscAktualizuj
            // 
            this.dateTimePickerDlugoscAktualizuj.CalendarForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dateTimePickerDlugoscAktualizuj.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dateTimePickerDlugoscAktualizuj.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pokazAktBindingSource, "dlugosc", true));
            this.dateTimePickerDlugoscAktualizuj.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerDlugoscAktualizuj.Location = new System.Drawing.Point(202, 216);
            this.dateTimePickerDlugoscAktualizuj.Name = "dateTimePickerDlugoscAktualizuj";
            this.dateTimePickerDlugoscAktualizuj.ShowUpDown = true;
            this.dateTimePickerDlugoscAktualizuj.Size = new System.Drawing.Size(286, 26);
            this.dateTimePickerDlugoscAktualizuj.TabIndex = 73;
            this.dateTimePickerDlugoscAktualizuj.Value = new System.DateTime(2018, 1, 31, 1, 0, 0, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label13.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(151, 111);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 19);
            this.label13.TabIndex = 72;
            this.label13.Text = "Akt";
            // 
            // comboBox5
            // 
            this.comboBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.comboBox5.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pokazPrzedstawienieBindingSource, "idprzed", true));
            this.comboBox5.DataSource = this.pokazAktBindingSource;
            this.comboBox5.DisplayMember = "nazwa";
            this.comboBox5.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBox5.ForeColor = System.Drawing.Color.LightGray;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(202, 108);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(286, 27);
            this.comboBox5.TabIndex = 71;
            this.comboBox5.ValueMember = "idakt";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(352, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 35);
            this.button2.TabIndex = 70;
            this.button2.Text = "Aktualizuj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxNazwaAktualizuj
            // 
            this.textBoxNazwaAktualizuj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.textBoxNazwaAktualizuj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pokazAktBindingSource, "nazwa", true));
            this.textBoxNazwaAktualizuj.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxNazwaAktualizuj.Location = new System.Drawing.Point(202, 162);
            this.textBoxNazwaAktualizuj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNazwaAktualizuj.Name = "textBoxNazwaAktualizuj";
            this.textBoxNazwaAktualizuj.Size = new System.Drawing.Size(286, 26);
            this.textBoxNazwaAktualizuj.TabIndex = 69;
            this.textBoxNazwaAktualizuj.Click += new System.EventHandler(this.textBoxNazwaAktualizuj_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label9.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(515, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 19);
            this.label9.TabIndex = 68;
            this.label9.Text = "Opis ";
            // 
            // richTextBoxOpisAktualizuj
            // 
            this.richTextBoxOpisAktualizuj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.richTextBoxOpisAktualizuj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pokazAktBindingSource, "opis", true));
            this.richTextBoxOpisAktualizuj.ForeColor = System.Drawing.Color.LightGray;
            this.richTextBoxOpisAktualizuj.Location = new System.Drawing.Point(519, 53);
            this.richTextBoxOpisAktualizuj.Name = "richTextBoxOpisAktualizuj";
            this.richTextBoxOpisAktualizuj.Size = new System.Drawing.Size(379, 265);
            this.richTextBoxOpisAktualizuj.TabIndex = 67;
            this.richTextBoxOpisAktualizuj.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label10.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(136, 222);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 19);
            this.label10.TabIndex = 66;
            this.label10.Text = "Długość";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label11.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(98, 166);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 19);
            this.label11.TabIndex = 64;
            this.label11.Text = "Nazwa Aktu";
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.comboBox3.DataSource = this.pokazPrzedstawienieBindingSource;
            this.comboBox3.DisplayMember = "nazwa";
            this.comboBox3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBox3.ForeColor = System.Drawing.Color.LightGray;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(202, 54);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(286, 27);
            this.comboBox3.TabIndex = 63;
            this.comboBox3.ValueMember = "idprzed";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label12.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(88, 57);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 19);
            this.label12.TabIndex = 62;
            this.label12.Text = "Przedstawienie: ";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1115, 348);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Usuń Akt";
            // 
            // PokazKompozytor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PokazKompozytor";
            this.Size = new System.Drawing.Size(950, 381);
            this.Load += new System.EventHandler(this.PokazAkt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pokazPrzedstawienieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tWDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokazAktBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource pokazPrzedstawienieBindingSource;
        private TWDataSet tWDataSet;
        private TWDataSetTableAdapters.pokazPrzedstawienieTableAdapter pokazPrzedstawienieTableAdapter;
        private System.Windows.Forms.BindingSource pokazAktBindingSource;
        private TWDataSetTableAdapters.pokazAktTableAdapter pokazAktTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelWynikDodajAkt;
        private System.Windows.Forms.DateTimePicker dateTimePickerDodajDlugosc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxNazwaAktDodaj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxDodajOpisAkt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxNazwaAktualizuj;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBoxOpisAktualizuj;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DateTimePicker dateTimePickerDlugoscAktualizuj;
        private System.Windows.Forms.Label labelWynikAktualizujAkt;
    }
}
