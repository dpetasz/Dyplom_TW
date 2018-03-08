using Dyplom_Dariusz_Petasz_Z709.Wozki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.Urzadzenia
{
    public class JazdaUrzadzenie: IJazdaWozek
    {
        public virtual float jazdaManual(bool kierunek, int v, float pozycja)
        {
            switch (kierunek)
            {
                case true:
                    {
                        pozycja += Math.Abs(v) * 0.01f;
                        break;
                    }
                case false:
                    {
                        pozycja -= Math.Abs(v) * 0.01f;
                        break;
                    }
            }
            return (float)Math.Round(pozycja, 2);
        }
        public virtual float jazdaDoPozycjiUp(int v, float pozycja)
        {
            pozycja += Math.Abs(v) * 0.01f;

            return (float)Math.Round(pozycja, 2);
        }
        public virtual float jazdaDoPozycjiDown( int v, float pozycja)
        {
             pozycja -= Math.Abs(v) * 0.01f;

             return (float)Math.Round(pozycja, 2);
        }
        public virtual float jazdaJoystick(int v, float pozycja)
        {
            pozycja += v * 0.01f;
            return (float)Math.Round(pozycja, 2);
        }
    }
}
