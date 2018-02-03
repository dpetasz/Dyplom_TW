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

        IRysujMost rysujMost = new RysujMost();
        IJazdaMost jazdaMost = new JazdaMost();
        Graphics g;

        public Most(int Id, string Nazwa, float Pozycja, int PredkoscMax, int Przychamowanie)
        {
            InitializeComponent();
            this.Id = Id;
            this.Nazwa = Nazwa;
            this.Pozycja = Pozycja;
            Aktywacja = false;
            this.PredkoscMax = PredkoscMax;
            Predkosc = 0;
            this.Przychamowanie = Przychamowanie;
            rysujMost.Wypelnienie();
            ListaMost.Add(this);
            
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
        int Przychamowanie
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

        private void Most_Load(object sender, EventArgs e)
        {
            textBoxNazwa.Text = Nazwa;
            
        }

        private void buttonAktywacja_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            rysujMost.Obramowanie(g);
            rysujMost.MostJazda(g, Pozycja);
        }

        

        
    }
}
