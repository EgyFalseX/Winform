using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace Members.DataSources.TeachersUnion
{

    public partial class TBLPrintCard
    {
        public TBLPrintCard() : base(Session.DefaultSession) { }
        public TBLPrintCard(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
