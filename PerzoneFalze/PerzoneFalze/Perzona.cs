using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerzoneFalze
{
    public class Perzona
    {
        string name;
        string surname;
        DateTime? birthDate;
        DateTime? dateAdded;
        DateTime? lastUpdate;
        DateTime? deletedDate;
        bool stateOfMind;

        public DateTime? DeletedDate
        {
            get
            {
                return deletedDate;
            }

            set
            {
                deletedDate = value;
            }
        }

        public DateTime? LastUpdate
        {
            get
            {
                return lastUpdate;
            }

            set
            {
                lastUpdate = value;
            }
        }

        public DateTime? DateAdded
        {
            get
            {
                return dateAdded;
            }

            set
            {
                dateAdded = value;
            }
        }

        public DateTime? BirthDate
        {
            get
            {
                return birthDate;
            }

            set
            {
                birthDate = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public bool StateOfMind
        {
            get
            {
                return stateOfMind;
            }
            set
            {
                stateOfMind = value;
            }
        }

        /// <summary>
        /// Costruttore con parametri
        /// </summary>
        /// <param name="name">Specifica il nome</param>
        /// <param name="surname">Specifica il cognome</param>
        /// <param name="Birth">Specifica la data di nascita</param>
        public Perzona(string name, string surname, DateTime Birth)
        {
            this.name = name;
            this.surname = surname;
            this.birthDate = Birth;
            this.dateAdded = DateTime.Now;
            this.lastUpdate = DateTime.Now;
            this.deletedDate = null;
        }

        public Perzona()
        {
            // TODO: Complete member initialization
        }

    }
}
