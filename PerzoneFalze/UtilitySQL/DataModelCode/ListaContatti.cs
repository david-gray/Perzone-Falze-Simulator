using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace PerzoneFalze.Database.Tables
{

    public partial class ListaContatti
    {
        public ListaContatti(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
