namespace Dyplom_Dariusz_Petasz_Z709
{
    partial class Most
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
            this.textBoxNazwa = new System.Windows.Forms.TextBox();
            this.buttonAktywacja = new System.Windows.Forms.Button();
            this.textBoxKD = new System.Windows.Forms.TextBox();
            this.textBoxKG = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBoxPozycja = new System.Windows.Forms.TextBox();
            this.textBoxPozycjaZadana = new System.Windows.Forms.TextBox();
            this.textBoxPredkosc = new System.Windows.Forms.TextBox();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.textBoxWynik = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNazwa
            // 
            this.textBoxNazwa.BackColor = System.Drawing.Color.Goldenrod;
            this.textBoxNazwa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNazwa.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.textBoxNazwa.Location = new System.Drawing.Point(36, 12);
            this.textBoxNazwa.Name = "textBoxNazwa";
            this.textBoxNazwa.ReadOnly = true;
            this.textBoxNazwa.Size = new System.Drawing.Size(186, 29);
            this.textBoxNazwa.TabIndex = 0;
            this.textBoxNazwa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonAktywacja
            // 
            this.buttonAktywacja.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonAktywacja.Location = new System.Drawing.Point(70, 56);
            this.buttonAktywacja.Name = "buttonAktywacja";
            this.buttonAktywacja.Size = new System.Drawing.Size(125, 31);
            this.buttonAktywacja.TabIndex = 1;
            this.buttonAktywacja.Text = "Aktywuj";
            this.buttonAktywacja.UseVisualStyleBackColor = false;
            this.buttonAktywacja.Click += new System.EventHandler(this.buttonAktywacja_Click);
            // 
            // textBoxKD
            // 
            this.textBoxKD.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBoxKD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxKD.Location = new System.Drawing.Point(0, 281);
            this.textBoxKD.Name = "textBoxKD";
            this.textBoxKD.Size = new System.Drawing.Size(30, 19);
            this.textBoxKD.TabIndex = 3;
            this.textBoxKD.Text = "K-D";
            this.textBoxKD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxKG
            // 
            this.textBoxKG.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBoxKG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKG.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxKG.Location = new System.Drawing.Point(0, 0);
            this.textBoxKG.Name = "textBoxKG";
            this.textBoxKG.Size = new System.Drawing.Size(30, 19);
            this.textBoxKG.TabIndex = 4;
            this.textBoxKG.Text = "K-G";
            this.textBoxKG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxKD);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBoxKG);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 300);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(2, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 250);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Moccasin;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(40, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(98, 25);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Aktualna pozycja";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Moccasin;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(40, 192);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(98, 25);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Pozycja zadana";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Moccasin;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(40, 224);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(98, 25);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "Prędkość";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPozycja
            // 
            this.textBoxPozycja.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPozycja.Location = new System.Drawing.Point(144, 160);
            this.textBoxPozycja.Name = "textBoxPozycja";
            this.textBoxPozycja.ReadOnly = true;
            this.textBoxPozycja.Size = new System.Drawing.Size(78, 26);
            this.textBoxPozycja.TabIndex = 11;
            // 
            // textBoxPozycjaZadana
            // 
            this.textBoxPozycjaZadana.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPozycjaZadana.Enabled = false;
            this.textBoxPozycjaZadana.Location = new System.Drawing.Point(144, 192);
            this.textBoxPozycjaZadana.Name = "textBoxPozycjaZadana";
            this.textBoxPozycjaZadana.Size = new System.Drawing.Size(78, 26);
            this.textBoxPozycjaZadana.TabIndex = 12;
            this.textBoxPozycjaZadana.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxPozycjaZadana_MouseClick);
            // 
            // textBoxPredkosc
            // 
            this.textBoxPredkosc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPredkosc.Location = new System.Drawing.Point(144, 224);
            this.textBoxPredkosc.Name = "textBoxPredkosc";
            this.textBoxPredkosc.ReadOnly = true;
            this.textBoxPredkosc.Size = new System.Drawing.Size(78, 26);
            this.textBoxPredkosc.TabIndex = 13;
            // 
            // buttonDown
            // 
            this.buttonDown.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonDown.BackgroundImage = global::Dyplom_Dariusz_Petasz_Z709.Properties.Resources.D;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDown.Location = new System.Drawing.Point(144, 102);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(66, 52);
            this.buttonDown.TabIndex = 10;
            this.buttonDown.UseVisualStyleBackColor = false;
            // 
            // buttonUp
            // 
            this.buttonUp.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonUp.BackgroundImage = global::Dyplom_Dariusz_Petasz_Z709.Properties.Resources.G;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUp.Location = new System.Drawing.Point(48, 102);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(66, 52);
            this.buttonUp.TabIndex = 9;
            this.buttonUp.UseVisualStyleBackColor = false;
            // 
            // textBoxWynik
            // 
            this.textBoxWynik.BackColor = System.Drawing.Color.Moccasin;
            this.textBoxWynik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWynik.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxWynik.Location = new System.Drawing.Point(42, 272);
            this.textBoxWynik.Name = "textBoxWynik";
            this.textBoxWynik.ReadOnly = true;
            this.textBoxWynik.Size = new System.Drawing.Size(180, 25);
            this.textBoxWynik.TabIndex = 22;
            this.textBoxWynik.Text = "Wynik";
            this.textBoxWynik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Most
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.textBoxWynik);
            this.Controls.Add(this.textBoxPredkosc);
            this.Controls.Add(this.textBoxPozycjaZadana);
            this.Controls.Add(this.textBoxPozycja);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonAktywacja);
            this.Controls.Add(this.textBoxNazwa);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Most";
            this.Size = new System.Drawing.Size(225, 300);
            this.Load += new System.EventHandler(this.Most_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNazwa;
        private System.Windows.Forms.Button buttonAktywacja;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxKD;
        private System.Windows.Forms.TextBox textBoxKG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.TextBox textBoxPozycja;
        private System.Windows.Forms.TextBox textBoxPozycjaZadana;
        private System.Windows.Forms.TextBox textBoxPredkosc;
        private System.Windows.Forms.TextBox textBoxWynik;
    }
}
