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

namespace Dyplom_Dariusz_Petasz_Z709
{
    public partial class Most : UserControl
    {
        static public List<Most> ListaMost = new List<Most>();

        RysujMost rysujMost = new RysujMost();
        IJazdaMost jazdaMost = new JazdaMost();
        Graphics g;


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
            SetId(Id);
            rysujMost.Nazwa = Nazwa;
            this.Pozycja = Pozycja ;
            this.Aktywacja = false;
            this.PredkoscMax = PredkoscMax;
            this.Predkosc = 0;
            this.Przychamowanie = Przychamowanie;
            rysujMost.Wypelnienie();
            ListaMost.Add(this);
            
        }
        
      

        private void Most_Load(object sender, EventArgs e)
        {
            textBoxNazwa.Text = rysujMost.Nazwa;
            textBoxPozycja.Text = (Pozycja / 10).ToString();
            textBoxPredkosc.Text = Predkosc.ToString();
        }

        private void buttonAktywacja_Click(object sender, EventArgs e)
        {
            if (Aktywacja == false)
            {
                Aktywacja = true;
                buttonAktywacja.BackColor = Color.IndianRed;
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
            float x = Kg -3, y = Kd +3;
            if ((Pozycja >= x) && Predkosc > 0)
            {
                Pozycja = jazdaMost.jazdaJoystick(Przychamowanie, Pozycja);
                Odswiez();
            }else if ((Pozycja <= y) && Predkosc<0)
            {

                Pozycja = jazdaMost.jazdaJoystick(Przychamowanie * -1, Pozycja);
                Odswiez();
            }
            else { Pozycja = jazdaMost.jazdaJoystick(Predkosc, Pozycja);
            Odswiez();
            }
        }
        public void DoPozycji()
        {
            Pozycja = jazdaMost.jazdaDoPozycjiDown(Predkosc,Pozycja);
        }
        public void Odswiez()
        {
            textBoxPozycja.Text = (Pozycja/10).ToString();
            textBoxPredkosc.Text = Predkosc.ToString();
            
            pictureBox1.Invalidate();
        }

        
       
        public void ZmianaAktywacja()
        {
            if(Aktywacja == false)
            { 

            buttonAktywacja.BackColor = Color.SkyBlue;
            }
            else {
                
                buttonAktywacja.BackColor = Color.Maroon;
            }
        }
        public void ZmianaKrancowa()
        {
            if (Pozycja >= Kg) { textBoxKG.BackColor = Color.Red; } else { textBoxKG.BackColor = Color.DarkSeaGreen; }
            if (Pozycja <= Kd) { textBoxKD.BackColor = Color.Red; } else { textBoxKD.BackColor = Color.DarkSeaGreen; }
        }

        private void textBoxPozycjaZadana_MouseClick(object sender, MouseEventArgs e)
        {
            

        }
        public void ZmianaDoPozycji()
        {
            if(textBoxPozycjaZadana.Enabled == true)
            textBoxPozycjaZadana.Enabled = false;
            else textBoxPozycjaZadana.Enabled = true;
        }
    }
}
