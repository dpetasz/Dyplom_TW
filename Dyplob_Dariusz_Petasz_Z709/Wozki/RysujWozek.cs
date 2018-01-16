using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.Wozki
{
    public class RysujWozek
    {
        StanWypWozki wyp = new Wypelnienie1();
        Pen pioroLinia, pioro;
        SolidBrush pioro1, pioro2, pioro3, kolorLiczby;
        Font textFont;

        public Pen PioroLinia
        {
            get
            {
                return pioroLinia;
            }
            set
            {
                pioroLinia = value;
            }
        }
        public Pen Pioro
        {
            get
            {
                return pioro;
            }
            set
            {
                pioro = value;
            }
        }
        public SolidBrush Pioro1
        {
            get
            {
                return pioro1;
            }
            set
            {
                pioro1 = value;
            }
        }
        public SolidBrush Pioro2
        {
            get
            {
                return pioro2;
            }
            set
            {
                pioro2 = value;
            }
        }
        public SolidBrush Pioro3
        {
            get
            {
                return pioro3;
            }
            set
            {
                pioro3 = value;
            }
        }
        public SolidBrush KolorLiczby
        {
            get
            {
                return kolorLiczby;
            }
            set
            {
                kolorLiczby = value;
            }
        }
        public Font TextFont
        {
            get
            {
                return textFont;
            }
            set
            {
                textFont = value;
            }
        }

        public void Wozek1(Graphics g, float x)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            
            g.FillRectangle(pioro1, x, 20, 460, 90);
            g.DrawRectangle(pioro, x, 20, 460, 90);
            

        }
        public void Wozek2(Graphics g, float x)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g.FillRectangle(pioro1, x, 110, 460, 90);
            g.DrawRectangle(pioro, x, 110, 460, 90);


        }
        public void Wozek3(Graphics g, float x)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g.FillRectangle(pioro1, x, 200, 460, 90);
            g.DrawRectangle(pioro, x, 200, 460, 90);


        }
        public void Wozek4(Graphics g, float x)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g.FillRectangle(pioro1, x, 290, 460, 90);
            g.DrawRectangle(pioro, x, 290, 460, 90);


        }
        public void Zascenie(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g.FillRectangle(pioro3, 20, 20, 460, 360);
            //g.DrawRectangle(pioroLinia, 20, 20, 460, 360);


        }
        public void Scena(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.DrawRectangle(pioro, 620, 20, 460, 360);

        }
        public void Wypelnienie()
        {
            wyp.Wypelnienie(this);

        }
    }
}
