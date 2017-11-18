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

        IZapiszBazaPrzedstawienie db = new ZapiszBazaPrzedstawienie();
        //string przycisk = "";

        public Form_BazaDanych()
        {
            InitializeComponent();
        }

        private void Form_BazaDanych_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tWDataSet.pokazRodzaj' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'tWDataSet.pokazPrzedstawienie' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'tWDataSet.pokazKompozytor' table. You can move, or remove it, as needed.
            

            PokazDane();

        }

        void PokazDane()
        {
            this.pokazRodzajTableAdapter.Fill(this.tWDataSet.pokazRodzaj);
            this.pokazKompozytorTableAdapter.Fill(this.tWDataSet.pokazKompozytor);
            this.pokazRezyserTableAdapter.Fill(this.tWDataSet.pokazRezyser);
            this.pokazPrzedstawienieTableAdapter.Fill(this.tWDataSet.pokazPrzedstawienie);
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
            buttonZapisz.Enabled = true;
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            string kom = "";
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

        private void buttonDodajKomp_Click(object sender, EventArgs e)
        {
            przycisk = buttonDodajKomp.Text;
            labelWynikKomp.Text = "Wybrano Dodaj nowego reżysera.";
            textBoxNazwiskoKomp.Clear();
            textBoxImieKomp.Clear();
            textBoxImieKomp.Enabled = true;
            textBoxNazwiskoKomp.Enabled = true;
            buttonZapiszKomp.Enabled = true;
        }

        private void buttonZapiszKomp_Click(object sender, EventArgs e)
        {
            string kom = "";
            switch (przycisk)
            {
                case "Dodaj":
                    {
                        kom = db.ZapiszKompozytor(textBoxNazwiskoKomp.Text, textBoxImieKomp.Text);
                        labelWynikKomp.Text = kom;
                        PokazDane();
                        textBoxImieKomp.Enabled = false;
                        textBoxNazwiskoKomp.Enabled = false;
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

        private void buttonDodajRodzaj_Click(object sender, EventArgs e)
        {
            przycisk = buttonDodajRodzaj.Text;
            labelWynikRodzaj.Text = "Wybrano Dodaj nowy Rodzaj.";
            textBoxNazwaRodzaj.Clear();
            textBoxNazwaRodzaj.Enabled = true;
            buttonZapiszRodzaj.Enabled = true;
        }

        private void buttonZapiszRodzaj_Click(object sender, EventArgs e)
        {
            string kom = "";
            switch (przycisk)
            {
                case "Dodaj":
                    {
                        kom = db.ZapiszRodzaj(textBoxNazwaRodzaj.Text);
                        labelWynikRodzaj.Text = kom;
                        PokazDane();
                        textBoxNazwaRodzaj.Enabled = false;
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

        private void buttonZapiszPrzedstawienie_Click(object sender, EventArgs e)
        {
            string kom = "";
            int idRez = Convert.ToInt32(labelIdRezyser.Text),
                idKom = Convert.ToInt32(labelIdKompozytor.Text),
                idRodz = Convert.ToInt32(labelIdRodzaj.Text);
            
            kom = db.ZapiszPrzedstawienie(idKom,idRez,idRodz,textBoxNazwaPrzedstawienia.Text.ToString(), dateTimePickerDataPremiery.Value);
            labelWynikPrzedstawienie.Text = kom;
        }

        

        

        
    }
}
