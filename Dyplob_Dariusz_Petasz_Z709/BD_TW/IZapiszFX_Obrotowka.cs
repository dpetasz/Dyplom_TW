using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.BD_TW
{
    public interface IZapiszFX_Obrotowka
    {
        string DodajFX(int idAkt, string nazwa, int predkosc, bool kierunek, decimal stop, string opis);
        string AktualizujFX(int idFX, int idAkt, string nazwa, int predkosc, bool kierunek, decimal stop, string opis);
    }
}
