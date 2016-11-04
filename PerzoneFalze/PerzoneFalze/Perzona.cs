using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerzoneFalze
{
    class Perzona
    {
        string name;
        string surname;
        DateTime birthDate;
        DateTime dateAdded;
        DateTime lastUpdate;
        DateTime deletedDate;
        bool stateOfMind;

        public DateTime DeletedDate
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

        public DateTime LastUpdate
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

        public DateTime DateAdded
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

        public DateTime BirthDate
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

        public Perzona()
        {
            name = "Name";
            Surname = "Surname";
            BirthDate = new DateTime(1989, 6, 1);
            DateAdded = new DateTime(2016, 11, 4);
            LastUpdate = new DateTime(2016, 11, 4);
            DeletedDate = new DateTime(1970, 1, 1, 0, 0, 0);
            StateOfMind = true; 
        }
    }
}
