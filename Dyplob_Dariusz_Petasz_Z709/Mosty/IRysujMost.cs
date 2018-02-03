using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.Mosty
{
    public interface IRysujMost
    {
        void Wypelnienie();
        void WypelnienieJazda();
        void MostJazda(Graphics g, float x);
        void Obramowanie(Graphics g);
    }
}
