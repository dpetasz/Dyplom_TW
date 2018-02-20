using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.BD_TW
{
    public interface IZapiszZapadnia
    {
        string ZapiszPozycja(int id, decimal pozycja, decimal portal, bool r1, bool r2, bool r3, bool s);
        string ZapiszFX_Zapadnia(int id, string opis);
        string ZapiszFX_Zapadnia_Zapadnia(int idzap, int idfx, int v, float stop, bool spr, bool akt);
    }
}
