using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dyplom_Dariusz_Petasz_Z709.BD_TW
{
    public partial class DodajFX_Obrotowka : UserControl
    {
        int idAkt;
        int IdAkt
        {
            get { return idAkt; }
            set { idAkt = value; }
        }
        public DodajFX_Obrotowka(int id)
        {
            InitializeComponent();
            IdAkt = id;
        }
    }
}
