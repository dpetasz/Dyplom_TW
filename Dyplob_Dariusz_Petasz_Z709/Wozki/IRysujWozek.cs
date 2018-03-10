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
        //void Wozek(Graphics g,  float x, int y);
        void WozekJazda(Graphics g, float x);
        void Wypelnienie();
        void WypelnienieJazda();
        string GetNazwa();
        void SetNazwa(string Nazwa);
        Pen GetPioro();
        SolidBrush GetPioro3();
        SolidBrush GetPioro1();
        Font GetTextFont();
        SolidBrush GetKolorLiczby();
    }
}
