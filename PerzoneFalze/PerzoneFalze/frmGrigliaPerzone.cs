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
    public partial class frmGrigliaPerzone : Form
    {
        bool isActive;

        List<Perzona> _listaPersone;
        public frmGrigliaPerzone(List<Perzona> ListaPersone)
        {
            InitializeComponent();

            this.isActive = false;

            this._listaPersone = ListaPersone;
            this.bindingSourcePerzone.DataSource = this._listaPersone;
        }

        private void frmGrigliaPerzone_Shown(object sender, EventArgs e)
        {
            this.isActive = true;
        }

        private void DGWPerzone_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (this.isActive)
            {
                if (e.ColumnIndex == this.colStateOfMind.Index)
                {
                    DataGridView griglia = sender as DataGridView;
                    Perzona currentPerz = griglia.CurrentRow.DataBoundItem as Perzona;
                    if (currentPerz.StateOfMind)
                        MessageBox.Show("E' UNA PERZONA FALZA!");
                }
            }
        }

        private void bindingSourcePerzone_AddingNew(object sender, AddingNewEventArgs e)
        {
            Utilities.SQL.ExecuteQuery("INSERT INTO ListaContatti(Name,Surname,Birthdate,DateAdded,lastUpdate,DeletedDate) VALUES('','','2016-11-04','2016-11-04','2016-11-04',True)");
        }
    }
}
