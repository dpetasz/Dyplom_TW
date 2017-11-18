using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dyplob_Dariusz_Petasz_Z709
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
            // TODO: This line of code loads data into the 'tWDataSet.pokazLogin' table. You can move, or remove it, as needed.
            //this.pokazLoginTableAdapter.Fill(this.tWDataSet.pokazLogin);

        }

        private void buttonWejscie_Click(object sender, EventArgs e)
        {
            string kom = "";
            proceduryDB.logowanie(comboBoxLogin.Text, textBoxPassword.Text, ref kom);
            if (kom == "Zalogowany")
            {
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
            Obrotowka obrotowka = new Obrotowka();
            obrotowka.Show();
        }
    }
}
