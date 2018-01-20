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

        StanWozek w = new Wozek1();

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
        public string Nazwa
        {
            get { return nazwa; }
            set { nazwa = value; }
        }

        int pozycja;
        public int Pozycja
        {
            get { return pozycja; }
            set { pozycja = value; }
        }
        float jazda;
        public float Jazda
        {
            get { return jazda; }
            set { jazda = value; }
        }
        int predkoscMax;
        public int PredkoscMax
        {
            get { return predkoscMax; }
            set { predkoscMax = value; }
        }
        public RysujWozek()
        {
            
        }
        
        public RysujWozek(float x, int y, int vmax, string name)
        {
            Pozycja = y;
            Jazda = x;
            PredkoscMax = vmax;
            Nazwa = name;
            
        }


        public void Wozek(Graphics g)
        {
            
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //rysuje wozek
            g.FillRectangle(pioro1, jazda + 20, pozycja, 460, 90);
            g.DrawRectangle(pioro, jazda + 20, pozycja, 460, 90);
            //napis
            g.DrawString(Nazwa.ToString(), textFont, KolorLiczby, jazda+20 , pozycja);


        }
        public void WozekJazda(Graphics g, float x)
        {
            Jazda = x;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //rysuje wozek
            g.FillRectangle(pioro1, jazda+20, pozycja, 460, 90);
            g.DrawRectangle(pioro, jazda+20, pozycja, 460, 90);
            //napis
            g.DrawString(Nazwa.ToString(), textFont, KolorLiczby, jazda, pozycja);


        }
        
        public void Scena(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g.FillRectangle(pioro3, 20, 20, 460, 360);
            g.DrawRectangle(pioro, 20, 20, 460, 360);
            g.DrawRectangle(pioro, 480, 20, 140, 360);
            g.DrawRectangle(pioro, 620, 20, 460, 360);
        }
       
        public void Wypelnienie()
        {
            wyp.Wypelnienie(this);

        }
        public void WozekPokaz()
        {
            w.WozekTworz(this);
        }
    }
}
