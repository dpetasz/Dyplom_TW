using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.BD_TW
{
    public interface IZapiszMost
    {
        string ZapiszPozycja(int id, float pozycja);
        string DodajFx_most(int id, string opis);
        string DodajFx_most_most(int idmost, int idfx, int v, float stop);
        string AktualizujFx_most(int idFx_most, string nazwa, string opis);
        string AktualizujFX_most_most(int idfx_mostmost, int v, float stop);
        
    }
}
