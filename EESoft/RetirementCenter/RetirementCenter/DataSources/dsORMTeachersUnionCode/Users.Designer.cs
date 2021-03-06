//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace Members.DataSources.TeachersUnion
{

    public partial class Users : XPLiteObject
    {
        int fUserID;
        [Key]
        public int UserID
        {
            get { return fUserID; }
            set { SetPropertyValue<int>("UserID", ref fUserID, value); }
        }
        string fUserName;
        [Size(50)]
        public string UserName
        {
            get { return fUserName; }
            set { SetPropertyValue<string>("UserName", ref fUserName, value); }
        }
        string fUserPass;
        [Size(50)]
        public string UserPass
        {
            get { return fUserPass; }
            set { SetPropertyValue<string>("UserPass", ref fUserPass, value); }
        }
        bool fIsActive;
        public bool IsActive
        {
            get { return fIsActive; }
            set { SetPropertyValue<bool>("IsActive", ref fIsActive, value); }
        }
        DateTime fLastActivityDate;
        public DateTime LastActivityDate
        {
            get { return fLastActivityDate; }
            set { SetPropertyValue<DateTime>("LastActivityDate", ref fLastActivityDate, value); }
        }
        [Association(@"TBLMembersReferencesUsers", typeof(TBLMembers))]
        public XPCollection<TBLMembers> TBLMembersCollection { get { return GetCollection<TBLMembers>("TBLMembersCollection"); } }
        [Association(@"TBLPrintCardReferencesUsers", typeof(TBLPrintCard))]
        public XPCollection<TBLPrintCard> TBLPrintCards { get { return GetCollection<TBLPrintCard>("TBLPrintCards"); } }
        [Association(@"TBLReplyPrintReferencesUsers", typeof(TBLReplyPrint))]
        public XPCollection<TBLReplyPrint> TBLReplyPrints { get { return GetCollection<TBLReplyPrint>("TBLReplyPrints"); } }
    }

}
