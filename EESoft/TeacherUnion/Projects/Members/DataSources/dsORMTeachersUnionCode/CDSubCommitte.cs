using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace Members.DataSources.TeachersUnion
{

    public partial class CDSubCommitte
    {
        public CDSubCommitte() : base(Session.DefaultSession) { }
        public CDSubCommitte(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
