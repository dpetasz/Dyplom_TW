using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.Wozki
{
    abstract class StanWypWozki
    {
        public abstract void Wypelnienie(Wozek x);
    }
    class Wypelnienie1 : StanWypWozki
    {
        public override void Wypelnienie(Wozek x)
        {
            x.PioroLinia = new Pen(Color.Black);
            
            x.Pioro1 = new SolidBrush(Color.SkyBlue);
            x.Pioro2 = new SolidBrush(Color.HotPink);
            x.Pioro3 = new SolidBrush(Color.Green);
            x.TextFont = new Font("Century", 18F, FontStyle.Bold);
            x.KolorLiczby = new SolidBrush(Color.FromArgb(10, 10, 10));
            x.Pioro = new Pen(Color.Gray);
        }
    }
    class WypelnienieJazdaWozek : StanWypWozki
    {
        public override void Wypelnienie(Wozek x)
        {
            x.PioroLinia = new Pen(Color.Black);

            x.Pioro1 = new SolidBrush(Color.Olive);
            x.Pioro2 = new SolidBrush(Color.HotPink);
            x.Pioro3 = new SolidBrush(Color.Green);
            x.TextFont = new Font("Century", 18F, FontStyle.Bold);
            x.KolorLiczby = new SolidBrush(Color.FromArgb(10, 10, 10));
            x.Pioro = new Pen(Color.Gray);
        }
    }
}
