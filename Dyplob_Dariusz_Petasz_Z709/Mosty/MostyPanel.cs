using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dyplom_Dariusz_Petasz_Z709.Mosty
{
    public partial class MostyPanel : UserControl
    {
        Most most ;
        public MostyPanel()
        {
            InitializeComponent();
        }
        void LadujMost()
        {
            
            int wys = 5;
            int szer = 5;
            foreach (DataRow m in twDataSet.pokazMosty.Rows)
            {
                float p = (float)(Convert.ToDouble(m["pozycja"].ToString()));
                string name = m["nazwa"].ToString();
                int vmax = Convert.ToInt32(m["predkosc_max"].ToString());
                int id = Convert.ToInt32(m["idmost"].ToString());
                float kd = (float)(Convert.ToDouble(m["krancowa_dol"].ToString()));
                float kg = (float)(Convert.ToDouble(m["krancowa_gora"].ToString()));
                int przych = Convert.ToInt32(m["przychamowanie"].ToString());
                if(szer < 700)
                {
                    most = new Most(id, name, p, vmax, przych);
                    most.Kg = kg ;
                    most.Kd = kd ;
                    most.Parent = panelMosty;
                    most.Top = wys;
                    most.Left = szer;
                    szer += 230;
                    if (szer == 925) { szer = 5; wys = 310; }
                }
                else
                {
                    
                    most = new Most(id, name, p, vmax, przych);
                    most.Kg = kg ;
                    most.Kd = kd ;
                    most.Parent = panelMosty;
                    most.Top = wys;
                    most.Left = szer;
                    szer += 230;
                }
                

            }
                    }

        private void MostyPanel_Load(object sender, EventArgs e)
        {
            //this.pokazWozkiTableAdapter.Fill(this.tWDataSet.pokazWozki);
            this.pokazMostyTableAdapter.Fill(this.twDataSet.pokazMosty);
            LadujMost();
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void trackBarJoystick_MouseUp(object sender, MouseEventArgs e)
        {
            trackBarJoystick.Value = 0;
            foreach (Most m in Most.ListaMost)
            {
                
                    m.Predkosc = trackBarJoystick.Value;

                    m.Odswiez();
                
            }
        }

        private void buttonJoystick_Click(object sender, EventArgs e)
        {
            
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Most m in Most.ListaMost)
            {
                if (m.Aktywacja == true)
                {
                    
                     
                     if (m.Pozycja >= m.Kg && trackBarJoystick.Value > 0)
                     { 
                         timer1.Enabled = false;
                         m.Aktywacja = false;
                         m.ZmianaAktywacja();
                         m.ZmianaKrancowa();
                     }
                     if (m.Pozycja <= m.Kd && trackBarJoystick.Value < 0)
                     {
                         timer1.Enabled = false;
                         m.Aktywacja = false;
                         m.ZmianaAktywacja();
                         m.ZmianaKrancowa();
                     }
                     m.Joystick();
                }
            }
        }

        private void trackBarJoystick_Scroll(object sender, EventArgs e)
        {
            foreach (Most m in Most.ListaMost)
            {
                if (m.Aktywacja == true)
                {
                    
                    m.Predkosc = trackBarJoystick.Value ;
                    m.ZmianaKrancowa();
                    
                    //m.Odswiez();
                }
            }
        }

        private void buttonJazdaDoPozycji_Click(object sender, EventArgs e)
        {
            foreach (Most m in Most.ListaMost)
            {
                m.Pozycja = 100;
                m.Odswiez();
            }
        }

        
    }
}
