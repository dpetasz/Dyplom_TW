using Dyplom_Dariusz_Petasz_Z709.Urzadzenia;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.Zapadnie
{
    public class RysujZapadnia : RysujUrzadzenie
    {
        public void ZapadniaJazda(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            //kolor rozstawu zapadni
            g.FillRectangle(Pioro1, 20, 180, 100, 100);
            //portal
            g.DrawRectangle(Pioro, 20, 180, 100, 10);
            //nogi
            g.DrawRectangle(Pioro, 30, 190, 10, 180);
            g.DrawRectangle(Pioro, 100, 190, 10, 180);
            //zapadnia
            g.DrawRectangle(Pioro, 40, 270, 60, 10);
            g.DrawRectangle(Pioro, 20, 270, 10, 10);
            g.DrawRectangle(Pioro, 110, 270, 10, 10);
        }
        public void Obramowanie(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //rysuje obramowanie
            g.FillRectangle(Pioro3, 20, 180, 100, 190);
            g.DrawRectangle(Pioro, 20, 0, 100, 370);
            //linie wskazan
            
            g.DrawLine(Pioro, 0, 0, 142, 0);
            g.DrawString("9,5", TextFont, KolorLiczby, 0, 1);
            g.DrawString("0", TextFont, KolorLiczby, 0, 165);
            g.DrawString("-9,5", TextFont, KolorLiczby, 0,370);
            g.DrawLine(Pioro, 0, 180, 142, 180);
            g.DrawLine(Pioro, 0, 370, 140, 370);
        }
    }
}
