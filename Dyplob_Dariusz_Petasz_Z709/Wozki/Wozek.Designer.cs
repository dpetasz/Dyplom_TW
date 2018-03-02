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
            this.buttonPrawo = new System.Windows.Forms.Button();
            this.buttonLewo = new System.Windows.Forms.Button();
            this.buttonAktywacja = new System.Windows.Forms.Button();
            this.textBoxPozycja = new System.Windows.Forms.TextBox();
            this.textBoxStop = new System.Windows.Forms.TextBox();
            this.textBoxPredkosc = new System.Windows.Forms.TextBox();
            this.tWDataSet = new Dyplom_Dariusz_Petasz_Z709.TWDataSet();
            this.pokazFxWozekWozekdlajednegoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokazFx_Wozek_Wozek_dlajednegoTableAdapter = new Dyplom_Dariusz_Petasz_Z709.TWDataSetTableAdapters.pokazFx_Wozek_Wozek_dlajednegoTableAdapter();
            this.panelPrzyciski.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tWDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokazFxWozekWozekdlajednegoBindingSource)).BeginInit();
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
            // textBoxStop
            // 
            this.textBoxStop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxStop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxStop.Location = new System.Drawing.Point(170, 35);
            this.textBoxStop.Name = "textBoxStop";
            this.textBoxStop.Size = new System.Drawing.Size(80, 26);
            this.textBoxStop.TabIndex = 14;
            // 
            // textBoxPredkosc
            // 
            this.textBoxPredkosc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPredkosc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPredkosc.Location = new System.Drawing.Point(170, 67);
            this.textBoxPredkosc.Name = "textBoxPredkosc";
            this.textBoxPredkosc.Size = new System.Drawing.Size(80, 26);
            this.textBoxPredkosc.TabIndex = 12;
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
            // Wozek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
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
    }
}
