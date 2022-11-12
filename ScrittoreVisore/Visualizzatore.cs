using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrittoreVisore
{
    internal class Visualizzatore
    {
        //attributi
        private string testo;

        //costruttori

        //metodi
        public string Testo
        {
            set
            {
                testo = value;
            }

            get
            {
                return testo;
            }
        }
        public void AggiungiTesto(string testo)
        {
            Testo += testo;
        }
    }
}
