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
        public MostyPanel()
        {
            InitializeComponent();
        }
        void LadujMost()
        {
            
            int wys = 3;
            int szer = 3;
            foreach (DataRow m in twDataSet.pokazMosty.Rows)
            {
                float p = (float)(Convert.ToDouble(m["pozycja"].ToString()));
                string name = m["nazwa"].ToString();
                int vmax = Convert.ToInt32(m["predkosc_max"].ToString());
                int id = Convert.ToInt32(m["idmost"].ToString());
                float kd = (float)(Convert.ToDouble(m["krancowa_dol"].ToString()));
                float kg = (float)(Convert.ToDouble(m["krancowa_gora"].ToString()));
                int przych = Convert.ToInt32(m["przychamowanie"].ToString());
                if(szer < 753)
                {
                    Most most = new Most(id, name, p, vmax, przych);
                    most.Parent = tabControl1.TabPages[0];
                    most.Top = wys;
                    most.Left = szer;
                    szer += 250;
                    if (szer == 753) { szer = 3; wys = 296; }
                }
                else
                {
                    
                    Most most = new Most(id, name, p, vmax, przych);
                    most.Parent = tabControl1.TabPages[0];
                    most.Top = wys;
                    most.Left = szer;
                    szer += 250;
                }
                

            }
        }

        private void MostyPanel_Load(object sender, EventArgs e)
        {
            LadujMost();
        }
    }
}
