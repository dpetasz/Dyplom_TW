using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.BD_TW
{
    public class ZapiszZapadnia: IZapiszZapadnia
    {
        TWDataSetTableAdapters.QueriesTableAdapter db = new TWDataSetTableAdapters.QueriesTableAdapter();
        public string ZapiszPozycja(int id, decimal pozycja, decimal portal)
        {
            string kom = "";

            db.zapisPozycjaZapadnia(id, (decimal)Math.Round(pozycja,1), (decimal)Math.Round(portal,1), ref kom);

            return kom;

        }
    }
}
