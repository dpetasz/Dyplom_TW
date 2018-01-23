namespace Dyplom_Dariusz_Petasz_Z709.Wozki
{
    partial class WozkiForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBazaDanych = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.przedstawienia1 = new Dyplom_Dariusz_Petasz_Z709.BD_TW.Przedstawienia();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pokazPrzedstawienieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tWDataSet = new Dyplom_Dariusz_Petasz_Z709.TWDataSet();
            this.pokazPrzedstawienieTableAdapter = new Dyplom_Dariusz_Petasz_Z709.TWDataSetTableAdapters.pokazPrzedstawienieTableAdapter();
            this.pokazWozkiTableAdapter = new Dyplom_Dariusz_Petasz_Z709.TWDataSetTableAdapters.pokazWozkiTableAdapter();
            this.buttonAktywujW1 = new System.Windows.Forms.Button();
            this.buttonAktywujW2 = new System.Windows.Forms.Button();
            this.buttonAktywujW3 = new System.Windows.Forms.Button();
            this.buttonAktywujW4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokazPrzedstawienieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tWDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1440, 600);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pictureBox1_LoadCompleted);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Dyplom_Dariusz_Petasz_Z709.Properties.Resources.prowo;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(1204, 721);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Przód";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Dyplom_Dariusz_Petasz_Z709.Properties.Resources.lewo;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(1086, 721);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 41);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageBazaDanych);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(26, 630);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1058, 219);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPageBazaDanych
            // 
            this.tabPageBazaDanych.Location = new System.Drawing.Point(4, 22);
            this.tabPageBazaDanych.Name = "tabPageBazaDanych";
            this.tabPageBazaDanych.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBazaDanych.Size = new System.Drawing.Size(1050, 193);
            this.tabPageBazaDanych.TabIndex = 0;
            this.tabPageBazaDanych.Text = "tabPage1";
            this.tabPageBazaDanych.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1050, 193);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // przedstawienia1
            // 
            this.przedstawienia1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(94)))));
            this.przedstawienia1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.przedstawienia1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.przedstawienia1.ForeColor = System.Drawing.Color.Gray;
            this.przedstawienia1.Location = new System.Drawing.Point(26, 7);
            this.przedstawienia1.Margin = new System.Windows.Forms.Padding(4);
            this.przedstawienia1.Name = "przedstawienia1";
            this.przedstawienia1.Size = new System.Drawing.Size(956, 166);
            this.przedstawienia1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.pokazPrzedstawienieBindingSource;
            this.comboBox1.DisplayMember = "nazwa";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1498, 732);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "idprzed";
            // 
            // pokazPrzedstawienieBindingSource
            // 
            this.pokazPrzedstawienieBindingSource.DataMember = "pokazPrzedstawienie";
            this.pokazPrzedstawienieBindingSource.DataSource = this.tWDataSet;
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
            // pokazWozkiTableAdapter
            // 
            this.pokazWozkiTableAdapter.ClearBeforeFill = true;
            // 
            // buttonAktywujW1
            // 
            this.buttonAktywujW1.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonAktywujW1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAktywujW1.Location = new System.Drawing.Point(1185, 358);
            this.buttonAktywujW1.Name = "buttonAktywujW1";
            this.buttonAktywujW1.Size = new System.Drawing.Size(111, 33);
            this.buttonAktywujW1.TabIndex = 6;
            this.buttonAktywujW1.Text = "Atywuj W1";
            this.buttonAktywujW1.UseVisualStyleBackColor = false;
            this.buttonAktywujW1.Click += new System.EventHandler(this.buttonAktywujW1_Click);
            // 
            // buttonAktywujW2
            // 
            this.buttonAktywujW2.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonAktywujW2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAktywujW2.Location = new System.Drawing.Point(1185, 263);
            this.buttonAktywujW2.Name = "buttonAktywujW2";
            this.buttonAktywujW2.Size = new System.Drawing.Size(111, 33);
            this.buttonAktywujW2.TabIndex = 7;
            this.buttonAktywujW2.Text = "Atywuj W2";
            this.buttonAktywujW2.UseVisualStyleBackColor = false;
            this.buttonAktywujW2.Click += new System.EventHandler(this.buttonAktywujW2_Click);
            // 
            // buttonAktywujW3
            // 
            this.buttonAktywujW3.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonAktywujW3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAktywujW3.Location = new System.Drawing.Point(1185, 153);
            this.buttonAktywujW3.Name = "buttonAktywujW3";
            this.buttonAktywujW3.Size = new System.Drawing.Size(111, 33);
            this.buttonAktywujW3.TabIndex = 8;
            this.buttonAktywujW3.Text = "Atywuj W3";
            this.buttonAktywujW3.UseVisualStyleBackColor = false;
            this.buttonAktywujW3.Click += new System.EventHandler(this.buttonAktywuj3_Click);
            // 
            // buttonAktywujW4
            // 
            this.buttonAktywujW4.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonAktywujW4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAktywujW4.Location = new System.Drawing.Point(1185, 49);
            this.buttonAktywujW4.Name = "buttonAktywujW4";
            this.buttonAktywujW4.Size = new System.Drawing.Size(111, 33);
            this.buttonAktywujW4.TabIndex = 9;
            this.buttonAktywujW4.Text = "Atywuj W4";
            this.buttonAktywujW4.UseVisualStyleBackColor = false;
            this.buttonAktywujW4.Click += new System.EventHandler(this.buttonAktywujW4_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(1308, 721);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 43);
            this.button3.TabIndex = 10;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // WozkiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonAktywujW4);
            this.Controls.Add(this.buttonAktywujW3);
            this.Controls.Add(this.buttonAktywujW2);
            this.Controls.Add(this.buttonAktywujW1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "WozkiForm";
            this.Text = "WozkiForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WozkiForm_FormClosing);
            this.Load += new System.EventHandler(this.WozkiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pokazPrzedstawienieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tWDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBazaDanych;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBox1;
        private TWDataSet tWDataSet;
        private System.Windows.Forms.BindingSource pokazPrzedstawienieBindingSource;
        private TWDataSetTableAdapters.pokazPrzedstawienieTableAdapter pokazPrzedstawienieTableAdapter;
        private BD_TW.Przedstawienia przedstawienia1;
        private TWDataSetTableAdapters.pokazWozkiTableAdapter pokazWozkiTableAdapter;
        private System.Windows.Forms.Button buttonAktywujW1;
        private System.Windows.Forms.Button buttonAktywujW2;
        private System.Windows.Forms.Button buttonAktywujW3;
        private System.Windows.Forms.Button buttonAktywujW4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
    }
}