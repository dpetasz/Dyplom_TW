using Dyplom_Dariusz_Petasz_Z709.ScenaObrotowa;
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
            x.PioroLinia = new Pen(Color.Black);
            x.wypelnienieTrojkat = new SolidBrush(Color.Green);
            x.Pioro1 = new SolidBrush(Color.SkyBlue);
            x.Pioro2 = new SolidBrush(Color.HotPink);
            x.Pioro3 = new SolidBrush(Color.Green);
            x.TextFont = new Font("Century", 12F, FontStyle.Bold);
            x.KolorLiczby = new SolidBrush(Color.FromArgb(10, 10, 10));
            x.Pioro = new Pen(Color.Gray);
        }
    }
    class WypelnienieJazda : StanWypelnienie
    {
        public override void Wypelnienie(RysujTarcza x)
        {
            x.PioroLinia = new Pen(Color.Black);
            x.wypelnienieTrojkat = new SolidBrush(Color.Red);
            x.Pioro1 = new SolidBrush(Color.Olive);
            x.Pioro2 = new SolidBrush(Color.HotPink);
            x.Pioro3 = new SolidBrush(Color.Green);
            x.TextFont = new Font("Century", 12F, FontStyle.Bold);
            x.KolorLiczby = new SolidBrush(Color.FromArgb(10, 10, 10));
            x.Pioro = new Pen(Color.Gray);
        }
    }
}
