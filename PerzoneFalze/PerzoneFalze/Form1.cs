using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Data.SQLite;
using System.Reflection;

namespace PerzoneFalze
{
    public partial class Form1 : Form
    {
        List<string> NamesList;
        List<string> SurnamesList;

        List<Perzona> listaPersone;

        DataTable PerzoneTable;

        int ToleranceRate = 90;

        public Form1()
        {
            InitializeComponent();

            if (PopulateNamesList() && PopulateSurnamesList())
            {
                if (!CheckIfDatabaseIsAlreadyCreated())
                {
                    if (CreateDatabase())
                    {
                        AddFIrstTimeContacts();
                        PerzoneTable = Utilities.SQL.SelectSQL("SELECT * FROM ListaContatti");
                        FromDatatableToClass(PerzoneTable);
                        using (frmNewGrigliaPerzone finestraGriglia = new frmNewGrigliaPerzone())
                            finestraGriglia.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Can't create database. Please check your console output!");
                    }
                }
                else
                {
                    PerzoneTable = Utilities.SQL.SelectSQL("SELECT * FROM ListaContatti");
                    FromDatatableToClass(PerzoneTable);
                    using (frmNewGrigliaPerzone finestraGriglia = new frmNewGrigliaPerzone())
                        finestraGriglia.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Something went wrong with your text files. Please check them!");
            }
        }

        private void AddFIrstTimeContacts()
        {
            SQLiteConnection ConnectionToDb = new SQLiteConnection("Data Source=" + Directory.GetCurrentDirectory() + "\\PerzoneFalze.sqlite;Version=3;");
            try
            {
                ConnectionToDb.Open();
                string AddPerzona = "INSERT INTO [ListaContatti] ([Name], [Surname], [BirthDate], [DateAdded], [LastUpdate], [DeletedDate], [StateOfMind]) VALUES (@name, @surname, @birthdate, @dateadded, @lastupdate, @deleteddate, 1);";

                for (int i = 0; i < 10; i++)
                {
                    Random rnd = new Random();
                    int r1 = rnd.Next(NamesList.Count);
                    int r2 = rnd.Next(SurnamesList.Count);
                    SQLiteCommand QueryToDb = new SQLiteCommand(AddPerzona, ConnectionToDb);
                    QueryToDb.Parameters.Add("@name", DbType.String);
                    QueryToDb.Parameters.Add("@surname", DbType.String);
                    QueryToDb.Parameters.Add("@birthdate", DbType.DateTime);
                    QueryToDb.Parameters.Add("@dateadded", DbType.DateTime);
                    QueryToDb.Parameters.Add("@lastupdate", DbType.DateTime);
                    QueryToDb.Parameters.Add("@deleteddate", DbType.DateTime);
                    QueryToDb.Parameters["@name"].Value = NamesList[r1];
                    QueryToDb.Parameters["@surname"].Value = SurnamesList[r1];
                    QueryToDb.Parameters["@birthdate"].Value = GenerateRandomBirthDate();
                    QueryToDb.Parameters["@dateadded"].Value = DateTime.Now;
                    QueryToDb.Parameters["@lastupdate"].Value = DateTime.Now;
                    QueryToDb.Parameters["@deleteddate"].Value = new DateTime(1970, 1, 1);
                    QueryToDb.ExecuteNonQuery();
                    Thread.Sleep(100);
                }

                ConnectionToDb.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("AddFIrstTimeContacts() Exception: " + ex.Message);
            }
        }

        public bool PopulateNamesList()
        {
            NamesList = new List<string>();

            try
            {
                StreamReader SR1 = new StreamReader(Directory.GetCurrentDirectory() + "\\TextFiles\\Nomi.txt", Encoding.Unicode);
                while (!SR1.EndOfStream)
                {
                    NamesList.Add(SR1.ReadLine());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("PopulateNamesList() Exception: " + ex.Message);
                return false;
            }

            return true; 
        }

        public bool PopulateSurnamesList()
        {
            SurnamesList = new List<string>();

            try
            {
                StreamReader SR1 = new StreamReader(Directory.GetCurrentDirectory() + "\\TextFiles\\Cognomi.txt", Encoding.Unicode);
                while (!SR1.EndOfStream)
                {
                    SurnamesList.Add(SR1.ReadLine());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("PopulateSurnamesList() Exception: " + ex.Message);
                return false;
            }

            return true;
        }

        public DateTime GenerateRandomBirthDate()
        {
            Random r = new Random();
            DateTime BirthDateLowerLimit = new DateTime(1956, 1, 1);
            DateTime BirthdateUpperLimit = new DateTime(2001, 1, 1);
            int RandomDateTime_Range = (BirthdateUpperLimit - BirthDateLowerLimit).Days;
            return BirthDateLowerLimit.AddDays(r.Next(RandomDateTime_Range));
        }

        public bool CreateDatabase()
        {
            try
            {
                SQLiteConnection.CreateFile(Directory.GetCurrentDirectory() + "\\PerzoneFalze.sqlite");
                SQLiteConnection ConnectionToDb = new SQLiteConnection("Data Source=" + Directory.GetCurrentDirectory() + "\\PerzoneFalze.sqlite;Version=3;");
                ConnectionToDb.Open();
                string CreateTable_ListaContatti = "create table ListaContatti (PerzonaID INTEGER PRIMARY KEY   AUTOINCREMENT, "
                    + "Name varchar(20), Surname varchar(20), BirthDate datetime, "
                    + "DateAdded datetime, LastUpdate datetime, DeletedDate datetime NULL, StateOfMind boolean)";
                SQLiteCommand CreateTableCommand = new SQLiteCommand(CreateTable_ListaContatti, ConnectionToDb);
                CreateTableCommand.ExecuteNonQuery();
                ConnectionToDb.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("CreateDatabase() Exception: " + ex.Message);
                return false;
            }
        }

        public bool CheckIfDatabaseIsAlreadyCreated()
        {
            return File.Exists(Directory.GetCurrentDirectory() + "\\PerzoneFalze.sqlite");
        }

        public void JudgePeople()
        {
            foreach (Perzona P in listaPersone)
            {
                JudgePerzona(P);
            }
            PerformCutting();

        }

        private void PerformCutting()
        {
            /*
             * Qui verrà eseguita la tagliola delle perzone false, espulse dalla Lista Contatti
             */
        }

        public void JudgePerzona(Perzona P)
        {
            P.StateOfMind = GetPerzonaNewState();
            P.LastUpdate = DateTime.Now;
        }

        public bool GetPerzonaNewState()
        {
            Random rnd = new Random();
            int Probability = rnd.Next(100);
            return (Probability > (100 - ToleranceRate));
        }

        public void AddPerzoneInstances()
        {
            //foreach (DataRow r in PerzoneTable.Rows)
            //{
            //    Perzona P = new Perzona(r.ItemArray.GetValue(0), r.ItemArray.GetValue(1), r.ItemArray.GetValue(2), r.ItemArray.GetValue(3), r.ItemArray.GetValue(4), r.ItemArray.GetValue(5), r.ItemArray.GetValue(6),
            //        r.ItemArray.GetValue(7);
            //}
        }

        public void FromDatatableToClass(DataTable dt)
        {
            listaPersone = dt.AsEnumerable().Select(row =>
            new Perzona
            {
                PerzonaID = row.Field<Int64>("PerzonaID"),
                Name = row.Field<string>("Name"),
                Surname = row.Field<string>("Surname"),
                BirthDate = row.Field<DateTime>("BirthDate"),
                DateAdded = row.Field<DateTime>("DateAdded"),
                LastUpdate = row.Field<DateTime>("LastUpdate"),
                DeletedDate = row.Field<DateTime>("DeletedDate"),
                StateOfMind = row.Field<bool>("StateOfMind")
            }).ToList();
                }
    }

}
