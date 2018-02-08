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
                        pozycja += v * 0.001f;
                        break;
                    }
                case false:
                    {
                        pozycja -= v * 0.001f;
                        break;
                    }
            }
            return (float)Math.Round(pozycja, 1);
        }
        public virtual float jazdaDoPozycji(float pozycjaZadana, int v, float pozycja)
        {
            if (pozycjaZadana > pozycja) pozycja += v * 0.001f;
            if (pozycjaZadana < pozycja) pozycja -= v * 0.001f;
            else pozycja = pozycjaZadana;
            return (float)Math.Round(pozycja, 1);
        }
        public virtual float jazdaJoystick(int v, float pozycja)
        {
            //float x = pozycja;
            pozycja += v * 0.01f;
            return (float)Math.Round(pozycja, 2);
        }
    }
}
