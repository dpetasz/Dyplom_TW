using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplob_Dariusz_Petasz_Z709
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
        public string ZapiszPrzedstawienie()
        {
            string kom = "";


            return kom;
        }
    }
}
