﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.Urzadzenia
{
    public class RysujUrzadzenie
    {
        int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string nazwa;
        public string Nazwa
        {
            get { return nazwa; }
            set { nazwa = value; }
        }

        


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

        public virtual void Wypelnienie()
        {
            pioroLinia = new Pen(Color.Black);

            Pioro1 = new SolidBrush(Color.SkyBlue);
            Pioro2 = new SolidBrush(Color.HotPink);
            Pioro3 = new SolidBrush(Color.Green);
            TextFont = new Font("Century", 7F, FontStyle.Bold);
            KolorLiczby = new SolidBrush(Color.Gray);
            pioro = new Pen(Color.Gray);
        }
        public virtual void WypelnienieJazda()
        {
            //pioroLinia = new Pen(Color.Black);

            this.Pioro1 = new SolidBrush(Color.DeepSkyBlue);
            //Pioro2 = new SolidBrush(Color.HotPink);
            //Pioro3 = new SolidBrush(Color.Green);
            //textFont = new Font("Century", 12F, FontStyle.Bold);
            //KolorLiczby = new SolidBrush(Color.FromArgb(10, 10, 10));

        }
        
    }
}