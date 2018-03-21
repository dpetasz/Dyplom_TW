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
using System.IO;

namespace Dyplom_Dariusz_Petasz_Z709.ScenaObrotowa
{
    public partial class ObrotowkaPanel : UserControl
    {
        Graphics g;
        StanWypelnienie stanWyp = new Wypelnienie1();
        IZapiszAkt zapiszAkt = new ZapiszAkt();
        IJazdaObrotowka Jazda = new JazdaObrotowka();
        IZapiszFX_Obrotowka db = new ZapiszFX_Obrotowka();
        RysujTarcza Rysuj = new RysujTarcza();
        IObrotowka obrotowka = new Urzadzenie();

        public Pen pioroLinia;
        public SolidBrush wypelnienieTrojkat;
        public Pen pioro;
        public SolidBrush Pioro1;
        public SolidBrush Pioro2;
        public SolidBrush Pioro3;
        public SolidBrush KolorLiczby;
        public Font textFont;
        
        public bool GetAktywacja()
        {
            return obrotowka.GetAktywacja();
        }
        public void SetAktywacja(bool Aktywacja)
        {
            obrotowka.SetAktywacja( Aktywacja);
        }
        
        public bool GetDoPozycji()
        {
            return obrotowka.GetDoPozycji();
        }
        public void SetDoPozycji(bool DoPozycji)
        {
            obrotowka.SetDoPozycji(DoPozycji);
        }
       
        public bool GetProgramowa()
        {
            return obrotowka.GetProgramowa();
        }
        public void SetProgramowa(bool Programowa)
        {
            obrotowka.SetProgramowa(Programowa);
        }
        
        public bool GetJoystick()
        {
            return obrotowka.GetJoystick();
        }
        public void SetJoystick(bool Joystick)
        {
            obrotowka.SetJoystick(Joystick);
        }
       
        public int GetPredkosc()
        {
            return obrotowka.GetPredkosc();
        }
        public void SetPredkosc(int Predkosc)
        {
            obrotowka.SetPredkosc(Predkosc);
        }
       
        public bool GetKierunek()
        {
            return obrotowka.GetKierunek();
        }
        public void SetKierunek(bool Kierunek)
        {
            obrotowka.SetKierunek(Kierunek);
        }
        
        public float GetPozycja()
        {
            return obrotowka.GetPozycja();
        }

        public void SetPozycja(float Pozycja)
        {
            obrotowka.SetPozycja ( Pozycja);
        }

        
        public float GetPozycjaZadana()
        {
            return obrotowka.GetPozycjaZadana();
        }
        public void SetPozycjaZadana(float PozycjaZadana)
        {
            obrotowka.SetPozycjaZadana ( PozycjaZadana);
        }
        void ladujProgramowa()
        {

        }
        public ObrotowkaPanel()
        {
            InitializeComponent();
            LadujPozycja();
            SetJoystick (false);
            SetDoPozycji (false);
            SetProgramowa (false);
            SetKierunek(false);
            SetAktywacja ( false);
            SetPredkosc(0);
            SetPozycjaZadana(GetPozycja());
            Odswiez();
        }

        private void ObrotowkaPanel_Load(object sender, EventArgs e)
        {
            jazdaTechniczna();

        }
        void LadujBaza()
        {
            this.pokazPrzedstawienieTableAdapter.Fill(this.tWDataSet.pokazPrzedstawienie);
        }

