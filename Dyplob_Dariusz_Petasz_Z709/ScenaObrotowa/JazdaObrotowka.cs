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
        private float o = 0f;
        string plik = @"C:\Users\dpeta\OneDrive\Documents\Visual Studio 2013\Projects\Dyplob_Dariusz_Petasz_Z709\Dyplob_Dariusz_Petasz_Z709\Resources\Pozycja_Obrotowka.txt";
        public float PozycjaObrotowka()
        {
            try
            {

                FileStream fs = new FileStream(plik, FileMode.Open, FileAccess.ReadWrite);

                StreamReader sr = new StreamReader(fs);
                string txt = sr.ReadToEnd();
                sr.Close();
                fs.Close();
                this.o = float.Parse(txt);
                

            }
            catch { o = 0;  }
            return o;

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
                        o += v * 0.0001f;
                        if ((float)Math.Round(o, 0) == 360) o = 0;
                        break;
                    }
                case false:
                    {
                        o -= v * 0.0001f;
                        if ((float)Math.Round(o, 0) == 0) o = 360;
                        break;
                    }
            }
            return (float)Math.Round(o,2);

        }
    }
}
