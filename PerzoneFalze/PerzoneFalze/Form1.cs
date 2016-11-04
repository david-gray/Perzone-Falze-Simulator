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

namespace PerzoneFalze
{
    public partial class Form1 : Form
    {
        List<string> NamesList;
        List<string> SurnamesList;

        public Form1()
        {
            InitializeComponent();
            PopulateNamesList();
            PopulateSurnamesList();
            Perzona P1 = new Perzona();
            MessageBox.Show(P1.Name + " " + P1.Surname + " " + P1.BirthDate.ToString() + " " + P1.DateAdded.ToString() + " " + P1.LastUpdate.ToString() + " " + P1.DeletedDate.ToString() + " " + P1.StateOfMind.ToString());

            List<Perzona> listaPersone = new List<Perzona>();
            listaPersone.Add(P1);

            using (frmGrigliaPerzone finestraGriglia = new frmGrigliaPerzone(listaPersone))
                finestraGriglia.ShowDialog();
            
        }

        public bool PopulateNamesList()
        {
            NamesList = new List<string>();
            try
            {
                StreamReader SR1 = new StreamReader(Directory.GetCurrentDirectory() + "\\TextFiles\\Nomi.txt");
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
                StreamReader SR1 = new StreamReader(Directory.GetCurrentDirectory() + "\\TextFiles\\Cognomi.txt");
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

    }
}
