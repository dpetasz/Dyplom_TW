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
            this.Pozycja = x;
            rysujWozek.PredkoscMax = vmax;
            rysujWozek.Nazwa = name;
            this.Aktywacja = false;
            this.Kierunek = false;
            rysujWozek.Przychamowanie = 10;
            rysujWozek.Wypelnienie();
            ListaWozek.Add(this);

            LadujPrzyciski();
        }
        
/*
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
        }*/
        private void Wozek_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            rysujWozek.Wypelnienie();
            Scena(g);
            WozekJazda(g, rysujWozek.Pozycja);

        }

        /*public void Wypelnienie()
        {
            wyp.Wypelnienie(this);

        }*/
        
        
       
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
            textBoxPozycja.Text = rysujWozek.Pozycja.ToString();
            textBoxPredkosc.Text = rysujWozek.Predkosc.ToString();
            buttonAktywuj.Text = "Aktywuj W-" + rysujWozek.Id;
            LadujAktywuj();
            LadujKierunek();
        }

        void LadujAktywuj()
        {
            if (rysujWozek.Aktywacja == true)
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
            buttonAktywuj.Text = "Aktywuj W-" + rysujWozek.Id;
            rysujWozek.WypelnienieJazda();
            Invalidate();
        }
        void Red()
        {

            buttonAktywuj.BackColor = Color.Firebrick;
            buttonAktywuj.Text = "Aktywny W-" + rysujWozek.Id;
            rysujWozek.Wypelnienie();
            Invalidate();
        }

        private void Wozek_Load(object sender, EventArgs e)
        {

        }

        void LadujKierunek()
        {
            if (rysujWozek.Kierunek == false)
            {
                buttonLewo.BackColor = Color.Maroon;
                buttonPrawo.BackColor = Color.Green;
                buttonLewo.Enabled = false;
                buttonPrawo.Enabled = true;
            } else
            {
                buttonLewo.BackColor = Color.Green;
                buttonPrawo.BackColor = Color.Maroon;
                buttonPrawo.Enabled = false;
                buttonLewo.Enabled = true;
            }
        }
        
        private void buttonAktywuj_Click(object sender, EventArgs e)
        {
            if (rysujWozek.Aktywacja == false)
            {
                rysujWozek.Aktywacja = true;
                LadujAktywuj();
            }
            else
            {
                rysujWozek.Aktywacja = false;
                LadujAktywuj();
            }



        }

        private void buttonLewo_Click(object sender, EventArgs e)
        {
            if (rysujWozek.Kierunek == true)
            {
                rysujWozek.Kierunek = false;
                LadujKierunek();
            }
            else
            {
                rysujWozek.Kierunek = true;
                LadujKierunek();
            }
        }

        private void buttonPrawo_Click(object sender, EventArgs e)
        {
            if (rysujWozek.Kierunek == true)
            {
                rysujWozek.Kierunek = false;
                LadujKierunek();
            }
            else
            {
                rysujWozek.Kierunek = true;
                LadujKierunek();
            }
        }
    }
}
