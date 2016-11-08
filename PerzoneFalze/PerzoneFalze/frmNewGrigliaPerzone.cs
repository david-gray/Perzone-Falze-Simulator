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
    }
}