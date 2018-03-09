using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.Zapadnie
{
    public interface IRysujZapadnia
    {
        void ZapadniaJazda(Graphics g, float zapadnia, float portal);
        void Obramowanie(Graphics g);
    }
}
