using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dyplom_Dariusz_Petasz_Z709.Zapadnie
{
    public partial class ZapadniePanel : UserControl
    {
        Zapadnia zapadnia;
        public ZapadniePanel()
        {
            InitializeComponent();
        }

        private void ZapadniePanel_Load(object sender, EventArgs e)
        {
            this.pokazZapadnieTableAdapter.Fill(this.twDataSet.pokazZapadnie);
            LadujZapadnia();
        }
        void LadujZapadnia()
        {
            int szer = 3;
            foreach (DataRow z in twDataSet.pokazZapadnie.Rows)
            {
                float p = (float)(Convert.ToDouble(z["pozycja"].ToString()));
                string name = z["nazwa"].ToString();
                int vmax = Convert.ToInt32(z["predkosc_max"].ToString());
                int id = Convert.ToInt32(z["idzapadnia"].ToString());
                float kd = (float)(Convert.ToDouble(z["krancowa_dol"].ToString()));
                float kg = (float)(Convert.ToDouble(z["krancowa_gora"].ToString()));
                int przych = Convert.ToInt32(z["przychamowanie"].ToString());
                zapadnia = new Zapadnia(id, name, p, vmax, przych);
                zapadnia.Kg = kg;
                zapadnia.Kd = kd;
                zapadnia.Parent = panelZapadnie;
                zapadnia.Top = 3;
                zapadnia.Left = szer;
                szer += 154;
            }
        }
    }
}
