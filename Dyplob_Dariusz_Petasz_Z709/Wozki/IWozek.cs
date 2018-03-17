using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplom_Dariusz_Petasz_Z709.Wozki
{
    public interface IWozek
    {
        int GetId();
        void SetId(int Id);
        bool GetKierunek();
        void SetKierunek(bool Kierunek);
        float GetPozycja();
        void SetPozycja(float Pozycja);
        int GetPredkosc();
        void SetPredkosc(int Predkosc);
        float GetPozycjaZadana();
        void SetPozycjaZadana(float PozycjaZadana);
        bool GetAktywacja();
        void SetAktywacja(bool Aktywacja);
        int GetPrzychamowanie();
        void SetPrzychamowanie(int Przychamowanie);
        bool GetProgramowa();
        void SetProgramowa(bool Programowa);
        bool GetJoystick();
        void SetJoystick(bool Joystick);
        bool GetManualna();
        void SetManualna(bool Manualna);
        bool GetDoPozycji();
        void SetDoPozycji(bool DoPozycji);
    }
}
