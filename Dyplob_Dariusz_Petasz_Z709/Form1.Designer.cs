namespace Dyplom_Dariusz_Petasz_Z709
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
            this.buttonKoniec = new System.Windows.Forms.Button();
            this.buttonWyloguj = new System.Windows.Forms.Button();
            this.buttonMosty = new System.Windows.Forms.Button();
            this.buttonWozki = new System.Windows.Forms.Button();
            this.buttonSztankiety = new System.Windows.Forms.Button();
            this.buttonZapadnie = new System.Windows.Forms.Button();
            this.buttonObrotowka = new System.Windows.Forms.Button();
            this.labelTextPrzyciski = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajPrzedstawienieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokazLoginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tWDataSet = new Dyplom_Dariusz_Petasz_Z709.TWDataSet();
            this.pokazLoginTableAdapter = new Dyplom_Dariusz_Petasz_Z709.TWDataSetTableAdapters.pokazLoginTableAdapter();
            this.panel_Glowny = new System.Windows.Forms.Panel();
            this.panelPrzyciski = new System.Windows.Forms.Panel();
            this.panelLogowanie = new System.Windows.Forms.Panel();
            this.comboBoxLogin = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelKom = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonWejscie = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokazLoginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tWDataSet)).BeginInit();
            this.panel_Glowny.SuspendLayout();
            this.panelPrzyciski.SuspendLayout();
            this.panelLogowanie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonKoniec
            // 
            this.buttonKoniec.BackColor = System.Drawing.Color.Brown;
            this.buttonKoniec.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonKoniec.FlatAppearance.BorderSize = 0;
            this.buttonKoniec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.buttonKoniec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKoniec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKoniec.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonKoniec.Location = new System.Drawing.Point(1123, 28);
            this.buttonKoniec.Name = "buttonKoniec";
            this.buttonKoniec.Size = new System.Drawing.Size(90, 37);
            this.buttonKoniec.TabIndex = 9;
            this.buttonKoniec.Text = "WYJŚCIE";
            this.buttonKoniec.UseVisualStyleBackColor = false;
            this.buttonKoniec.Click += new System.EventHandler(this.buttonKoniec_Click);
            // 
            // buttonWyloguj
            // 
            this.buttonWyloguj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(165)))), ((int)(((byte)(98)))));
            this.buttonWyloguj.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonWyloguj.FlatAppearance.BorderSize = 0;
            this.buttonWyloguj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.buttonWyloguj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWyloguj.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWyloguj.Location = new System.Drawing.Point(1004, 28);
            this.buttonWyloguj.Name = "buttonWyloguj";
            this.buttonWyloguj.Size = new System.Drawing.Size(90, 37);
            this.buttonWyloguj.TabIndex = 8;
            this.buttonWyloguj.Text = "Wyloguj";
            this.buttonWyloguj.UseVisualStyleBackColor = false;
            // 
            // buttonMosty
            // 
            this.buttonMosty.BackColor = System.Drawing.Color.Tan;
            this.buttonMosty.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.buttonMosty.FlatAppearance.BorderSize = 0;
            this.buttonMosty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(146)))), ((int)(((byte)(120)))));
            this.buttonMosty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMosty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMosty.Location = new System.Drawing.Point(879, 13);
            this.buttonMosty.Name = "buttonMosty";
            this.buttonMosty.Size = new System.Drawing.Size(90, 67);
            this.buttonMosty.TabIndex = 7;
            this.buttonMosty.Text = "Mosty";
            this.buttonMosty.UseVisualStyleBackColor = false;
            this.buttonMosty.Click += new System.EventHandler(this.buttonMosty_Click);
            // 
            // buttonWozki
            // 
            this.buttonWozki.BackColor = System.Drawing.Color.Tan;
            this.buttonWozki.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.buttonWozki.FlatAppearance.BorderSize = 0;
            this.buttonWozki.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(146)))), ((int)(((byte)(120)))));
            this.buttonWozki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWozki.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWozki.Location = new System.Drawing.Point(755, 13);
            this.buttonWozki.Name = "buttonWozki";
            this.buttonWozki.Size = new System.Drawing.Size(90, 67);
            this.buttonWozki.TabIndex = 6;
            this.buttonWozki.Text = "Wózki";
            this.buttonWozki.UseVisualStyleBackColor = false;
            this.buttonWozki.Click += new System.EventHandler(this.buttonWozki_Click);
            // 
            // buttonSztankiety
            // 
            this.buttonSztankiety.BackColor = System.Drawing.Color.Tan;
            this.buttonSztankiety.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.buttonSztankiety.FlatAppearance.BorderSize = 0;
            this.buttonSztankiety.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(146)))), ((int)(((byte)(120)))));
            this.buttonSztankiety.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSztankiety.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSztankiety.Location = new System.Drawing.Point(629, 13);
            this.buttonSztankiety.Name = "buttonSztankiety";
            this.buttonSztankiety.Size = new System.Drawing.Size(90, 67);
            this.buttonSztankiety.TabIndex = 5;
            this.buttonSztankiety.Text = "Sztankiety";
            this.buttonSztankiety.UseVisualStyleBackColor = false;
            // 
            // buttonZapadnie
            // 
            this.buttonZapadnie.BackColor = System.Drawing.Color.Tan;
            this.buttonZapadnie.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.buttonZapadnie.FlatAppearance.BorderSize = 0;
            this.buttonZapadnie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(146)))), ((int)(((byte)(120)))));
            this.buttonZapadnie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZapadnie.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZapadnie.Location = new System.Drawing.Point(508, 13);
            this.buttonZapadnie.Name = "buttonZapadnie";
            this.buttonZapadnie.Size = new System.Drawing.Size(90, 67);
            this.buttonZapadnie.TabIndex = 4;
            this.buttonZapadnie.Text = "Zapadnie";
            this.buttonZapadnie.UseVisualStyleBackColor = false;
            // 
            // buttonObrotowka
            // 
            this.buttonObrotowka.BackColor = System.Drawing.Color.Tan;
            this.buttonObrotowka.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.buttonObrotowka.FlatAppearance.BorderSize = 0;
            this.buttonObrotowka.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(146)))), ((int)(((byte)(120)))));
            this.buttonObrotowka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonObrotowka.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonObrotowka.Location = new System.Drawing.Point(386, 13);
            this.buttonObrotowka.Name = "buttonObrotowka";
            this.buttonObrotowka.Size = new System.Drawing.Size(94, 67);
            this.buttonObrotowka.TabIndex = 3;
            this.buttonObrotowka.Text = "Obrotówka";
            this.buttonObrotowka.UseVisualStyleBackColor = false;
            this.buttonObrotowka.Click += new System.EventHandler(this.buttonObrotowka_Click);
            // 
            // labelTextPrzyciski
            // 
            this.labelTextPrzyciski.AutoSize = true;
            this.labelTextPrzyciski.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTextPrzyciski.Location = new System.Drawing.Point(18, 13);
            this.labelTextPrzyciski.Name = "labelTextPrzyciski";
            this.labelTextPrzyciski.Size = new System.Drawing.Size(97, 20);
            this.labelTextPrzyciski.TabIndex = 1;
            this.labelTextPrzyciski.Text = "Wylogowany";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.GhostWhite;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.bazaToolStripMenuItem,
            this.widokToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.Enabled = false;
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // bazaToolStripMenuItem
            // 
            this.bazaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajPrzedstawienieToolStripMenuItem});
            this.bazaToolStripMenuItem.Enabled = false;
            this.bazaToolStripMenuItem.Name = "bazaToolStripMenuItem";
            this.bazaToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.bazaToolStripMenuItem.Text = "Baza";
            // 
            // dodajPrzedstawienieToolStripMenuItem
            // 
            this.dodajPrzedstawienieToolStripMenuItem.Name = "dodajPrzedstawienieToolStripMenuItem";
            this.dodajPrzedstawienieToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.dodajPrzedstawienieToolStripMenuItem.Text = "DodajPrzedstawienie";
            this.dodajPrzedstawienieToolStripMenuItem.Click += new System.EventHandler(this.dodajPrzedstawienieToolStripMenuItem_Click);
            // 
            // widokToolStripMenuItem
            // 
            this.widokToolStripMenuItem.Enabled = false;
            this.widokToolStripMenuItem.Name = "widokToolStripMenuItem";
            this.widokToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.widokToolStripMenuItem.Text = "Widok";
            // 
            // pokazLoginBindingSource
            // 
            this.pokazLoginBindingSource.DataMember = "pokazLogin";
            this.pokazLoginBindingSource.DataSource = this.tWDataSet;
            // 
            // tWDataSet
            // 
            this.tWDataSet.DataSetName = "TWDataSet";
            this.tWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pokazLoginTableAdapter
            // 
            this.pokazLoginTableAdapter.ClearBeforeFill = true;
            // 
            // panel_Glowny
            // 
            this.panel_Glowny.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.panel_Glowny.Controls.Add(this.panelPrzyciski);
            this.panel_Glowny.Controls.Add(this.panelLogowanie);
            this.panel_Glowny.Controls.Add(this.pictureBox1);
            this.panel_Glowny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Glowny.Location = new System.Drawing.Point(0, 24);
            this.panel_Glowny.Name = "panel_Glowny";
            this.panel_Glowny.Size = new System.Drawing.Size(1350, 705);
            this.panel_Glowny.TabIndex = 8;
            // 
            // panelPrzyciski
            // 
            this.panelPrzyciski.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelPrzyciski.Controls.Add(this.labelTextPrzyciski);
            this.panelPrzyciski.Controls.Add(this.buttonKoniec);
            this.panelPrzyciski.Controls.Add(this.buttonObrotowka);
            this.panelPrzyciski.Controls.Add(this.buttonWyloguj);
            this.panelPrzyciski.Controls.Add(this.buttonZapadnie);
            this.panelPrzyciski.Controls.Add(this.buttonMosty);
            this.panelPrzyciski.Controls.Add(this.buttonSztankiety);
            this.panelPrzyciski.Controls.Add(this.buttonWozki);
            this.panelPrzyciski.Enabled = false;
            this.panelPrzyciski.Location = new System.Drawing.Point(0, 0);
            this.panelPrzyciski.Name = "panelPrzyciski";
            this.panelPrzyciski.Size = new System.Drawing.Size(1347, 85);
            this.panelPrzyciski.TabIndex = 10;
            // 
            // panelLogowanie
            // 
            this.panelLogowanie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelLogowanie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLogowanie.Controls.Add(this.comboBoxLogin);
            this.panelLogowanie.Controls.Add(this.button2);
            this.panelLogowanie.Controls.Add(this.label1);
            this.panelLogowanie.Controls.Add(this.labelKom);
            this.panelLogowanie.Controls.Add(this.textBoxPassword);
            this.panelLogowanie.Controls.Add(this.buttonWejscie);
            this.panelLogowanie.Controls.Add(this.label2);
            this.panelLogowanie.Location = new System.Drawing.Point(610, 117);
            this.panelLogowanie.Name = "panelLogowanie";
            this.panelLogowanie.Size = new System.Drawing.Size(291, 292);
            this.panelLogowanie.TabIndex = 12;
            // 
            // comboBoxLogin
            // 
            this.comboBoxLogin.DataSource = this.pokazLoginBindingSource;
            this.comboBoxLogin.DisplayMember = "login";
            this.comboBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxLogin.FormattingEnabled = true;
            this.comboBoxLogin.Location = new System.Drawing.Point(138, 32);
            this.comboBoxLogin.Name = "comboBoxLogin";
            this.comboBoxLogin.Size = new System.Drawing.Size(121, 28);
            this.comboBoxLogin.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Brown;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(83, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 37);
            this.button2.TabIndex = 11;
            this.button2.Text = "WYJŚCIE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(46, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // labelKom
            // 
            this.labelKom.AutoSize = true;
            this.labelKom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKom.ForeColor = System.Drawing.Color.Red;
            this.labelKom.Location = new System.Drawing.Point(16, 235);
            this.labelKom.Name = "labelKom";
            this.labelKom.Size = new System.Drawing.Size(39, 20);
            this.labelKom.TabIndex = 6;
            this.labelKom.Text = "Text";
            this.labelKom.Visible = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPassword.Location = new System.Drawing.Point(138, 87);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(121, 26);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonWejscie
            // 
            this.buttonWejscie.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonWejscie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWejscie.Location = new System.Drawing.Point(83, 132);
            this.buttonWejscie.Name = "buttonWejscie";
            this.buttonWejscie.Size = new System.Drawing.Size(115, 35);
            this.buttonWejscie.TabIndex = 4;
            this.buttonWejscie.Text = "Zaloguj";
            this.buttonWejscie.UseVisualStyleBackColor = false;
            this.buttonWejscie.Click += new System.EventHandler(this.buttonWejscie_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(16, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = global::Dyplom_Dariusz_Petasz_Z709.Properties.Resources.TeatrWielki;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1350, 705);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel_Glowny);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System sterowania urządzeń scenicznych TW";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokazLoginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tWDataSet)).EndInit();
            this.panel_Glowny.ResumeLayout(false);
            this.panelPrzyciski.ResumeLayout(false);
            this.panelPrzyciski.PerformLayout();
            this.panelLogowanie.ResumeLayout(false);
            this.panelLogowanie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTextPrzyciski;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widokToolStripMenuItem;
        private System.Windows.Forms.Button buttonZapadnie;
        private System.Windows.Forms.Button buttonObrotowka;
        private System.Windows.Forms.Button buttonMosty;
        private System.Windows.Forms.Button buttonWozki;
        private System.Windows.Forms.Button buttonSztankiety;
        private System.Windows.Forms.Button buttonWyloguj;
        private System.Windows.Forms.Button buttonKoniec;
        private TWDataSet tWDataSet;
        private System.Windows.Forms.BindingSource pokazLoginBindingSource;
        private TWDataSetTableAdapters.pokazLoginTableAdapter pokazLoginTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem dodajPrzedstawienieToolStripMenuItem;
        private System.Windows.Forms.Panel panel_Glowny;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelKom;
        private System.Windows.Forms.Button buttonWejscie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLogowanie;
        private System.Windows.Forms.Panel panelPrzyciski;
    }
}

