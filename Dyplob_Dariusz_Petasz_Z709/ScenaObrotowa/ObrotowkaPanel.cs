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

        public Pen pioroLinia;
        public SolidBrush wypelnienieTrojkat;
        public Pen pioro;
        public SolidBrush Pioro1;
        public SolidBrush Pioro2;
        public SolidBrush Pioro3;
        public SolidBrush KolorLiczby;
        public Font textFont;

       

        int predkosc;
        int Predkosc
        {
            get { return predkosc; }
            set { predkosc = value; }
        }
        bool kierunek = false;
        bool Kierunek
        {
            get { return kierunek; }
            set { kierunek = value; }
        }
        float pozycja;
        float Pozycja
        {
            get { return pozycja; }
            set { pozycja = value; }
        }

        public ObrotowkaPanel()
        {
            InitializeComponent();
            Pozycja = Jazda.PozycjaObrotowka();
        }

        private void ObrotowkaPanel_Load(object sender, EventArgs e)
        {
            this.pokazPrzedstawienieTableAdapter.Fill(this.tWDataSet.pokazPrzedstawienie);
            jazdaTechniczna();

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


        private void green()
        {

            timer1.Enabled = false;
            buttonStartStop.BackColor = Color.Green;
            buttonStartStop.Text = "Start";
            this.stanWyp = new Wypelnienie1();
            pictureBox1.Invalidate();

        }
        private void red()
        {
            timer1.Enabled = true;
            buttonStartStop.BackColor = Color.Red;
            buttonStartStop.Text = "Stop";
            this.stanWyp = new WypelnienieJazda();
            pictureBox1.Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pozycja = Jazda.ruch(Kierunek, predkosc);
            textBoxPozycjaObrotowka.Text = pozycja.ToString();
            pictureBox1.Invalidate();
        }

        private void trackBarKierunek_Scroll(object sender, EventArgs e)
        {
            if (trackBarKierunek.Value == 1)
                Kierunek = true;

            else Kierunek = false;
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {

                red();
            }
            else
            {

                Jazda.ZapisPozycja(pozycja);
                green();
            }
        }

        private void trackBarPredkoscObrotowka_Scroll(object sender, EventArgs e)
        {
            textBoxPredkoscObrotowka.Text = trackBarPredkoscObrotowka.Value.ToString();
            Predkosc = trackBarPredkoscObrotowka.Value;
        }

        void jazdaDoPozycji()
        {
            buttonJazdaDoPozycji.BackColor = Color.Maroon;
            buttonJazdaDoPozycji.Enabled = false;

            buttonJazdaTechniczna.BackColor = Color.LightSteelBlue;
            buttonJazdaTechniczna.Enabled = true;

            buttonJazdaProgramowa.BackColor = Color.LightSteelBlue;
            buttonJazdaProgramowa.Enabled = true;

            textBoxPozycjaZadanaObrotowka.ReadOnly = false;
            //panelBazaDanych.Enabled = false;
        }
        void jazdaProgramowa()
        {
            buttonJazdaDoPozycji.BackColor = Color.LightSteelBlue;
            buttonJazdaDoPozycji.Enabled = true;

            buttonJazdaTechniczna.BackColor = Color.LightSteelBlue;
            buttonJazdaTechniczna.Enabled = true;

            buttonJazdaProgramowa.BackColor = Color.Maroon;
            buttonJazdaProgramowa.Enabled = false;

            textBoxPozycjaZadanaObrotowka.ReadOnly = true;

            //panelBazaDanych.Enabled = true;
        }
        void jazdaTechniczna()
        {
            buttonJazdaDoPozycji.BackColor = Color.LightSteelBlue;
            buttonJazdaDoPozycji.Enabled = true;

            buttonJazdaTechniczna.BackColor = Color.Maroon;
            buttonJazdaTechniczna.Enabled = false;

            buttonJazdaProgramowa.BackColor = Color.LightSteelBlue;
            buttonJazdaProgramowa.Enabled = true;

            textBoxPozycjaZadanaObrotowka.ReadOnly = true;
           // panelBazaDanych.Enabled = false;
        }

       



        private void buttonJazdaTechniczna_Click(object sender, EventArgs e)
        {
            jazdaTechniczna();
        }

        private void buttonJazdaProgramowa_Click(object sender, EventArgs e)
        {
            jazdaProgramowa();
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
            try
            {
                int idAkt = ((this.pokazAktBindingSource.Current as DataRowView).Row as TWDataSet.pokazAktRow).idakt;
                this.pokazFxObrotowkaTableAdapter.Fill(this.tWDataSet.pokazFxObrotowka, idAkt);
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
            
            textBoxNazwaFX.Text = idAkt.ToString();
        }
    }
}
