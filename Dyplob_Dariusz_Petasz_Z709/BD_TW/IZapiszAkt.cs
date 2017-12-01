using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.BD_TW
{
    public interface IZapiszAkt
    {
        string DodajAkt(int idPrzed, string nazwa);
        string AktualizujAkt(int idAkt, string nazwa, string opis, TimeSpan dlugosc);
    }
}
