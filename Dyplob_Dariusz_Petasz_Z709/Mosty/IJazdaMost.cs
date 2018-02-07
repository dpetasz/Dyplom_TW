using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.Mosty
{
    public interface IJazdaMost
    {
        float jazdaManual(bool kierunek, int v, float pozycja);
        float jazdaDoPozycji(float pozycjaZadana, int v, float pozycja);
        float jazdaJoystick(int v, float pozycja);
    }
}
