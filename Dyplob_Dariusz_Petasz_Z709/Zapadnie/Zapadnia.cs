using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Dyplom_Dariusz_Petasz_Z709.BD_TW;

namespace Dyplom_Dariusz_Petasz_Z709.Zapadnie
{
    public partial class Zapadnia : UserControl
    {
        static public List<Zapadnia> ListaZapadnia = new List<Zapadnia>();

        RysujZapadnia rysujZapadnia = new RysujZapadnia();
        JazdaZapadnia jazdaZapadnia = new JazdaZapadnia();
        IZapiszZapadnia db = new ZapiszZapadnia();
        Graphics g;

        bool rygiel_1;
        public bool Rygiel_1
        {
            get { return rygiel_1; }
            set { rygiel_1 = value; }
        }
        bool rygiel_2;
        public bool Rygiel_2
        {
            get { return rygiel_2; }
            set { rygiel_2 = value; }
        }
        bool rygiel_3;
        public bool Rygiel_3
        {
            get { return rygiel_3; }
            set { rygiel_3 = value; }
        }
        bool sprzeganie;
        public bool Sprzeganie
        {
            get { return sprzeganie; }
            set { sprzeganie = value; }
        }
        bool kierunek;
        public bool Kierunek
        {
            get { return kierunek; }
            set { kierunek = value; }
        }
        bool aktywacja;
        public bool Aktywacja
        {
            get { return aktywacja; }
            set { aktywacja = value; }
        }
        bool joystick;
        public bool Joystick
        {
            get { return joystick; }
            set { joystick = value; }
        }
        bool rozstaw;
        public bool Rozstaw
        {
            get { return rozstaw; }
            set { rozstaw = value; }
        }
        bool doPozycji;
        public bool DoPozycji
        {
            get { return doPozycji; }
            set { doPozycji = value; }
        }
        float pozycjaZadana;
        public float PozycjaZadana
        {
            get { return pozycjaZadana; }
            set { pozycjaZadana = value; }
        }
        int przychamowanie;
        public int Przychamowanie
        {
            get { return przychamowanie; }
            set { przychamowanie = value; }
        }
        float pozycja;
        public float Pozycja
        {
            get { return pozycja; }
            set { pozycja = value; }
        }
        float pozycjaPortal;
        public float PozycjaPortal
        {
            get { return pozycjaPortal; }
            set { pozycjaPortal = value; }
        }
        float kg;
        public float Kg
        {
            get { return kg; }
            set { kg = value; }
        }
        float kd;
        public float Kd
        {
            get { return kd; }
            set { kd = value; }
        }
        int predkoscMax;
        public int PredkoscMax
        {
            get { return predkoscMax; }
            set { predkoscMax = value; }
        }
        int predkosc;
        public int Predkosc
        {
            get { return predkosc; }
            set { predkosc = value; }
        }


