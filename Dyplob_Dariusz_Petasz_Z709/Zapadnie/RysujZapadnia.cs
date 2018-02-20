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
        public void ZapadniaJazda(Graphics g, float zapadnia, float portal)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            //kolor rozstawu zapadni
            g.FillRectangle(Pioro1, 20, 190 - portal, 100, portal - zapadnia);
            //portal
            g.FillRectangle(Rygiel_1, 20, 190 - portal, 100, 10);
            g.DrawRectangle(Pioro, 20, 190 - portal, 100, 10);
            //zapadnia
            g.FillRectangle(Rygiel_2, 30, 190 - zapadnia, 80, 10);
            g.FillRectangle(Rygiel_3, 20, 190 - zapadnia, 10, 10);
            g.FillRectangle(Rygiel_3, 110, 190 - zapadnia, 10, 10);
            g.DrawRectangle(Pioro, 20, 190 - zapadnia, 100, 10);
            //nogi
            g.DrawRectangle(Pioro, 30, 200 - portal, 10, 190);
            g.DrawRectangle(Pioro, 100, 200 - portal, 10, 190);
        }

        public void Obramowanie(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //rysuje obramowanie
            g.FillRectangle(Pioro3, 20, 190, 100, 190);
            g.DrawRectangle(Pioro, 20, 0, 100, 380);


            //linie wskazan
            
            g.DrawLine(Pioro, 0, 0, 142, 0);
            g.DrawString("9,5", TextFont, KolorLiczby, 0, 1);
            g.DrawString("0", TextFont, KolorLiczby, 0, 175);
            g.DrawString("-9,5", TextFont, KolorLiczby, 0, 365);
            g.DrawLine(Pioro, 0, 190, 142, 190);
            g.DrawLine(Pioro, 0, 380, 140, 380);
        }
    }
}
