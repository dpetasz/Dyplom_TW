namespace Dyplom_Dariusz_Petasz_Z709.Mosty
{
    partial class MostyPanel
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
            this.panelMosty = new System.Windows.Forms.Panel();
            this.twDataSet = new Dyplom_Dariusz_Petasz_Z709.TWDataSet();
            this.pokazMostyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokazMostyTableAdapter = new Dyplom_Dariusz_Petasz_Z709.TWDataSetTableAdapters.pokazMostyTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.fxobrotowkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pokazAktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pokazPrzedstawienieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelJoystick = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBarJoystick = new System.Windows.Forms.TrackBar();
            this.buttonPrgramowa = new System.Windows.Forms.Button();
            this.buttonJazdaDoPozycji = new System.Windows.Forms.Button();
            this.buttonManual = new System.Windows.Forms.Button();
            this.buttonJoystick = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pokazPrzedstawienieTableAdapter = new Dyplom_Dariusz_Petasz_Z709.TWDataSetTableAdapters.pokazPrzedstawienieTableAdapter();
            this.pokazAktTableAdapter = new Dyplom_Dariusz_Petasz_Z709.TWDataSetTableAdapters.pokazAktTableAdapter();
            this.fx_obrotowkaTableAdapter = new Dyplom_Dariusz_Petasz_Z709.TWDataSetTableAdapters.Fx_obrotowkaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.twDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokazMostyBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fxobrotowkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokazAktBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokazPrzedstawienieBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelJoystick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarJoystick)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMosty
            // 
            this.panelMosty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(52)))));
            this.panelMosty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMosty.Location = new System.Drawing.Point(21, 45);
            this.panelMosty.Name = "panelMosty";
            this.panelMosty.Size = new System.Drawing.Size(930, 620);
            this.panelMosty.TabIndex = 0;
            // 
            // twDataSet
            // 
            this.twDataSet.DataSetName = "TWDataSet";
            this.twDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pokazMostyBindingSource
            // 
            this.pokazMostyBindingSource.DataMember = "pokazMosty";
            this.pokazMostyBindingSource.DataSource = this.twDataSet;
            // 
            // pokazMostyTableAdapter
            // 
            this.pokazMostyTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(969, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 701);
            this.panel1.TabIndex = 1;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(377, 416);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(40)))));
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Controls.Add(this.comboBox3);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.comboBox2);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(369, 383);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Jazda Programowa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(33, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Opis ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.richTextBox1.ForeColor = System.Drawing.Color.LightGray;
            this.richTextBox1.Location = new System.Drawing.Point(37, 192);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(304, 172);
            this.richTextBox1.TabIndex = 27;
            this.richTextBox1.Text = "";
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.comboBox3.DataSource = this.fxobrotowkaBindingSource;
            this.comboBox3.DisplayMember = "nazwa";
            this.comboBox3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBox3.ForeColor = System.Drawing.Color.LightGray;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(138, 104);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(203, 27);
            this.comboBox3.TabIndex = 26;
            this.comboBox3.ValueMember = "idfx_obrotowka";
            // 
            // fxobrotowkaBindingSource
            // 
            this.fxobrotowkaBindingSource.DataMember = "Fx_obrotowka";
            this.fxobrotowkaBindingSource.DataSource = this.twDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(24, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "FX_Most";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.comboBox2.DataSource = this.pokazAktBindingSource;
            this.comboBox2.DisplayMember = "nazwa";
            this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBox2.ForeColor = System.Drawing.Color.LightGray;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(138, 61);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(203, 27);
            this.comboBox2.TabIndex = 24;
            this.comboBox2.ValueMember = "idakt";
            // 
            // pokazAktBindingSource
            // 
            this.pokazAktBindingSource.DataMember = "pokazAkt";
            this.pokazAktBindingSource.DataSource = this.twDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(100, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 23;
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
            this.comboBox1.Location = new System.Drawing.Point(138, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 27);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.ValueMember = "idprzed";
            // 
            // pokazPrzedstawienieBindingSource
            // 
            this.pokazPrzedstawienieBindingSource.DataMember = "pokazPrzedstawienie";
            this.pokazPrzedstawienieBindingSource.DataSource = this.twDataSet;
            this.pokazPrzedstawienieBindingSource.CurrentChanged += new System.EventHandler(this.pokazPrzedstawienieBindingSource_CurrentChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Przedstawienie: ";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(40)))));
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(369, 383);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Dodaj Efekt";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panelJoystick);
            this.panel2.Controls.Add(this.buttonPrgramowa);
            this.panel2.Controls.Add(this.buttonJazdaDoPozycji);
            this.panel2.Controls.Add(this.buttonManual);
            this.panel2.Controls.Add(this.buttonJoystick);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 283);
            this.panel2.TabIndex = 0;
            // 
            // panelJoystick
            // 
            this.panelJoystick.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelJoystick.Controls.Add(this.label5);
            this.panelJoystick.Controls.Add(this.label6);
            this.panelJoystick.Controls.Add(this.label7);
            this.panelJoystick.Controls.Add(this.trackBarJoystick);
            this.panelJoystick.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelJoystick.Enabled = false;
            this.panelJoystick.Location = new System.Drawing.Point(280, 0);
            this.panelJoystick.Name = "panelJoystick";
            this.panelJoystick.Size = new System.Drawing.Size(95, 281);
            this.panelJoystick.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(42, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "- 100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(42, -2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "- 100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(42, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "- 0";
            // 
            // trackBarJoystick
            // 
            this.trackBarJoystick.Dock = System.Windows.Forms.DockStyle.Left;
            this.trackBarJoystick.Location = new System.Drawing.Point(0, 0);
            this.trackBarJoystick.Maximum = 100;
            this.trackBarJoystick.Minimum = -100;
            this.trackBarJoystick.Name = "trackBarJoystick";
            this.trackBarJoystick.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarJoystick.Size = new System.Drawing.Size(45, 277);
            this.trackBarJoystick.TabIndex = 0;
            this.trackBarJoystick.TickFrequency = 10;
            this.trackBarJoystick.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarJoystick.Scroll += new System.EventHandler(this.trackBarJoystick_Scroll);
            this.trackBarJoystick.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarJoystick_MouseUp);
            // 
            // buttonPrgramowa
            // 
            this.buttonPrgramowa.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonPrgramowa.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonPrgramowa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonPrgramowa.Location = new System.Drawing.Point(141, 54);
            this.buttonPrgramowa.Name = "buttonPrgramowa";
            this.buttonPrgramowa.Size = new System.Drawing.Size(112, 35);
            this.buttonPrgramowa.TabIndex = 24;
            this.buttonPrgramowa.Text = "Programowa";
            this.buttonPrgramowa.UseVisualStyleBackColor = false;
            // 
            // buttonJazdaDoPozycji
            // 
            this.buttonJazdaDoPozycji.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonJazdaDoPozycji.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonJazdaDoPozycji.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonJazdaDoPozycji.Location = new System.Drawing.Point(7, 54);
            this.buttonJazdaDoPozycji.Name = "buttonJazdaDoPozycji";
            this.buttonJazdaDoPozycji.Size = new System.Drawing.Size(112, 35);
            this.buttonJazdaDoPozycji.TabIndex = 23;
            this.buttonJazdaDoPozycji.Text = "Do pozycji";
            this.buttonJazdaDoPozycji.UseVisualStyleBackColor = false;
            this.buttonJazdaDoPozycji.Click += new System.EventHandler(this.buttonJazdaDoPozycji_Click);
            // 
            // buttonManual
            // 
            this.buttonManual.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonManual.Enabled = false;
            this.buttonManual.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonManual.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonManual.Location = new System.Drawing.Point(7, 3);
            this.buttonManual.Name = "buttonManual";
            this.buttonManual.Size = new System.Drawing.Size(112, 35);
            this.buttonManual.TabIndex = 22;
            this.buttonManual.Text = "Manual";
            this.buttonManual.UseVisualStyleBackColor = false;
            this.buttonManual.Click += new System.EventHandler(this.buttonManual_Click);
            // 
            // buttonJoystick
            // 
            this.buttonJoystick.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonJoystick.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonJoystick.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonJoystick.Location = new System.Drawing.Point(141, 3);
            this.buttonJoystick.Name = "buttonJoystick";
            this.buttonJoystick.Size = new System.Drawing.Size(112, 35);
            this.buttonJoystick.TabIndex = 21;
            this.buttonJoystick.Text = "Joystick";
            this.buttonJoystick.UseVisualStyleBackColor = false;
            this.buttonJoystick.Click += new System.EventHandler(this.buttonJoystick_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(63, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 125);
            this.button3.TabIndex = 20;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pokazPrzedstawienieTableAdapter
            // 
            this.pokazPrzedstawienieTableAdapter.ClearBeforeFill = true;
            // 
            // pokazAktTableAdapter
            // 
            this.pokazAktTableAdapter.ClearBeforeFill = true;
            // 
            // fx_obrotowkaTableAdapter
            // 
            this.fx_obrotowkaTableAdapter.ClearBeforeFill = true;
            // 
            // MostyPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.panelMosty);
            this.Controls.Add(this.panel1);
            this.Name = "MostyPanel";
            this.Size = new System.Drawing.Size(1346, 701);
            this.Load += new System.EventHandler(this.MostyPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.twDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokazMostyBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fxobrotowkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokazAktBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokazPrzedstawienieBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelJoystick.ResumeLayout(false);
            this.panelJoystick.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarJoystick)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TWDataSet twDataSet;
        private System.Windows.Forms.BindingSource pokazMostyBindingSource;
        private TWDataSetTableAdapters.pokazMostyTableAdapter pokazMostyTableAdapter;
        private System.Windows.Forms.Panel panelMosty;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPrgramowa;
        private System.Windows.Forms.Button buttonJazdaDoPozycji;
        private System.Windows.Forms.Button buttonManual;
        private System.Windows.Forms.Button buttonJoystick;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelJoystick;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBarJoystick;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource fxobrotowkaBindingSource;
        private System.Windows.Forms.BindingSource pokazAktBindingSource;
        private System.Windows.Forms.BindingSource pokazPrzedstawienieBindingSource;
        private TWDataSetTableAdapters.pokazPrzedstawienieTableAdapter pokazPrzedstawienieTableAdapter;
        private TWDataSetTableAdapters.pokazAktTableAdapter pokazAktTableAdapter;
        private TWDataSetTableAdapters.Fx_obrotowkaTableAdapter fx_obrotowkaTableAdapter;
    }
}
