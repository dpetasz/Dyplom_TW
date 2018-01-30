using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dyplom_Dariusz_Petasz_Z709.ScenaObrotowa
{
    public class JazdaObrotowka: IJazdaObrotowka
    {
        float obrot;
        float Obrot
        {
            get { return obrot; }
            set { obrot = value; }
        }
        string plik = @"C:\GitHub\Dyplom_TW\Dyplob_Dariusz_Petasz_Z709\Resources\Pozycja_Obrotowka.txt";
        public float PozycjaObrotowka()
        {
            try
            {

                FileStream fs = new FileStream(plik, FileMode.Open, FileAccess.ReadWrite);

                StreamReader sr = new StreamReader(fs);
                string txt = sr.ReadToEnd();
                sr.Close();
                fs.Close();
                this.Obrot = float.Parse(txt);
                

            }
            catch { Obrot = 0; }
            return Obrot;

        }
        public void ZapisPozycja(float x)
        {

            FileStream fs = new FileStream(plik, FileMode.Create, FileAccess.ReadWrite);

            try
            {
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(Math.Round(x,2).ToString());
                sw.Close();
                fs.Close();
                
            }
            catch {  }
        }
        public float ruch(bool kierunek, int v)
        {
           
            switch (kierunek)
            {
                case true:
                    {
                        this.Obrot += v * 0.001f;
                        if (Math.Round(Obrot, 1) == 360) Obrot = 0;
                        break;
                    }
                case false:
                    {
                        this.Obrot -= v * 0.001f;
                        if (Math.Round(Obrot, 1) == 0) Obrot = 360;
                        break;
                    }
            }
            return (float)Math.Round(Obrot, 1);

        }
    }
}