        public Zapadnia(int Id, string Nazwa, float Pozycja, int PredkoscMax, int Przychamowanie)
        {
            InitializeComponent();
            rysujZapadnia.Id = Id;
            rysujZapadnia.Nazwa = Nazwa;
            this.Pozycja = Pozycja;
            this.Aktywacja = false;
            this.PredkoscMax = PredkoscMax;
            this.Predkosc = 0;
            this.Przychamowanie = Przychamowanie;
            this.Rozstaw = false;
            this.DoPozycji = false;
            this.Joystick = false;
            ListaZapadnia.Add(this);

        }
        void LadujDane()
        {
            textBoxNazwa.Text = rysujZapadnia.Nazwa;
            textBoxPozycja.Text = ((float)Math.Round((Pozycja / 20), 2)).ToString() + " m";
            textBoxRozstaw.Text = ((float)Math.Round(((PozycjaPortal - Pozycja) / 20), 2)).ToString() + " m";
            textBoxPredkosc.Text = Predkosc.ToString();
            textBoxMiejsceStop.Text = (Pozycja / 20).ToString() + " m";
            WczytajMiejsceStop(Math.Abs((Pozycja / 20)).ToString());
        }
        void JazdaDoPozycjiOdryglowanie()
        {
            Rygiel_1 = false;
            Rygiel_3 = false;
            Rygiel_2 = true;
        }
        void JazdaRozstawOdryglowanie()
        {
            Rygiel_1 = true;
            Rygiel_3 = false;
            Rygiel_2 = false;
        }
        void Ryglowanie()
        {
            Rygiel_1 = true;
            Rygiel_3 = true;
            Rygiel_2 = true;
        }
        private void Zapadnia_Load(object sender, EventArgs e)
        {
            LadujDane();
        }
        void LadujKolor()
        {
            if (Rygiel_1 == true && Rygiel_2 == true && Rygiel_3 == true)
            {
                rysujZapadnia.Wypelnienie();
                rysujZapadnia.WypelnienieZaryglowanie();
            }
            else if (Rygiel_1 == true && Rygiel_2 == false && Rygiel_3 == false)
            {
                rysujZapadnia.WypelnienieJazda();
                rysujZapadnia.WypelnienieJazdaRozstaw();
            }
            else
            {
                rysujZapadnia.WypelnienieJazda();
                rysujZapadnia.WypelnienieJazdaZapadnia();
            }
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            LadujKolor();
            rysujZapadnia.Obramowanie(g);
            rysujZapadnia.ZapadniaJazda(g, Pozycja, PozycjaPortal);
        }
        public void ZmianaAktywacjaJoystick()
        {
            buttonAktywacja.BackColor = Color.SkyBlue;
            Aktywacja = false;
            Rozstaw = false;
            DoPozycji = false;
            Predkosc = 0;
            textBoxWynik.BackColor = Color.Moccasin;
            textBoxWynik.Text = db.ZapiszPozycja(rysujZapadnia.Id, (decimal)Pozycja, (decimal)PozycjaPortal);
            Odswiez();

        }
        public void ZmianaAktywacjaRozstaw()
        {
            Ryglowanie();
            DoPozycji = false;
            Joystick = false;
            buttonAktywacja.BackColor = Color.SkyBlue;
            Aktywacja = false;
            Rozstaw = true;
            Predkosc = 0;
            textBoxWynik.BackColor = Color.Moccasin;
            textBoxWynik.Text = db.ZapiszPozycja(rysujZapadnia.Id, (decimal)Pozycja, (decimal)PozycjaPortal);
        }
        public void ZmianaAktywacjaDoPozycji()
        {
            Ryglowanie();
            buttonAktywacja.BackColor = Color.SkyBlue;
            Aktywacja = false;
            Rozstaw = false;
            Joystick = false;
            Predkosc = 0;
            buttonZmianaRozstaw.BackColor = Color.SkyBlue;
            buttonZmianaRozstaw.Enabled = false;
            textBoxWynik.BackColor = Color.Moccasin;
            textBoxWynik.Text = db.ZapiszPozycja(rysujZapadnia.Id, (decimal)Pozycja, (decimal)PozycjaPortal);
        }
        public void zmianaPrzyciskRozstawTak()
        {
            buttonZmianaRozstaw.Enabled = true;
        }
        public void zmianaPrzyciskRozstawNie()
        {

            buttonZmianaRozstaw.Enabled = false;
        }
        public void JazdaJoystick()
        {
            if (Pozycja > -10 && Predkosc > 0)
            {
                PozycjaPortal = jazdaZapadnia.jazdaJoystick(Przychamowanie, PozycjaPortal);
                Pozycja = jazdaZapadnia.jazdaJoystick(Przychamowanie, Pozycja);
                Odswiez();
                if (Pozycja >= Kg)
                {
                    ZmianaAktywacjaJoystick();
                }
            }
            else if (Pozycja < -180 && Predkosc < 0)
            {
                PozycjaPortal = jazdaZapadnia.jazdaJoystick(Przychamowanie * -1, PozycjaPortal);
                Pozycja = jazdaZapadnia.jazdaJoystick(Przychamowanie * -1, Pozycja);
                Odswiez();
                if (Pozycja <= Kg)
                {
                    ZmianaAktywacjaJoystick();
                }
            }
            else
            {
                PozycjaPortal = jazdaZapadnia.jazdaJoystick(Predkosc, PozycjaPortal);
                Pozycja = jazdaZapadnia.jazdaJoystick(Predkosc, Pozycja);
                Odswiez();
            }
        }
        public void JazdaRozstaw()
        {
            if (Pozycja < PozycjaZadana)
            {
                if ((PozycjaPortal - PozycjaZadana) < 60)
                {
                    ZmianaAktywacjaRozstaw();
                    textBoxWynik.BackColor = Color.Red;
                    textBoxWynik.Text = "Rozstaw < 3m !!!";
                }
                else if ((float)Math.Round(Pozycja, 1) == PozycjaZadana)
                {
                    Aktywacja = false;
                    DoPozycji = false;
                    Predkosc = 0;
                    ZmianaAktywacjaRozstaw();
                    Odswiez();
                }
                else if (Pozycja > PozycjaZadana - 10)
                {
                    Pozycja = jazdaZapadnia.jazdaDoPozycjiUp(Przychamowanie, Pozycja);

                    Odswiez();
                }
                else
                {
                    Pozycja = jazdaZapadnia.jazdaDoPozycjiUp(Predkosc, Pozycja);

                    Odswiez();
                }
            }
            if (Pozycja > PozycjaZadana)
            {
                if ((float)Math.Round(Pozycja, 1) == PozycjaZadana)
                {
                    Aktywacja = false;
                    DoPozycji = false;
                    Predkosc = 0;
                    ZmianaAktywacjaRozstaw();
                    Odswiez();
                }
                else if (Pozycja < PozycjaZadana + 10)
                {
                    Pozycja = jazdaZapadnia.jazdaDoPozycjiDown(Przychamowanie, Pozycja);
                    //PozycjaPortal = jazdaZapadnia.jazdaDoPozycjiDown(Przychamowanie, PozycjaPortal);
                    Odswiez();
                }
                else
                {
                    Pozycja = jazdaZapadnia.jazdaDoPozycjiDown(Predkosc, Pozycja);
                    //PozycjaPortal = jazdaZapadnia.jazdaDoPozycjiDown(Predkosc, PozycjaPortal);
                    Odswiez();
                }
            }
        }
        public void JazdaDoPozycji()
        {
            if (Pozycja < PozycjaZadana)
            {
                if ((float)Math.Round(Pozycja, 1) == PozycjaZadana)
                {
                    Aktywacja = false;
                    Predkosc = 0;
                    ZmianaAktywacjaDoPozycji();
                    Odswiez();
                }
                else if (Pozycja > PozycjaZadana - 10)
                {
                    Pozycja = jazdaZapadnia.jazdaDoPozycjiUp(Przychamowanie, Pozycja);
                    PozycjaPortal = jazdaZapadnia.jazdaDoPozycjiUp(Przychamowanie, PozycjaPortal);
                    Odswiez();
                }
                else
                {
                    Pozycja = jazdaZapadnia.jazdaDoPozycjiUp(Predkosc, Pozycja);
                    PozycjaPortal = jazdaZapadnia.jazdaDoPozycjiUp(Predkosc, PozycjaPortal);
                    Odswiez();
                }

            }
            if (Pozycja > PozycjaZadana)
            {
                if ((float)Math.Round(Pozycja, 1) == PozycjaZadana)
                {
                    Aktywacja = false;
                    Predkosc = 0;
                    ZmianaAktywacjaDoPozycji();
                    Odswiez();
                }
                else if (Pozycja < PozycjaZadana + 10)
                {
                    Pozycja = jazdaZapadnia.jazdaDoPozycjiDown(Przychamowanie, Pozycja);
                    PozycjaPortal = jazdaZapadnia.jazdaDoPozycjiDown(Przychamowanie, PozycjaPortal);
                    Odswiez();
                }
                else
                {
                    Pozycja = jazdaZapadnia.jazdaDoPozycjiDown(Predkosc, Pozycja);
                    PozycjaPortal = jazdaZapadnia.jazdaDoPozycjiDown(Predkosc, PozycjaPortal);
                    Odswiez();
                }
            }



        }
        public void Odswiez()
        {
            textBoxPozycja.Text = ((float)Math.Round((Pozycja / 20), 2)).ToString() + " m";
            textBoxRozstaw.Text = ((float)Math.Round(((PozycjaPortal - Pozycja) / 20), 2)).ToString() + " m";
            textBoxPredkosc.Text = Predkosc.ToString();
            pictureBox1.Invalidate();
        }

