using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dyplom_Dariusz_Petasz_Z709.BD_TW
{
    public partial class BazaDanych : Form
    {
        PokazPrzedstawienia pp = new PokazPrzedstawienia();
        PokazKompozytor pa = new PokazKompozytor();
        
        
        public BazaDanych()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetWidok();
            ladujWidok(comboBox1.Text);

        }
        void resetWidok()
        {
            pp.Dispose();
            pa.Dispose();
            
        }
        void ladujWidok(string txt)
        {

            switch (txt)
            {
                case "Przedstawienie":
                    {
                        pp = new PokazPrzedstawienia();
                        pp.Parent = panelBazaPokaz;
                        
                        break;
                    }
                case "Akt":
                    {
                        pa = new PokazKompozytor();
                        pa.Parent = panelBazaPokaz;
                        
                        break;
                    }
                case "Rezyser":
                    {

                        break;
                    }
                case "Kompozytor":
                    {

                        break;
                    }
                case "Rodzaj":
                    {

                        break;
                    }
                default: break;

            }
        }

        private void BazaDanych_Load(object sender, EventArgs e)
        {
            ladujWidok(comboBox1.Text);
        }
    }
}
