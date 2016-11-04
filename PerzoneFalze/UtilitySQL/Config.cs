using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace PerzoneFalze.Utilities
{
    /// <summary>
    /// Classe Singleton che contiene le configurazioni
    /// </summary>
    public class Config
    {
        private static Config _istanza;

        private string _connectionString;
        public string ConnectionString { get { return this._connectionString; } }
        
        private SQLiteConnection _connection;
        public SQLiteConnection Connection { get { return this._connection; } }

        private Config()
        {
            this._connectionString = Funzioni.ReadINI("connectionString", "config.ini");
            this._connection = new SQLiteConnection(this._connectionString);
            this._connection.Open();
        }
        public static Config Istanza
        {
            get
            {
                if (_istanza == null)
                {
                    _istanza = new Config();
                }
                return _istanza;
            }
        }
    }
}
