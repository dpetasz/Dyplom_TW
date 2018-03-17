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
        IWozek wozek = new Urzadzenie();
        Graphics g;
        public bool GetDoPozycji()
        {
            return wozek.GetDoPozycji();
        }
        public void SetDoPozycji(bool DoPozycji)
        {
            wozek.SetDoPozycji(DoPozycji);
        }
        
        public bool GetProgramowa()
        {
            return wozek.GetProgramowa();
        }
        public void SetProgramowa(bool Programowa)
        {
            wozek.SetProgramowa(Programowa);
        }
       
        
        public bool GetManualna()
        {
            return wozek.GetManualna();
        }
        public void SetManualna(bool Manualna)
        {
            wozek.SetManualna(Manualna);
        }
        public bool GetJoystick()
        {
            return wozek.GetJoystick();
        }
        public void SetJoystick(bool Joystick)
        {
            wozek.SetJoystick(Joystick);
        }
        
        public int GetId()
        {
            return wozek.GetId();
        }
        public void SetId(int Id)
        {
            wozek.SetId(Id);
        }
        int predkoscMax;
        int PredkoscMax
        {
            get { return predkoscMax; }
            set { predkoscMax = value; }
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
            return wozek.GetKierunek();
        }
        public void SetKierunek(bool Kierunek)
        {
            wozek.SetKierunek(Kierunek);
        }
        
        
        public bool GetAktywacja()
        { 
            return wozek.GetAktywacja(); 
        }
        public void SetAktywacja(bool Aktywacja)
        {
           wozek.SetAktywacja(Aktywacja);
        }
        
        public int GetPrzychamowanie()
        {
            return wozek.GetPrzychamowanie();
        }
        public void SetPrzychamowanie(int Przychamowanie)
        {
            wozek.SetPrzychamowanie(Przychamowanie);
        }

       
        public float GetPozycja()
        {
            return wozek.GetPozycja();
        }

        public void SetPozycja(float Pozycja)
        {
            wozek.SetPozycja(Pozycja);
        }
        
        public int GetPredkosc()
        {
            return wozek.GetPredkosc();
        }
        public void SetPredkosc(int Predkosc)
        {
            wozek.SetPredkosc(Predkosc);
        }

        
        public float GetPozycjaZadana()
        {
            return wozek.GetPozycjaZadana();
        }
        public void SetPozycjaZadana(float PozycjaZadana)
        {
            wozek.SetPozycjaZadana(PozycjaZadana);
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
            SetPozycja(x);
            this.PredkoscMax = vmax;
            SetPozycjaZadana(GetPozycja());
            SetAktywacja(false);
            SetKierunek(false);
            SetPrzychamowanie(10);
            rysujWozek.Wypelnienie();
            ListaWozek.Add(this);
            SetPredkosc(0);
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
            SetDoPozycji(true);
            SetManualna(false);
            SetJoystick(false);
            SetProgramowa(false);
            SetAktywacja(false);
            textBoxStop.ReadOnly = false;
            Odswiez();
        }

        public void AktywujManualna()
        {
            SetDoPozycji(false);
            SetManualna(true);
            SetJoystick(false);
            SetProgramowa(false);
            SetAktywacja(false);
            textBoxStop.ReadOnly = true;
            Odswiez();
        }
        public void AktywujJoystick()
        {
            SetDoPozycji(false);
            SetManualna(false);
            SetJoystick(true);
            SetProgramowa(false);
            SetAktywacja(false);
            textBoxStop.ReadOnly = true;
            Odswiez();
        }
        public void AktywujProgamowa()
        {
            SetDoPozycji(true);
            SetManualna(false);
            SetJoystick(false);
            SetProgramowa(true);
            SetAktywacja(false);
            textBoxStop.ReadOnly = false;
            Odswiez();
        }
        void LadujPrzyciski()
        {
            textBoxPozycja.Text = ((float)Math.Round(GetPozycja() / 20, 2)).ToString() + " m";
            textBoxStop.Text = ((float)Math.Round(GetPozycjaZadana() / 20, 2)).ToString() + " m";
            textBoxPredkosc.Text = Math.Abs(GetPredkosc()).ToString();
            buttonAktywacja.Text = "Aktywuj W-" + GetId();
            LadujAktywuj();
            PrzyciskKierunek();
            Invalidate();
        }

        public void LadujAktywuj()
        {
            if (GetAktywacja() == true)
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
                    SetPozycja(jazdaWozek.jazdaJoystick(GetPrzychamowanie() * -1, GetPozycja()));
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
                    SetPozycja(jazdaWozek.jazdaJoystick(GetPrzychamowanie(), GetPozycja()));
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
                    SetPozycja(jazdaWozek.jazdaManual(GetKierunek(), GetPrzychamowanie(), GetPozycja()));
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
                    SetPozycja(jazdaWozek.jazdaManual(GetKierunek(), GetPrzychamowanie(), GetPozycja()));
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
                if ((float)Math.Round(GetPozycja(), 1) == (float)Math.Round(GetPozycjaZadana(), 1))
                {
                    SetPredkosc(0);
                    ZmianaAktywacja();

                    LadujAktywuj();
                    Odswiez();
                }
                else if (GetPozycja() > GetPozycjaZadana() - 5)
                {
                    SetPozycja(jazdaWozek.jazdaDoPozycjiUp(GetPrzychamowanie(), GetPozycja()));

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
                    SetPozycja(jazdaWozek.jazdaDoPozycjiDown(GetPrzychamowanie(), GetPozycja()));
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
            if (GetAktywacja() == false)
            {
                SetAktywacja(true);
                LadujAktywuj();
            }
            else
            {
                SetAktywacja(false);
                LadujAktywuj();
            }



        }

        private void buttonLewo_Click(object sender, EventArgs e)
        {

            SetKierunek(false);
            PrzyciskKierunek();

        }

        private void buttonPrawo_Click(object sender, EventArgs e)
        {

            SetKierunek(true);
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
            textBoxPredkosc.Text = Math.Abs(GetPredkosc()).ToString();
            PrzyciskAktywacja();
            Invalidate();
        }
        void PrzyciskAktywacja()
        {
            if (GetAktywacja() == false)
            {
                buttonAktywacja.BackColor = Color.SkyBlue;
            }
            else buttonAktywacja.BackColor = Color.IndianRed;
        }
        public void ZmianaAktywacja()
        {
            SetAktywacja(false);
            SetPredkosc(0);
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
                    MessageBox.Show("Przedział od " + Kd / 20 + " do " + Kg / 20);
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
                MessageBox.Show("To nie są liczby");
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
