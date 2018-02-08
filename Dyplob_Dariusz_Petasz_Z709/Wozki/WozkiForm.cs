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

        Graphics g;


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

                Wozek wozek = new Wozek(p, Convert.ToInt32(w["predkosc_max"].ToString()), w["nazwa"].ToString(), (Convert.ToInt32(w["idwozek"].ToString())));
                wozek.Przychamowanie = Convert.ToInt32(w["przychamowanie"].ToString());
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



        }
        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            LadujWozek();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Wozek w in Wozek.ListaWozek)
            {
                w.Kierunek = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Wozek w in Wozek.ListaWozek)
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
            Wozek.ListaWozek.Clear();

            f1.Visible = true;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Wozek w in Wozek.ListaWozek)
            {
                if (w.Aktywacja == true)
                {
                    if (w.Pozycja >= 600 && trackBarJoystick.Value > 0)
                    {
                        w.Aktywacja = false;
                        w.LadujAktywuj();
                    }
                    if (w.Pozycja <= 0 && trackBarJoystick.Value < 0)
                    {
                        w.Aktywacja = false;
                        w.LadujAktywuj();
                    }
                    w.Joystick();
                }
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

        private void trackBarJoystick_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
            trackBarJoystick.Value = 0;
            foreach(Wozek w in Wozek.ListaWozek)
            {
                w.Predkosc = trackBarJoystick.Value;
                w.LadujAktywuj();
            }
        }

        private void buttonJazdaProgramowa_Click(object sender, EventArgs e)
        {
            if (panelJoystick.Enabled == true)
            {
                buttonJoystick.BackColor = Color.LightSteelBlue;
                panelJoystick.Enabled = false;
            }
            else
            {
                buttonJoystick.BackColor = Color.IndianRed;
                panelJoystick.Enabled = true;
            }
        }

        private void trackBarJoystick_Scroll(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            foreach (Wozek w in Wozek.ListaWozek)
            {
                if (w.Aktywacja == true)
                {
                    w.Predkosc = trackBarJoystick.Value;
                }
            }
        }
    }
}
