﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.ScenaObrotowa
{
    public interface IJazdaObrotowka
    {
        float PozycjaObrotowka();
        void ZapisPozycja(float x);
        float ruch(bool kierunek, int v);
        float joystick(int v, float pozycja);
        float doPozycji(int v, bool kierunek, float pozycja);
    }
}
