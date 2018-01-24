using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.Wozki
{
    public class RysujWozek
    {

        static public List<RysujWozek> ListaWozek = new List<RysujWozek>();


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
        int pozycja;
        public int Pozycja
        {
            get { return pozycja; }
            set { pozycja = value; }
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
        public RysujWozek()
        {

        }

        public RysujWozek(float x, int p, int vmax, string name)
        {
            Pozycja = p;
            Jazda = x;
            PredkoscMax = vmax;
            Nazwa = name;
            Aktywacja = false;
            Kierunek = false;
            Przychamowanie = 10;
            ListaWozek.Add(this);
        }


        public void Wozek(Graphics g)
        {

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //rysuje wozek
            g.FillRectangle(pioro1, jazda + 20, pozycja, 460, 90);
            g.DrawRectangle(pioro, jazda + 20, pozycja, 460, 90);
            //napis
            g.DrawString(Nazwa.ToString(), textFont, KolorLiczby, jazda + 20, pozycja);


        }
        public void WozekJazda(Graphics g, float x)
        {
            Jazda = x;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //rysuje wozek
            g.FillRectangle(pioro1, jazda + 20, pozycja, 460, 90);
            g.DrawRectangle(pioro, jazda + 20, pozycja, 460, 90);
            //napis
            g.DrawString(Nazwa.ToString(), textFont, KolorLiczby, jazda + 180, pozycja + 30);


        }

        public void Scena(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g.FillRectangle(pioro3, 20, 20, 460, 360);
            g.DrawRectangle(pioro, 20, 20, 460, 360);
            g.DrawRectangle(pioro, 480, 20, 140, 360);
            g.DrawRectangle(pioro, 620, 20, 460, 360);
        }

        public float ruch(bool kierunek, int v)
        {
            switch (kierunek)
            {
                case true:
                    {
                        this.Jazda += v * 0.002f;
                        if (Math.Round(Jazda, 1) == 29) Jazda += 5 * 0.002f;
                        if (Math.Round(Jazda, 1) == 30) break;
                        break;
                    }
                case false:
                    {
                        this.Jazda -= v * 0.002f;
                        if (Math.Round(Jazda, 1) == 1) Jazda -= 5 * 0.002f;
                        if (Math.Round(Jazda, 1) == 0) break;
                        break;
                    }
            }
            return (float)Math.Round(Jazda, 1);

        }
        /*public void Wypelnienie()
        {
            wyp.Wypelnienie(this);

        }*/
        public void WozekPokaz()
        {
            //w.WozekTworz(this);
        }
    }
}
