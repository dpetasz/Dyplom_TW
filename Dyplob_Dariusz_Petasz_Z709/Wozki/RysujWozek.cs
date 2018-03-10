using Dyplom_Dariusz_Petasz_Z709.Urzadzenia;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.Wozki
{
    public class RysujWozek: RysujUrzadzenie, IRysujWozek
    {
        public void WozekJazda(Graphics g, float x)
        {
            
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //rysuje wozek
            g.FillRectangle(Pioro1, x, 1, 460, 104);
            g.DrawRectangle(Pioro, x, 1, 460, 104);
            //napis
            g.DrawString(Nazwa.ToString(), TextFont, KolorLiczby, x + 180, 30);


        }
        public void Scena(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g.FillRectangle(Pioro3, 0, 0, 460, 105);
            g.DrawRectangle(Pioro, 0, 0, 460, 105);
            //g.DrawRectangle(pioro, 480, 20, 140, 360);
            g.DrawRectangle(Pioro, 600, 0, 460, 105);
        }
    }
}
