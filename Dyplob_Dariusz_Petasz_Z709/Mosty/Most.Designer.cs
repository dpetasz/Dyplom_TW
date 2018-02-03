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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNazwa
            // 
            this.textBoxNazwa.BackColor = System.Drawing.Color.Goldenrod;
            this.textBoxNazwa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNazwa.Location = new System.Drawing.Point(52, 6);
            this.textBoxNazwa.Name = "textBoxNazwa";
            this.textBoxNazwa.Size = new System.Drawing.Size(194, 26);
            this.textBoxNazwa.TabIndex = 0;
            // 
            // buttonAktywacja
            // 
            this.buttonAktywacja.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonAktywacja.Location = new System.Drawing.Point(74, 48);
            this.buttonAktywacja.Name = "buttonAktywacja";
            this.buttonAktywacja.Size = new System.Drawing.Size(125, 31);
            this.buttonAktywacja.TabIndex = 1;
            this.buttonAktywacja.Text = "Aktywuj";
            this.buttonAktywacja.UseVisualStyleBackColor = false;
            this.buttonAktywacja.Click += new System.EventHandler(this.buttonAktywacja_Click);
            // 
            // textBoxKD
            // 
            this.textBoxKD.BackColor = System.Drawing.Color.Green;
            this.textBoxKD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxKD.Location = new System.Drawing.Point(0, 1);
            this.textBoxKD.Name = "textBoxKD";
            this.textBoxKD.Size = new System.Drawing.Size(45, 19);
            this.textBoxKD.TabIndex = 3;
            this.textBoxKD.Text = "K-D";
            this.textBoxKD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxKG
            // 
            this.textBoxKG.BackColor = System.Drawing.Color.Green;
            this.textBoxKG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKG.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxKG.Location = new System.Drawing.Point(0, 0);
            this.textBoxKG.Name = "textBoxKG";
            this.textBoxKG.Size = new System.Drawing.Size(45, 19);
            this.textBoxKG.TabIndex = 4;
            this.textBoxKG.Text = "K-G";
            this.textBoxKG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(45, 290);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxKG);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(45, 20);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxKD);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 270);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(45, 20);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(45, 250);
            this.panel4.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(51, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(109, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Aktualna pozycja";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightBlue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(51, 205);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(109, 26);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Pozycja zadana";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.LightBlue;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(51, 237);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(109, 26);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "Prędkość";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox4.Location = new System.Drawing.Point(166, 173);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(78, 26);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox5.Location = new System.Drawing.Point(166, 205);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(78, 26);
            this.textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox6.Location = new System.Drawing.Point(166, 237);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(78, 26);
            this.textBox6.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CadetBlue;
            this.button2.BackgroundImage = global::Dyplom_Dariusz_Petasz_Z709.Properties.Resources.D;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(145, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 52);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.BackgroundImage = global::Dyplom_Dariusz_Petasz_Z709.Properties.Resources.G;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(64, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 52);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 250);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // Most
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonAktywacja);
            this.Controls.Add(this.textBoxNazwa);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Most";
            this.Size = new System.Drawing.Size(250, 290);
            this.Load += new System.EventHandler(this.Most_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}
