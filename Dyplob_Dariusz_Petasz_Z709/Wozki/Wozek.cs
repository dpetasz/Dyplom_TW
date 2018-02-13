using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dyplom_Dariusz_Petasz_Z709.Wozki
{
    public partial class Wozek : UserControl
    {
        static public List<Wozek> ListaWozek = new List<Wozek>();

        RysujWozek rysujWozek = new RysujWozek();
        JazdaWozek jazdaWozek = new JazdaWozek();
        Graphics g;

        int predkoscMax;
        int PredkoscMax
        {
            get { return predkoscMax; }
            set { predkoscMax = value; }
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

        int predkosc;
        public int Predkosc
        {
            get { return predkosc; }
            set { predkosc = value; }
        }
        public Wozek()
        {
            InitializeComponent();
        }
        public Wozek(float x, int vmax, string name, int idW)
        {
            InitializeComponent();

            rysujWozek.Id = idW;
            rysujWozek.Nazwa = name;
            this.Pozycja = x;
            this.PredkoscMax = vmax;

            this.Aktywacja = false;
            this.Kierunek = false;
            //this.Przychamowanie = 10;
            rysujWozek.Wypelnienie();
            ListaWozek.Add(this);
            this.Predkosc = 0;
            LadujPrzyciski();
            rysujWozek.Wypelnienie();
        }





        private void Wozek_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Scena(g);
            WozekJazda(g, Pozycja);

        }





        public void WozekJazda(Graphics g, float x)
        {

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //rysuje wozek
            g.FillRectangle(rysujWozek.Pioro1, x, 1, 460, 104);
            g.DrawRectangle(rysujWozek.Pioro, x, 1, 460, 104);
            //napis
            g.DrawString(rysujWozek.Nazwa.ToString(), rysujWozek.TextFont, rysujWozek.KolorLiczby, x + 180, 30);


        }
        public void Scena(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g.FillRectangle(rysujWozek.Pioro3, 0, 0, 460, 105);
            g.DrawRectangle(rysujWozek.Pioro, 0, 0, 460, 105);
            //g.DrawRectangle(pioro, 480, 20, 140, 360);
            g.DrawRectangle(rysujWozek.Pioro, 600, 0, 460, 105);
        }
        void LadujPrzyciski()
        {
            textBoxPozycja.Text = (Pozycja/20).ToString();
            textBoxPredkosc.Text = Predkosc.ToString();
            buttonAktywuj.Text = "Aktywuj W-" + rysujWozek.Id;
            LadujAktywuj();
            LadujKierunek();
            Invalidate();
        }

        public void LadujAktywuj()
        {
            if (Aktywacja == true)
            {
                rysujWozek.WypelnienieJazda();
                Red();
            }
            else
            {
                rysujWozek.Wypelnienie();
                Green();
            }
        }
        void Green()
        {

            buttonAktywuj.BackColor = Color.SkyBlue;
            buttonAktywuj.Text = "Aktywuj W-" + rysujWozek.Id;
            rysujWozek.Wypelnienie();
            Invalidate();
        }
        void Red()
        {

            buttonAktywuj.BackColor = Color.IndianRed;
            buttonAktywuj.Text = "Aktywny W-" + rysujWozek.Id;
            rysujWozek.WypelnienieJazda();
            Invalidate();
        }
        public void Joystick()
        {
            if (Pozycja >= 590 && Predkosc > 0)
            {
                Pozycja = jazdaWozek.jazdaJoystick(Przychamowanie, Pozycja);
                LadujPrzyciski();
            } else if (Pozycja <= 10 && Predkosc < 0)
            {
                Pozycja = jazdaWozek.jazdaJoystick(Przychamowanie * -1, Pozycja);
                LadujPrzyciski();
            }
            else
            {
                Pozycja = jazdaWozek.jazdaJoystick(Predkosc, Pozycja);
                LadujPrzyciski();
            }
        }

        private void Wozek_Load(object sender, EventArgs e)
        {

        }

        void LadujKierunek()
        {
            if (Kierunek == false)
            {
                buttonLewo.BackColor = Color.DarkSeaGreen;
                buttonPrawo.BackColor = Color.SkyBlue;
                buttonLewo.Enabled = false;
                buttonPrawo.Enabled = true;
            }
            else
            {
                buttonLewo.BackColor = Color.SkyBlue;
                buttonPrawo.BackColor = Color.DarkSeaGreen;
                buttonPrawo.Enabled = false;
                buttonLewo.Enabled = true;
            }
        }

        private void buttonAktywuj_Click(object sender, EventArgs e)
        {
            if (Aktywacja == false)
            {
                Aktywacja = true;
                LadujAktywuj();
            }
            else
            {
                Aktywacja = false;
                LadujAktywuj();
            }



        }

        private void buttonLewo_Click(object sender, EventArgs e)
        {
            if (Kierunek == true)
            {
                Kierunek = false;
                LadujKierunek();
            }
            else
            {
                Kierunek = true;
                LadujKierunek();
            }
        }

        private void buttonPrawo_Click(object sender, EventArgs e)
        {
            if (Kierunek == true)
            {
                Kierunek = false;
                LadujKierunek();
            }
            else
            {
                Kierunek = true;
                LadujKierunek();
            }
        }
    }
}
