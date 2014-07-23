using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace Members.DataSources.TeachersUnion
{

    public partial class CDCardtype
    {
        public CDCardtype() : base(Session.DefaultSession) { }
        public CDCardtype(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
