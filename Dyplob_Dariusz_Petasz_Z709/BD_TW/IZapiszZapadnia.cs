using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.BD_TW
{
    public interface IZapiszZapadnia
    {
        string ZapiszPozycja(int id, decimal pozycja, decimal portal);
    }
}
