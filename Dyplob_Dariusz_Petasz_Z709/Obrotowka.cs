using Dyplob_Dariusz_Petasz_Z709.ScenaObrotowa;
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


namespace Dyplob_Dariusz_Petasz_Z709
{
    public partial class Obrotowka : Form
    {
        RysujTarcza tarcza = new RysujTarcza();
        Graphics g;
        StanWypelnienie stanWyp = new Wypelnienie1();
        IJazdaObrotowka jazda = new JazdaObrotowka();

        public Obrotowka()
        {
            InitializeComponent();
            textBoxPredkosc.Text = trackBar1.Value.ToString();
        }

        private void PaintTarcza(object sender, PaintEventArgs e)
        {
            stanWyp.Wypelnienie(tarcza);
            g = e.Graphics;

            
            
            tarcza.Tarcza(g);
            tarcza.Obrot(g, jazda.PozycjaObrotowka());
        }
       
        private void buttonDodajBaza_Click(object sender, EventArgs e)
        {
            Form_BazaDanych formBazaDanych = new Form_BazaDanych();
            formBazaDanych.Show();
        }

        private void buttonZapiszPozycja_Click(object sender, EventArgs e)
        {
            jazda.ZapisPozycja(12);
        }
    }
}
