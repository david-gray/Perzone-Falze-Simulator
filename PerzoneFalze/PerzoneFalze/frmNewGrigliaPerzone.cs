using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpo;

namespace PerzoneFalze
{
    public partial class frmNewGrigliaPerzone : DevExpress.XtraEditors.XtraForm
    {
        public frmNewGrigliaPerzone()
        {
            InitializeComponent();
        }

        private void GVPerzoneFalze_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle == DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                e.Appearance.BackColor = Color.Cornsilk;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                Database.Tables.ListaContatti newContatto = new Database.Tables.ListaContatti(uow);

                newContatto.Name = "Tizio";
                newContatto.Surname = "Caio";
                newContatto.BirthDate = DateTime.Now;
                newContatto.DateAdded = DateTime.Now;
                newContatto.DeletedDate = DateTime.Now;
                newContatto.lastUpdate = DateTime.Now;
                newContatto.StateOfMind = true;

                newContatto.Save();
                uow.CommitChanges();
            }

            this.xpViewGenerale.Session.DropIdentityMap();
            this.xpViewGenerale.Reload();
        }
    }
}