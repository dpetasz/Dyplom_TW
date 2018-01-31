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
    public partial class PokazPrzedstawienia : UserControl
    {
        IZapiszBazaPrzedstawienie db = new ZapiszBazaPrzedstawienie();

        public PokazPrzedstawienia()
        {
            InitializeComponent();
        }

        private void Przedstawienia_Load(object sender, EventArgs e)
        {
            ladujDane();
        }
        void ladujDane()
        {
            this.pokazPrzedstawienieTableAdapter.Fill(this.tWDataSet.pokazPrzedstawienie);
            this.pokazKompozytorTableAdapter.Fill(this.tWDataSet.pokazKompozytor);
            this.pokazRezyserTableAdapter.Fill(this.tWDataSet.pokazRezyser);
            this.pokazRodzajTableAdapter.Fill(this.tWDataSet.pokazRodzaj);
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

        

        private void buttonZapiszNowePrzedstawienie_Click(object sender, EventArgs e)
        {
            string kom = "";
            try
            {
                int idRez = ((this.pokazRezyserBindingSource.Current as DataRowView).Row as TWDataSet.pokazRezyserRow).idrezyser,
                        idKom = ((this.pokazKompozytorBindingSource.Current as DataRowView).Row as TWDataSet.pokazKompozytorRow).idkompozytor,
                        idRodz = ((this.pokazRodzajBindingSource.Current as DataRowView).Row as TWDataSet.pokazRodzajRow).idrodzaj;
                kom = db.ZapiszPrzedstawienie(idKom, idRez, idRodz, textBoxNazwaPrzedstawieniaDodaj.Text.ToString(), dateTimePicker1.Value);
                labelWynikZpisz.Text = kom;
                ladujDane();
            }
            catch { }

        }
    }
}
