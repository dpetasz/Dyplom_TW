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

        IZapiszWozek db = new ZapiszFxWozek();
        PokazPrzedstawienia przedstawienia = new PokazPrzedstawienia();

        bool joystick = false, doPozycji = false, manualna = false, programowa = false;
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
                wozek.Kd = (float)(Convert.ToDouble(w["krancowa_przod"].ToString()));
                wozek.Kg = (float)(Convert.ToDouble(w["krancowa_tyl"].ToString()));
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
            //this.pokazPrzedstawienieTableAdapter.Fill(this.tWDataSet.pokazPrzedstawienie);
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
                    if (joystick == true)
                    {
                        w.JazdaJoystick();
                    }
                    else if (manualna == true)
                    {
                        w.JazdaManual();
                    }
                    else if (doPozycji == true || programowa == true)
                    {
                        w.JazdaDoPozycji();
                    }

                }
            }
            pictureBox1.Invalidate();
        }
        private void green()
        {

            timer1.Enabled = false;
            buttonStartStop.BackColor = Color.Green;
            buttonStartStop.Text = "Start";


        }
        private void red()
        {
            timer1.Enabled = true;
            buttonStartStop.BackColor = Color.Red;
            buttonStartStop.Text = "Stop";
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
            textBoxWynikZapisu.Clear();
            foreach (Wozek w in Wozek.ListaWozek)
            {
                if (w.Aktywacja == true)
                {
                    w.SetPredkosc(trackBarJoystick.Value);
                    textBoxWynikZapisu.Text +=" / " +  w.ZapiszPozycjaBaza() ;
                    w.Odswiez();
                }

            }
        }

        private void buttonJazdaProgramowa_Click(object sender, EventArgs e)
        {
            LadujProgramowa();
            LadujBazaPrzedstawienie();
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

        private void pokazPrzedstawienieBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                int idPrzed = ((this.pokazPrzedstawienieBindingSource.Current as DataRowView).Row as TWDataSet.pokazPrzedstawienieRow).idprzed;
                this.pokazAktTableAdapter.Fill(this.tWDataSet.pokazAkt, idPrzed);
            }
            catch (Exception)
            {


            }
        }

        private void pokazAktBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ladujFx_Wozek();
        }

        void ladujFx_Wozek()
        {
            try
            {
                int idAkt = ((this.pokazAktBindingSource.Current as DataRowView).Row as TWDataSet.pokazAktRow).idakt;
                this.pokazFx_Wozek_malejacoTableAdapter.Fill(this.tWDataSet.pokazFx_Wozek_malejaco, idAkt);
                this.pokazFx_Wozek_rosnacoTableAdapter.Fill(this.tWDataSet.pokazFx_Wozek_rosnaco, idAkt);
            }
            catch
            {


            }
        }

        void ladujFx_Wozek_Wozek()
        {
            try
            {
                int idFx_wozek = ((this.pokazFxWozekrosnacoBindingSource.Current as DataRowView).Row as TWDataSet.pokazFx_Wozek_rosnacoRow).idfx_wozek;
                this.pokazFx_Wozek_WozekTableAdapter.Fill(this.tWDataSet.pokazFx_Wozek_Wozek, idFx_wozek);
                foreach (Wozek w in Wozek.ListaWozek)
                {
                    w.ladujBazaProgramowa(idFx_wozek);
                }
            }
            catch
            {


            }
        }
        void ladujFx_Wozek_Wozek_malejaco()
        {
            try
            {
                int idFx_wozek = ((this.pokazFxWozekmalejacoBindingSource.Current as DataRowView).Row as TWDataSet.pokazFx_Wozek_malejacoRow).idfx_wozek;
                this.pokazFx_Wozek_WozekTableAdapter.Fill(this.tWDataSet.pokazFx_Wozek_Wozek, idFx_wozek);
                foreach (Wozek w in Wozek.ListaWozek)
                {
                    w.ladujBazaProgramowa(idFx_wozek);
                }
            }
            catch
            {


            }
        }
        void LadujProgramowa()
        {
            doPozycji = true;
            buttonJazdaDoPozycji.BackColor = Color.LightSteelBlue;
            buttonJazdaDoPozycji.Enabled = true;
            buttonStartStop.Enabled = true;

            joystick = false;
            buttonJoystick.BackColor = Color.LightSteelBlue;
            buttonJoystick.Enabled = true;

            manualna = false;
            buttonManual.BackColor = Color.LightSteelBlue;
            buttonManual.Enabled = true;


            programowa = true;
            buttonProgramowa.BackColor = Color.IndianRed;
            buttonProgramowa.Enabled = false;
            tabControlProgramowa.Enabled = true;
            LadujJazdaDoPozycji();
        }
        void LadujJoystick()
        {
            doPozycji = false;
            buttonJazdaDoPozycji.BackColor = Color.LightSteelBlue;
            buttonJazdaDoPozycji.Enabled = true;
            buttonStartStop.Enabled = false;
            Stop();

            joystick = true;
            buttonJoystick.BackColor = Color.IndianRed;
            buttonJoystick.Enabled = false;
            LadujJazdaJoystick();

            manualna = false;
            buttonManual.BackColor = Color.LightSteelBlue;
            buttonManual.Enabled = true;


            programowa = false;
            buttonProgramowa.BackColor = Color.LightSteelBlue;
            buttonProgramowa.Enabled = true;
            tabControlProgramowa.Enabled = false;
        }
        void LadujDoPozycji()
        {
            doPozycji = true;
            buttonJazdaDoPozycji.BackColor = Color.IndianRed;
            buttonJazdaDoPozycji.Enabled = false;
            buttonStartStop.Enabled = true;
            LadujJazdaDoPozycji();

            joystick = false;
            buttonJoystick.BackColor = Color.LightSteelBlue;
            buttonJoystick.Enabled = true;

            manualna = false;
            buttonManual.BackColor = Color.LightSteelBlue;
            buttonManual.Enabled = true;


            programowa = false;
            buttonProgramowa.BackColor = Color.LightSteelBlue;
            buttonProgramowa.Enabled = true;
            tabControlProgramowa.Enabled = false;
        }
        void LadujManual()
        {
            doPozycji = false;
            buttonJazdaDoPozycji.BackColor = Color.LightSteelBlue;
            buttonJazdaDoPozycji.Enabled = true;
            buttonStartStop.Enabled = false;
            Stop();

            joystick = false;
            buttonJoystick.BackColor = Color.LightSteelBlue;
            buttonJoystick.Enabled = true;

            manualna = true;
            buttonManual.BackColor = Color.IndianRed;
            buttonManual.Enabled = false;
            LadujJazdaManual();

            programowa = false;
            buttonProgramowa.BackColor = Color.LightSteelBlue;
            buttonProgramowa.Enabled = true;
            tabControlProgramowa.Enabled = false;
        }
        void Start()
        {
            timer1.Enabled = true;
            buttonStartStop.BackColor = Color.IndianRed;
            buttonStartStop.Text = "Stop";
        }
        void Stop()
        {
            timer1.Enabled = false;
            buttonStartStop.BackColor = Color.Green;
            buttonStartStop.Text = "Start";
            foreach (Most m in Most.ListaMost)
            {
                if (m.Aktywacja == true)
                {
                    m.ZapiszPozycjaBaza();
                    m.Odswiez();
                }

            }
        }
        private void buttonProgramowa_Click(object sender, EventArgs e)
        {
            LadujProgramowa();
            LadujBazaPrzedstawienie();
        }
        void LadujJazdaJoystick()
        {
            foreach (Wozek w in Wozek.ListaWozek)
            {
                w.AktywujJoystick();
            }
        }
        void LadujJazdaDoPozycji()
        {
            foreach (Wozek w in Wozek.ListaWozek)
            {
                w.AktywujDoPozycji();
            }

        }
        void LadujJazdaProgramowa()
        {
            foreach (Wozek w in Wozek.ListaWozek)
            {
                w.AktywujDoPozycji();
            }
        }
        void LadujJazdaManual()
        {
            foreach (Wozek w in Wozek.ListaWozek)
            {
                w.AktywujManualna();
            }
        }
        void LadujBazaPrzedstawienie()
        {
            this.pokazPrzedstawienieTableAdapter.Fill(this.tWDataSet.pokazPrzedstawienie);
        }

        private void buttonJoystick_Click(object sender, EventArgs e)
        {
            LadujJoystick();
        }

        private void buttonJazdaDoPozycji_Click(object sender, EventArgs e)
        {
            LadujDoPozycji();
        }

        private void buttonManual_Click(object sender, EventArgs e)
        {
            LadujManual();
        }

        private void buttonDodajFX_Click(object sender, EventArgs e)
        {
            try
            {
                int idAkt = ((this.pokazAktBindingSource.Current as DataRowView).Row as TWDataSet.pokazAktRow).idakt;
                textBoxWynik.Text = db.DodajFx_Wozek(idAkt, richTextBox3.Text);
                ladujFx_Wozek();
            }
            catch
            {


            }
        }

        private void buttonZapiszFx_wozek_wozek_Click(object sender, EventArgs e)
        {
            
            try
            {
                int idfxwozek = ((this.pokazFxWozekmalejacoBindingSource.Current as DataRowView).Row as TWDataSet.pokazFx_Wozek_malejacoRow).idfx_wozek;
                
                foreach (Wozek w in Wozek.ListaWozek)
                {
                    textBoxWynik.Text = db.DodajFx_Wozek_Wozek( idfxwozek,w.GetId(),  w.GetPredkosc(), w.GetPozycja());
                    ladujFx_Wozek();
                    w.ladujBazaProgramowa(idfxwozek);
                }
            }
            catch
            {
                textBoxWynik.Text = "Błąd bazy";

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int idfxwozek = ((this.pokazFxWozekmalejacoBindingSource.Current as DataRowView).Row as TWDataSet.pokazFx_Wozek_malejacoRow).idfx_wozek;

                foreach (Wozek w in Wozek.ListaWozek)
                {
                    w.aktualizujFx_wozek_wozek(idfxwozek);
                }
                ladujFx_Wozek_Wozek();
            }
            catch
            {


            }
        }

        private void pokazFxWozekrosnacoBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ladujFx_Wozek_Wozek();
        }

        private void pokazFxWozekmalejacoBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ladujFx_Wozek_Wozek_malejaco();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                int idfxwozek = ((this.pokazFxWozekrosnacoBindingSource.Current as DataRowView).Row as TWDataSet.pokazFx_Wozek_rosnacoRow).idfx_wozek;

                foreach (Wozek w in Wozek.ListaWozek)
                {
                    textBoxWynik.Text = db.AktualizujFx_wozek(idfxwozek, textBoxNazwaFX.Text, richTextBox2.Text);
                    ladujFx_Wozek();
                }
            }
            catch
            {
                textBoxWynik.Text = "Błąd bazy";

            }
        }
    }
}
