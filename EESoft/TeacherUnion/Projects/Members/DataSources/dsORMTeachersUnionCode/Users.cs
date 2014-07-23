using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace Members.DataSources.TeachersUnion
{

    public partial class Users
    {
        public Users() : base(Session.DefaultSession) { }
        public Users(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
