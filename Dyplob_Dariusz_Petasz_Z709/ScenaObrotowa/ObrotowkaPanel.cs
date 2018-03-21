﻿using System;
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

        public Pen pioroLinia;
        public SolidBrush wypelnienieTrojkat;
        public Pen pioro;
        public SolidBrush Pioro1;
        public SolidBrush Pioro2;
        public SolidBrush Pioro3;
        public SolidBrush KolorLiczby;
        public Font textFont;
        bool aktywacja;
        public bool Aktywacja
        {
            get { return aktywacja; }
            set { aktywacja = value; }
        }
        bool doPozycji;
        public bool DoPozycji
        {
            get { return doPozycji; }
            set { doPozycji = value; }
        }
        bool programowa;
        public bool Programowa
        {
            get { return programowa; }
            set { programowa = value; }
        }
        bool joystick;
        public bool Joystick
        {
            get { return joystick; }
            set { joystick = value; }
        }

        int predkosc;
        int Predkosc
        {
            get { return predkosc; }
            set { predkosc = value; }
        }
        public int GetPredkosc()
        {
            return Predkosc;
        }
        public void SetPredkosc(int Predkosc)
        {
            this.Predkosc = Predkosc;
        }
        bool kierunek;
        bool Kierunek
        {
            get { return kierunek; }
            set { kierunek = value; }
        }
        public bool GetKierunek()
        {
            return Kierunek;
        }
        public void SetKierunek(bool Kierunek)
        {
            this.Kierunek = Kierunek;
        }
        float pozycja;
        float Pozycja
        {
            get { return pozycja; }
            set { pozycja = value; }
        }
        public float GetPozycja()
        {
            return Pozycja;
        }

        public void SetPozycja(float Pozycja)
        {
            this.Pozycja = Pozycja;
        }

        float pozycjaZadana;
        float PozycjaZadana
        {
            get { return pozycjaZadana; }
            set { pozycjaZadana = value; }
        }
        public float GetPozycjaZadana()
        {
            return PozycjaZadana;
        }
        public void SetPozycjaZadana(float PozycjaZadana)
        {
            this.PozycjaZadana = PozycjaZadana;
        }
        void ladujProgramowa()
        {

        }
        public ObrotowkaPanel()
        {
            InitializeComponent();
            LadujPozycja();
            Joystick = false;
            DoPozycji = false;
            Programowa = false;
            Kierunek = false;
            Aktywacja = false;
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
            Rysuj.Obrot(g, pozycja);
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
            if (Joystick == true)
            {
                SetPozycja(Jazda.joystick(GetPredkosc(), GetPozycja()));
                Odswiez();
                pictureBox1.Invalidate();
            }
            if (DoPozycji == true || Programowa == true)
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

                textBoxWynik.Text = db.ZapiszPozycja(1, pozycja);
                green();
            }
        }

        void Odswiez()
        {
            textBoxPredkoscObrotowka.Text = GetPredkosc().ToString();
            textBoxPozycjaObrotowka.Text = (Math.Round(GetPozycja(), 2)).ToString();
            textBoxPozycjaZadanaObrotowka.Text = GetPozycjaZadana().ToString();
            PrzyciskKierunek();
            if (DoPozycji == true)
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
            else if (Programowa == true)
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
            else if (Joystick == true)
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
            DoPozycji = true;
            Joystick = false;
            Programowa = false;
            Odswiez();

        }
        void jazdaProgramowa()
        {
            DoPozycji = false;
            Joystick = false;
            Programowa = true;
            Odswiez();
        }
        void jazdaTechniczna()
        {
            DoPozycji = false;
            Joystick = true;
            Programowa = false;
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

            labelWynikDodajFX_Ob.Text = db.DodajFX(idAkt, textBoxNazwaFX.Text, Predkosc, Kierunek, (decimal)Pozycja, richTextBoxOpisZapisFx.Text);
            ladujAkt();
        }

        private void buttonLewo_Click(object sender, EventArgs e)
        {
            Kierunek = false;
            PrzyciskKierunek();
        }

        void PrzyciskKierunek()
        {
            if (Kierunek == false)
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
            Kierunek = true;
            PrzyciskKierunek();
        }

        private void trackBarJoystick_Scroll(object sender, EventArgs e)
        {
            if (joystick == true)
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
            db.ZapiszPozycja(1,GetPozycja());
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


    }
}
