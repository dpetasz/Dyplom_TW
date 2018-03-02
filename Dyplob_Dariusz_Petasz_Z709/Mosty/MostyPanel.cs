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
        bool joystick = false, doPozycji = false, manualna = false, programowa = false;
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
                    most.Width = 225;
                    most.Top = wys;
                    most.Left = szer;
                    szer += 230;
                    if (szer == 925) { szer = 5; wys = 320; }
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
            this.pokazMostyTableAdapter.Fill(this.twDataSet.pokazMosty);
            LadujMost();

        }
        void LadujBazaPrzedstawienie()
        {
            this.pokazPrzedstawienieTableAdapter.Fill(this.twDataSet.pokazPrzedstawienie);
        }



        void LadujProgramowa()
        {
            doPozycji = true;
            buttonJazdaDoPozycji.BackColor = Color.LightSteelBlue;
            buttonJazdaDoPozycji.Enabled = true;
            buttonStartStop.Enabled = true;

            joystick = false;
            buttonJoystick.BackColor = Color.LightSteelBlue;
            buttonJoystick.Enabled = true;

            manualna = false;
            buttonManual.BackColor = Color.LightSteelBlue;
            buttonManual.Enabled = true;


            programowa = true;
            buttonProgramowa.BackColor = Color.IndianRed;
            buttonProgramowa.Enabled = false;
            tabControlProgramowa.Enabled = true;
            LadujJazdaDoPozycji();
        }
        void LadujJoystick()
        {
            doPozycji = false;
            buttonJazdaDoPozycji.BackColor = Color.LightSteelBlue;
            buttonJazdaDoPozycji.Enabled = true;
            buttonStartStop.Enabled = false;
            Stop();

            joystick = true;
            buttonJoystick.BackColor = Color.IndianRed;
            buttonJoystick.Enabled = false;
            LadujJazdaJoystick();

            manualna = false;
            buttonManual.BackColor = Color.LightSteelBlue;
            buttonManual.Enabled = true;


            programowa = false;
            buttonProgramowa.BackColor = Color.LightSteelBlue;
            buttonProgramowa.Enabled = true;
            tabControlProgramowa.Enabled = false;
        }
        void LadujDoPozycji()
        {
            doPozycji = true;
            buttonJazdaDoPozycji.BackColor = Color.IndianRed;
            buttonJazdaDoPozycji.Enabled = false;
            buttonStartStop.Enabled = true;
            LadujJazdaDoPozycji();

            joystick = false;
            buttonJoystick.BackColor = Color.LightSteelBlue;
            buttonJoystick.Enabled = true;

            manualna = false;
            buttonManual.BackColor = Color.LightSteelBlue;
            buttonManual.Enabled = true;


            programowa = false;
            buttonProgramowa.BackColor = Color.LightSteelBlue;
            buttonProgramowa.Enabled = true;
            tabControlProgramowa.Enabled = false;
        }
        void LadujJazdaJoystick()
        {
            foreach (Most z in Most.ListaMost)
            {
                z.ZmianaAktywacjaJoystick();
            }
        }
        void LadujJazdaDoPozycji()
        {
            foreach (Most m in Most.ListaMost)
            {
                m.AktywujDoPozycji();
            }

        }
        void LadujJazdaProgramowa()
        {
            foreach (Most m in Most.ListaMost)
            {
                m.AktywujDoPozycji();
            }
        }
        void LadujJazdaManual()
        {
            foreach (Most z in Most.ListaMost)
            {
                z.ZmianaAktywacjaManual();
            }
        }
        void Start()
        {
            timer1.Enabled = true;
            buttonStartStop.BackColor = Color.IndianRed;
            buttonStartStop.Text = "Stop";
        }
        void Stop()
        {
            timer1.Enabled = false;
            buttonStartStop.BackColor = Color.Green;
            buttonStartStop.Text = "Start";
            foreach (Most m in Most.ListaMost)
            {
                if (m.Aktywacja == true)
                {
                    m.ZapiszPozycjaBaza();
                    m.Odswiez();
                }

            }
        }
        void LadujManual()
        {
            doPozycji = false;
            buttonJazdaDoPozycji.BackColor = Color.LightSteelBlue;
            buttonJazdaDoPozycji.Enabled = true;
            buttonStartStop.Enabled = false;
            Stop();

            joystick = false;
            buttonJoystick.BackColor = Color.LightSteelBlue;
            buttonJoystick.Enabled = true;

            manualna = true;
            buttonManual.BackColor = Color.IndianRed;
            buttonManual.Enabled = false;
            LadujJazdaManual();

            programowa = false;
            buttonProgramowa.BackColor = Color.LightSteelBlue;
            buttonProgramowa.Enabled = true;
            tabControlProgramowa.Enabled = false;
        }

        private void buttonJoystick_Click(object sender, EventArgs e)
        {
            LadujJoystick();


        }
        private void buttonPrgramowa_Click(object sender, EventArgs e)
        {
            LadujProgramowa();
            LadujBazaPrzedstawienie();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (joystick == true)
            {
                foreach (Most m in Most.ListaMost)
                {
                    if (m.Aktywacja == true )
                    {
                        m.JazdaJoystick();
                    }
                }
            }
            if (manualna == true)
            {
                foreach (Most m in Most.ListaMost)
                {
                    if (m.Aktywacja == true)
                    {
                        m.JazdaManual();
                    }
                }
            }
            if(doPozycji == true || programowa == true)
            {
                foreach (Most m in Most.ListaMost)
                {
                    if (m.Aktywacja == true)
                    {
                        m.JazdaDoPozycji();
                    }
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
                    m.SetPredkosc((trackBarJoystick.Value)*-1);
                    m.ZmianaKrancowa();
                    //m.Odswiez();
                }
            }
        }
        private void trackBarJoystick_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
            trackBarJoystick.Value = 0;
            foreach (Most m in Most.ListaMost)
            {
                if (m.Aktywacja == true)
                {
                    m.SetPredkosc(trackBarJoystick.Value);
                    m.ZapiszPozycjaBaza();
                    m.Odswiez();
                }
            }
        }


        private void buttonJazdaDoPozycji_Click(object sender, EventArgs e)
        {
            LadujDoPozycji();
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
            LadujManual();
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
                    textBoxWynik.Text = db.DodajFx_most_most(m.GetId(), idfx, m.GetPredkosc(), m.GetPozycja());
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
                foreach (Most m in Most.ListaMost)
                {
                    m.ladujBazaProgramowa(idFx_most);
                }
            }
            catch
            {


            }
        }

        private void buttonStartStop_MouseDown(object sender, MouseEventArgs e)
        {
            Start();
        }

        private void buttonStartStop_MouseUp(object sender, MouseEventArgs e)
        {
            Stop();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            int idFxMost = ((this.pokazFxMostrosnacoBindingSource.Current as DataRowView).Row as TWDataSet.pokazFx_Most_rosnacoRow).idfx_most;
            string x = db.AktualizujFx_most(idFxMost, textBoxNazwaFX.Text, richTextBox4.Text);
            ladujFx_Most();
            richTextBox4.Text += " " + x;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                int idfx = ((this.pokazFxMostmalejacoBindingSource.Current as DataRowView).Row as TWDataSet.pokazFx_Most_malejacoRow).idfx_most;
                foreach (Most m in Most.ListaMost)
                {
                    m.aktualizujFx_most_most(idfx);
                }
                ladujFx_Most_Most();
            }
            catch
            {


            }
        }


    }
}
