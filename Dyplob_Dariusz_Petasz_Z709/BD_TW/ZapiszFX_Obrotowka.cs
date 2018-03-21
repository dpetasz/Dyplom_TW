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
        public string DodajFX(int idAkt, string nazwa, int predkosc, bool kierunek, float stop, string opis)
        {
            string kom = "";

            db.dodajFx_obrotowka(idAkt, nazwa,predkosc , kierunek, (decimal)Math.Round(stop, 2) ,opis, ref kom);

            return kom;

        }

        public string AktualizujFX(int idFX,  string nazwa, int predkosc, bool kierunek, float stop, string opis)
        {
            string kom = "";

            db.aktualizujFx_obrotowka(idFX,  nazwa, predkosc, kierunek, (decimal)Math.Round(stop, 2), opis, ref kom);

            return kom;

        }
        public string ZapiszPozycja(int id, float pozycja)
        {
            string kom = "";
            db.zapisz_Pozycja_Obrotowka(id, (decimal)Math.Round(pozycja, 2), ref kom);
            return kom;
        }
    }
}
