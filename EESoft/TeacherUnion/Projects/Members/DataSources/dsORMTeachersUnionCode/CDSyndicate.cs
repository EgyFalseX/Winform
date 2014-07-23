using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace Members.DataSources.TeachersUnion
{

    public partial class CDSyndicate
    {
        public CDSyndicate() : base(Session.DefaultSession) { }
        public CDSyndicate(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
