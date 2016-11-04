using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PerzoneFalze.Utilities
{
    public class Funzioni
    {
        /// <summary>
        /// Funzione che legge nel file di configurazione il valore della chiave specificato
        /// Solleva un eccezione qualora qualcosa vada storto
        /// </summary>
        /// <param name="chiave">Chiave da cercare</param>
        /// <param name="pathIni">Percorso del file INI</param>
        /// <returns>Ritorna stringa vuota nel caso che non abbia trovato nulla</returns>
        public static string ReadINI(string chiave, string pathIni)
        {
            string valore = string.Empty;
            StreamReader flusso = new StreamReader(pathIni);
            while (!flusso.EndOfStream)
            {
                string riga = flusso.ReadLine();
                if (riga.Contains("="))
                {
                    string[] pezzi = riga.Split('=');
                    if (pezzi[0] == chiave)
                    {
                        valore = pezzi[1];
                        break;
                    }
                }
            }
            return valore;
        }
    }
}
