using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace PerzoneFalze
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            DevExpress.Skins.SkinManager.EnableMdiFormSkins();

            XpoDefault.DataLayer = XpoDefault.GetDataLayer(@"XpoProvider=SQLite;Data Source=" + Application.StartupPath + "\\PerzoneFalze.sqlite", AutoCreateOption.SchemaAlreadyExists);
            XpoDefault.Session = null;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