        private void buttonAktywacja_Click(object sender, EventArgs e)
        {
            if (Aktywacja == false)
            {
                Aktywacja = true;
                buttonAktywacja.BackColor = Color.IndianRed;

                if ((Aktywacja == true && DoPozycji == true) || (Aktywacja == true && Joystick == true))
                {
                    JazdaDoPozycjiOdryglowanie();
                    LadujKolor();
                    pictureBox1.Invalidate();
                }
                else if ((Aktywacja == true && Rozstaw == true))
                {
                    JazdaRozstawOdryglowanie();
                    LadujKolor();
                    pictureBox1.Invalidate();

                }
            }
            else
            {
                Aktywacja = false;
                //Rozstaw = false;
                buttonAktywacja.BackColor = Color.SkyBlue;
                buttonZmianaRozstaw.BackColor = Color.SkyBlue;
                textBoxWynik.Text = db.ZapiszPozycja(rysujZapadnia.Id, (decimal)Pozycja, (decimal)PozycjaPortal);
                Ryglowanie();
                LadujKolor();
                pictureBox1.Invalidate();
            }
        }

        private void buttonZmianaRozstaw_Click(object sender, EventArgs e)
        {
            if (Aktywacja == true)
            {
                if (Rozstaw == false)
                {
                    Rozstaw = true;
                    buttonZmianaRozstaw.BackColor = Color.IndianRed;
                }
                else
                {
                    Rozstaw = false;
                    buttonZmianaRozstaw.BackColor = Color.SkyBlue;
                }
            }
        }

