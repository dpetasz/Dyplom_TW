using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dyplom_Dariusz_Petasz_Z709.Mosty;
using Dyplom_Dariusz_Petasz_Z709.Urzadzenia;
using Dyplom_Dariusz_Petasz_Z709.BD_TW;

namespace Dyplom_Dariusz_Petasz_Z709
{
    public partial class Most : UserControl
    {
        static public List<Most> ListaMost = new List<Most>();

        RysujMost rysujMost = new RysujMost();
        IJazdaMost jazdaMost = new JazdaMost();
        IZapiszMost db = new ZapiszMost();
        Graphics g;

        bool doPozycji;
        public bool DoPozycji
        {
            get { return doPozycji; }
            set { doPozycji = value; }
        }
        bool programowa;
        public bool Programowa
        {
            get { return programowa; }
            set { programowa = value; }
        }
        bool joystick;
        public bool Joystick
        {
            get { return joystick; }
            set { joystick = value; }
        }
        bool manualna;
        public bool Manualna
        {
            get { return manualna; }
            set { manualna = value; }
        }
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
        public Most(int Id, string Nazwa, float Pozycja, int PredkoscMax, int Przychamowanie)
        {
            InitializeComponent();
            SetId(Id);
            rysujMost.Nazwa = Nazwa;
            this.Pozycja = Pozycja;
            this.Aktywacja = false;
            this.PredkoscMax = PredkoscMax;
            this.Predkosc = 0;
            this.Przychamowanie = Przychamowanie;
            rysujMost.Wypelnienie();
            ListaMost.Add(this);

        }

        public void AktywujDoPozycji()
        {
            DoPozycji = true;
            Manualna = false;
            Joystick = false;
            Programowa = false;
            Aktywacja = false;
            textBoxPozycjaZadana.ReadOnly = false;
            Odswiez();
        }

        public void AktywujManualna()
        {
            DoPozycji = false;
            Manualna = true;
            Joystick = false;
            Programowa = false;
            Aktywacja = false;
            textBoxPozycjaZadana.ReadOnly = true;
            Odswiez();
        }
        public void AktywujJoystick()
        {
            DoPozycji = false;
            Manualna = false;
            Joystick = true;
            Programowa = false;
            Aktywacja = false;
            textBoxPozycjaZadana.ReadOnly = true;
            Odswiez();
        }
        public void AktywujProgamowa()
        {
            DoPozycji = true;
            Manualna = false;
            Joystick = false;
            Programowa = true;
            Aktywacja = false;
            textBoxPozycjaZadana.ReadOnly = false;
            Odswiez();
        }
        private void Most_Load(object sender, EventArgs e)
        {
            textBoxNazwa.Text = rysujMost.Nazwa;
            Odswiez();
        }

