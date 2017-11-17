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
    public partial class Form_BazaDanych : Form
    {

        IZapiszBazaPrzedstawienie db;
        string przycisk = "";

        public Form_BazaDanych()
        {
            InitializeComponent();
        }

        private void Form_BazaDanych_Load(object sender, EventArgs e)
        {

            PokazDane();

        }

        void PokazDane()
        {
            this.pokazRezyserTableAdapter.Fill(this.tWDataSet.pokazRezyser);
            //this.pokazNowyRezTableAdapter.Fill(this.tWDataSet.pokazNowyRez);
        }

        

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            przycisk = buttonDodaj.Text;
            labelWynikRez.Text = "Wybrano Dodaj nowego reżysera.";
            textBoxNazwiskoRez.Clear();
            textBoxImieRez.Clear();
            textBoxImieRez.Enabled = true;
            textBoxNazwiskoRez.Enabled = true;
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            string kom = "";
            db = new ZapiszBazaPrzedstawienie();
            switch (przycisk)
            {
                case "Dodaj":
                    {
                        kom = db.ZapiszRezyser(textBoxNazwiskoRez.Text, textBoxImieRez.Text);
                        labelWynikRez.Text = kom;
                        PokazDane();
                        textBoxImieRez.Enabled = false;
                        textBoxNazwiskoRez.Enabled = false;
                        przycisk = "";
                        break;
                    }
                case "Aktualizuj":
                    {

                        break;
                    }
                default:
                    {
                        labelWynikRez.Text = "Nic nie wybrane";
                        break;
                    }

            }
        }
    }
}
