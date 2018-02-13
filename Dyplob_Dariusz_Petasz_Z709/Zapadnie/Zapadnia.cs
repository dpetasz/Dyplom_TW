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
    public partial class Zapadnia : UserControl
    {
        static public List<Zapadnia> ListaZapadnia = new List<Zapadnia>();

        RysujZapadnia rysujZapadnia = new RysujZapadnia();
        JazdaZapadnia jazdaZapadnia = new JazdaZapadnia();
        Graphics g;

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
        bool rozstaw;
        public bool Rozstaw
        {
            get { return rozstaw; }
            set { rozstaw = value; }
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
            rysujZapadnia.Wypelnienie();
            ListaZapadnia.Add(this);
        }
        void LadujDane()
        {
            textBoxNazwa.Text = rysujZapadnia.Nazwa;
            textBoxPozycja.Text = (Pozycja / 20).ToString();
            textBoxRozstaw.Text = ((PozycjaPortal - Pozycja) / 20).ToString();
            textBoxPredkosc.Text = Predkosc.ToString();
        }

        private void Zapadnia_Load(object sender, EventArgs e)
        {
            LadujDane();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            rysujZapadnia.Obramowanie(g);
            rysujZapadnia.ZapadniaJazda(g, Pozycja, PozycjaPortal);
        }

        public void Joystick()
        {
            if (Pozycja > -10 && Predkosc > 0)
            {
                PozycjaPortal = jazdaZapadnia.jazdaJoystick(Przychamowanie, PozycjaPortal);
                Pozycja = jazdaZapadnia.jazdaJoystick(Przychamowanie, Pozycja);
                Odswiez();
            }
            else if (Pozycja < -180 && Predkosc < 0)
            {
                PozycjaPortal = jazdaZapadnia.jazdaJoystick(Przychamowanie * -1, PozycjaPortal);
                Pozycja = jazdaZapadnia.jazdaJoystick(Przychamowanie * -1, Pozycja);
                Odswiez();
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
            if (PozycjaPortal - Pozycja < 70 && Predkosc > 0)
            {
                Pozycja = jazdaZapadnia.jazdaJoystick(Przychamowanie, Pozycja);
                Odswiez();
            }
            else if (Pozycja > -10 && Predkosc > 0)
            {
                Pozycja = jazdaZapadnia.jazdaJoystick(Przychamowanie, Pozycja);
                Odswiez();
            }
            else if (Pozycja < -180 && Predkosc < 0)
            {
                Pozycja = jazdaZapadnia.jazdaJoystick(Przychamowanie * -1, Pozycja);
                Odswiez();
            }
            else
            {
                Pozycja = jazdaZapadnia.jazdaJoystick(Predkosc, Pozycja);
                Odswiez();
            }
        }

        public void Odswiez()
        {
            textBoxPozycja.Text = (Pozycja / 20).ToString();
            textBoxRozstaw.Text = ((PozycjaPortal - Pozycja) / 20).ToString();
            textBoxPredkosc.Text = Predkosc.ToString();
            pictureBox1.Invalidate();
        }
        public void ZmianaAktywacja()
        {
            if (Aktywacja == false)
            {

                buttonAktywacja.BackColor = Color.SkyBlue;
            }
            else
            {

                buttonAktywacja.BackColor = Color.Maroon;
            }
        }
        private void buttonAktywacja_Click(object sender, EventArgs e)
        {
            if (Aktywacja == false)
            {
                Aktywacja = true;
                buttonAktywacja.BackColor = Color.IndianRed;
            }
            else
            {
                Aktywacja = false;
                Rozstaw = false;
                buttonAktywacja.BackColor = Color.SkyBlue;
                buttonZmianaRozstaw.BackColor = Color.SkyBlue;
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
    }
}
