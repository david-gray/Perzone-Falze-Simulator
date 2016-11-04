using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerzoneFalze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Perzona P1 = new Perzona();
            MessageBox.Show(P1.Name + " " + P1.Surname + " " + P1.BirthDate.ToString() + " " + P1.DateAdded.ToString() + " " + P1.LastUpdate.ToString() + " " + P1.DeletedDate.ToString() + " " + P1.StateOfMind.ToString());
        }

    }
}