        void LadujPozycja()
        {
            try
            {
                this.pokaz_ObrotowkaTableAdapter.Fill(this.tWDataSet.pokaz_Obrotowka, 1);
                SetPozycja((float)((this.pokazObrotowkaBindingSource.Current as DataRowView).Row as TWDataSet.pokaz_ObrotowkaRow).pozycja);
            }
            catch (Exception)
            {

                SetPozycja(0);
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            stanWyp.Wypelnienie(Rysuj);

            Rysuj.Tarcza(g);
            Rysuj.Obrot(g, GetPozycja());
        }


        public void Wypelnienie()
        {
            stanWyp.Wypelnienie(Rysuj);

        }
        void StopWypelnienie()
        {
            this.stanWyp = new Wypelnienie1();
            pictureBox1.Invalidate();
        }
        void JazdaWypelnienie()
        {
            this.stanWyp = new WypelnienieJazda();
            pictureBox1.Invalidate();
        }
        private void green()
        {
            timer1.Enabled = false;
            buttonStartStop.BackColor = Color.Green;
            buttonStartStop.Text = "Start";
            StopWypelnienie();

        }
        private void red()
        {
            timer1.Enabled = true;
            buttonStartStop.BackColor = Color.Red;
            buttonStartStop.Text = "Stop";
            JazdaWypelnienie();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (GetJoystick() == true)
            {
                SetPozycja(Jazda.joystick(GetPredkosc(), GetPozycja()));
                Odswiez();
                pictureBox1.Invalidate();
            }
            if (GetDoPozycji() == true || GetProgramowa() == true)
            {
                if ((Math.Round(GetPozycja(), 1)) == (Math.Round(GetPozycjaZadana(), 1)))
                {
                    StopWypelnienie();
                    Odswiez();
                }
                else
                {
                    SetPozycja(Jazda.doPozycji(GetPredkosc(), GetKierunek(), GetPozycja()));
                    Odswiez();
                    pictureBox1.Invalidate();

                }
            }

        }

        private void trackBarKierunek_Scroll(object sender, EventArgs e)
        {

        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {

                red();
            }
            else
            {

                textBoxWynik.Text = db.ZapiszPozycja(1, GetPozycja());
                green();
            }
        }

        void Odswiez()
        {
            textBoxPredkoscObrotowka.Text = GetPredkosc().ToString();
            textBoxPozycjaObrotowka.Text = (Math.Round(GetPozycja(), 2)).ToString();
            textBoxPozycjaZadanaObrotowka.Text = GetPozycjaZadana().ToString();
            PrzyciskKierunek();
            if (GetDoPozycji() == true)
            {
                buttonJazdaDoPozycji.BackColor = Color.IndianRed;
                buttonJazdaDoPozycji.Enabled = false;

                buttonJazdaTechniczna.BackColor = Color.LightSteelBlue;
                buttonJazdaTechniczna.Enabled = true;

                buttonJazdaProgramowa.BackColor = Color.LightSteelBlue;
                buttonJazdaProgramowa.Enabled = true;

                textBoxPozycjaZadanaObrotowka.ReadOnly = false;
                //panelBazaDanych.Enabled = false;
                textBoxPredkoscObrotowka.ReadOnly = false;
                buttonStartStop.Enabled = true;
                tabControlBazaDanych.Enabled = false;
            }
            else if (GetProgramowa() == true)
            {
                buttonJazdaDoPozycji.BackColor = Color.LightSteelBlue;
                buttonJazdaDoPozycji.Enabled = true;

                buttonJazdaTechniczna.BackColor = Color.LightSteelBlue;
                buttonJazdaTechniczna.Enabled = true;

                buttonJazdaProgramowa.BackColor = Color.IndianRed;
                buttonJazdaProgramowa.Enabled = false;

                textBoxPozycjaZadanaObrotowka.ReadOnly = false;
                textBoxPredkoscObrotowka.ReadOnly = false;
                //panelBazaDanych.Enabled = true;

                buttonStartStop.Enabled = true;
                tabControlBazaDanych.Enabled = true;
            }
            else if (GetJoystick() == true)
            {
                buttonJazdaDoPozycji.BackColor = Color.LightSteelBlue;
                buttonJazdaDoPozycji.Enabled = true;

                buttonJazdaTechniczna.BackColor = Color.IndianRed;
                buttonJazdaTechniczna.Enabled = false;

                buttonJazdaProgramowa.BackColor = Color.LightSteelBlue;
                buttonJazdaProgramowa.Enabled = true;
                textBoxPredkoscObrotowka.ReadOnly = true;
                textBoxPozycjaZadanaObrotowka.ReadOnly = true;
                // panelBazaDanych.Enabled = false;

                buttonStartStop.Enabled = false;
                tabControlBazaDanych.Enabled = false;
            }
        }

        void jazdaDoPozycji()
        {
             SetDoPozycji (true);
             SetJoystick(false);
            SetProgramowa(false);
            Odswiez();

        }
        void jazdaProgramowa()
        {
             SetDoPozycji (false);
             SetJoystick(false);
            SetProgramowa(true);
            Odswiez();
        }
        void jazdaTechniczna()
        {
            SetDoPozycji(false);
            SetJoystick(true);
            SetProgramowa(false);
            Odswiez();
        }





        private void buttonJazdaTechniczna_Click(object sender, EventArgs e)
        {
            jazdaTechniczna();
        }

        private void buttonJazdaProgramowa_Click(object sender, EventArgs e)
        {
            jazdaProgramowa();

            LadujBaza();
        }

        private void buttonJazdaDoPozycji_Click(object sender, EventArgs e)
        {
            jazdaDoPozycji();
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

        private void pokazAktBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ladujAkt();
        }
        void ladujAkt()
        {
            try
            {
                int idAkt = ((this.pokazAktBindingSource.Current as DataRowView).Row as TWDataSet.pokazAktRow).idakt;
                this.pokazFxObrotowkaTableAdapter.Fill(this.tWDataSet.pokazFxObrotowka, idAkt);
            }
            catch (Exception)
            {


            }
        }
        private void pokazFxObrotowkaBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                int idFx = ((this.pokazFxObrotowkaBindingSource.Current as DataRowView).Row as TWDataSet.pokazFxObrotowkaRow).idfx_obrotowka;
                SetPredkosc(((this.pokazFxObrotowkaBindingSource.Current as DataRowView).Row as TWDataSet.pokazFxObrotowkaRow).predkosc);
                SetPozycjaZadana((float)((this.pokazFxObrotowkaBindingSource.Current as DataRowView).Row as TWDataSet.pokazFxObrotowkaRow).miejsce_stop);
                SetKierunek(((this.pokazFxObrotowkaBindingSource.Current as DataRowView).Row as TWDataSet.pokazFxObrotowkaRow).kierunek);
                Odswiez();
            }
            catch (Exception)
            {

            }
        }
        private void buttonZapiszFX_Click(object sender, EventArgs e)
        {
            int idAkt;
            try
            {
                idAkt = ((this.pokazAktBindingSource.Current as DataRowView).Row as TWDataSet.pokazAktRow).idakt;
            }
            catch (Exception)
            {

                idAkt = 0;
            }

            labelWynikDodajFX_Ob.Text = db.DodajFX(idAkt, textBoxNazwaFX.Text, GetPredkosc(), GetKierunek(), GetPozycja(), richTextBoxOpisZapisFx.Text);
            ladujAkt();
        }

