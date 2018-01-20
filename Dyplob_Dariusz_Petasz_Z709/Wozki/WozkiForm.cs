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
        float jazda = 20.00f;
        float Jazda
        {
            get { return jazda; }
            set { jazda = value; }
        }
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
            int wys = 290;
            foreach (DataRow w in tWDataSet.pokazWozki.Rows)
            {


                Jazda = (float)(Convert.ToDouble(w["pozycja"].ToString()));
                RysujWozek wozek = new RysujWozek(jazda,
                                                    wys,
                                                    Convert.ToInt32(w["predkosc_max"].ToString()),
                                                    w["nazwa"].ToString());
                RysujWozek.ListaWozek.Add(wozek);
                /*stanWyp.Wypelnienie(wozek);
                wozek.Wozek(g);*/
                wys -= 90;
            }
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            scena = new RysujWozek();
            stanWyp.Wypelnienie(scena);
            scena.Scena(g);

            foreach(RysujWozek w in RysujWozek.ListaWozek)
            {
                stanWyp.Wypelnienie(w);
                w.Wozek(g);
            }
            
            
            //scena.Scena(g);

            /*tmp.Wozek1(g, x1);
            tmp.Wozek2(g, x2);
            tmp.Wozek3(g, x3);
            tmp.Wozek4(g, x4);
            stanWozek = new Wozek1();
            stanWozek.WozekTworz(tmp);
            tmp.Wozek(g, x1);
            */

        }
        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jazda += 0.55f;

            pictureBox1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Jazda -= 0.55f;

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

        




    }
}
