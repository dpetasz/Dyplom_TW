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
            this.panelPrzyciski = new System.Windows.Forms.Panel();
            this.buttonPrawo = new System.Windows.Forms.Button();
            this.buttonLewo = new System.Windows.Forms.Button();
            this.buttonAktywuj = new System.Windows.Forms.Button();
            this.textBoxPozycja = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPredkosc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPrzyciski.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrzyciski
            // 
            this.panelPrzyciski.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelPrzyciski.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPrzyciski.Controls.Add(this.buttonPrawo);
            this.panelPrzyciski.Controls.Add(this.buttonLewo);
            this.panelPrzyciski.Controls.Add(this.buttonAktywuj);
            this.panelPrzyciski.Controls.Add(this.textBoxPozycja);
            this.panelPrzyciski.Controls.Add(this.label3);
            this.panelPrzyciski.Controls.Add(this.textBoxStop);
            this.panelPrzyciski.Controls.Add(this.label2);
            this.panelPrzyciski.Controls.Add(this.textBoxPredkosc);
            this.panelPrzyciski.Controls.Add(this.label1);
            this.panelPrzyciski.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPrzyciski.Location = new System.Drawing.Point(1100, 0);
            this.panelPrzyciski.Name = "panelPrzyciski";
            this.panelPrzyciski.Size = new System.Drawing.Size(300, 106);
            this.panelPrzyciski.TabIndex = 0;
            // 
            // buttonPrawo
            // 
            this.buttonPrawo.BackColor = System.Drawing.Color.Green;
            this.buttonPrawo.BackgroundImage = global::Dyplom_Dariusz_Petasz_Z709.Properties.Resources.P;
            this.buttonPrawo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPrawo.Location = new System.Drawing.Point(83, 41);
            this.buttonPrawo.Name = "buttonPrawo";
            this.buttonPrawo.Size = new System.Drawing.Size(62, 52);
            this.buttonPrawo.TabIndex = 19;
            this.buttonPrawo.UseVisualStyleBackColor = false;
            this.buttonPrawo.Click += new System.EventHandler(this.buttonPrawo_Click);
            // 
            // buttonLewo
            // 
            this.buttonLewo.BackColor = System.Drawing.Color.Green;
            this.buttonLewo.BackgroundImage = global::Dyplom_Dariusz_Petasz_Z709.Properties.Resources.L;
            this.buttonLewo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLewo.Location = new System.Drawing.Point(4, 41);
            this.buttonLewo.Name = "buttonLewo";
            this.buttonLewo.Size = new System.Drawing.Size(62, 52);
            this.buttonLewo.TabIndex = 18;
            this.buttonLewo.UseVisualStyleBackColor = false;
            this.buttonLewo.Click += new System.EventHandler(this.buttonLewo_Click);
            // 
            // buttonAktywuj
            // 
            this.buttonAktywuj.BackColor = System.Drawing.Color.Green;
            this.buttonAktywuj.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAktywuj.Location = new System.Drawing.Point(3, 3);
            this.buttonAktywuj.Name = "buttonAktywuj";
            this.buttonAktywuj.Size = new System.Drawing.Size(142, 37);
            this.buttonAktywuj.TabIndex = 17;
            this.buttonAktywuj.Text = "Aktywuj";
            this.buttonAktywuj.UseVisualStyleBackColor = false;
            this.buttonAktywuj.Click += new System.EventHandler(this.buttonAktywuj_Click);
            // 
            // textBoxPozycja
            // 
            this.textBoxPozycja.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPozycja.Location = new System.Drawing.Point(192, 67);
            this.textBoxPozycja.Name = "textBoxPozycja";
            this.textBoxPozycja.ReadOnly = true;
            this.textBoxPozycja.Size = new System.Drawing.Size(100, 26);
            this.textBoxPozycja.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(150, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Poz.";
            // 
            // textBoxStop
            // 
            this.textBoxStop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxStop.Location = new System.Drawing.Point(192, 35);
            this.textBoxStop.Name = "textBoxStop";
            this.textBoxStop.Size = new System.Drawing.Size(100, 26);
            this.textBoxStop.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(148, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Stop";
            // 
            // textBoxPredkosc
            // 
            this.textBoxPredkosc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPredkosc.Location = new System.Drawing.Point(192, 3);
            this.textBoxPredkosc.Name = "textBoxPredkosc";
            this.textBoxPredkosc.Size = new System.Drawing.Size(100, 26);
            this.textBoxPredkosc.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(166, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "V";
            // 
            // Wozek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.panelPrzyciski);
            this.DoubleBuffered = true;
            this.Name = "Wozek";
            this.Size = new System.Drawing.Size(1400, 106);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Wozek_Paint);
            this.panelPrzyciski.ResumeLayout(false);
            this.panelPrzyciski.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrzyciski;
        private System.Windows.Forms.Button buttonAktywuj;
        private System.Windows.Forms.TextBox textBoxPozycja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPredkosc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPrawo;
        private System.Windows.Forms.Button buttonLewo;
    }
}
