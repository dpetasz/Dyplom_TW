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

namespace Dyplom_Dariusz_Petasz_Z709
{
    public partial class Most : UserControl
    {
        static public List<Most> ListaMost = new List<Most>();

        RysujMost rysujMost = new RysujMost();
        IJazdaMost jazdaMost = new JazdaMost();
        Graphics g;
        
        

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
        public float Pozycja
        {
            get { return pozycja; }
            set { pozycja = value; }
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
        public int Predkosc
        {
            get { return predkosc; }
            set { predkosc = value; }
        }
        public Most(int Id, string Nazwa, float Pozycja, int PredkoscMax, int Przychamowanie)
        {
            InitializeComponent();
            rysujMost.Id = Id;
            rysujMost.Nazwa = Nazwa;
            this.Pozycja = Pozycja ;
            this.Aktywacja = false;
            rysujMost.PredkoscMax = PredkoscMax;
            this.Predkosc = 0;
            rysujMost.Przychamowanie = Przychamowanie;
            rysujMost.Wypelnienie();
            ListaMost.Add(this);
            
        }
        
      

        private void Most_Load(object sender, EventArgs e)
        {
            textBoxNazwa.Text = rysujMost.Nazwa;
            textBoxPozycja.Text = Pozycja.ToString();
            textBoxPredkosc.Text = Predkosc.ToString();
        }

        private void buttonAktywacja_Click(object sender, EventArgs e)
        {
            if (Aktywacja == false)
            {
                Aktywacja = true;
                buttonAktywacja.BackColor = Color.Green;
            }
            else
            {
                Aktywacja = false;
                buttonAktywacja.BackColor = Color.SkyBlue;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            rysujMost.Obramowanie(g);
            rysujMost.MostJazda(g, Pozycja);
        }

        public void Manual()
        {
            Pozycja = jazdaMost.jazdaManual(Kierunek, Predkosc, Pozycja);
            //return jazdaMost.jazdaManual(Kierunek, Predkosc, Pozycja);
        }
        public void Joystick()
        {
            if (Pozycja < (Kg - 10) || Pozycja > (Kd + 10))
            {
                Pozycja = jazdaMost.jazdaJoystick(Predkosc, Pozycja);

                Odswiez();
            }
            else
            {
                Pozycja = jazdaMost.jazdaJoystick(Przychamowanie, Pozycja);

                Odswiez();
            }
        }
        public void DoPozycji()
        {
            Pozycja = jazdaMost.jazdaDoPozycji( PozycjaZadana,Predkosc,Pozycja);
        }
        public void Odswiez()
        {
            textBoxPozycja.Text = (Pozycja).ToString();
            textBoxPredkosc.Text = Predkosc.ToString();
            
            pictureBox1.Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
       

        
    }
}
