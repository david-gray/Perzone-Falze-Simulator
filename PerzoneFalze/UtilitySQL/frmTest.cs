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

namespace PerzoneFalze.Utilities
{
    public partial class frmTest : DevExpress.XtraEditors.XtraForm
    {
        public frmTest()
        {
            InitializeComponent();
            this.LancettaOre.Value = DateTime.Now.Hour + (float)((Convert.ToDouble(DateTime.Now.Minute) * 100) / 6000);
            this.LancettaMinuti.Value = (float)Convert.ToDouble(DateTime.Now.Minute) / 5;
            this.LancettaSecondi.Value = (float)Convert.ToDouble(DateTime.Now.Second) / 5;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.LancettaOre.Value = DateTime.Now.Hour + (float)((Convert.ToDouble(DateTime.Now.Minute) * 100) / 6000);
            this.LancettaMinuti.Value = (float)Convert.ToDouble(DateTime.Now.Minute) / 5;
            this.LancettaSecondi.Value = (float)Convert.ToDouble(DateTime.Now.Second) / 5;
        }
    }
}