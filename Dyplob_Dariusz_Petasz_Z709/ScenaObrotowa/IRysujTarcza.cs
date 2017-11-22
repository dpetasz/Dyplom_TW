using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709
{
    public interface IRysujTarcza
    {
        void Tarcza(Graphics g);
        void Obrot(Graphics g, float o);
        void Wypelnienie();
        //void PozycjaObrotowka(float x);
    }
    
}
