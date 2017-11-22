using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709
{
    abstract class StanWypelnienie
    {
        public abstract void Wypelnienie(RysujTarcza x);
    }
    class Wypelnienie1 : StanWypelnienie
    {
        public override void Wypelnienie(RysujTarcza x)
        {
            x.pioroLinia = new Pen(Color.Black);
            x.wypelnienieTrojkat = new SolidBrush(Color.Green);
            x.Pioro1 = new SolidBrush(Color.CornflowerBlue);
            x.Pioro2 = new SolidBrush(Color.HotPink);
            x.Pioro3 = new SolidBrush(Color.Green);
            x.textFont = new Font("Century", 12F, FontStyle.Bold);
            x.KolorLiczby = new SolidBrush(Color.FromArgb(10, 10, 10));
            x.pioro = new Pen(Color.Gray);
        }
    }
}
