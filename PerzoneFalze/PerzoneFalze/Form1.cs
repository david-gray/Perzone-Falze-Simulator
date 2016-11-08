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

namespace PerzoneFalze
{
    public partial class Form1 : Form
    {
        List<string> NamesList;
        List<string> SurnamesList;

        public Form1()
        {
            InitializeComponent();
            List<Perzona> listaPersone = new List<Perzona>();
            if (PopulateNamesList() && PopulateSurnamesList())
            {
                for (int i = 0; i < 10; i++)
                {
                    Random rnd = new Random();
                    int r1 = rnd.Next(NamesList.Count);
                    int r2 = rnd.Next(SurnamesList.Count);
                    Perzona P = new Perzona(NamesList[r1], SurnamesList[r2], GenerateRandomBirthDate());
                    listaPersone.Add(P);
                    Thread.Sleep(100);
                }
            }
            Perzona P1 = new Perzona("Luca", "Giordano", new DateTime(1991, 3, 26));

            
            listaPersone.Add(P1);

            if (!CheckIfDatabaseIsAlreadyCreated())
            {
                CreateDatabase();
            }


            DataTable dt = Utilities.SQL.SelectSQL("SELECT * FROM ListaContatti");

            using (frmNewGrigliaPerzone nuovaFinestraGriglia = new frmNewGrigliaPerzone())
                nuovaFinestraGriglia.ShowDialog();

            //using (frmGrigliaPerzone finestraGriglia = new frmGrigliaPerzone(listaPersone))
            //    finestraGriglia.ShowDialog();
            
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
                    + "DateAdded datetime, lastUpdate datetime, DeletedDate datetime, StateOfMind boolean)";
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

    }
}
