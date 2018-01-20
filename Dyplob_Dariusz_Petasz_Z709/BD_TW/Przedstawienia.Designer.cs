namespace Dyplom_Dariusz_Petasz_Z709.BD_TW
{
    partial class Przedstawienia
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pokazPrzedstawienieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tWDataSet = new Dyplom_Dariusz_Petasz_Z709.TWDataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pokazAktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.pokazPrzedstawienieTableAdapter = new Dyplom_Dariusz_Petasz_Z709.TWDataSetTableAdapters.pokazPrzedstawienieTableAdapter();
            this.pokazAktTableAdapter = new Dyplom_Dariusz_Petasz_Z709.TWDataSetTableAdapters.pokazAktTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pokazPrzedstawienieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tWDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokazAktBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.pokazPrzedstawienieBindingSource;
            this.comboBox1.DisplayMember = "nazwa";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(165, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 27);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "idprzed";
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
            // comboBox2
            // 
            this.comboBox2.DataSource = this.pokazAktBindingSource;
            this.comboBox2.DisplayMember = "nazwa";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(165, 61);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(219, 27);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "idprzed";
            // 
            // pokazAktBindingSource
            // 
            this.pokazAktBindingSource.DataMember = "pokazAkt";
            this.pokazAktBindingSource.DataSource = this.tWDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(165, 114);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(219, 27);
            this.comboBox3.TabIndex = 2;
            // 
            // pokazPrzedstawienieTableAdapter
            // 
            this.pokazPrzedstawienieTableAdapter.ClearBeforeFill = true;
            // 
            // pokazAktTableAdapter
            // 
            this.pokazAktTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Przedstawienie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Akt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "FX";
            // 
            // Przedstawienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(94)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ForeColor = System.Drawing.Color.Gray;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Przedstawienia";
            this.Size = new System.Drawing.Size(956, 166);
            this.Load += new System.EventHandler(this.Przedstawienia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pokazPrzedstawienieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tWDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokazAktBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource pokazPrzedstawienieBindingSource;
        private TWDataSet tWDataSet;
        private TWDataSetTableAdapters.pokazPrzedstawienieTableAdapter pokazPrzedstawienieTableAdapter;
        private System.Windows.Forms.BindingSource pokazAktBindingSource;
        private TWDataSetTableAdapters.pokazAktTableAdapter pokazAktTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
