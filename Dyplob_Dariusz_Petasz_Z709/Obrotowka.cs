using Dyplom_Dariusz_Petasz_Z709.BD_TW;
using Dyplom_Dariusz_Petasz_Z709.ScenaObrotowa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Dyplom_Dariusz_Petasz_Z709
{
    public partial class Obrotowka : Form
    {
        RysujTarcza tarcza = new RysujTarcza();
        Graphics g;
        StanWypelnienie stanWyp = new Wypelnienie1();
        IJazdaObrotowka jazda = new JazdaObrotowka();
        IZapiszAkt zapiszAkt = new ZapiszAkt();

        int predkosc = 0, kierunek = 0;
        float pozycja = 0f;

        public Obrotowka()
        {
            InitializeComponent();
            predkosc = trackBarPredkoscObrotowka.Value;
            textBoxPredkoscObrotowka.Text = trackBarPredkoscObrotowka.Value.ToString();
            pozycja = jazda.PozycjaObrotowka();
            textBoxPozycjaObrotowka.Text = pozycja.ToString();
            
        }

        private void pictureBoxTarcza_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            stanWyp.Wypelnienie(tarcza);
            
            tarcza.Tarcza(g);
            tarcza.Obrot(g, pozycja);
        }
       
        private void buttonDodajBaza_Click(object sender, EventArgs e)
        {
            Form_BazaDanych formBazaDanych = new Form_BazaDanych();
            formBazaDanych.Show();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            pozycja = jazda.ruch(kierunek, predkosc);
            textBoxPozycjaObrotowka.Text = pozycja.ToString();
            pictureBoxTarcza.Invalidate();
        }

       

        private void trackBarKierunek_Scroll(object sender, EventArgs e)
        {
            kierunek = trackBarKierunek.Value;
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

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                red();
            }
            else
            {
                jazda.ZapisPozycja(pozycja);
                green();
            }
        }

       

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBoxPredkoscObrotowka.Text = trackBarPredkoscObrotowka.Value.ToString();
            predkosc = trackBarPredkoscObrotowka.Value;
        }

        private void Obrotowka_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tWDataSet.pokazPrzedstawienie' table. You can move, or remove it, as needed.
            this.pokazPrzedstawienieTableAdapter.Fill(this.tWDataSet.pokazPrzedstawienie);
           

        }

        private void buttonOpisPrzedstawienie_Click(object sender, EventArgs e)
        {
            richTextBoxOpis.Text = ((this.pokazPrzedstawienieBindingSource.Current as DataRowView).Row as TWDataSet.pokazPrzedstawienieRow).opis;
            
        }

        private void buttonDodajAkt_Click(object sender, EventArgs e)
        {
            panelDodajAkt.Visible = true;

            
        }

        private void buttonAnulujDodajAkt_Click(object sender, EventArgs e)
        {
            panelDodajAkt.Visible = false;
        }

        private void buttonZapiszNowyAkt_Click(object sender, EventArgs e)
        {
            int idPrzed = ((this.pokazPrzedstawienieBindingSource.Current as DataRowView).Row as TWDataSet.pokazPrzedstawienieRow).idprzed;
            richTextBoxOpis.Text = zapiszAkt.DodajAkt(idPrzed, textBoxNazwaAktDodaj.Text);
            panelDodajAkt.Visible = false;
            this.pokazAktTableAdapter.Fill(this.tWDataSet.pokazAkt, idPrzed);
        }

        private void pokazAktBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            int idAkt = ((this.pokazAktBindingSource.Current as DataRowView).Row as TWDataSet.pokazAktRow).idakt;
            this.pokazFxObrotowkaTableAdapter.Fill(this.tWDataSet.pokazFxObrotowka, idAkt);
        }

        private void pokazPrzedstawienieBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            int idPrzed = ((this.pokazPrzedstawienieBindingSource.Current as DataRowView).Row as TWDataSet.pokazPrzedstawienieRow).idprzed;
            this.pokazAktTableAdapter.Fill(this.tWDataSet.pokazAkt, idPrzed);
        }
    }
}
