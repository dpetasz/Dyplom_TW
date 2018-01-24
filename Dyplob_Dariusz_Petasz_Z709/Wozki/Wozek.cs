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
        public Wozek()
        {
            InitializeComponent();
        }
        static public List<Wozek> ListaWozek = new List<Wozek>();
        Graphics g;

        StanWypWozki wyp = new Wypelnienie1();

        Pen pioroLinia, pioro;
        public Pen PioroLinia
        {
            get
            {
                return pioroLinia;
            }
            set
            {
                pioroLinia = value;
            }
        }
        public Pen Pioro
        {
            get
            {
                return pioro;
            }
            set
            {
                pioro = value;
            }
        }

        SolidBrush pioro1, pioro2, pioro3, kolorLiczby;
        public SolidBrush Pioro1
        {
            get
            {
                return pioro1;
            }
            set
            {
                pioro1 = value;
            }
        }
        public SolidBrush Pioro2
        {
            get
            {
                return pioro2;
            }
            set
            {
                pioro2 = value;
            }
        }
        public SolidBrush Pioro3
        {
            get
            {
                return pioro3;
            }
            set
            {
                pioro3 = value;
            }
        }
        public SolidBrush KolorLiczby
        {
            get
            {
                return kolorLiczby;
            }
            set
            {
                kolorLiczby = value;
            }
        }

        Font textFont;
        public Font TextFont
        {
            get
            {
                return textFont;
            }
            set
            {
                textFont = value;
            }
        }
        int id;
        int Id
        {
            get { return id; }
            set { id = value; }
        }
        string nazwa;
        string Nazwa
        {
            get { return nazwa; }
            set { nazwa = value; }
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
        float jazda;
        public float Jazda
        {
            get { return jazda; }
            set { jazda = value; }
        }
        int predkoscMax;
        int PredkoscMax
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
        private void Wozek_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Wypelnienie();
            Scena(g);
            WozekJazda(g, Jazda);

        }

        public void Wypelnienie()
        {
            wyp.Wypelnienie(this);

        }
        
        public Wozek(float x, int vmax, string name, int idW)
        {
            InitializeComponent();

            Id = idW;
            Jazda = x;
            PredkoscMax = vmax;
            Nazwa = name;
            Aktywacja = false;
            Kierunek = false;
            Przychamowanie = 10;
            ListaWozek.Add(this);
            LadujPrzyciski();
        }
       
        public void WozekJazda(Graphics g, float x)
        {
            Jazda = x;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //rysuje wozek
            g.FillRectangle(pioro1, jazda, 1, 460, 104);
            g.DrawRectangle(pioro, jazda, 1, 460, 104);
            //napis
            g.DrawString(Nazwa.ToString(), textFont, KolorLiczby, jazda + 180, 30);


        }
        public void Scena(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g.FillRectangle(pioro3, 0, 0, 460, 105);
            g.DrawRectangle(pioro, 0, 0, 460, 105);
            //g.DrawRectangle(pioro, 480, 20, 140, 360);
            g.DrawRectangle(pioro, 600, 0, 460, 105);
        }
        void LadujPrzyciski()
        {
            textBoxPozycja.Text = Jazda.ToString();
            textBoxPredkosc.Text = Predkosc.ToString();
            buttonAktywuj.Text = "Aktywuj W-" + Id;
            LadujAktywuj();
            LadujKierunek();
        }

        void LadujAktywuj()
        {
            if (Aktywacja == true)
            {

                Red();
            }
            else
            {

                Green();
            }
        }
        void Green()
        {

            buttonAktywuj.BackColor = Color.Green;
            buttonAktywuj.Text = "Aktywuj W-" + Id;
            this.wyp = new Wypelnienie1();
            Invalidate();
        }
        void Red()
        {

            buttonAktywuj.BackColor = Color.Firebrick;
            buttonAktywuj.Text = "Aktywny W-" + Id;
            this.wyp = new WypelnienieJazdaWozek();
            Invalidate();
        }

        void LadujKierunek()
        {
            if (Kierunek == false)
            {
                buttonLewo.BackColor = Color.Firebrick;
                buttonPrawo.BackColor = Color.Green;
            } else
            {
                buttonLewo.BackColor = Color.Green;
                buttonPrawo.BackColor = Color.Firebrick;
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
