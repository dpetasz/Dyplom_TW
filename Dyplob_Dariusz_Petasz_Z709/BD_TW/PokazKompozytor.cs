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

        private void button1_Click(object sender, EventArgs e)
        {
            string kom = "";
            try
            {
                int idPrzed = ((this.pokazPrzedstawienieBindingSource.Current as DataRowView).Row as TWDataSet.pokazPrzedstawienieRow).idprzed;
                kom = db.DodajAkt(idPrzed, textBoxNazwaAktDodaj.Text, richTextBoxDodajOpisAkt.Text, TimeSpan.Parse(dateTimePickerDodajDlugosc.Text));
                labelWynikDodajAkt.Text = kom;
                ladujDane();
            }
            catch
            {
            }
        }
    }
}
