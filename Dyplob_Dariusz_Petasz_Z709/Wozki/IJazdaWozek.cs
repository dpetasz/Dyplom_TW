using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.Wozki
{
    public interface IJazdaWozek
    {
        float jazdaManual(bool kierunek, int v, float pozycja);
        float jazdaDoPozycjiUp(int v, float pozycja);
        float jazdaDoPozycjiDown(int v, float pozycja);
        float jazdaJoystick(int v, float pozycja);
    }
}
