using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.Urzadzenia
{
    public class RysujPrzycisk
    {
        Pen liniaPrzycisk;
        
        public Pen LiniaPrzycisk
        {
            get
            {
                return liniaPrzycisk;
            }
            set
            {
                liniaPrzycisk = value;
            }
        }
        SolidBrush start, kolorTextPrzycisk;
       
        public SolidBrush Start
        {
            get
            {
                return start;
            }
            set
            {
                start = value;
            }
        }
        public SolidBrush KolorTextPrzycisk
        {
            get
            {
                return kolorTextPrzycisk;
            }
            set
            {
                kolorTextPrzycisk = value;
            }
        }
        Font textFont, textPrzycisk;
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
        public Font TextPrzycisk
        {
            get
            {
                return TextPrzycisk;
            }
            set
            {
                TextPrzycisk = value;
            }
        }
        public virtual void WypelnienieStart()
        {
            Start = new SolidBrush(Color.Green);
            TextFont = new Font("Century", 12F, FontStyle.Bold);
            KolorTextPrzycisk = new SolidBrush(Color.Black);
            LiniaPrzycisk = new Pen(Color.Gray, 4);
        }
        public virtual void WypelnienieStop()
        {
            Start = new SolidBrush(Color.IndianRed);
            TextFont = new Font("Century", 12F, FontStyle.Bold);
            KolorTextPrzycisk = new SolidBrush(Color.Black);
            LiniaPrzycisk = new Pen(Color.Gray, 4);
        }
        public void PrzyciskStartStop(Graphics g, string txt)
        {
            g.FillEllipse(Start, 0, 0, 125, 125);
            g.DrawEllipse(LiniaPrzycisk, 0, 0, 125, 125);
            g.DrawString(txt, TextFont, KolorTextPrzycisk, 10, 50);
        }
    }
}
