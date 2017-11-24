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
        int predkosc = 1000;
        float pozycja = 0f;

        public Obrotowka()
        {
            InitializeComponent();
            textBoxPredkosc.Text = trackBar1.Value.ToString();
            pozycja = jazda.PozycjaObrotowka();
        }

        private void PaintTarcza(object sender, PaintEventArgs e)
        {
            stanWyp.Wypelnienie(tarcza);
            g = e.Graphics;

            tarcza.Tarcza(g);
            tarcza.Obrot(g,pozycja);
        }
       
        private void buttonDodajBaza_Click(object sender, EventArgs e)
        {
            Form_BazaDanych formBazaDanych = new Form_BazaDanych();
            formBazaDanych.Show();
        }

        private void buttonZapiszPozycja_Click(object sender, EventArgs e)
        {
            jazda.ZapisPozycja(float.Parse(textBoxPozycjaObrotowka.Text));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //tarcza.Obrot(g,jazda.ruch(false, predkosc));
            //tarcza.PozycjaObrotowka(jazda.ruch(false, predkosc));
            textBoxPozycjaObrotowka.Text =  jazda.ruch(false, predkosc).ToString();
            pozycja = jazda.ruch(false, predkosc);
            Invalidate();
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
