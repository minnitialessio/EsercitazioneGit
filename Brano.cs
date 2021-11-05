using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneGit
{
    class Brano
    {
        private string _titolo;
        private string _autore;
        private int _durataInSecondi;

        #region PROPRIETA

        public string Titolo
        {
            get
            {
                return _titolo;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("errore nell'inserimento del titolo del brano ");
                }
                _titolo = value;
            }
        }
        public string Autore
        {
            get
            {
                return _autore;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("errore nell'inserimento del nome del autore ");
                }
                _autore = value;
            }
        }
        public int DurataInSecondi
        {
            get
            {
                return _durataInSecondi;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("errore nell'inserimento della durata del brano  ");

                }
            }
        }
        #endregion

        public Brano(string titolo,string autore,int durata)
        {
            Titolo = titolo;
            Autore = autore;
            DurataInSecondi = durata;
        }
        public bool ShortSong(string s)
        {
            bool song = false;
            if (DurataInSecondi>int.Parse(s))
            {
                song = true;
            }
            return song;
            
        }
        public override string ToString()
        {
            return  "titolo: "+Titolo+" autore: "+Autore+" durata: "+DurataInSecondi;
        }


    
    }
}
