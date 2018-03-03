using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.BD_TW
{
    public interface IZapiszWozek
    {
        string DodajFx_Wozek(int idAkt, string opis);
        string DodajFx_Wozek_Wozek(int idfx, int idw, int v, float stop);
        string ZapiszPozycja(int id, float pozycja);
        string AktualizujFx_wozek(int idFx_wozek, string nazwa, string opis);
        string AktualizujFX_most_most(int idfx_wozekwozek, int v, float stop);
    }
}
