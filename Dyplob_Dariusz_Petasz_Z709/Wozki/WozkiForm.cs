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
        RysujWozek scena;

        Graphics g;
        StanWypWozki stanWyp = new Wypelnienie1();
        //StanWozek stanWozek;
        List<float> jazda = new List<float>();
        List<bool> aktywacja = new List<bool>();
        /*float Jazda
        {
            get { return jazda; }
            set { jazda = value; }
        }*/
        Przedstawienia przedstawienia = new Przedstawienia();
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
            if (RysujWozek.ListaJest == null)
            {
                int wys = 290;
                int i = 0;
                foreach (DataRow w in tWDataSet.pokazWozki.Rows)
                {

                    float p = (float)(Convert.ToDouble(w["pozycja"].ToString()));
                    jazda.Add(p);
                    RysujWozek.ListaAktywuj.Add(false);
                    RysujWozek.ListaJest.Add(true);
                    RysujWozek.ListaJazda.Add(jazda[i]);


                    RysujWozek wozek = new RysujWozek(jazda[i],
                                                        wys,
                                                        Convert.ToInt32(w["predkosc_max"].ToString()),
                                                        w["nazwa"].ToString());
                    RysujWozek.ListaWozek.Add(wozek);




                    i++;
                    wys -= 90;
                }
            }
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            scena = new RysujWozek();
            stanWyp.Wypelnienie(scena);
            scena.Scena(g);
            int i = 0;
            if (RysujWozek.ListaJest == null)
            {
                foreach (RysujWozek w in RysujWozek.ListaWozek)
                {
                    stanWyp.Wypelnienie(w);
                    w.WozekJazda(g, jazda[i]);
                    i++;
                }
            }
            foreach (RysujWozek w in RysujWozek.ListaWozek)
            {
                if (w.Aktywacja == true && w.Jest == true)
                {
                    stanWyp.Wypelnienie(w);
                    w.WozekJazda(g, jazda[i]);
                }



                i++;
            }
        }
        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            jazda[0] += 0.455f;
            jazda[1] += 0.155f;
            jazda[2] += 0.455f;
            jazda[3] += 0.155f;
            pictureBox1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            jazda[0] -= 0.55f;
            jazda[1] -= 0.155f;
            pictureBox1.Invalidate();
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
            f1.Visible = true;
        }

        private void buttonAktywujW1_Click(object sender, EventArgs e)
        {
            if (RysujWozek.ListaAktywuj[0] == false)
            {
                RysujWozek.ListaAktywuj[0] = true;
                buttonAktywujW1.BackColor = Color.Red;
                buttonAktywujW1.Text = "Aktywny W1";
            }
            else
            {
                RysujWozek.ListaAktywuj[0] = false;
                buttonAktywujW1.BackColor = Color.LawnGreen;
                buttonAktywujW1.Text = "Atywuj W1";
            }

        }

        private void buttonAktywujW2_Click(object sender, EventArgs e)
        {
            if (RysujWozek.ListaAktywuj[1] == false)
            {
                RysujWozek.ListaAktywuj[1] = true;
                buttonAktywujW2.BackColor = Color.Red;
                buttonAktywujW2.Text = "Aktywny W2";
            }
            else
            {
                RysujWozek.ListaAktywuj[1] = false;
                buttonAktywujW2.BackColor = Color.LawnGreen;
                buttonAktywujW2.Text = "Atywuj W2";
            }
        }

        private void buttonAktywuj3_Click(object sender, EventArgs e)
        {
            if (RysujWozek.ListaAktywuj[2] == false)
            {
                RysujWozek.ListaAktywuj[2] = true;
                buttonAktywujW3.BackColor = Color.Red;
                buttonAktywujW3.Text = "Aktywny W3";
            }
            else
            {
                RysujWozek.ListaAktywuj[2] = false;
                buttonAktywujW3.BackColor = Color.LawnGreen;
                buttonAktywujW3.Text = "Atywuj W3";
            }
        }

        private void buttonAktywujW4_Click(object sender, EventArgs e)
        {
            if (RysujWozek.ListaAktywuj[3] == false)
            {
                RysujWozek.ListaAktywuj[3] = true;
                buttonAktywujW4.BackColor = Color.Red;
                buttonAktywujW4.Text = "Aktywny W4";
            }
            else
            {
                RysujWozek.ListaAktywuj[3] = false;
                buttonAktywujW4.BackColor = Color.LawnGreen;
                buttonAktywujW4.Text = "Atywuj W4";
            }
        }
    }
}
