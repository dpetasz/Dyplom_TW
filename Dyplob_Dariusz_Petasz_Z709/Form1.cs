using Dyplom_Dariusz_Petasz_Z709.Wozki;
using Dyplom_Dariusz_Petasz_Z709.ScenaObrotowa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dyplom_Dariusz_Petasz_Z709.BD_TW;
using Dyplom_Dariusz_Petasz_Z709.Mosty;

namespace Dyplom_Dariusz_Petasz_Z709
{
    public partial class Form1 : Form
    {
        public static TWDataSetTableAdapters.QueriesTableAdapter proceduryDB = new TWDataSetTableAdapters.QueriesTableAdapter();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKoniec_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.pokazLoginTableAdapter.Fill(this.tWDataSet.pokazLogin);

            }
            catch (Exception)
            {

                
            }
            
            // TODO: This line of code loads data into the 'tWDataSet.pokazLogin' table. You can move, or remove it, as needed.

        }

       private void buttonWejscie_Click(object sender, EventArgs e)
        {
            string kom = "";
            proceduryDB.logowanie(comboBoxLogin.Text, textBoxPassword.Text, ref kom);
            if (kom == "Zalogowany")
            {
                plikToolStripMenuItem.Enabled = true;
                bazaToolStripMenuItem.Enabled = true;
                widokToolStripMenuItem.Enabled = true;
                panelLogowanie.Visible = false;
                panelPrzyciski.Enabled = true;
                labelTextPrzyciski.Text = kom + ": " + comboBoxLogin.Text;
                panelLogowanie.Visible = false;
                textBoxPassword.Clear();
            }
            else
            {
                labelKom.Visible = true;
                labelKom.Text = kom;
                textBoxPassword.Clear();
            }

        }

        private void buttonWyloguj_Click(object sender, EventArgs e)
        {
            panelLogowanie.Visible = true;
            panelPrzyciski.Enabled = false;
            labelTextPrzyciski.Text = "Wylogowany";
            labelKom.Visible = true;
            labelKom.Text = "";
            textBoxPassword.Clear();
        }

        private void buttonObrotowka_Click(object sender, EventArgs e)
        {
           /* ObrotowkaPanel obrotowka = new ObrotowkaPanel();
            obrotowka.Parent = panel_Glowny;*/
            pictureBox1.Visible = false;
            panelPrzyciski.Visible = false;
            ObrotowkaPanel O = new ObrotowkaPanel();
            O.Parent = panel_Glowny;
            /*Obrotowka obrotowka = new Obrotowka(this);
            this.Visible = false;
            obrotowka.Show();*/
            //obrotowka.Parent = Form1.ActiveForm;
        }

        private void dodajPrzedstawienieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BazaDanych baza = new BazaDanych();
            baza.Show();
            /*Form_BazaDanych baza = new Form_BazaDanych(this);
            this.Enabled = false;
            baza.Show();*/
        }

        private void buttonMosty_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            panelPrzyciski.Visible = false;
            MostyPanel m = new MostyPanel();
            m.Parent = panel_Glowny;
        }

        private void buttonWozki_Click(object sender, EventArgs e)
        {
            WozkiForm wozki = new WozkiForm(this);
            this.Visible = false;
            wozki.Show();
        }
    }
}
