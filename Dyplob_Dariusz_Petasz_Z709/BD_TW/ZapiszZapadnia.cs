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
        public string ZapiszPozycja(int id, decimal pozycja, decimal portal, bool r1, bool r2, bool r3, bool s)
        {
            string kom = "";

            db.zapisPozycjaZapadnia(id, (decimal)Math.Round(pozycja,1), (decimal)Math.Round(portal,1),r1,r2,r3,s ,ref kom);

            return kom;

        }
        public string ZapiszFX_Zapadnia(int id, string opis)
        {
            string kom = "";
            db.dodaj_FX_zapadnia(id, opis, ref kom);
            return kom;
        }
        public string ZapiszFX_Zapadnia_Zapadnia(int idzap, int idfx, int v, float stop, bool spr, bool akt)
        {
            string kom = "";
            db.dodaj_FX_zapadnia_zapadnia(idzap, idfx, v, (decimal)Math.Round(stop,1), spr, akt, ref kom);
            return kom;
        }

        public string AktualizujFX_zap_zap(int idzapzap, int v, float stop, bool spr, bool akt)
        {
            string kom = "";
            db.aktualizujFx_zap_zap(idzapzap, v, (decimal)Math.Round(stop, 1), spr, akt, ref kom);
            return kom;
        }

        public string AktualizujFX_zap(int idfx_zap, string nazwa, string opis)
        {
            string kom = "";
            db.AktualizujFX_zap(idfx_zap, nazwa, opis, ref kom);
            return kom;
        }
        
    }
}
