using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709
{
    public interface IZapiszBazaPrzedstawienie
    {
        string ZapiszRezyser(string n, string i);
        string ZapiszKompozytor(string n, string i);
        string ZapiszRodzaj(string n);
        string ZapiszPrzedstawienie(int komp, int rez, int rodz, string nazwa, DateTime data);
        string AktualizujPrzedstawienie(int idprzed, int komp, int rez, int rodz, string nazwa, DateTime data, string dl, string opis);
    }
}
