using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dyplom_Dariusz_Petasz_Z709.BD_TW;
using Dyplom_Dariusz_Petasz_Z709.Urzadzenia;

namespace Dyplom_Dariusz_Petasz_Z709.Wozki
{
    public partial class Wozek : UserControl
    {
        static public List<Wozek> ListaWozek = new List<Wozek>();

        IRysujWozek rysujWozek = new RysujWozek();
        IJazdaWozek jazdaWozek = new JazdaUrzadzenie();
        IZapiszWozek db = new ZapiszFxWozek();
        
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
            rysujWozek.SetNazwa(name);
            this.Pozycja = x;
            this.PredkoscMax = vmax;
            SetPozycjaZadana(GetPozycja());
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
            WozekJazda(g, GetPozycja());

        }
        public void WozekJazda(Graphics g, float x)
        {

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //rysuje wozek
            g.FillRectangle(rysujWozek.GetPioro1(), x, 1, 460, 104);
            g.DrawRectangle(rysujWozek.GetPioro(), x, 1, 460, 104);
            //napis
            g.DrawString(rysujWozek.GetNazwa().ToString(), rysujWozek.GetTextFont(), rysujWozek.GetKolorLiczby(), x + 180, 30);


        }
        public void Scena(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g.FillRectangle(rysujWozek.GetPioro3(), 0, 0, 460, 105);
            g.DrawRectangle(rysujWozek.GetPioro(), 0, 0, 460, 105);
            //g.DrawRectangle(pioro, 480, 20, 140, 360);
            g.DrawRectangle(rysujWozek.GetPioro(), 600, 0, 460, 105);
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
            if (GetPozycja() <= Kg + 10 && GetPredkosc() < 0)
            {
                if (GetPozycja() <= Kg)
                {
                    ZmianaAktywacja();
                    LadujAktywuj();
                    ZapiszPozycjaBaza();
                    Odswiez();
                }
                else
                {
                    SetPozycja(jazdaWozek.jazdaJoystick(Przychamowanie * -1, GetPozycja()));
                    Odswiez();
                }

            }
            else if (GetPozycja() >= Kd - 10 && GetPredkosc() > 0)
            {
                if (GetPozycja() >= Kd)
                {
                    ZmianaAktywacja();
                    LadujAktywuj();
                    ZapiszPozycjaBaza();
                    Odswiez();

                }
                else
                {
                    SetPozycja(jazdaWozek.jazdaJoystick(Przychamowanie, GetPozycja()));
                    Odswiez();
                }
            }
            else
            {
                SetPozycja(jazdaWozek.jazdaJoystick(GetPredkosc(), GetPozycja()));
                Odswiez();
            }
        }

        public void JazdaManual()
        {
            if (GetPozycja() <= Kg + 5 && GetKierunek() == false)
            {
                if (GetPozycja() <= Kg)
                {
                    ZmianaAktywacja();
                    ZapiszPozycjaBaza();
                    LadujAktywuj();
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
                    ZapiszPozycjaBaza();
                    LadujAktywuj();
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


            if (GetPozycja() < GetPozycjaZadana())
            {
                if ((float)Math.Round(GetPozycja(), 1) == (float)Math.Round(GetPozycjaZadana(),1))
                {
                    Predkosc = 0;
                    ZmianaAktywacja();

                    LadujAktywuj();
                    Odswiez();
                }
                else if (GetPozycja() > GetPozycjaZadana() - 5)
                {
                    SetPozycja(jazdaWozek.jazdaDoPozycjiUp(Przychamowanie, GetPozycja()));

                    Odswiez();
                }
                else
                {
                    SetPozycja(jazdaWozek.jazdaDoPozycjiUp(GetPredkosc(), GetPozycja()));
                    Odswiez();
                }

            }
            if (GetPozycja() > GetPozycjaZadana())
            {
                if ((float)Math.Round(GetPozycja(), 1) == (float)Math.Round(GetPozycjaZadana(), 1))
                {
                    ZmianaAktywacja();
                    LadujAktywuj();
                    Odswiez();
                }
                else if (GetPozycja() < GetPozycjaZadana() + 5)
                {
                    SetPozycja(jazdaWozek.jazdaDoPozycjiDown(Przychamowanie, GetPozycja()));
                    Odswiez();
                }
                else
                {
                    SetPozycja(jazdaWozek.jazdaDoPozycjiDown(GetPredkosc(), GetPozycja()));
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
                buttonLewo.BackColor = Color.Green;
                buttonPrawo.BackColor = Color.SkyBlue;
            }
            else
            {
                buttonLewo.BackColor = Color.SkyBlue;
                buttonPrawo.BackColor = Color.Green;
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
        public void aktualizujFx_wozek_wozek(int idFx)
        {
            try
            {
                this.pokazFx_Wozek_Wozek_dlajednegoTableAdapter.Fill(this.tWDataSet.pokazFx_Wozek_Wozek_dlajednego, idFx, GetId());
                int idFx_wozek_wozek = ((this.pokazFxWozekWozekdlajednegoBindingSource.Current as DataRowView).Row as TWDataSet.pokazFx_Wozek_Wozek_dlajednegoRow).idfx_wozek_wozek;
                db.AktualizujFX_most_most(idFx_wozek_wozek, GetPredkosc(), GetPozycjaZadana());
                ladujBazaProgramowa(idFx);
            }
            catch { }
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

        public string ZapiszPozycjaBaza()
        {
            try
            {
                return db.ZapiszPozycja(GetId(), GetPozycja());
            }
            catch (Exception)
            {

                return "Błąd bazy danych";
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPredkosc_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void textBoxPredkosc_Click(object sender, EventArgs e)
        {
            trackBarPredkosc.Value = GetPredkosc();
            labelPredkosc.Text = trackBarPredkosc.Value.ToString();
            panelPredkosc.Visible = true;
            panelPredkosc.Left = 1088;
        }

        private void trackBarPredkosc_Scroll(object sender, EventArgs e)
        {
            labelPredkosc.Text = trackBarPredkosc.Value.ToString();
            SetPredkosc(trackBarPredkosc.Value);
            Odswiez();
        }

        private void trackBarPredkosc_MouseUp(object sender, MouseEventArgs e)
        {
            panelPredkosc.Visible = false;
        }

        private void buttonZamknijPanelPredkosc_Click(object sender, EventArgs e)
        {
            panelPredkosc.Visible = false;
        }
        public void WczytajPozycjaZadana()
        {
            try
            {
                SetPozycjaZadana((float.Parse(textBox4.Text.ToString()) * 20));
                if (GetPozycjaZadana() > Kd || GetPozycjaZadana() < Kg)
                {
                    MessageBox.Show("Przedział od " + Kd/20 + " do " + Kg/20);
                    textBoxStop.Clear();
                    SetPozycjaZadana(GetPozycja());
                    Odswiez();
                }
                else
                {
                    textBoxStop.Text = (GetPozycjaZadana() / 20).ToString() + " m";
                    Odswiez();
                }
            }
            catch
            {
                MessageBox.Show("To nie są liczby" );
                SetPozycjaZadana(GetPozycja());
                textBoxStop.Clear();
                Odswiez();
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            WczytajPozycjaZadana();
            panelPozycjaZadana.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Text += button3.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox4.Text += button12.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox4.Text += button11.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox4.Text += button10.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox4.Text += button6.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox4.Text += button9.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox4.Text += button8.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }

        private void textBoxStop_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            panelPozycjaZadana.Visible = true;
            panelPozycjaZadana.Left = 1088;
        }

    }
}
