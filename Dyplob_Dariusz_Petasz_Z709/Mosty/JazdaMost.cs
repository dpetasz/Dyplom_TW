using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.Mosty
{
    public class JazdaMost:IJazdaMost
    {
        public float jazdaTechniczna(bool kierunek, int v, float pozycja)
        {
            switch(kierunek)
            {
                case true:
                    {
                        pozycja += v *  0.001f;
                        break;
                    }
                case false:
                    {
                        pozycja -=v*0.001f;
                        break;
                    }
            }
            return (float)Math.Round(pozycja, 1);
        }
        public float jazdaDoPozycji(float pozycjaZadana, int v, float pozycja)
        {
            if (pozycjaZadana > pozycja) pozycja += v * 0.001f; 
            if (pozycjaZadana < pozycja) pozycja -= v * 0.001f;                
            else pozycja = pozycjaZadana;
            return (float)Math.Round(pozycja, 1);
        }
    }
}
