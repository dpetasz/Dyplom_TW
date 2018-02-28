using Dyplom_Dariusz_Petasz_Z709.Urzadzenia;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.Mosty
{
    public class RysujMost: RysujUrzadzenie
    {
       

        
        public void MostJazda(Graphics g, float x)
        {
            
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //rysuje most
            g.FillRectangle(Pioro1, 0, x, 25, 10);
            g.DrawRectangle(Pioro, 0, x, 25, 10);
           
        }
        public void Obramowanie(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g.FillRectangle(Pioro3, 0, 0, 25, 260);
            g.DrawRectangle(Pioro, 0, 0, 25, 260);
        }

    }
}
