using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplob_Dariusz_Petasz_Z709
{
    public interface IZapiszBazaPrzedstawienie
    {
        string ZapiszRezyser(string n, string i);
        string ZapiszKompozytor(string n, string i);
        string ZapiszRodzaj(string n);
        string ZapiszPrzedstawienie();
    }
}
