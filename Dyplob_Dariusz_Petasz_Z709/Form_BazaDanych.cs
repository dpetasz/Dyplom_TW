using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dyplom_Dariusz_Petasz_Z709
{
    public partial class Form_BazaDanych : Form
    {

        IZapiszBazaPrzedstawienie db = new ZapiszBazaPrzedstawienie();
        Form1 f1 = new Form1();
        string przycisk = "";

        public Form_BazaDanych()
        {
            InitializeComponent();
        }
        public Form_BazaDanych(Form1 f)
        {
            InitializeComponent();
            f1 = f;
        }

        private void Form_BazaDanych_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tWDataSet1.pokazPrzedstawienie' table. You can move, or remove it, as needed.
            

            PokazDane();

        }

        void PokazDane()
        {
            this.pokazRodzajTableAdapter.Fill(this.tWDataSet.pokazRodzaj);
            this.pokazKompozytorTableAdapter.Fill(this.tWDataSet.pokazKompozytor);
            this.pokazRezyserTableAdapter.Fill(this.tWDataSet.pokazRezyser);
            this.pokazPrzedstawienieTableAdapter.Fill(this.tWDataSet1.pokazPrzedstawienie);

        }



        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            przycisk = buttonDodaj.Text;
            labelWynikRez.Text = "Wybrano Dodaj nowego reżysera.";
            textBoxNazwiskoRez.Clear();
            textBoxImieRez.Clear();
            textBoxImieRez.Enabled = true;
            textBoxNazwiskoRez.Enabled = true;

            buttonZapisz.Visible = true;
            buttonDodajPrzedstawienie.Visible = false;
            buttonAktualizujPrzedstawienie.Visible = false;
            buttonAnulujPrzedstawienie.Visible = true;
            
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

            switch (przycisk)
            {
                case "Dodaj":
                    {
                        int idRez = ((this.pokazRezyserBindingSource.Current as DataRowView).Row as TWDataSet.pokazRezyserRow).idrezyser,
                        idKom = ((this.pokazKompozytorBindingSource.Current as DataRowView).Row as TWDataSet.pokazKompozytorRow).idkompozytor,
                        idRodz = ((this.pokazRodzajBindingSource.Current as DataRowView).Row as TWDataSet.pokazRodzajRow).idrodzaj;

                        kom = db.ZapiszPrzedstawienie(idKom, idRez, idRodz, textBoxNazwaPrzedstawienia.Text.ToString(), dateTimePickerDataPremiery.Value);
                        labelWynikPrzedstawienie.Text = kom;
                        PokazDane();
                        comboBoxPrzedstawienieRezyser.Enabled = false;
                        comboBoxPrzedstawienieRezyser.Enabled = false;
                        comboBoxPrzedstawienieKompozytor.Enabled = false;
                        comboBoxPrzedstawienieRodzaj.Enabled = false;
                        textBoxNazwaPrzedstawienia.Enabled = false;
                        buttonZapiszPrzedstawienie.Visible = false;
                        dateTimePickerDataPremiery.Enabled = false;
                        dateTimePickerDlugoscPrzedstawienia.Enabled = false;
                        richTextBoxOpisPrzedstawienie.Enabled = false;

                        buttonDodajPrzedstawienie.Visible = true; ;
                        buttonAktualizujPrzedstawienie.Visible = true; 

                        przycisk = "";
                        PokazDane();
                        break;
                    }
                case "Aktualizuj":
                    {
                        int idRez = ((this.pokazRezyserBindingSource.Current as DataRowView).Row as TWDataSet.pokazRezyserRow).idrezyser,
                        idKom = ((this.pokazKompozytorBindingSource.Current as DataRowView).Row as TWDataSet.pokazKompozytorRow).idkompozytor,
                        idRodz = ((this.pokazRodzajBindingSource.Current as DataRowView).Row as TWDataSet.pokazRodzajRow).idrodzaj,
                        idPrzed = ((this.pokazPrzedstawienieBindingSource.Current as DataRowView).Row as TWDataSet.pokazPrzedstawienieRow).idprzed;
                        kom = db.AktualizujPrzedstawienie(idPrzed, idKom, idRez, idRodz, 
                            textBoxNazwaPrzedstawienia.Text.ToString(), dateTimePickerDataPremiery.Value, 
                            dateTimePickerDlugoscPrzedstawienia.Text, 
                            richTextBoxOpisPrzedstawienie.Text.ToString());
                        labelWynikPrzedstawienie.Text = kom;

                        buttonDodajPrzedstawienie.Visible = true; ;
                        buttonAktualizujPrzedstawienie.Visible = true; 

                        PokazDane();
                        break;
                    }

                default:
                    {
                        labelWynikRez.Text = "Nic nie wybrane";
                        break;
                    }

            }
        }

        private void buttonDodajPrzedstawienie_Click(object sender, EventArgs e)
        {
            przycisk = "Dodaj";

            comboBoxPrzedstawienieRezyser.Enabled = true;
            comboBoxPrzedstawienieRezyser.Enabled = true;
            comboBoxPrzedstawienieKompozytor.Enabled = true;
            comboBoxPrzedstawienieRodzaj.Enabled = true;

            textBoxNazwaPrzedstawienia.Enabled = true;
            textBoxNazwaPrzedstawienia.Text = "";
            
            dateTimePickerDataPremiery.Enabled = true;

            buttonZapiszPrzedstawienie.Visible = true;
            buttonAktualizujPrzedstawienie.Visible = false;
            buttonAnulujPrzedstawienie.Visible = true;
            buttonDodajPrzedstawienie.Visible = false;

        }

        private void buttonAktualizujPrzedstawienie_Click(object sender, EventArgs e)
        {
            przycisk = "Aktualizuj";
            comboBoxPrzedstawienieRezyser.Enabled = true;
            comboBoxPrzedstawienieRezyser.Enabled = true;
            comboBoxPrzedstawienieKompozytor.Enabled = true;
            comboBoxPrzedstawienieRodzaj.Enabled = true;
            textBoxNazwaPrzedstawienia.Enabled = true;
            
            dateTimePickerDataPremiery.Enabled = true;

            buttonZapiszPrzedstawienie.Visible = true;
            buttonAnulujPrzedstawienie.Visible = true;
            buttonDodajPrzedstawienie.Visible = false;
            buttonAktualizujPrzedstawienie.Visible = false;

            dateTimePickerDlugoscPrzedstawienia.Enabled = true;
            richTextBoxOpisPrzedstawienie.Enabled = true;
        }

        private void buttonAnulujPrzedstawienie_Click(object sender, EventArgs e)
        {
            PokazDane();
            comboBoxPrzedstawienieRezyser.Enabled = false;
            comboBoxPrzedstawienieRezyser.Enabled = false;
            comboBoxPrzedstawienieKompozytor.Enabled = false;
            comboBoxPrzedstawienieRodzaj.Enabled = false;
            textBoxNazwaPrzedstawienia.Enabled = false;
            
            dateTimePickerDataPremiery.Enabled = false;
            dateTimePickerDlugoscPrzedstawienia.Enabled = false;
            richTextBoxOpisPrzedstawienie.Enabled = false;

            buttonAnulujPrzedstawienie.Visible = false;
            buttonZapiszPrzedstawienie.Visible = false;
            buttonDodajPrzedstawienie.Visible = true; ;
            buttonAktualizujPrzedstawienie.Visible = true; ;
            przycisk = "";
        }

        private void Form_BazaDanych_FormClosing(object sender, FormClosingEventArgs e)
        {
            f1.Enabled = true;
        }
    }
}
