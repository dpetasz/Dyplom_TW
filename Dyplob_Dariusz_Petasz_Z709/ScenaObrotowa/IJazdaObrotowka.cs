using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplob_Dariusz_Petasz_Z709.ScenaObrotowa
{
    public interface IJazdaObrotowka
    {
        float PozycjaObrotowka();
        void ZapisPozycja(float x);
    }
}