        private void buttonLewo_Click(object sender, EventArgs e)
        {
            SetKierunek(false);
            PrzyciskKierunek();
        }

        void PrzyciskKierunek()
        {
            if (GetKierunek() == false)
            {
                buttonLewo.BackColor = Color.Green;
                buttonPrawo.BackColor = Color.SkyBlue;
            }
            else
            {
                buttonLewo.BackColor = Color.SkyBlue;
                buttonPrawo.BackColor = Color.Green;
            }
        }

        private void buttonPrawo_Click(object sender, EventArgs e)
        {
            SetKierunek(true);
            PrzyciskKierunek();
        }

        private void trackBarJoystick_Scroll(object sender, EventArgs e)
        {
            if (GetJoystick() == true)
            {
                JazdaWypelnienie();
                timer1.Enabled = true;
                SetPredkosc(trackBarJoystick.Value);
                Odswiez();
            }
            else
            {
                SetPozycjaZadana(float.Parse(textBoxPozycjaZadanaObrotowka.Text));
                SetPredkosc(Int32.Parse(textBoxPredkoscObrotowka.Text));
                JazdaWypelnienie();
                timer1.Enabled = true;
                SetPredkosc(Math.Abs(trackBarJoystick.Value));
                Odswiez();
            }

        }

        private void trackBarJoystick_MouseUp(object sender, MouseEventArgs e)
        {

            StopWypelnienie();
            timer1.Enabled = false;
            trackBarJoystick.Value = 0;
            SetPredkosc(trackBarJoystick.Value);
            db.ZapiszPozycja(1, GetPozycja());
            Odswiez();
        }

        private void buttonStartStop_MouseDown(object sender, MouseEventArgs e)
        {
            SetPozycjaZadana(float.Parse(textBoxPozycjaZadanaObrotowka.Text));
            SetPredkosc(Int32.Parse(textBoxPredkoscObrotowka.Text));
            red();
        }

        private void buttonStartStop_MouseUp(object sender, MouseEventArgs e)
        {
            green();
            db.ZapiszPozycja(1, GetPozycja());
            Odswiez();
        }

        private void buttonAktualizuj_Click(object sender, EventArgs e)
        {
            try
            {
                int idFx = ((this.pokazFxObrotowkaBindingSource.Current as DataRowView).Row as TWDataSet.pokazFxObrotowkaRow).idfx_obrotowka;

                label5.Text = db.AktualizujFX(idFx, textBox4.Text, GetPredkosc(), GetKierunek(), GetPozycjaZadana(), richTextBox3.Text);
            }
            catch (Exception)
            {

                label5.Text = "Błąd Bazy danych";
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            panelPozycjaZadana.Visible = false;
        }

        private void buttonZamknijPanelPredkosc_Click(object sender, EventArgs e)
        {
            panelPredkosc.Visible = false;
        }

        private void trackBarPredkosc_Scroll(object sender, EventArgs e)
        {
            SetPredkosc(trackBarPredkosc.Value);
            labelPredkosc.Text = GetPredkosc().ToString();
        }

        private void trackBarPredkosc_MouseUp(object sender, MouseEventArgs e)
        {
            panelPredkosc.Visible = false;
        }

        private void buttonZapiszPozycjaZadana_Click(object sender, EventArgs e)
        {
            
            try
            {

                SetPozycjaZadana(float.Parse(textBox5.Text.ToString()));
                if (GetPozycjaZadana() > 360 || GetPozycjaZadana() < 0)
                {
                    MessageBox.Show("Przedział nie zawiera się 0-360");
                    textBox5.Clear();
                    SetPozycjaZadana(GetPozycja());
                    Odswiez();
                }
                else
                {
                    panelPozycjaZadana.Visible = false;
                    textBox5.Clear();
                    Odswiez();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Zły format liczb");
                textBox5.Clear();
                SetPozycjaZadana(GetPozycja());
                Odswiez();
            }
        }

        private void textBoxPozycjaZadanaObrotowka_Click(object sender, EventArgs e)
        {
            panelPozycjaZadana.Visible = true;
        }

        private void textBoxPredkoscObrotowka_Click(object sender, EventArgs e)
        {
            panelPredkosc.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox5.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox5.Text += button3.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox5.Text += button12.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox5.Text += button11.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox5.Text += button10.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox5.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox5.Text += button6.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox5.Text += button9.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox5.Text += button8.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
        }


    }
}
