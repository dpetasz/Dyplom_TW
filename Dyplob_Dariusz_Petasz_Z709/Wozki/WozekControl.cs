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
    public partial class WozekControl : UserControl
    {
        static public List<WozekControl> ListaWozek = new List<WozekControl>();


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
        public WozekControl(float x,  int vmax, string name)
        {
            InitializeComponent();
            
            Jazda = x;
            PredkoscMax = vmax;
            Nazwa = name;
            Aktywacja = false;
            Kierunek = false;
            Przychamowanie = 10;
            ListaWozek.Add(this);
        }
        public void WozekJazda(Graphics g, float x)
        {
            Jazda = x;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //rysuje wozek
            g.FillRectangle(pioro1, jazda , 0, 460, 90);
            g.DrawRectangle(pioro, jazda , 0, 460, 90);
            //napis
            g.DrawString(Nazwa.ToString(), textFont, KolorLiczby, jazda + 180,  30);


        }
        /*public void Wypelnienie()
        {
            wyp.Wypelnienie(this);

        }*/
    }
}
