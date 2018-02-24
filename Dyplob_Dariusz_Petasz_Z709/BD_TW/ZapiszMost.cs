using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.BD_TW
{
    public class ZapiszMost: IZapiszMost
    {
        TWDataSetTableAdapters.QueriesTableAdapter db = new TWDataSetTableAdapters.QueriesTableAdapter();
        public string ZapiszPozycja(int id, float pozycja)
        {
            string kom ="";
            db.zapisPozycjaMost(id, (decimal)Math.Round(pozycja, 1), ref kom);
            return kom;
        }
        public string DodajFx_most(int id, string opis)
        {
            string kom = "";
            db.dodajFX_Most(id, opis, ref kom);
            return kom;
        }
        public string DodajFx_most_most(int idmost, int idfx, int v, float stop)
        {
            string kom = "";
            db.dodaj_FX_most_most(idmost, idfx, v, (decimal)Math.Round(stop, 1), ref kom);
            return kom;
        }

        public string AktualizujFx_most(int idFx_most, string nazwa, string opis)
        {
            string kom = "";
            db.AktualizujFX_Most(idFx_most, nazwa, opis, ref kom);
            return kom;
        }
        public string AktualizujFX_most_most(int idfx_mostmost, int v, float stop)
        {
            string kom = "";
            db.aktualizujFx_most_most(idfx_mostmost, v, (decimal)Math.Round(stop, 1),  ref kom);
            return kom;
        }
    }
}
