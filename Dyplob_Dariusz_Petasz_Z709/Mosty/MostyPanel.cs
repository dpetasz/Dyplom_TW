using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dyplom_Dariusz_Petasz_Z709.BD_TW;

namespace Dyplom_Dariusz_Petasz_Z709.Mosty
{
    public partial class MostyPanel : UserControl
    {
        Most most;
        IZapiszMost db = new ZapiszMost();
        public MostyPanel()
        {
            InitializeComponent();
        }
        void LadujMost()
        {

            int wys = 5;
            int szer = 5;
            foreach (DataRow m in twDataSet.pokazMosty.Rows)
            {
                float p = (float)(Convert.ToDouble(m["pozycja"].ToString()));
                string name = m["nazwa"].ToString();
                int vmax = Convert.ToInt32(m["predkosc_max"].ToString());
                int id = Convert.ToInt32(m["idmost"].ToString());
                float kd = (float)(Convert.ToDouble(m["krancowa_dol"].ToString()));
                float kg = (float)(Convert.ToDouble(m["krancowa_gora"].ToString()));
                int przych = Convert.ToInt32(m["przychamowanie"].ToString());
                if (szer < 700)
                {
                    most = new Most(id, name, p, vmax, przych);
                    most.Kg = kg;
                    most.Kd = kd;
                    most.Parent = panelMosty;
                    most.Top = wys;
                    most.Left = szer;
                    szer += 230;
                    if (szer == 925) { szer = 5; wys = 310; }
                }
                else
                {

                    most = new Most(id, name, p, vmax, przych);
                    most.Kg = kg;
                    most.Kd = kd;
                    most.Parent = panelMosty;
                    most.Top = wys;
                    most.Left = szer;
                    szer += 230;
                }


            }
        }

        private void MostyPanel_Load(object sender, EventArgs e)
        {
            //this.pokazWozkiTableAdapter.Fill(this.tWDataSet.pokazWozki);
            this.pokazMostyTableAdapter.Fill(this.twDataSet.pokazMosty);
            LadujMost();
            LadujBaza();

        }
        void LadujBaza()
        {
            this.pokazPrzedstawienieTableAdapter.Fill(this.twDataSet.pokazPrzedstawienie);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void trackBarJoystick_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
            trackBarJoystick.Value = 0;
            foreach (Most m in Most.ListaMost)
            {

                m.Predkosc = trackBarJoystick.Value;

                m.Odswiez();

            }
        }

        private void buttonJoystick_Click(object sender, EventArgs e)
        {
            if (panelJoystick.Enabled == true)
            {
                buttonJoystick.BackColor = Color.LightSteelBlue;
                panelJoystick.Enabled = false;
            }
            else
            {
                buttonJoystick.BackColor = Color.IndianRed;
                panelJoystick.Enabled = true;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Most m in Most.ListaMost)
            {
                if (m.Aktywacja == true)
                {


                    if (m.Pozycja > m.Kg && trackBarJoystick.Value > 0)
                    {
                        m.Aktywacja = false;
                        m.ZmianaAktywacja();
                        m.ZmianaKrancowa();
                    }
                    if (m.Pozycja < m.Kd && trackBarJoystick.Value < 0)
                    {
                        m.Aktywacja = false;
                        m.ZmianaAktywacja();
                        m.ZmianaKrancowa();
                    }
                    m.Joystick();
                }
            }
        }

        private void trackBarJoystick_Scroll(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            foreach (Most m in Most.ListaMost)
            {
                if (m.Aktywacja == true)
                {

                    m.Predkosc = trackBarJoystick.Value;
                    m.ZmianaKrancowa();

                    //m.Odswiez();
                }
            }
        }

        private void buttonJazdaDoPozycji_Click(object sender, EventArgs e)
        {

            foreach (Most m in Most.ListaMost)
            {
                m.ZmianaDoPozycji();
            }
        }

        private void pokazPrzedstawienieBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                int idPrzed = ((this.pokazPrzedstawienieBindingSource.Current as DataRowView).Row as TWDataSet.pokazPrzedstawienieRow).idprzed;
                this.pokazAktTableAdapter.Fill(this.twDataSet.pokazAkt, idPrzed);
            }
            catch (Exception)
            {


            }
        }

        private void buttonManual_Click(object sender, EventArgs e)
        {

        }
        void ladujFx_Most()
        {
            try
            {
                int idAkt = ((this.pokazAktBindingSource.Current as DataRowView).Row as TWDataSet.pokazAktRow).idakt;
                this.pokazFx_Most_malejacoTableAdapter.Fill(this.twDataSet.pokazFx_Most_malejaco, idAkt);
                this.pokazFx_Most_rosnacoTableAdapter.Fill(this.twDataSet.pokazFx_Most_rosnaco, idAkt);
            }
            catch
            {


            }
        }
        private void pokazAktBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ladujFx_Most();
        }

        private void buttonDodajFX_Click(object sender, EventArgs e)
        {
            try
            {
                int idAkt = ((this.pokazAktBindingSource.Current as DataRowView).Row as TWDataSet.pokazAktRow).idakt;
                textBoxWynik.Text = db.DodajFx_most(idAkt, richTextBoxOpisFXMost.Text);
                ladujFx_Most();
            }
            catch
            {


            }

        }

        private void buttonZapiszFx_most_most_Click(object sender, EventArgs e)
        {
            try
            {
                int idfx = ((this.pokazFxMostmalejacoBindingSource.Current as DataRowView).Row as TWDataSet.pokazFx_Most_malejacoRow).idfx_most;
                foreach (Most m in Most.ListaMost)
                {
                    textBoxWynik.Text = db.DodajFx_most_most(m.GetId(), idfx, m.Predkosc, m.Pozycja);
                    ladujFx_Most();
                }
            }
            catch
            {


            }
        }

        private void pokazFxMostrosnacoBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ladujFx_Most_Most();
        }
        void ladujFx_Most_Most()
        {
            try
            {
                int idFx_most = ((this.pokazFxMostrosnacoBindingSource.Current as DataRowView).Row as TWDataSet.pokazFx_Most_rosnacoRow).idfx_most;
                this.pokazFx_Most_MostTableAdapter.Fill(this.twDataSet.pokazFx_Most_Most, idFx_most);

            }
            catch
            {


            }
        }
    }
}
