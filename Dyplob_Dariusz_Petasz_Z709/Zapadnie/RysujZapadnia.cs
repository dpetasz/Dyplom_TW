using Dyplom_Dariusz_Petasz_Z709.Urzadzenia;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.Zapadnie
{
    public class RysujZapadnia: RysujUrzadzenie
    {
        public void ZapadniaJazda(Graphics g, float por, float zap)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }
    }
}
