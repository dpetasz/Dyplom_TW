using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.Wozki
{
    public interface IRysujWozek
    {
        void Wozek(Graphics g,  float x, int y);
        void Zascenie(Graphics g);
        void Scena(Graphics g);
        void Wypelnienie();
    }
}
