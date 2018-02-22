using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dyplom_Dariusz_Petasz_Z709.Urzadzenia;
using Dyplom_Dariusz_Petasz_Z709.BD_TW;

namespace Dyplom_Dariusz_Petasz_Z709.Zapadnie
{
    public partial class ZapadniePanel : UserControl
    {
        Zapadnia zapadnia;
        Graphics g;
        IZapiszZapadnia zapiszZapadnia = new ZapiszZapadnia();
        bool rozstaw = false, joystick = false, doPozycji = false, programowa = false, ryglowanie = true;
        
        public ZapadniePanel()
        {
            InitializeComponent();
        }

        private void ZapadniePanel_Load(object sender, EventArgs e)
        {
            this.pokazZapadnieTableAdapter.Fill(this.twDataSet.pokazZapadnie);
            this.pokazPrzedstawienieTableAdapter.Fill(this.twDataSet.pokazPrzedstawienie);
            LadujZapadnia();
            Stop();
        }
        void LadujZapadnia()
        {
            int szer = 3;
            foreach (DataRow z in twDataSet.pokazZapadnie.Rows)
            {
                float p = (float)(Convert.ToDouble(z["pozycja"].ToString()));
                float pp = (float)(Convert.ToDouble(z["pozycja_portal"].ToString()));
                string name = z["nazwa"].ToString();
                int vmax = Convert.ToInt32(z["predkosc_max"].ToString());
                int id = Convert.ToInt32(z["idzapadnia"].ToString());
                float kd = (float)(Convert.ToDouble(z["krancowa_dol"].ToString()));
                float kg = (float)(Convert.ToDouble(z["krancowa_gora"].ToString()));
                int przych = Convert.ToInt32(z["przychamowanie"].ToString());
                zapadnia = new Zapadnia(id, name, p, vmax, przych);
                zapadnia.Rygiel_1 = Convert.ToBoolean(z["rygiel_1"]);
                zapadnia.Rygiel_2 = Convert.ToBoolean(z["rygiel_2"]);
                zapadnia.Rygiel_3 = Convert.ToBoolean(z["rygiel_3"]);
                zapadnia.Sprzeganie = Convert.ToBoolean(z["sprzeganie"]);
                zapadnia.Kg = kg;
                zapadnia.Kd = kd;
                zapadnia.PozycjaPortal = pp;
                zapadnia.Parent = panelZapadnie;
                zapadnia.Width = 150;
                zapadnia.Top = 3;
                zapadnia.Left = szer;
                szer += 154;
            }
        }
        void LadujDoPozycji()
        {
            doPozycji = true;
            buttonJazdaDoPozycji.BackColor = Color.IndianRed;
            buttonJazdaDoPozycji.Enabled = false;
            LadujJazdaDoPozycji();

            joystick = false;
            buttonJoystick.BackColor = Color.LightSteelBlue;
            buttonJoystick.Enabled = true;

            rozstaw = false;
            buttonRozstaw.BackColor = Color.LightSteelBlue;
            buttonRozstaw.Enabled = true;


            programowa = false;
            buttonPrgramowa.BackColor = Color.LightSteelBlue;
            buttonPrgramowa.Enabled = true;
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

            rozstaw = false;
            buttonRozstaw.BackColor = Color.LightSteelBlue;
            buttonRozstaw.Enabled = true;


            programowa = false;
            buttonPrgramowa.BackColor = Color.LightSteelBlue;
            buttonPrgramowa.Enabled = true;
        }
        void LadujRozstaw()
        {
            doPozycji = false;
            buttonJazdaDoPozycji.BackColor = Color.LightSteelBlue;
            buttonJazdaDoPozycji.Enabled = true;
            buttonStartStop.Enabled = false;
            Stop();

            joystick = false;
            buttonJoystick.BackColor = Color.LightSteelBlue;
            buttonJoystick.Enabled = true;

            rozstaw = true;
            buttonRozstaw.BackColor = Color.IndianRed;
            buttonRozstaw.Enabled = false;
            LadujJazdaRozstaw();

            programowa = false;
            buttonPrgramowa.BackColor = Color.LightSteelBlue;
            buttonPrgramowa.Enabled = true;
        }
        void LadujProgramowa()
        {
            doPozycji = false;
            buttonJazdaDoPozycji.BackColor = Color.LightSteelBlue;
            buttonJazdaDoPozycji.Enabled = true;

            joystick = false;
            buttonJoystick.BackColor = Color.LightSteelBlue;
            buttonJoystick.Enabled = true;

            rozstaw = false;
            buttonRozstaw.BackColor = Color.LightSteelBlue;
            buttonRozstaw.Enabled = true;


            programowa = true;
            buttonPrgramowa.BackColor = Color.IndianRed;
            buttonPrgramowa.Enabled = false;
            LadujJazdaDoPozycji();
        }
        void LadujJazdaDoPozycji()
        {
            
            foreach (Zapadnia z in Zapadnia.ListaZapadnia)
            {
                z.AktywujDoPozycji();
            }
        }
        void LadujJazdaRozstaw()
        {

            foreach (Zapadnia z in Zapadnia.ListaZapadnia)
            {
                z.ZmianaAktywacjaRozstaw();

            }
        }
        void LadujJazdaJoystick()
        {
            foreach (Zapadnia z in Zapadnia.ListaZapadnia)
            {
                z.ZmianaAktywacjaJoystick();
            }
        }
        private void buttonJoystick_Click(object sender, EventArgs e)
        {
            LadujJoystick();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {


            if (joystick == true)
            {
                foreach (Zapadnia z in Zapadnia.ListaZapadnia)
                {
                    if (z.Aktywacja == true)
                    {
                        z.JazdaJoystick();
                    }
                }
            }
            if (rozstaw == true)
            {
                foreach (Zapadnia z in Zapadnia.ListaZapadnia)
                {
                    if (z.Aktywacja == true && z.Rozstaw == true)
                    {

                        z.JazdaRozstaw();
                    }
                }
            }

            if (doPozycji == true)
            {
                foreach (Zapadnia z in Zapadnia.ListaZapadnia)
                {
                    if (z.DoPozycji == true && z.Aktywacja == true)
                    {
                        z.JazdaDoPozycji();
                    }


                }
            }
        }


        private void trackBarJoystick_Scroll(object sender, EventArgs e)
        {
            if (doPozycji == true)
            {
                timer1.Enabled = true;
                foreach (Zapadnia z in Zapadnia.ListaZapadnia)
                {
                    if (z.Aktywacja == true)
                    {
                        z.Predkosc = trackBarJoystick.Value;
                    }
                }
            }
            if (joystick == true)
            {
                timer1.Enabled = true;
                foreach (Zapadnia z in Zapadnia.ListaZapadnia)
                {
                    if (z.Aktywacja == true)
                    {
                        z.Predkosc = trackBarJoystick.Value;
                    }
                }
            }
            if (rozstaw == true)
            {
                timer1.Enabled = true;
                foreach (Zapadnia z in Zapadnia.ListaZapadnia)
                {
                    if (z.Aktywacja == true && z.Rozstaw == true)
                    {
                        //z.AktywujRozstaw();
                        z.Predkosc = trackBarJoystick.Value;
                        z.Odswiez();
                    }
                }
            }

        }

        private void trackBarJoystick_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
            trackBarJoystick.Value = 0;
            foreach (Zapadnia z in Zapadnia.ListaZapadnia)
            {
                if (z.Aktywacja == true)
                {
                    z.Predkosc = trackBarJoystick.Value;
                    z.Odswiez();
                }

            }
        }

