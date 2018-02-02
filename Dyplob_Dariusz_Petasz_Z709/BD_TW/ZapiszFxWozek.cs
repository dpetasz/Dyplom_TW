using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.BD_TW
{
    public class ZapiszFxWozek
    {
        TWDataSetTableAdapters.QueriesTableAdapter db = new TWDataSetTableAdapters.QueriesTableAdapter();

        public string DodajFxWozek(int idAkt, string nazwa, string opis)
        {
            string kom = "";

            db.dodajFx_Wozek(idAkt, nazwa, opis, ref kom);

            return kom;

        }

        public string DodajFxWozekWozek(int idfx, int idw, int v, decimal stop)
        {
            string kom = "";

            db.dodajFx_Wozek_Wozek(idfx, idw, v, stop, ref kom);

            return kom;
        }
    }
}
