using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.Wozki
{
    abstract class StanWozek
    {
        public abstract void WozekTworz(RysujWozek x);
    }

    class Wozek1 : StanWozek
    {
        public override void WozekTworz(RysujWozek x)
        {
            x.Pozycja = 290;
        }
    }
    class Wozek2 : StanWozek
    {
        public override void WozekTworz(RysujWozek x)
        {
            x.Pozycja = 200;
        }
    }
    class Wozek3 : StanWozek
    {
        public override void WozekTworz(RysujWozek x)
        {
            x.Pozycja = 110;
        }
    }
    class Wozek4 : StanWozek
    {
        public override void WozekTworz(RysujWozek x)
        {
            x.Pozycja = 20;
        }
    }
}
