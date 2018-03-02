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
        public int Id
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
        public bool GetKierunek()
        {
            return Kierunek;
        }
        public void SetKierunek(bool Kierunek)
        {
            this.Kierunek = Kierunek;
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
        public float GetPozycja()
        {
            return Pozycja;
        }

        public void SetPozycja(float Pozycja)
        {
            this.Pozycja = Pozycja;
        }
        int predkosc;
        public int Predkosc
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
        public Wozek()
        {
            InitializeComponent();
        }
        public Wozek(float x, int vmax, string name, int idW)
        {
            InitializeComponent();

            SetId(idW);
            rysujWozek.Nazwa = name;
            this.Pozycja = x;
            this.PredkoscMax = vmax;

            this.Aktywacja = false;
            this.Kierunek = false;
            this.Przychamowanie = 10;
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

        public void AktywujDoPozycji()
        {
            DoPozycji = true;
            Manualna = false;
            Joystick = false;
            Programowa = false;
            Aktywacja = false;
            textBoxStop.ReadOnly = false;
            Odswiez();
        }

        public void AktywujManualna()
        {
            DoPozycji = false;
            Manualna = true;
            Joystick = false;
            Programowa = false;
            Aktywacja = false;
            textBoxStop.ReadOnly = true;
            Odswiez();
        }
        public void AktywujJoystick()
        {
            DoPozycji = false;
            Manualna = false;
            Joystick = true;
            Programowa = false;
            Aktywacja = false;
            textBoxStop.ReadOnly = true;
            Odswiez();
        }
        public void AktywujProgamowa()
        {
            DoPozycji = true;
            Manualna = false;
            Joystick = false;
            Programowa = true;
            Aktywacja = false;
            textBoxStop.ReadOnly = false;
            Odswiez();
        }
        void LadujPrzyciski()
        {
            textBoxPozycja.Text = ((float)Math.Round(GetPozycja() / 20, 2)).ToString() + " m";
            textBoxStop.Text = ((float)Math.Round(GetPozycjaZadana() / 20, 2)).ToString() + " m";
            textBoxPredkosc.Text = Math.Abs(Predkosc).ToString();
            buttonAktywacja.Text = "Aktywuj W-" + GetId();
            LadujAktywuj();
            PrzyciskKierunek();
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

            buttonAktywacja.BackColor = Color.SkyBlue;
            buttonAktywacja.Text = "Aktywuj W-" + GetId();
            rysujWozek.Wypelnienie();
            Invalidate();
        }
        void Red()
        {

            buttonAktywacja.BackColor = Color.IndianRed;
            buttonAktywacja.Text = "Aktywny W-" + GetId();
            rysujWozek.WypelnienieJazda();
            Invalidate();
        }
        public void JazdaJoystick()
        {
            if (GetPozycja() >= 590 && GetPredkosc() > 0)
            {
                SetPozycja(jazdaWozek.jazdaJoystick(Przychamowanie, GetPozycja()));
                LadujPrzyciski();
            }
            else if (GetPozycja() <= 10 && GetPredkosc() < 0)
            {
                SetPozycja(jazdaWozek.jazdaJoystick(Przychamowanie * -1, GetPozycja()));
                LadujPrzyciski();
            }
            else
            {
                SetPozycja(jazdaWozek.jazdaJoystick(GetPredkosc(), GetPozycja()));
                LadujPrzyciski();
            }
        }

        public void JazdaManual()
        {
            if (GetPozycja() <= Kg + 5 && GetKierunek() == false)
            {
                if (GetPozycja() <= Kg)
                {
                    ZmianaAktywacja();
                    //ZapiszPozycjaBaza();
                }
                else
                {
                    SetPozycja(jazdaWozek.jazdaManual(GetKierunek(), Przychamowanie, GetPozycja()));
                    Odswiez();
                }

            }
            else if (GetPozycja() >= Kd - 5 && GetKierunek() == true)
            {
                if (GetPozycja() >= Kd)
                {
                    ZmianaAktywacja();
                    //ZapiszPozycjaBaza();
                }
                else
                {
                    SetPozycja(jazdaWozek.jazdaManual(GetKierunek(), Przychamowanie, GetPozycja()));
                    Odswiez();
                }
            }
            else
            {
                SetPozycja(jazdaWozek.jazdaManual(GetKierunek(), GetPredkosc(), GetPozycja()));
                Odswiez();
            }

        }

        public void JazdaDoPozycji()
        {


            if (GetPozycja() < PozycjaZadana)
            {
                if ((float)Math.Round(Pozycja, 1) == PozycjaZadana)
                {
                    Predkosc = 0;
                    ZmianaAktywacja();
                    Odswiez();
                }
                else if (GetPozycja() > PozycjaZadana - 5)
                {
                    SetPozycja(jazdaWozek.jazdaDoPozycjiUp(Przychamowanie, Pozycja));

                    Odswiez();
                }
                else
                {
                    SetPozycja(jazdaWozek.jazdaDoPozycjiUp(Predkosc, Pozycja));
                    Odswiez();
                }

            }
            if (GetPozycja() > PozycjaZadana)
            {
                if ((float)Math.Round(Pozycja, 1) == PozycjaZadana)
                {
                    ZmianaAktywacja();
                    Odswiez();
                }
                else if (GetPozycja() < PozycjaZadana + 5)
                {
                    SetPozycja(jazdaWozek.jazdaDoPozycjiDown(Przychamowanie, Pozycja));
                    Odswiez();
                }
                else
                {
                    SetPozycja(jazdaWozek.jazdaDoPozycjiDown(Predkosc, Pozycja));
                    Odswiez();
                }
            }

        }
        private void Wozek_Load(object sender, EventArgs e)
        {

        }

        void PrzyciskKierunek()
        {
            if (GetKierunek() == false)
            {
                buttonLewo.BackColor = Color.IndianRed;
                buttonPrawo.BackColor = Color.SkyBlue;
            }
            else
            {
                buttonLewo.BackColor = Color.SkyBlue;
                buttonPrawo.BackColor = Color.IndianRed;
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

            Kierunek = false;
            PrzyciskKierunek();

        }

        private void buttonPrawo_Click(object sender, EventArgs e)
        {

            Kierunek = true;
            PrzyciskKierunek();

        }
        public void ladujBazaProgramowa(int idFx_wozek)
        {
            try
            {
                this.pokazFx_Wozek_Wozek_dlajednegoTableAdapter.Fill(this.tWDataSet.pokazFx_Wozek_Wozek_dlajednego, idFx_wozek, GetId());
                SetPredkosc(((this.pokazFxWozekWozekdlajednegoBindingSource.Current as DataRowView).Row as TWDataSet.pokazFx_Wozek_Wozek_dlajednegoRow).predkosc);
                SetPozycjaZadana((float)((this.pokazFxWozekWozekdlajednegoBindingSource.Current as DataRowView).Row as TWDataSet.pokazFx_Wozek_Wozek_dlajednegoRow).miejsce_stop);
                Odswiez();
            }
            catch (Exception)
            {
            }

        }
        public void Odswiez()
        {
            textBoxPozycja.Text = ((float)Math.Round(GetPozycja() / 20, 2)).ToString() + " m";
            textBoxStop.Text = ((float)Math.Round(GetPozycjaZadana() / 20, 2)).ToString() + " m";
            textBoxPredkosc.Text = Math.Abs(Predkosc).ToString();
            PrzyciskAktywacja();
            Invalidate();
        }
        void PrzyciskAktywacja()
        {
            if (Aktywacja == false)
            {
                buttonAktywacja.BackColor = Color.SkyBlue;
            }
            else buttonAktywacja.BackColor = Color.IndianRed;
        }
        public void ZmianaAktywacja()
        {
            Aktywacja = false;
            Predkosc = 0;
            PrzyciskAktywacja();
            Odswiez();
        }
        public string Wynik(string wynik)
        {
            return wynik;
        }

    }
}