        private void buttonRozstaw_Click(object sender, EventArgs e)
        {
            LadujRozstaw();
        }

        private void buttonJazdaDoPozycji_Click(object sender, EventArgs e)
        {
            LadujDoPozycji();

        }


        void StartStop()
        {

            if (timer1.Enabled == false)
            {
                Start();
            }
            else
            {
                Stop();
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
        }

        private void buttonStartStop_MouseDown(object sender, MouseEventArgs e)
        {
            Start();
        }

        private void buttonStartStop_MouseUp(object sender, MouseEventArgs e)
        {
            Stop();
        }

        private void buttonPrgramowa_Click(object sender, EventArgs e)
        {
            LadujProgramowa();
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            StartStop();
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

        private void buttonDodajFX_Click(object sender, EventArgs e)
        {
            int id = ((this.pokazAktBindingSource.Current as DataRowView).Row as TWDataSet.pokazAktRow).idakt;
            textBoxWynik.Text = zapiszZapadnia.ZapiszFX_Zapadnia(id,"");
            LadujFx_Zapadnia();
        }

        private void pokazAktBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            LadujFx_Zapadnia();
        }
        void LadujFx_Zapadnia()
        {
            try
            {
                int idAkt = ((this.pokazAktBindingSource.Current as DataRowView).Row as TWDataSet.pokazAktRow).idakt;
                this.pokazFx_ZapadniaTableAdapter.Fill(this.twDataSet.pokazFx_Zapadnia, idAkt);
            }
            catch (Exception)
            {

            }
        }
        void LadujFx_Zapadnia_Zapadnia()
        {
            try
            {
                int idFx = ((this.pokazFxZapadniaBindingSource.Current as DataRowView).Row as TWDataSet.pokazFx_ZapadniaRow).idfx_zapadnia;
                this.pokazFx_Zapadnia_ZapadniaTableAdapter.Fill(this.twDataSet.pokazFx_Zapadnia_Zapadnia, idFx);
            }
            catch (Exception)
            {

            }
        }

        private void buttonZapiszFx_zap_zap_Click(object sender, EventArgs e)
        {
            try
            {
                int idfx = ((this.pokazFxZapadniaBindingSource.Current as DataRowView).Row as TWDataSet.pokazFx_ZapadniaRow).idfx_zapadnia;
                foreach (Zapadnia z in Zapadnia.ListaZapadnia)
                {
                    textBoxWynik.Text = zapiszZapadnia.ZapiszFX_Zapadnia_Zapadnia(z.Id, idfx, z.Predkosc, z.Pozycja, z.Sprzeganie, z.Aktywacja);
                    LadujFx_Zapadnia();
                }
            }
            catch
            {

            }
        }

        private void pokazFxZapadniaBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            LadujFx_Zapadnia_Zapadnia();
        }

