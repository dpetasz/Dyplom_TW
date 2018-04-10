using Dyplom_Dariusz_Petasz_Z709.ScenaObrotowa;
using Dyplom_Dariusz_Petasz_Z709.Urzadzenia;
using Dyplom_Dariusz_Petasz_Z709.Wozki;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709
{
    public class Urzadzenie: RysujUrzadzenie, IWozek, IObrotowka
    {


        int id;
        int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int GetId()
        {
            return Id;
        }
        public void SetId(int Id)
        {
            this.Id = Id;
        }
        //string nazwa;
        //string Nazwa
        //{
        //    get { return nazwa; }
        //    set { nazwa = value; }
        //}
        //public string GetNazwa()
        //{
        //    return Nazwa;
        //}
        //public void SetNazwa(string Nazwa)
        //{
        //    this.Nazwa = Nazwa;
        //}
        float pozycjaZadana;
        float PozycjaZadana
        {
            get { return pozycjaZadana; }
            set { pozycjaZadana = value; }
        }
        public float GetPozycjaZadana()
        {
            return PozycjaZadana;
        }
        public void SetPozycjaZadana(float PozycjaZadana)
        {
            this.PozycjaZadana = PozycjaZadana;
        }
        bool kierunek;
        bool Kierunek
        {
            get { return kierunek; }
            set { kierunek = value; }
        }
        public bool GetKierunek()
        {
            return Kierunek;
        }
        public void SetKierunek(bool Kierunek)
        {
            this.Kierunek = Kierunek;
        }
        bool aktywacja;
        bool Aktywacja
        {
            get { return aktywacja; }
            set { aktywacja = value; }
        }
        public bool GetAktywacja()
        {
            return Aktywacja;
        }
        public void SetAktywacja(bool Aktywacja)
        {
            this.Aktywacja = Aktywacja;
        }
        int przychamowanie;
        int Przychamowanie
        {
            get { return przychamowanie; }
            set { przychamowanie = value; }
        }
        public int GetPrzychamowanie()
        {
            return Przychamowanie;
        }
        public void SetPrzychamowanie(int Przychamowanie)
        {
            this.Przychamowanie = Przychamowanie;
        }
        float pozycja;
        float Pozycja
        {
            get { return pozycja; }
            set { pozycja = value; }
        }
        public float GetPozycja()
        {
            return Pozycja;
        }
        public void SetPozycja(float Pozycja)
        {
            this.Pozycja = Pozycja;
        }
        int predkoscMax;
        public int PredkoscMax
        {
            get { return predkoscMax; }
            set { predkoscMax = value; }
        }
        int predkosc;
        int Predkosc
        {
            get { return predkosc; }
            set { predkosc = value; }
        }
        public int GetPredkosc()
        {
            return Predkosc;
        }
        public void SetPredkosc(int Predkosc)
        {
            this.Predkosc = Predkosc;
        }

        bool doPozycji;
        public bool DoPozycji
        {
            get { return doPozycji; }
            set { doPozycji = value; }
        }
        public bool GetDoPozycji()
        {
            return DoPozycji;
        }
        public void SetDoPozycji(bool DoPozycji)
        {
            this.DoPozycji = DoPozycji;
        }
        bool programowa;
        public bool Programowa
        {
            get { return programowa; }
            set { programowa = value; }
        }
        public bool GetProgramowa()
        {
            return Programowa;
        }
        public void SetProgramowa(bool Programowa)
        {
            this.Programowa = Programowa;
        }
        bool joystick;
        public bool Joystick
        {
            get { return joystick; }
            set { joystick = value; }
        }
        public bool GetJoystick()
        {
            return Joystick;
        }
        public void SetJoystick(bool Joystick)
        {
            this.Joystick = Joystick;
        }

        bool manualna;
        public bool Manualna
        {
            get { return manualna; }
            set { manualna = value; }
        }
        public bool GetManualna()
        {
            return Manualna;
        }
        public void SetManualna(bool Manualna)
        {
            this.Manualna = Manualna;
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

        public virtual void Wypelnienie()
        {
            pioroLinia = new Pen(Color.Black);

            Pioro1 = new SolidBrush(Color.SkyBlue);
            Pioro2 = new SolidBrush(Color.HotPink);
            Pioro3 = new SolidBrush(Color.Green);
            textFont = new Font("Century", 12F, FontStyle.Bold);
            KolorLiczby = new SolidBrush(Color.FromArgb(10, 10, 10));
            pioro = new Pen(Color.Gray);
        }
        public virtual void WypelnienieJazda()
        {
            //pioroLinia = new Pen(Color.Black);

            Pioro1 = new SolidBrush(Color.Olive);
            //Pioro2 = new SolidBrush(Color.HotPink);
            //Pioro3 = new SolidBrush(Color.Green);
            //textFont = new Font("Century", 12F, FontStyle.Bold);
            //KolorLiczby = new SolidBrush(Color.FromArgb(10, 10, 10));

        }
    }
}
