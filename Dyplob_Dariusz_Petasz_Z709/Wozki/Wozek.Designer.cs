namespace Dyplom_Dariusz_Petasz_Z709.Wozki
{
    partial class Wozek
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
            this.panelPrzyciski = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBoxPozycja = new System.Windows.Forms.TextBox();
            this.buttonPrawo = new System.Windows.Forms.Button();
            this.buttonLewo = new System.Windows.Forms.Button();
            this.buttonAktywacja = new System.Windows.Forms.Button();
            this.textBoxStop = new System.Windows.Forms.TextBox();
            this.textBoxPredkosc = new System.Windows.Forms.TextBox();
            this.tWDataSet = new Dyplom_Dariusz_Petasz_Z709.TWDataSet();
            this.pokazFxWozekWozekdlajednegoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokazFx_Wozek_Wozek_dlajednegoTableAdapter = new Dyplom_Dariusz_Petasz_Z709.TWDataSetTableAdapters.pokazFx_Wozek_Wozek_dlajednegoTableAdapter();
            this.panelPozycjaZadana = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelPredkosc = new System.Windows.Forms.Panel();
            this.buttonZamknijPanelPredkosc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarPredkosc = new System.Windows.Forms.TrackBar();
            this.labelPredkosc = new System.Windows.Forms.Label();
            this.panelPrzyciski.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tWDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokazFxWozekWozekdlajednegoBindingSource)).BeginInit();
            this.panelPozycjaZadana.SuspendLayout();
            this.panelPredkosc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPredkosc)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrzyciski
            // 
            this.panelPrzyciski.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.panelPrzyciski.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPrzyciski.Controls.Add(this.textBox2);
            this.panelPrzyciski.Controls.Add(this.textBox1);
            this.panelPrzyciski.Controls.Add(this.textBox3);
            this.panelPrzyciski.Controls.Add(this.textBoxPozycja);
            this.panelPrzyciski.Controls.Add(this.buttonPrawo);
            this.panelPrzyciski.Controls.Add(this.buttonLewo);
            this.panelPrzyciski.Controls.Add(this.buttonAktywacja);
            this.panelPrzyciski.Controls.Add(this.textBoxStop);
            this.panelPrzyciski.Controls.Add(this.textBoxPredkosc);
            this.panelPrzyciski.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPrzyciski.Location = new System.Drawing.Point(1088, 0);
            this.panelPrzyciski.Name = "panelPrzyciski";
            this.panelPrzyciski.Size = new System.Drawing.Size(262, 106);
            this.panelPrzyciski.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Moccasin;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(123, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(41, 25);
            this.textBox2.TabIndex = 22;
            this.textBox2.Text = "Poz.";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Moccasin;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(123, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(41, 25);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "Stop";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Moccasin;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(123, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(41, 25);
            this.textBox3.TabIndex = 20;
            this.textBox3.Text = "V";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPozycja
            // 
            this.textBoxPozycja.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPozycja.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPozycja.Location = new System.Drawing.Point(170, 3);
            this.textBoxPozycja.Name = "textBoxPozycja";
            this.textBoxPozycja.ReadOnly = true;
            this.textBoxPozycja.Size = new System.Drawing.Size(80, 26);
            this.textBoxPozycja.TabIndex = 16;
            // 
            // buttonPrawo
            // 
            this.buttonPrawo.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonPrawo.BackgroundImage = global::Dyplom_Dariusz_Petasz_Z709.Properties.Resources.P;
            this.buttonPrawo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPrawo.Location = new System.Drawing.Point(64, 41);
            this.buttonPrawo.Name = "buttonPrawo";
            this.buttonPrawo.Size = new System.Drawing.Size(54, 52);
            this.buttonPrawo.TabIndex = 19;
            this.buttonPrawo.UseVisualStyleBackColor = false;
            this.buttonPrawo.Click += new System.EventHandler(this.buttonPrawo_Click);
            // 
            // buttonLewo
            // 
            this.buttonLewo.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonLewo.BackgroundImage = global::Dyplom_Dariusz_Petasz_Z709.Properties.Resources.L;
            this.buttonLewo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLewo.Location = new System.Drawing.Point(4, 41);
            this.buttonLewo.Name = "buttonLewo";
            this.buttonLewo.Size = new System.Drawing.Size(54, 52);
            this.buttonLewo.TabIndex = 18;
            this.buttonLewo.UseVisualStyleBackColor = false;
            this.buttonLewo.Click += new System.EventHandler(this.buttonLewo_Click);
            // 
            // buttonAktywacja
            // 
            this.buttonAktywacja.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonAktywacja.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAktywacja.Location = new System.Drawing.Point(3, 3);
            this.buttonAktywacja.Name = "buttonAktywacja";
            this.buttonAktywacja.Size = new System.Drawing.Size(115, 37);
            this.buttonAktywacja.TabIndex = 17;
            this.buttonAktywacja.Text = "Aktywuj";
            this.buttonAktywacja.UseVisualStyleBackColor = false;
            this.buttonAktywacja.Click += new System.EventHandler(this.buttonAktywuj_Click);
            // 
            // textBoxStop
            // 
            this.textBoxStop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxStop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxStop.Location = new System.Drawing.Point(170, 35);
            this.textBoxStop.Name = "textBoxStop";
            this.textBoxStop.Size = new System.Drawing.Size(80, 26);
            this.textBoxStop.TabIndex = 14;
            this.textBoxStop.Click += new System.EventHandler(this.textBoxStop_Click);
            // 
            // textBoxPredkosc
            // 
            this.textBoxPredkosc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPredkosc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPredkosc.Location = new System.Drawing.Point(170, 67);
            this.textBoxPredkosc.Name = "textBoxPredkosc";
            this.textBoxPredkosc.Size = new System.Drawing.Size(80, 26);
            this.textBoxPredkosc.TabIndex = 12;
            this.textBoxPredkosc.Click += new System.EventHandler(this.textBoxPredkosc_Click);
            this.textBoxPredkosc.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.textBoxPredkosc_ChangeUICues);
            // 
            // tWDataSet
            // 
            this.tWDataSet.DataSetName = "TWDataSet";
            this.tWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pokazFxWozekWozekdlajednegoBindingSource
            // 
            this.pokazFxWozekWozekdlajednegoBindingSource.DataMember = "pokazFx_Wozek_Wozek_dlajednego";
            this.pokazFxWozekWozekdlajednegoBindingSource.DataSource = this.tWDataSet;
            // 
            // pokazFx_Wozek_Wozek_dlajednegoTableAdapter
            // 
            this.pokazFx_Wozek_Wozek_dlajednegoTableAdapter.ClearBeforeFill = true;
            // 
            // panelPozycjaZadana
            // 
            this.panelPozycjaZadana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(32)))));
            this.panelPozycjaZadana.Controls.Add(this.button14);
            this.panelPozycjaZadana.Controls.Add(this.button13);
            this.panelPozycjaZadana.Controls.Add(this.textBox4);
            this.panelPozycjaZadana.Controls.Add(this.button7);
            this.panelPozycjaZadana.Controls.Add(this.button8);
            this.panelPozycjaZadana.Controls.Add(this.button9);
            this.panelPozycjaZadana.Controls.Add(this.button6);
            this.panelPozycjaZadana.Controls.Add(this.button5);
            this.panelPozycjaZadana.Controls.Add(this.button4);
            this.panelPozycjaZadana.Controls.Add(this.button10);
            this.panelPozycjaZadana.Controls.Add(this.button11);
            this.panelPozycjaZadana.Controls.Add(this.button12);
            this.panelPozycjaZadana.Controls.Add(this.button3);
            this.panelPozycjaZadana.Controls.Add(this.button2);
            this.panelPozycjaZadana.Controls.Add(this.button1);
            this.panelPozycjaZadana.Location = new System.Drawing.Point(515, 0);
            this.panelPozycjaZadana.Name = "panelPozycjaZadana";
            this.panelPozycjaZadana.Size = new System.Drawing.Size(260, 106);
            this.panelPozycjaZadana.TabIndex = 24;
            this.panelPozycjaZadana.Visible = false;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(232, 0);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(30, 25);
            this.button14.TabIndex = 22;
            this.button14.Text = "X";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(172, 74);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(78, 26);
            this.button13.TabIndex = 19;
            this.button13.Text = "Zapisz";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox4.Location = new System.Drawing.Point(23, 78);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 18;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(186, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(30, 30);
            this.button7.TabIndex = 17;
            this.button7.Text = "C";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(186, 38);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(30, 30);
            this.button8.TabIndex = 16;
            this.button8.Text = ",";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(150, 38);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(30, 30);
            this.button9.TabIndex = 15;
            this.button9.Text = "0";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(114, 37);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(30, 30);
            this.button6.TabIndex = 14;
            this.button6.Text = "9";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(78, 38);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 30);
            this.button5.TabIndex = 13;
            this.button5.Text = "8";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(42, 38);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 30);
            this.button4.TabIndex = 12;
            this.button4.Text = "7";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(6, 37);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(30, 30);
            this.button10.TabIndex = 11;
            this.button10.Text = "6";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(150, 5);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(30, 30);
            this.button11.TabIndex = 10;
            this.button11.Text = "5";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(114, 5);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(30, 30);
            this.button12.TabIndex = 9;
            this.button12.Text = "4";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(78, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelPredkosc
            // 
            this.panelPredkosc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(52)))));
            this.panelPredkosc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPredkosc.Controls.Add(this.labelPredkosc);
            this.panelPredkosc.Controls.Add(this.buttonZamknijPanelPredkosc);
            this.panelPredkosc.Controls.Add(this.label3);
            this.panelPredkosc.Controls.Add(this.label2);
            this.panelPredkosc.Controls.Add(this.label1);
            this.panelPredkosc.Controls.Add(this.trackBarPredkosc);
            this.panelPredkosc.Location = new System.Drawing.Point(820, 3);
            this.panelPredkosc.Name = "panelPredkosc";
            this.panelPredkosc.Size = new System.Drawing.Size(262, 106);
            this.panelPredkosc.TabIndex = 25;
            this.panelPredkosc.Visible = false;
            // 
            // buttonZamknijPanelPredkosc
            // 
            this.buttonZamknijPanelPredkosc.Location = new System.Drawing.Point(223, 2);
            this.buttonZamknijPanelPredkosc.Name = "buttonZamknijPanelPredkosc";
            this.buttonZamknijPanelPredkosc.Size = new System.Drawing.Size(31, 26);
            this.buttonZamknijPanelPredkosc.TabIndex = 4;
            this.buttonZamknijPanelPredkosc.Text = "X";
            this.buttonZamknijPanelPredkosc.UseVisualStyleBackColor = true;
            this.buttonZamknijPanelPredkosc.Click += new System.EventHandler(this.buttonZamknijPanelPredkosc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(127, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "50";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(220, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "100";
            // 
            // trackBarPredkosc
            // 
            this.trackBarPredkosc.LargeChange = 1;
            this.trackBarPredkosc.Location = new System.Drawing.Point(3, 35);
            this.trackBarPredkosc.Maximum = 100;
            this.trackBarPredkosc.Name = "trackBarPredkosc";
            this.trackBarPredkosc.RightToLeftLayout = true;
            this.trackBarPredkosc.Size = new System.Drawing.Size(242, 45);
            this.trackBarPredkosc.TabIndex = 0;
            this.trackBarPredkosc.TickFrequency = 5;
            this.trackBarPredkosc.Scroll += new System.EventHandler(this.trackBarPredkosc_Scroll);
            this.trackBarPredkosc.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarPredkosc_MouseUp);
            // 
            // labelPredkosc
            // 
            this.labelPredkosc.AutoSize = true;
            this.labelPredkosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPredkosc.ForeColor = System.Drawing.Color.LightGray;
            this.labelPredkosc.Location = new System.Drawing.Point(127, 9);
            this.labelPredkosc.Name = "labelPredkosc";
            this.labelPredkosc.Size = new System.Drawing.Size(18, 20);
            this.labelPredkosc.TabIndex = 5;
            this.labelPredkosc.Text = "0";
            // 
            // Wozek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.panelPredkosc);
            this.Controls.Add(this.panelPozycjaZadana);
            this.Controls.Add(this.panelPrzyciski);
            this.DoubleBuffered = true;
            this.Name = "Wozek";
            this.Size = new System.Drawing.Size(1350, 106);
            this.Load += new System.EventHandler(this.Wozek_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Wozek_Paint);
            this.panelPrzyciski.ResumeLayout(false);
            this.panelPrzyciski.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tWDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokazFxWozekWozekdlajednegoBindingSource)).EndInit();
            this.panelPozycjaZadana.ResumeLayout(false);
            this.panelPozycjaZadana.PerformLayout();
            this.panelPredkosc.ResumeLayout(false);
            this.panelPredkosc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPredkosc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrzyciski;
        private System.Windows.Forms.Button buttonAktywacja;
        private System.Windows.Forms.TextBox textBoxPozycja;
        private System.Windows.Forms.TextBox textBoxStop;
        private System.Windows.Forms.TextBox textBoxPredkosc;
        private System.Windows.Forms.Button buttonPrawo;
        private System.Windows.Forms.Button buttonLewo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private TWDataSet tWDataSet;
        private System.Windows.Forms.BindingSource pokazFxWozekWozekdlajednegoBindingSource;
        private TWDataSetTableAdapters.pokazFx_Wozek_Wozek_dlajednegoTableAdapter pokazFx_Wozek_Wozek_dlajednegoTableAdapter;
        private System.Windows.Forms.Panel panelPozycjaZadana;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelPredkosc;
        private System.Windows.Forms.Button buttonZamknijPanelPredkosc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarPredkosc;
        private System.Windows.Forms.Label labelPredkosc;
    }
}
