using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dyplom_Dariusz_Petasz_Z709.Zapadnie
{
    public partial class ZapadniePanel : UserControl
    {
        Zapadnia zapadnia;
        bool rozstaw = false, joystick = false, doPozycji = false, programowa = false;
        public ZapadniePanel()
        {
            InitializeComponent();
        }

        private void ZapadniePanel_Load(object sender, EventArgs e)
        {
            this.pokazZapadnieTableAdapter.Fill(this.twDataSet.pokazZapadnie);
            LadujZapadnia();
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
            buttonStartStop.Enabled = true;
            foreach (Zapadnia z in Zapadnia.ListaZapadnia)
            {
                z.AktywujDoPozycji();
                z.zmianaPrzyciskRozstawNie();
            }
        }
        void LadujJazdaRozstaw()
        {

            foreach (Zapadnia z in Zapadnia.ListaZapadnia)
            {
                z.ZmianaAktywacjaRozstaw();
                z.zmianaPrzyciskRozstawTak();
            }
        }
        void LadujJazdaJoystick()
        {
            foreach (Zapadnia z in Zapadnia.ListaZapadnia)
            {
                z.ZmianaAktywacjaJoystick();
                z.zmianaPrzyciskRozstawNie();
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
                        z.Joystick();
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
                        z.AktywujDoPozycji();
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
            //if (rozstaw == true)
            //{
            //    buttonRozstaw.BackColor = Color.LightSteelBlue;

            //    rozstaw = false;
            //    foreach (Zapadnia z in Zapadnia.ListaZapadnia)
            //    {
            //        z.zmianaPrzyciskRozstawNie();
            //        z.ZmianaAktywacja();
            //    }
            //}
            //else
            //{
            //    buttonRozstaw.BackColor = Color.IndianRed;
            //    rozstaw = true;
            //    foreach (Zapadnia z in Zapadnia.ListaZapadnia)
            //    {
            //        z.zmianaPrzyciskRozstawTak();
            //    }
            //}

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



        

        private void buttonPrgramowa_Click(object sender, EventArgs e)
        {
            LadujProgramowa();
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            StartStop();
        }

        


    }
}