        private void buttonOdryglowanie_Click(object sender, EventArgs e)
        {
            if (ryglowanie == true) Odryglowanie();
            else Ryglowanie();
            
        }

        void Ryglowanie()
        {
            foreach (Zapadnia z in Zapadnia.ListaZapadnia)
            {
                if (z.DoPozycji == true || z.Rozstaw == true) z.Ryglowanie();
            }
            ryglowanie = true;
            buttonOdryglowanie.BackColor = Color.SkyBlue;
            buttonStartStop.Enabled = false;
            panelJoystick.Enabled = false;
        }
        void Odryglowanie()
        {
            foreach (Zapadnia z in Zapadnia.ListaZapadnia)
            {
                if (z.Aktywacja == true && z.DoPozycji == true)
                {
                    z.JazdaDoPozycjiOdryglowanie();
                    buttonStartStop.Enabled = true;
                    panelJoystick.Enabled = true;
                }
                if (z.Aktywacja == true && z.Joystick == true)
                {
                    z.JazdaDoPozycjiOdryglowanie();
                    panelJoystick.Enabled = true;
                }
                if (z.Aktywacja == true && z.Rozstaw == true)
                {
                    z.JazdaRozstawOdryglowanie();
                    panelJoystick.Enabled = true;
                }
            }
            ryglowanie = false;
            buttonOdryglowanie.BackColor = Color.IndianRed;
        }

        void LadujBazaProgramowa()
        {
            foreach (Zapadnia z in Zapadnia.ListaZapadnia)
            {
                try
                {
                    int idFx = ((this.pokazFxZapadniaBindingSource.Current as DataRowView).Row as TWDataSet.pokazFx_ZapadniaRow).idfx_zapadnia;
                    z.ladujBazaProgramowa(idFx);
                    
                }
                catch (Exception)
                {

                }
            }
        }

        private void comboBox3_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox6_SelectedValueChanged(object sender, EventArgs e)
        {
            LadujBazaProgramowa();
        }
    }
}