        void PrzyciskAktywacja()
        {
            if (Aktywacja == false)
            {
                buttonAktywacja.BackColor = Color.SkyBlue;
            }
            else buttonAktywacja.BackColor = Color.IndianRed;
        }
        private void buttonAktywacja_Click(object sender, EventArgs e)
        {
            if (Aktywacja == false)
            {
                Aktywacja = true;
                PrzyciskAktywacja();
            }
            else
            {
                Aktywacja = false;
                PrzyciskAktywacja();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            rysujMost.Obramowanie(g);
            rysujMost.MostJazda(g, Pozycja);
        }

        public void JazdaManual()
        {
            SetPozycja(jazdaMost.jazdaManual(Kierunek, Predkosc, Pozycja));
            Odswiez();
        }
        public void JazdaJoystick()
        {
            float x = Kg - 3, y = Kd + 3;
            if ((Pozycja >= x) && Predkosc > 0)
            {
                if (GetPozycja() >= Kg && GetPredkosc() > 0)
                {
                    ZmianaAktywacjaJoystick();
                    ZapiszPozycjaBaza();
                    ZmianaKrancowa();
                }
                else
                {
                    SetPozycja(jazdaMost.jazdaJoystick(Przychamowanie, GetPozycja()));
                    Odswiez();
                }
            }
            else if ((Pozycja <= y) && Predkosc < 0)
            {
                if (GetPozycja() <= Kd && GetPredkosc() < 0)
                {
                    ZmianaAktywacjaJoystick();
                    ZapiszPozycjaBaza();
                    ZmianaKrancowa();
                }
                else
                {
                    SetPozycja(jazdaMost.jazdaJoystick(Przychamowanie * -1, GetPozycja()));
                    Odswiez();
                }


            }
            else
            {
                SetPozycja(jazdaMost.jazdaJoystick(Predkosc, GetPozycja()));
                Odswiez();
            }
        }
        public void JazdaDoPozycji()
        {
            WczytajPozycjaZadana();
            SetPozycja(jazdaMost.jazdaDoPozycjiDown(Predkosc, Pozycja));
            Odswiez();
            if (Pozycja < PozycjaZadana)
            {
                if ((float)Math.Round(Pozycja, 1) == PozycjaZadana)
                {
                    Predkosc = 0;
                    ZmianaAktywacjaDoPozycji();
                    Odswiez();
                }
                else if (Pozycja > PozycjaZadana - 10)
                {
                    Pozycja = jazdaMost.jazdaDoPozycjiUp(Przychamowanie, Pozycja);

                    Odswiez();
                }
                else
                {
                    Pozycja = jazdaMost.jazdaDoPozycjiUp(Predkosc, Pozycja);
                    Odswiez();
                }

            }
            if (Pozycja > PozycjaZadana)
            {
                if ((float)Math.Round(Pozycja, 1) == PozycjaZadana)
                {
                    ZmianaAktywacjaDoPozycji();
                    Odswiez();
                }
                else if (Pozycja < PozycjaZadana + 10)
                {
                    Pozycja = jazdaMost.jazdaDoPozycjiDown(Przychamowanie, Pozycja);
                    Odswiez();
                }
                else
                {
                    Pozycja = jazdaMost.jazdaDoPozycjiDown(Predkosc, Pozycja);
                    Odswiez();
                }
            }

        }
        public void Odswiez()
        {
            textBoxPozycja.Text = ((float)Math.Round((Pozycja / 10), 2)).ToString() + " m";
            textBoxPozycjaZadana.Text = ((float)Math.Round((PozycjaZadana / 10), 2)).ToString() + " m";
            textBoxPredkosc.Text = Predkosc.ToString();
            PrzyciskAktywacja();
            ZmianaKrancowa();
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
        public void ZmianaKrancowa()
        {
            if (GetPozycja() >= Kg) { textBoxKG.BackColor = Color.Red; } else { textBoxKG.BackColor = Color.DarkSeaGreen; }
            if (GetPozycja() <= Kd) { textBoxKD.BackColor = Color.Red; } else { textBoxKD.BackColor = Color.DarkSeaGreen; }
        }

        private void textBoxPozycjaZadana_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxPozycjaZadana.Clear();
        }
        public void ZmianaManual()
        {
            Aktywacja = false;
            Manualna = true;
            Predkosc = 0;
            textBoxWynik.BackColor = Color.Moccasin;
            PrzyciskAktywacja();
            Odswiez();
        }
        public void ZmianaAktywacjaDoPozycji()
        {
            Aktywacja = false;

            Predkosc = 0;
            textBoxWynik.BackColor = Color.Moccasin;
            PrzyciskAktywacja();
            Odswiez();
        }
        public void ZmianaAktywacjaJoystick()
        {

            Aktywacja = false;
            Predkosc = 0;
            textBoxWynik.BackColor = Color.Moccasin;
            PrzyciskAktywacja();
            Odswiez();

        }
        public void ZapiszPozycjaBaza()
        {
            textBoxWynik.Text = db.ZapiszPozycja(Id, GetPozycja());
        }
        public void WczytajPozycjaZadana()
        {
            try
            {
                PozycjaZadana = float.Parse(textBoxPozycjaZadana.Text.ToString());

            }
            catch
            {
                PozycjaZadana = Pozycja;
                
            }

        }
    }
}
