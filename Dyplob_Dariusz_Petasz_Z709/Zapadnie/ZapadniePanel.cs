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
        bool rozstaw = false, joystick = false;
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
                zapadnia.Top = 3;
                zapadnia.Left = szer;
                szer += 154;
            }
        }

        private void buttonJoystick_Click(object sender, EventArgs e)
        {
            if (panelJoystick.Enabled == true)
            {
                buttonJoystick.BackColor = Color.LightSteelBlue;
                panelJoystick.Enabled = false;
                joystick = false;
            }
            else
            {
                buttonJoystick.BackColor = Color.IndianRed;
                panelJoystick.Enabled = true;
                joystick = true;
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {

            foreach (Zapadnia z in Zapadnia.ListaZapadnia)
            {
                if (joystick == true)
                {
                    if (z.Aktywacja == true)
                    {
                        if (z.Pozycja >= z.Kg && trackBarJoystick.Value > 0)
                        {
                            z.Aktywacja = false;
                            z.ZmianaAktywacja();
                        }
                        if (z.Pozycja <= z.Kd && trackBarJoystick.Value < 0)
                        {
                            z.Aktywacja = false;
                            z.ZmianaAktywacja();
                        }
                        z.Joystick();
                    }
                }
                if (rozstaw == true)
                {
                    if (z.Aktywacja == true && z.Rozstaw == true)
                    {
                        if ((z.PozycjaPortal - z.Pozycja) <=60 && trackBarJoystick.Value > 0)
                        {
                            z.Aktywacja = false;
                            z.Rozstaw = false;
                            z.ZmianaAktywacja();
                        }
                        if (z.Pozycja >= z.Kg && trackBarJoystick.Value > 0)
                        {
                            z.Aktywacja = false;
                            z.ZmianaAktywacja();
                        }
                        if (z.Pozycja <= z.Kd && trackBarJoystick.Value < 0)
                        {
                            z.Aktywacja = false;
                            z.Rozstaw = false;
                            z.ZmianaAktywacja();
                        }
                        z.JazdaRozstaw();
                    }
                }

            }
        }


        private void trackBarJoystick_Scroll(object sender, EventArgs e)
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

        private void trackBarJoystick_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
            trackBarJoystick.Value = 0;
            foreach (Zapadnia z in Zapadnia.ListaZapadnia)
            {

                z.Predkosc = trackBarJoystick.Value;
                z.Odswiez();
            }
        }

        private void buttonRozstaw_Click(object sender, EventArgs e)
        {
            if (panelJoystick.Enabled == true)
            {
                buttonRozstaw.BackColor = Color.LightSteelBlue;
                panelJoystick.Enabled = false;
                rozstaw = false;
            }
            else
            {
                buttonRozstaw.BackColor = Color.IndianRed;
                panelJoystick.Enabled = true;
                rozstaw = true;
            }
        }

        private void buttonJazdaDoPozycji_Click(object sender, EventArgs e)
        {

        }
    }
}
