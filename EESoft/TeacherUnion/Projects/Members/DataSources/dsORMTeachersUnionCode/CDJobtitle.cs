using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace Members.DataSources.TeachersUnion
{

    public partial class CDJobtitle
    {
        public CDJobtitle() : base(Session.DefaultSession) { }
        public CDJobtitle(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
