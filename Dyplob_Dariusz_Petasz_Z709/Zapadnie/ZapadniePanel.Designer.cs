namespace Dyplom_Dariusz_Petasz_Z709.Zapadnie
{
    partial class ZapadniePanel
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
            this.panelZapadnie = new System.Windows.Forms.Panel();
            this.twDataSet = new Dyplom_Dariusz_Petasz_Z709.TWDataSet();
            this.pokazZapadnieTableAdapter = new Dyplom_Dariusz_Petasz_Z709.TWDataSetTableAdapters.pokazZapadnieTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.twDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panelZapadnie
            // 
            this.panelZapadnie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(52)))));
            this.panelZapadnie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelZapadnie.Location = new System.Drawing.Point(13, 13);
            this.panelZapadnie.Name = "panelZapadnie";
            this.panelZapadnie.Size = new System.Drawing.Size(930, 674);
            this.panelZapadnie.TabIndex = 1;
            // 
            // twDataSet
            // 
            this.twDataSet.DataSetName = "TWDataSet";
            this.twDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pokazZapadnieTableAdapter
            // 
            this.pokazZapadnieTableAdapter.ClearBeforeFill = true;
            // 
            // ZapadniePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(32)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.panelZapadnie);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ZapadniePanel";
            this.Size = new System.Drawing.Size(1346, 701);
            this.Load += new System.EventHandler(this.ZapadniePanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.twDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelZapadnie;
        private TWDataSet twDataSet;
        private TWDataSetTableAdapters.pokazZapadnieTableAdapter pokazZapadnieTableAdapter;
    }
}
