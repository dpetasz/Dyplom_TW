using Dyplom_Dariusz_Petasz_Z709.BD_TW;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dyplom_Dariusz_Petasz_Z709.Wozki
{
    public partial class WozkiForm : Form
    {
        Form1 f1 = new Form1();
        //RysujWozek scena;

        Graphics g;
        StanWypWozki stanWyp = new Wypelnienie1();
        //StanWozek stanWozek;
        List<float> jazda = new List<float>();
        List<bool> aktywacja = new List<bool>();
        List<bool> kierunek = new List<bool>();
        /*float Jazda
        {
            get { return jazda; }
            set { jazda = value; }
        }*/
        PokazPrzedstawienia przedstawienia = new PokazPrzedstawienia();
        public WozkiForm()
        {
            InitializeComponent();


        }
        public WozkiForm(Form1 f)
        {
            InitializeComponent();
            f1 = f;

        }
        public void LadujWozek()
        {

            int wys = 328;

            foreach (DataRow w in tWDataSet.pokazWozki.Rows)
            {
                float p = (float)(Convert.ToDouble(w["pozycja"].ToString()));
                //jazda.Add(p);
                //aktywacja.Add(false);
                //kierunek.Add(false);
                //RysujWozek wozek = new RysujWozek(p,wys, Convert.ToInt32(w["predkosc_max"].ToString()), w["nazwa"].ToString());
                Wozek wozek = new Wozek(p, Convert.ToInt32(w["predkosc_max"].ToString()), w["nazwa"].ToString(), (Convert.ToInt32(w["idwozek"].ToString())));
                //RysujWozek.ListaWozek.Add(wozek);
                wozek.Parent = pictureBox1;
                wozek.Top = wys;
                wozek.Left = 10;
                wys -= 106;
            }
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //scena = new RysujWozek();
            //stanWyp.Wypelnienie(scena);
            //scena.Scena(g);
            //int i = 0;
            /*
                        foreach (RysujWozek w in RysujWozek.ListaWozek)
                        {
                            stanWyp.Wypelnienie(w);
                            w.WozekJazda(g, w.Jazda);
                            //i++;
                        }*/
            //i = 0;
            //stanWyp.Wypelnienie(Wozek.ListaWozek[0]);
            //Wozek.ListaWozek[0].WozekJazda(g, 1);
            
        }
        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            LadujWozek();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(RysujWozek w in RysujWozek.ListaWozek)
            {
                w.Kierunek = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (RysujWozek w in RysujWozek.ListaWozek)
            {
                w.Kierunek = false;
            }
        }

        private void tabPageBazaDanych_Paint(object sender, PaintEventArgs e)
        {
            przedstawienia.Show();
        }

        private void WozkiForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tWDataSet.pokazPrzedstawienie' table. You can move, or remove it, as needed.
            this.pokazPrzedstawienieTableAdapter.Fill(this.tWDataSet.pokazPrzedstawienie);
            this.pokazWozkiTableAdapter.Fill(this.tWDataSet.pokazWozki);
            LadujWozek();
        }

        private void WozkiForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            RysujWozek.ListaWozek.Clear();
            jazda.Clear();
            aktywacja.Clear();
            f1.Visible = true;
        }

        /*private void buttonAktywujW1_Click(object sender, EventArgs e)
        {
            if (RysujWozek.ListaWozek[0].Aktywacja == false)
            {
                RysujWozek.ListaWozek[0].Aktywacja = true;
                buttonAktywujW1.BackColor = Color.Red;
                buttonAktywujW1.Text = "Aktywny W1";
            }
            else
            {
                RysujWozek.ListaWozek[0].Aktywacja = false;
                buttonAktywujW1.BackColor = Color.LawnGreen;
                buttonAktywujW1.Text = "Atywuj W1";
            }

        }

        private void buttonAktywujW2_Click(object sender, EventArgs e)
        {
            if (RysujWozek.ListaWozek[1].Aktywacja == false)
            {
                RysujWozek.ListaWozek[1].Aktywacja = true;
                buttonAktywujW2.BackColor = Color.Red;
                buttonAktywujW2.Text = "Aktywny W2";
            }
            else
            {
                RysujWozek.ListaWozek[1].Aktywacja = false;
                buttonAktywujW2.BackColor = Color.LawnGreen;
                buttonAktywujW2.Text = "Atywuj W2";
            }
        }

        private void buttonAktywuj3_Click(object sender, EventArgs e)
        {
            if (RysujWozek.ListaWozek[2].Aktywacja == false)
            {
                RysujWozek.ListaWozek[2].Aktywacja = true;
                buttonAktywujW3.BackColor = Color.Red;
                buttonAktywujW3.Text = "Aktywny W3";
            }
            else
            {
                RysujWozek.ListaWozek[2].Aktywacja = false;
                buttonAktywujW3.BackColor = Color.LawnGreen;
                buttonAktywujW3.Text = "Atywuj W3";
            }
        }

        private void buttonAktywujW4_Click(object sender, EventArgs e)
        {
            if (RysujWozek.ListaWozek[3].Aktywacja == false)
            {
                RysujWozek.ListaWozek[3].Aktywacja = true;
                buttonAktywujW4.BackColor = Color.Red;
                buttonAktywujW4.Text = "Aktywny W4";
            }
            else
            {
                RysujWozek.ListaWozek[3].Aktywacja = false;
                buttonAktywujW4.BackColor = Color.LawnGreen;
                buttonAktywujW4.Text = "Atywuj W4";
            }
        }*/

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach(RysujWozek w in RysujWozek.ListaWozek)
            {
                if (w.Jazda <= 0 && w.Kierunek == false && w.Aktywacja == true)
                {
                    w.Aktywacja = false;
                    Invalidate();
                    
                } 
                if (w.Jazda < 100 && w.Kierunek == false && w.Aktywacja == true) w.Jazda = w.ruch(w.Kierunek, w.Przychamowanie);

                if (w.Jazda >= 600 && w.Kierunek == true && w.Aktywacja == true)
                {
                    w.Aktywacja = false;
                    Invalidate();
                }
                if (w.Jazda >500 && w.Kierunek == true && w.Aktywacja == true) w.Jazda = w.ruch(w.Kierunek, w.Przychamowanie);
                
                if (w.Aktywacja == true)w.Jazda = w.ruch(w.Kierunek, 100);
            }
            pictureBox1.Invalidate();
        }
        private void green()
        {

            timer1.Enabled = false;
            button3.BackColor = Color.Green;
            button3.Text = "Start";
            

        }
        private void red()
        {
            timer1.Enabled = true;
            button3.BackColor = Color.Red;
            button3.Text = "Stop";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {

                red();
            }
            else
            {

                
                green();
            }
        }

       
    }
}