        public void AktywujDoPozycji()
        {
            DoPozycji = true;
            Rozstaw = false;
            Joystick = false;
            //buttonZmianaRozstaw.BackColor = Color.SkyBlue;
            //buttonZmianaRozstaw.Enabled = false;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            Pen pioro = new Pen(Color.Gray);
            Font textFont = new Font("Century", 10F);
            SolidBrush kolor = new SolidBrush(Color.Gray);
            int x = 15;
            for (int i = 0; i <= 9; i++)
            {
                g.DrawLine(pioro, 2, x, 120, x);
                g.DrawString("- " + i, textFont, kolor, 122, x - 8);
                x += 65;

            }

        }

        private void textBoxMiejsceStop_MouseClick(object sender, MouseEventArgs e)
        {
            panelMiejsceStop.Visible = true;
            panelMiejsceStop.Left = 0;
            panelMiejsceStop.Top = 0;

        }

        void WczytajMiejsceStop(string x)
        {
            PozycjaZadana = float.Parse(x) * -20;
            textBoxMiejsceStop.Text = "- " + x;
            panelMiejsceStop.Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button3.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button6.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button5.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button4.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button12.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button11.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button10.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button9.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button8.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button7.Text);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button24.Text);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button23.Text);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button22.Text);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button21.Text);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button20.Text);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button19.Text);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button18.Text);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button17.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button16.Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button15.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button14.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button13.Text);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button48.Text);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button47.Text);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button46.Text);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button45.Text);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button44.Text);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button43.Text);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button42.Text);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button41.Text);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button40.Text);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button39.Text);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button38.Text);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button37.Text);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button36.Text);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button35.Text);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button34.Text);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button33.Text);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button32.Text);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button31.Text);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button30.Text);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button29.Text);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button28.Text);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button27.Text);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button26.Text);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button25.Text);
        }

        private void button57_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button57.Text);
        }

        private void button56_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button56.Text);
        }

        private void button55_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button55.Text);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button54.Text);
        }

        private void button53_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button53.Text);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button52.Text);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button51.Text);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button50.Text);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button49.Text);
        }

        private void button58_Click(object sender, EventArgs e)
        {
            WczytajMiejsceStop(button58.Text);
        }



        private void buttonZamknijPanelPredkosc_Click(object sender, EventArgs e)
        {
            panelPredkosc.Visible = false;
        }

        private void trackBarPredkosc_Scroll(object sender, EventArgs e)
        {
            Predkosc = trackBarPredkosc.Value;
            textBoxPredkosc.Text = Predkosc.ToString();
        }

        private void textBoxPredkosc_MouseClick(object sender, MouseEventArgs e)
        {
            panelPredkosc.Visible = true;
        }

        private void trackBarPredkosc_MouseUp(object sender, MouseEventArgs e)
        {
            panelPredkosc.Visible = false;
        }
    }
}
