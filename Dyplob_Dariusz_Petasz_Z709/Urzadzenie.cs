using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709
{
    public class Urzadzenie
    {
        Urzadzenie()
        {

        }
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
        float pozycja;
        public float Pozycja
        {
            get { return pozycja; }
            set { pozycja = value; }
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
    }
}
