using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709
{
    class RysujTarcza: IRysujTarcza
    {
        StanWypelnienie stanWyp = new Wypelnienie1();
        public Pen pioroLinia;
        public SolidBrush wypelnienieTrojkat;
        public Pen pioro;
        public SolidBrush Pioro1;
        public SolidBrush Pioro2;
        public SolidBrush Pioro3;
        public SolidBrush KolorLiczby;
        public Font textFont;

        

        public void Tarcza(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            int x = 0;
            

            Font textFont = new Font("Century", 12F, FontStyle.Bold);
            g.FillRectangle(Pioro3, 0, 0, 630, 630);
            g.DrawEllipse(pioro, 70, 70, 500, 500);
            g.FillEllipse(Pioro1, 90, 90, 460, 460);
            g.FillEllipse(Pioro2, 317, 317, 6, 6);
            g.DrawLine(pioro, 550, 320, 570, 320);
            g.DrawString(x.ToString(), textFont, KolorLiczby, 575, 310);
            for (int i = 1; i < 360; i++)
            {

                g.TranslateTransform(320, 320);
                g.RotateTransform(1);
                g.TranslateTransform(-320, -320);
                if (i % 5 == 0)
                {
                    g.DrawLine(pioro, 560, 320, 570, 320);
                }
                if (i % 10 == 0)
                {
                    x += 10;
                    g.DrawLine(pioro, 550, 320, 570, 320);
                    g.DrawString(x.ToString(), textFont, KolorLiczby, 575, 310);

                }
                else
                {
                    g.DrawLine(pioro, 565, 320, 570, 320);
                }

            }

        }
        public void Obrot(Graphics g, float o)
        {
            
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Point[] trojkat = { new Point(530, 314), new Point(550, 324), new Point(530, 334) };

            g.TranslateTransform(320, 320);
            g.RotateTransform(o);
            g.TranslateTransform(-320, -320);
            g.DrawLine(pioroLinia, 90, 316, 550, 324);
            g.FillPolygon(wypelnienieTrojkat, trojkat);
        }
        public void Wypelnienie()
        {
            stanWyp.Wypelnienie(this);

        }
        
    }
}
