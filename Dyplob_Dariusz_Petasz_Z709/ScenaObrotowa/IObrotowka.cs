using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.ScenaObrotowa
{
    public interface IObrotowka
    {
        bool GetAktywacja();
        void SetAktywacja(bool Aktywacja);
        bool GetDoPozycji();
        void SetDoPozycji(bool DoPozycji);
        bool GetProgramowa();
        void SetProgramowa(bool Programowa);
        bool GetJoystick();
        void SetJoystick(bool Joystick);
        int GetPredkosc();
        void SetPredkosc(int Predkosc);
        bool GetKierunek();
        void SetKierunek(bool Kierunek);
        float GetPozycja();
        void SetPozycja(float Pozycja);
        float GetPozycjaZadana();
        void SetPozycjaZadana(float PozycjaZadana);
    }
}
