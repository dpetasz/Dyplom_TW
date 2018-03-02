using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.BD_TW
{
    public class ZapiszFxWozek : IZapiszWozek
    {
        TWDataSetTableAdapters.QueriesTableAdapter db = new TWDataSetTableAdapters.QueriesTableAdapter();

        public string DodajFx_Wozek(int idAkt, string nazwa, string opis)
        {
            string kom = "";

            db.dodajFx_Wozek(idAkt, nazwa, opis, ref kom);

            return kom;

        }

        public string DodajFx_Wozek_Wozek(int idfx, int idw, int v, float stop)
        {
            string kom = "";

            db.dodajFx_Wozek_Wozek(idfx, idw, v, (decimal)Math.Round(stop, 1), ref kom);

            return kom;
        }
        public string ZapiszPozycja(int id, float pozycja)
        {
            string kom = "";
            db.zapisPozycjaWozek(id, (decimal)Math.Round(pozycja, 1), ref kom);
            return kom;
        }
        public string AktualizujFx_wozek(int idFx_wozek, string nazwa, string opis)
        {
            string kom = "";
            db.AktualizujFX_Wozek(idFx_wozek, nazwa, opis, ref kom);
            return kom;
        }
        public string AktualizujFX_most_most(int idfx_wozekwozek, int v, float stop)
        {
            string kom = "";
            db.aktualizujFx_wozek_wozek(idfx_wozekwozek, v, (decimal)Math.Round(stop, 1), ref kom);
            return kom;
        }
    }
}
