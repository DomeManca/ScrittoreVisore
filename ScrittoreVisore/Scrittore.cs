using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrittoreVisore
{
    public class Scrittore
    {
        //attributi
        private string nome;
        private int stile;
        private string colore;
        private string testo;
        private Visualizzatore visualizzatore;

        //costruttori
        public Scrittore(Visualizzatore visualizzatore0)
        {
            visualizzatore = visualizzatore0;
        }

        //metodi
        public string Nome
        {
            set
            {
                nome = value;
            }

            get
            {
                return nome;
            }
        }

        public int Stile
        {
            set
            {
                stile = value;
            }

            get
            {
                return stile;
            }
        }

        public string Colore
        {
            set
            {
                colore = value;
            }

            get
            {
                return colore;
            }
        }

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

        public Visualizzatore visualizzatore0
        {
            set
            {
                visualizzatore0 = value;
            }

            get
            {
                return visualizzatore0;
            }
        }
    }
}
