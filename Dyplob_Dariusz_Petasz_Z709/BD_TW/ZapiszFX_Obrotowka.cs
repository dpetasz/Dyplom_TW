using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.BD_TW
{
    public class ZapiszFX_Obrotowka : IZapiszFX_Obrotowka
    {
        TWDataSetTableAdapters.QueriesTableAdapter db = new TWDataSetTableAdapters.QueriesTableAdapter();
        public string DodajFX(int idAkt, string nazwa, int predkosc, bool kierunek, decimal stop, string opis)
        {
            string kom = "";

            db.dodajFx_obrotowka(idAkt, nazwa,predkosc , kierunek, stop ,opis, ref kom);

            return kom;

        }

        public string AktualizujFX(int idFX, int idAkt, string nazwa, int predkosc, bool kierunek, decimal stop, string opis)
        {
            string kom = "";

            db.aktualizujFx_obrotowka(idFX,idAkt, nazwa, predkosc, kierunek, stop, opis, ref kom);

            return kom;

        }
    }
}
