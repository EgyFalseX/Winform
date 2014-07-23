using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace Members.DataSources.TeachersUnion
{

    public partial class TBLMembers
    {
        public TBLMembers() : base(Session.DefaultSession) { }
        public TBLMembers(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
