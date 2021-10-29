using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneGit
{
    class CD
    {
        public List<Brano> Brani { set; get; }
        public string Titolo { set; get; }
        public string Autore { set; get; }

        public CD(string titolo, string autore)
        {
            Brani = new List<Brano>();
            Titolo = titolo;
            Autore = autore;
        }

        public CD(string titolo, string autore, List<Brano> lista)
        {
            Brani = lista;
            Titolo = titolo;
            Autore = autore;
        }
        public void AggiungiBrano(Brano b)
        {
            Brani.Add(b);
        }

        public int DurataTot
        {
            get
            {
                int durataTot = 0;

                foreach (Brano b in Brani)
                {
                    durataTot += b.DurataInSecondi;
                }

                return durataTot;
            }
        }

        public override string ToString()
        {
            string stringa = "";
          
            foreach(Brano b in Brani)
            {
                stringa = stringa + " " + b.Titolo;
            }

            return stringa;
        }
    }
}
