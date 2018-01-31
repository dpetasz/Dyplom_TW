using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.BD_TW
{
    public class ZapiszAkt :IZapiszAkt
    {
        TWDataSetTableAdapters.QueriesTableAdapter db = new TWDataSetTableAdapters.QueriesTableAdapter();

        public string DodajAkt(int idPrzed, string nazwa, string opis, TimeSpan dlugosc)
        {
            string kom = "";

            db.DodajAkt(idPrzed, nazwa, opis, dlugosc, ref kom);

            return kom;

        }

        public string AktualizujAkt(int idAkt, string nazwa, string opis, TimeSpan dlugosc)
        {
            string kom = "";

            db.AktualizujAkt(idAkt, nazwa, opis, dlugosc,ref kom);

            return kom;
        }
    }
}
