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

        public Pen pioroLinia;
        public SolidBrush wypelnienieTrojkat;
        public Pen pioro;
        public SolidBrush Pioro1;
        public SolidBrush Pioro2;
        public SolidBrush Pioro3;
        public SolidBrush KolorLiczby;
        public Font textFont;

        float obrot;
        float Obrot
        {
            get { return obrot; }
            set { obrot = value; }
        }
        string plik = @"C:\GitHub\Dyplom_TW\Dyplob_Dariusz_Petasz_Z709\Resources\Pozycja_Obrotowka.txt";

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
            Pozycja = PozycjaObrotowka();
        }

        private void ObrotowkaPanel_Load(object sender, EventArgs e)
        {
            this.pokazPrzedstawienieTableAdapter.Fill(this.tWDataSet.pokazPrzedstawienie);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            stanWyp.Wypelnienie(this);

            Tarcza(g);
            ObrotWskaznik(g, pozycja);
        }

        public void Tarcza(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            int x = 0;


            Font textFont = new Font("Century", 12F, FontStyle.Bold);
            g.FillRectangle(Pioro3, 0, 0, 630, 630);
            g.DrawEllipse(pioro, 70, 70, 500, 500);
            g.FillEllipse(Pioro1, 90, 90, 460, 460);
            g.FillEllipse(Pioro2, 317, 317, 6, 6);
            g.DrawLine(pioro, 550, 320, 570, 320);
            g.DrawString(x.ToString(), textFont, KolorLiczby, 575, 310);
            for (int i = 1; i < 360; i++)
            {

                g.TranslateTransform(320, 320);
                g.RotateTransform(1);
                g.TranslateTransform(-320, -320);
                if (i % 5 == 0)
                {
                    g.DrawLine(pioro, 560, 320, 570, 320);
                }
                if (i % 10 == 0)
                {
                    x += 10;
                    g.DrawLine(pioro, 550, 320, 570, 320);
                    g.DrawString(x.ToString(), textFont, KolorLiczby, 575, 310);

                }
                else
                {
                    g.DrawLine(pioro, 565, 320, 570, 320);
                }

            }

        }
        public void ObrotWskaznik(Graphics g, float o)
        {

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Point[] trojkat = { new Point(530, 314), new Point(550, 324), new Point(530, 334) };

            g.TranslateTransform(320, 320);
            g.RotateTransform(o);
            g.TranslateTransform(-320, -320);
            g.DrawLine(pioroLinia, 90, 316, 550, 324);
            g.FillPolygon(wypelnienieTrojkat, trojkat);
        }
        public void Wypelnienie()
        {
            stanWyp.Wypelnienie(this);

        }


        public float PozycjaObrotowka()
        {
            try
            {

                FileStream fs = new FileStream(plik, FileMode.Open, FileAccess.ReadWrite);

                StreamReader sr = new StreamReader(fs);
                string txt = sr.ReadToEnd();
                sr.Close();
                fs.Close();
                Obrot = float.Parse(txt);


            }
            catch { Obrot = 0; }
            return Obrot;

        }
        public void ZapisPozycja(float x)
        {

            FileStream fs = new FileStream(plik, FileMode.Create, FileAccess.ReadWrite);

            try
            {
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(Math.Round(x, 2).ToString());
                sw.Close();
                fs.Close();

            }
            catch { }
        }
        public float ruch(bool direct, int v)
        {

            switch (direct)
            {
                case true:
                    {
                        this.Obrot += v * 0.001f;
                        if (Math.Round(Obrot, 1) == 360) Obrot = 0;
                        break;
                    }
                case false:
                    {
                        this.Obrot -= v * 0.001f;
                        if (Math.Round(Obrot, 1) == 0) Obrot = 360;
                        break;
                    }
            }
            return (float)Math.Round(Obrot, 1);

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
            pozycja = ruch(Kierunek, predkosc);
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

                ZapisPozycja(pozycja);
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
    }
}
