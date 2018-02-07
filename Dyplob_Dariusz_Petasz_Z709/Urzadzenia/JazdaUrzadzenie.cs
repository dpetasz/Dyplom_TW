using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.Urzadzenia
{
    public class JazdaUrzadzenie
    {
        public virtual float jazdaManual(bool kierunek, int v, float pozycja)
        {
            switch (kierunek)
            {
                case true:
                    {
                        pozycja += v * 0.01f;
                        break;
                    }
                case false:
                    {
                        pozycja -= v * 0.01f;
                        break;
                    }
            }
            return (float)Math.Round(pozycja, 1);
        }
        public virtual float jazdaDoPozycji(float pozycjaZadana, int v, float pozycja)
        {
            if (pozycjaZadana > pozycja) pozycja += v * 0.01f;
            if (pozycjaZadana < pozycja) pozycja -= v * 0.01f;
            else pozycja = pozycjaZadana;
            return (float)Math.Round(pozycja, 1);
        }
        public virtual float jazdaJoystick(int v, float pozycja)
        {
            pozycja += v * 0.01f;
            return (float)Math.Round(pozycja, 2);
        }
    }
}
