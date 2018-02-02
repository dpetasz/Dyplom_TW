using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dyplom_Dariusz_Petasz_Z709.BD_TW
{
    public partial class PokazKompozytor : UserControl
    {
        IZapiszAkt db = new ZapiszAkt();
        public PokazKompozytor()
        {
            InitializeComponent();
        }

        private void PokazAkt_Load(object sender, EventArgs e)
        {
            ladujDane();
        }
        void ladujDane()
        {
            this.pokazPrzedstawienieTableAdapter.Fill(this.tWDataSet.pokazPrzedstawienie);
        }

        //przypisanie idPrzedstawienia dla wyświetlania aktu
        private void pokazPrzedstawienieBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                int idPrzed = ((this.pokazPrzedstawienieBindingSource.Current as DataRowView).Row as TWDataSet.pokazPrzedstawienieRow).idprzed;
                this.pokazAktTableAdapter.Fill(this.tWDataSet.pokazAkt, idPrzed);
            }
            catch (Exception)
            {


            }
        }

        //dodawanie nowego aktu
        private void button1_Click(object sender, EventArgs e)
        {
            string kom = "";
            try
            {
                int idPrzed = ((this.pokazPrzedstawienieBindingSource.Current as DataRowView).Row as TWDataSet.pokazPrzedstawienieRow).idprzed;
                kom = db.DodajAkt(idPrzed, textBoxNazwaAktDodaj.Text, richTextBoxDodajOpisAkt.Text, dateTimePickerDodajDlugosc.Text);
                labelWynikDodajAkt.Text = kom;
                ladujDane();
            }
            catch
            {
            }
        }

        private void textBoxNazwaAktualizuj_Click(object sender, EventArgs e)
        {
            textBoxNazwaAktualizuj.Text = "Akt ";
            
        }
        //Aktualizacja aktu
        private void button2_Click(object sender, EventArgs e)
        {
            string kom = "";
            try
            {
                
                int idPrzed = ((this.pokazPrzedstawienieBindingSource.Current as DataRowView).Row as TWDataSet.pokazPrzedstawienieRow).idprzed;
                int idAkt = ((this.pokazAktBindingSource.Current as DataRowView).Row as TWDataSet.pokazAktRow).idakt;
                kom = db.AktualizujAkt(idAkt,idPrzed, textBoxNazwaAktualizuj.Text, richTextBoxOpisAktualizuj.Text, dateTimePickerDlugoscAktualizuj.Text);
                labelWynikAktualizujAkt.Text = kom;
                ladujDane();
            }
            catch { }
            
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
