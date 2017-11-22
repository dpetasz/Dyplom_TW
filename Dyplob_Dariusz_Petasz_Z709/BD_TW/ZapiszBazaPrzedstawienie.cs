using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709
{
    public class ZapiszBazaPrzedstawienie : IZapiszBazaPrzedstawienie
    {
        TWDataSetTableAdapters.QueriesTableAdapter db = new TWDataSetTableAdapters.QueriesTableAdapter();

        public string ZapiszRezyser(string n, string i)
        {
            string kom = "";
            db.dodajRezyser(n, i, ref kom);
            return kom;
        }
        public string ZapiszKompozytor(string n, string i)
        {
            string kom = "";
            db.dodajKompozytor(n, i, ref kom);
            return kom;
        }
        public string ZapiszRodzaj(string n)
        {
            string kom = "";
            db.dodajRodzaj(n, ref kom);
            return kom;
        }
        public string ZapiszPrzedstawienie(int komp, int rez, int rodz, string nazwa, DateTime data)
        {
            string kom = "";
            db.DodajPrzedstawienie(komp, rez, rodz, nazwa, data, ref kom);

            return kom;
        }
        public string AktualizujPrzedstawienie(int idprzed, int komp, int rez, int rodz, string nazwa, DateTime data, TimeSpan dl, string opis)
        {
            string kom = "";
            db.AktualizujPrzedstawienie(idprzed, komp, rez, rodz, nazwa, data, dl, opis, ref kom);

            return kom;
        }
    }
}
