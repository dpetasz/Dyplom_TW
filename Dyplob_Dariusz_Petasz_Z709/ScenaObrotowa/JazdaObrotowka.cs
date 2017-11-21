using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyplob_Dariusz_Petasz_Z709.ScenaObrotowa
{
    public class JazdaObrotowka: IJazdaObrotowka
    {
        private float o = 0;
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
            catch { o = 0f;  }
            return o;

        }
        public void ZapisPozycja(float x)
        {
            FileStream fs = new FileStream(plik, FileMode.Create, FileAccess.ReadWrite);

            try
            {
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(x.ToString());
                sw.Close();
                fs.Close();
                
            }
            catch {  }
        }
    }
}
