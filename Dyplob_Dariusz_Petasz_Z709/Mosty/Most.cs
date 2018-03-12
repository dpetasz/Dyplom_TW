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
            SetPozycja(Pozycja);
            this.Aktywacja = false;
            this.PredkoscMax = PredkoscMax;
            SetPredkosc(0);
            this.PozycjaZadana = GetPozycja();
            this.Przychamowanie = Przychamowanie;
            SetKierunek(true);
            rysujMost.Wypelnienie();
            AktywujDoPozycji();
            ListaMost.Add(this);
            Odswiez();
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
            if (GetPozycja() <= Kg + 5 && GetKierunek() == false)
            {
                if (GetPozycja() <= Kg)
                {
                    ZmianaAktywacjaManual();
                    ZapiszPozycjaBaza();
                    ZmianaKrancowa();
                }
                else
                {
                    SetPozycja(jazdaMost.jazdaManual(GetKierunek(), Przychamowanie, GetPozycja()));
                    Odswiez();
                }

            }
            else if (GetPozycja() >= Kd - 5 && GetKierunek() == true)
            {
                if (GetPozycja() >= Kd)
                {
                    ZmianaAktywacjaManual();
                    ZapiszPozycjaBaza();
                    ZmianaKrancowa();
                }
                else
                {
                    SetPozycja(jazdaMost.jazdaManual(GetKierunek(), Przychamowanie, GetPozycja()));
                    Odswiez();
                }
            }
            else
            {
                SetPozycja(jazdaMost.jazdaManual(GetKierunek(), GetPredkosc(), GetPozycja()));
                Odswiez();
            }

        }
        public void JazdaJoystick()
        {

            if ((GetPozycja() <= Kg + 5) && GetPredkosc() < 0)
            {
                if (GetPozycja() <= Kg && GetPredkosc() < 0)
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
            else if ((GetPozycja() >= Kd - 5) && GetPredkosc() > 0)
            {
                if (GetPozycja() >= Kd && GetPredkosc() > 0)
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
            else
            {
                SetPozycja(jazdaMost.jazdaJoystick(GetPredkosc(), GetPozycja()));
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
                    ZmianaAktywacjaDoPozycji();
                    Odswiez();
                }
                else if (GetPozycja() > PozycjaZadana - 5)
                {
                    SetPozycja(jazdaMost.jazdaDoPozycjiUp(Przychamowanie, Pozycja));

                    Odswiez();
                }
                else
                {
                    SetPozycja(jazdaMost.jazdaDoPozycjiUp(Predkosc, Pozycja));
                    Odswiez();
                }

            }
            if (GetPozycja() > PozycjaZadana)
            {
                if ((float)Math.Round(Pozycja, 1) == PozycjaZadana)
                {
                    ZmianaAktywacjaDoPozycji();
                    Odswiez();
                }
                else if (GetPozycja() < PozycjaZadana + 5)
                {
                    SetPozycja(jazdaMost.jazdaDoPozycjiDown(Przychamowanie, Pozycja));
                    Odswiez();
                }
                else
                {
                    SetPozycja(jazdaMost.jazdaDoPozycjiDown(Predkosc, Pozycja));
                    Odswiez();
                }
            }

        }
        public void Odswiez()
        {
            textBoxPozycja.Text = ((float)Math.Round((250 - Pozycja) / 10, 2)).ToString() + " m";
            textBoxPozycjaZadana.Text = ((float)Math.Round((250 - PozycjaZadana) / 10, 2)).ToString() + " m";
            textBoxPredkosc.Text = Math.Abs(Predkosc).ToString();
            PrzyciskAktywacja();
            ZmianaKrancowa();
            pictureBox1.Invalidate();
        }

        public void ladujBazaProgramowa(int idFx)
        {
            this.pokazFx_Most_Most_dlajednegoTableAdapter.Fill(this.twDataSet.pokazFx_Most_Most_dlajednego, idFx, GetId());
            SetPredkosc(((this.pokazFxMostMostdlajednegoBindingSource.Current as DataRowView).Row as TWDataSet.pokazFx_Most_Most_dlajednegoRow).predkosc);
            SetPozycjaZadana((float)((this.pokazFxMostMostdlajednegoBindingSource.Current as DataRowView).Row as TWDataSet.pokazFx_Most_Most_dlajednegoRow).miejsce_stop);
            Odswiez();
        }
        public void aktualizujFx_most_most(int idFx)
        {
            try
            {
                this.pokazFx_Most_Most_dlajednegoTableAdapter.Fill(this.twDataSet.pokazFx_Most_Most_dlajednego, idFx, GetId());
                int idFx_most_most = ((this.pokazFxMostMostdlajednegoBindingSource.Current as DataRowView).Row as TWDataSet.pokazFx_Most_Most_dlajednegoRow).idfx_most_most;
                textBoxWynik.Text = db.AktualizujFX_most_most(idFx_most_most, GetPredkosc(), GetPozycja());
            }
            catch { }
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
            if (GetPozycja() <= Kg) { textBoxKG.BackColor = Color.Red; } else { textBoxKG.BackColor = Color.DarkSeaGreen; }
            if (GetPozycja() >= Kd) { textBoxKD.BackColor = Color.Red; } else { textBoxKD.BackColor = Color.DarkSeaGreen; }
        }

        private void textBoxPozycjaZadana_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxPozycjaZadana.Clear();
            panelPrzyciski.Visible = true;
        }
        public void ZmianaAktywacjaManual()
        {
            Aktywacja = false;
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
                SetPozycjaZadana(250 - (float.Parse(textBoxStop.Text.ToString()) * 10));
                if (GetPozycjaZadana() > Kd || GetPozycjaZadana() < Kg)
                {
                    MessageBox.Show("Przedział ruchu od " + ((250 - Kd) / 10) + " do " + (250 -Kg)/10);
                    textBoxStop.Clear();
                    SetPozycjaZadana(GetPozycja());
                    Odswiez();
                }
                else
                {
                    textBoxPozycjaZadana.Text = (GetPozycjaZadana() / 10).ToString() + " m";
                    Odswiez();
                }
            }
            catch
            {
                SetPozycjaZadana(GetPozycja());
                MessageBox.Show("To nie są liczby");
                textBoxStop.Clear();
            }

        }
        private void button13_Click(object sender, EventArgs e)
        {
            WczytajPozycjaZadana();
            panelPrzyciski.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxStop.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxStop.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxStop.Text += button3.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBoxStop.Text += button12.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBoxStop.Text += button11.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBoxStop.Text += button10.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxStop.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxStop.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxStop.Text += button6.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxStop.Text += button9.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxStop.Text += button8.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxStop.Clear();
        }

        private void textBoxPozycjaZadana_Click(object sender, EventArgs e)
        {
            panelPrzyciski.Visible = true;
            textBoxStop.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panelPrzyciski.Visible = false;
            textBoxPozycjaZadana.Text = (PozycjaZadana / 10).ToString();
        }

        private void textBoxPredkosc_Click(object sender, EventArgs e)
        {
            panelPredkosc.Visible = true;
            textBoxPredkosc.Clear();
        }

        private void trackBarPredkosc_Scroll(object sender, EventArgs e)
        {
            SetPredkosc(trackBarPredkosc.Value);
            Odswiez();
        }

        private void trackBarPredkosc_MouseUp(object sender, MouseEventArgs e)
        {
            panelPredkosc.Visible = false;
            trackBarPredkosc.Value = GetPredkosc();
        }

        private void buttonZamknijPanelPredkosc_Click(object sender, EventArgs e)
        {
            panelPredkosc.Visible = false;

        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            SetKierunek(false);
            PrzyciskKierunek();
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            SetKierunek(true);
            PrzyciskKierunek();
        }
        void PrzyciskKierunek()
        {
            if (GetKierunek() == false)
            {
                buttonUp.BackColor = Color.IndianRed;
                buttonDown.BackColor = Color.SkyBlue;
            }
            else
            {
                buttonUp.BackColor = Color.SkyBlue;
                buttonDown.BackColor = Color.IndianRed;
            }
        }
    }
}
