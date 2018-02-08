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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBazaDanych = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pokazPrzedstawienieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tWDataSet = new Dyplom_Dariusz_Petasz_Z709.TWDataSet();
            this.pokazPrzedstawienieTableAdapter = new Dyplom_Dariusz_Petasz_Z709.TWDataSetTableAdapters.pokazPrzedstawienieTableAdapter();
            this.pokazWozkiTableAdapter = new Dyplom_Dariusz_Petasz_Z709.TWDataSetTableAdapters.pokazWozkiTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonJazdaDoPozycji = new System.Windows.Forms.Button();
            this.buttonJazdaTechniczna = new System.Windows.Forms.Button();
            this.buttonJoystick = new System.Windows.Forms.Button();
            this.panelJoystick = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarJoystick = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokazPrzedstawienieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tWDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelJoystick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarJoystick)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1430, 440);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pictureBox1_LoadCompleted);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageBazaDanych);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(10, 445);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 254);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPageBazaDanych
            // 
            this.tabPageBazaDanych.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.tabPageBazaDanych.Location = new System.Drawing.Point(4, 27);
            this.tabPageBazaDanych.Name = "tabPageBazaDanych";
            this.tabPageBazaDanych.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBazaDanych.Size = new System.Drawing.Size(592, 223);
            this.tabPageBazaDanych.TabIndex = 0;
            this.tabPageBazaDanych.Text = "Jazda Programowa";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(22)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(592, 223);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dodaj FX_Wózek";
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
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(261, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 130);
            this.button3.TabIndex = 10;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonJazdaDoPozycji);
            this.panel1.Controls.Add(this.buttonJazdaTechniczna);
            this.panel1.Controls.Add(this.buttonJoystick);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(606, 470);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 229);
            this.panel1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(33, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 35);
            this.button1.TabIndex = 19;
            this.button1.Text = "Programowa";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonJazdaDoPozycji
            // 
            this.buttonJazdaDoPozycji.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonJazdaDoPozycji.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonJazdaDoPozycji.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonJazdaDoPozycji.Location = new System.Drawing.Point(33, 68);
            this.buttonJazdaDoPozycji.Name = "buttonJazdaDoPozycji";
            this.buttonJazdaDoPozycji.Size = new System.Drawing.Size(161, 35);
            this.buttonJazdaDoPozycji.TabIndex = 18;
            this.buttonJazdaDoPozycji.Text = "Do pozycji";
            this.buttonJazdaDoPozycji.UseVisualStyleBackColor = false;
            // 
            // buttonJazdaTechniczna
            // 
            this.buttonJazdaTechniczna.BackColor = System.Drawing.Color.Maroon;
            this.buttonJazdaTechniczna.Enabled = false;
            this.buttonJazdaTechniczna.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonJazdaTechniczna.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonJazdaTechniczna.Location = new System.Drawing.Point(33, 17);
            this.buttonJazdaTechniczna.Name = "buttonJazdaTechniczna";
            this.buttonJazdaTechniczna.Size = new System.Drawing.Size(161, 35);
            this.buttonJazdaTechniczna.TabIndex = 17;
            this.buttonJazdaTechniczna.Text = "Manual";
            this.buttonJazdaTechniczna.UseVisualStyleBackColor = false;
            // 
            // buttonJoystick
            // 
            this.buttonJoystick.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonJoystick.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonJoystick.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonJoystick.Location = new System.Drawing.Point(33, 119);
            this.buttonJoystick.Name = "buttonJoystick";
            this.buttonJoystick.Size = new System.Drawing.Size(161, 35);
            this.buttonJoystick.TabIndex = 16;
            this.buttonJoystick.Text = "Joystick";
            this.buttonJoystick.UseVisualStyleBackColor = false;
            this.buttonJoystick.Click += new System.EventHandler(this.buttonJazdaProgramowa_Click);
            // 
            // panelJoystick
            // 
            this.panelJoystick.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelJoystick.Controls.Add(this.label3);
            this.panelJoystick.Controls.Add(this.label2);
            this.panelJoystick.Controls.Add(this.label1);
            this.panelJoystick.Controls.Add(this.trackBarJoystick);
            this.panelJoystick.Enabled = false;
            this.panelJoystick.Location = new System.Drawing.Point(1154, 467);
            this.panelJoystick.Name = "panelJoystick";
            this.panelJoystick.Size = new System.Drawing.Size(142, 232);
            this.panelJoystick.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(79, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "- 100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(79, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "- 100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(79, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "- 0";
            // 
            // trackBarJoystick
            // 
            this.trackBarJoystick.Location = new System.Drawing.Point(28, 3);
            this.trackBarJoystick.Maximum = 100;
            this.trackBarJoystick.Minimum = -100;
            this.trackBarJoystick.Name = "trackBarJoystick";
            this.trackBarJoystick.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarJoystick.Size = new System.Drawing.Size(45, 222);
            this.trackBarJoystick.TabIndex = 0;
            this.trackBarJoystick.TickFrequency = 10;
            this.trackBarJoystick.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarJoystick.Scroll += new System.EventHandler(this.trackBarJoystick_Scroll);
            this.trackBarJoystick.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarJoystick_MouseUp);
            // 
            // WozkiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelJoystick);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "WozkiForm";
            this.Text = "WozkiForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WozkiForm_FormClosing);
            this.Load += new System.EventHandler(this.WozkiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pokazPrzedstawienieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tWDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelJoystick.ResumeLayout(false);
            this.panelJoystick.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarJoystick)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBazaDanych;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBox1;
        private TWDataSet tWDataSet;
        private System.Windows.Forms.BindingSource pokazPrzedstawienieBindingSource;
        private TWDataSetTableAdapters.pokazPrzedstawienieTableAdapter pokazPrzedstawienieTableAdapter;
       
        private TWDataSetTableAdapters.pokazWozkiTableAdapter pokazWozkiTableAdapter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelJoystick;
        private System.Windows.Forms.TrackBar trackBarJoystick;
        private System.Windows.Forms.Button buttonJazdaDoPozycji;
        private System.Windows.Forms.Button buttonJazdaTechniczna;
        private System.Windows.Forms.Button buttonJoystick;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}