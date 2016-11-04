using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace PerzoneFalze.Utilities
{
    public static class SQL
    {
        /// <summary>
        /// Metodo che esegue una query
        /// </summary>
        /// <param name="sql">La query da eseguire. Devi gestire tu gli apici ecc..</param>
        /// <returns>Ritorna il numero di righe che sono state modificate</returns>
        public static int ExecuteQuery(string sql)
        {
            int righeModificate = 0;
            SQLiteCommand cmd = new SQLiteCommand(sql, Config.Istanza.Connection);
            righeModificate = cmd.ExecuteNonQuery();
            cmd.Dispose();
            return righeModificate;
        }

        /// <summary>
        /// Esegue una query di select e ritorna un datatable coi dati
        /// </summary>
        /// <param name="sql">Stringa da eseguire. Devi gestire tu gli apici</param>
        /// <returns>Ritorna il DataTable dei valori</returns>
        public static DataTable SelectSQL(string sql)
        {
            DataTable dtValori = new DataTable();

            SQLiteCommand cmd = new SQLiteCommand(sql, Config.Istanza.Connection);
            dtValori.Load(cmd.ExecuteReader());
            cmd.Dispose();

            return dtValori;
        }
    }
}
