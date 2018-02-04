using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.Mosty
{
    public class RysujMost: IRysujMost
    {
        Pen pioroLinia, pioro;
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

        SolidBrush pioro1, pioro2, pioro3, kolorLiczby;
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

        Font textFont;
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

        public void Wypelnienie()
        {
            pioroLinia = new Pen(Color.Black);
            
            Pioro1 = new SolidBrush(Color.SkyBlue);
            Pioro2 = new SolidBrush(Color.HotPink);
            Pioro3 = new SolidBrush(Color.Green);
            textFont = new Font("Century", 12F, FontStyle.Bold);
            KolorLiczby = new SolidBrush(Color.FromArgb(10, 10, 10));
            pioro = new Pen(Color.Gray);
        }
        public void WypelnienieJazda()
        {
            //pioroLinia = new Pen(Color.Black);
            
            Pioro1 = new SolidBrush(Color.Olive);
            //Pioro2 = new SolidBrush(Color.HotPink);
            //Pioro3 = new SolidBrush(Color.Green);
            //textFont = new Font("Century", 12F, FontStyle.Bold);
            //KolorLiczby = new SolidBrush(Color.FromArgb(10, 10, 10));
           
        }
        public void MostJazda(Graphics g, float x)
        {
            
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //rysuje most
            g.FillRectangle(Pioro1, 0, 0, 25, 125);
            g.DrawRectangle(Pioro, 0, 0, 25, 125);
           
        }
        public void Obramowanie(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g.FillRectangle(Pioro3, 0, 0, 25, 250);
            g.DrawRectangle(Pioro, 0, 0, 25, 250);
        }

    }
}
