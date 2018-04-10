using Dyplom_Dariusz_Petasz_Z709.Wozki;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.Urzadzenia
{
    public class RysujUrzadzenie 
    {
        
        string nazwa;
        public string Nazwa
        {
            get { return nazwa; }
            set { nazwa = value; }
        }

        public string GetNazwa()
        {
            return Nazwa;
        }
        public void SetNazwa(string Nazwa)
        {
            this.Nazwa = Nazwa;
        }

        Pen pioroLinia, pioro, liniaPrzycisk;
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
        public Pen GetPioro()
        {
            return Pioro;
        }
        public Pen LiniaPrzycisk
        {
            get
            {
                return liniaPrzycisk;
            }
            set
            {
                liniaPrzycisk = value;
            }
        }
        SolidBrush pioro1, pioro2, pioro3, kolorLiczby, rygiel_1, rygiel_2, rygiel_3, start, kolorTextPrzycisk;
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
        public SolidBrush GetPioro1()
        {
            return Pioro1;
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
        public SolidBrush GetPioro3()
        {
            return Pioro3;
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
        public SolidBrush GetKolorLiczby()
        {
            return KolorLiczby;
        }
        public SolidBrush Rygiel_1
        {
            get
            {
                return rygiel_1;
            }
            set
            {
                rygiel_1 = value;
            }
        }
        public SolidBrush Rygiel_2
        {
            get
            {
                return rygiel_2;
            }
            set
            {
                rygiel_2 = value;
            }
        }
        public SolidBrush Rygiel_3
        {
            get
            {
                return rygiel_3;
            }
            set
            {
                rygiel_3 = value;
            }
        }
        public SolidBrush Start
        {
            get
            {
                return start;
            }
            set
            {
                start = value;
            }
        }
        public SolidBrush KolorTextPrzycisk
        {
            get
            {
                return kolorTextPrzycisk;
            }
            set
            {
                kolorTextPrzycisk = value;
            }
        }
        Font textFont, textPrzycisk;
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
        public Font GetTextFont()
        {
            return TextFont;
        }
        public Font TextPrzycisk
        {
            get
            {
                return TextPrzycisk;
            }
            set
            {
                TextPrzycisk = value;
            }
        }
        public SolidBrush wypelnienieTrojkat;

        public virtual void Wypelnienie()
        {
            pioroLinia = new Pen(Color.Black);

            Pioro1 = new SolidBrush(Color.SkyBlue);
            Pioro2 = new SolidBrush(Color.DeepSkyBlue);
            Pioro3 = new SolidBrush(Color.Green);
            TextFont = new Font("Century", 7F, FontStyle.Bold);
            KolorLiczby = new SolidBrush(Color.Gray);
            Pioro = new Pen(Color.Gray);
        }
        public virtual void WypelnienieJazda()
        {
            pioroLinia = new Pen(Color.Black);

            Pioro1 = new SolidBrush(Color.DeepSkyBlue);
            Pioro2 = new SolidBrush(Color.SkyBlue);
            Pioro3 = new SolidBrush(Color.Green);
            TextFont = new Font("Century", 7F, FontStyle.Bold);
            KolorLiczby = new SolidBrush(Color.Gray);
            Pioro = new Pen(Color.Gray);
        }
        public virtual void WypelnienieJazdaRozstaw()
        {
            Rygiel_1 = new SolidBrush(Color.IndianRed);
            Rygiel_2 = new SolidBrush(Color.DeepSkyBlue);
            Rygiel_3 = new SolidBrush(Color.DeepSkyBlue);

        }

        public virtual void WypelnienieJazdaZapadnia()
        {
            Rygiel_1 = new SolidBrush(Color.DeepSkyBlue);
            Rygiel_2 = new SolidBrush(Color.IndianRed);
            Rygiel_3 = new SolidBrush(Color.DeepSkyBlue);

        }
        public virtual void WypelnienieZaryglowanie()
        {
            Rygiel_1 = new SolidBrush(Color.IndianRed);
            Rygiel_2 = new SolidBrush(Color.IndianRed);
            Rygiel_3 = new SolidBrush(Color.IndianRed);

        }
       
    }
}
