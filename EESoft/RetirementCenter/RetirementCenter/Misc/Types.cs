using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RetirementCenter.Misc
{
    class Types
    {
        public struct UserInfo
        {
            public string UserName;
            public int UserId;
            public bool IsAdmin;
            public string RealName;
            public List<int> UserRoles;
            public List<int> Syndicates;

        }
        public enum TBLMashatLog : byte
        {
            EditName= 1,
            Editsarfnumber,
            EditSyndicateId,
            EditSubCommitteId,
            Delete
        }
        public enum CDsarfType : byte
        {
            A3da2 = 1,
            Armala,
            Abn_Abna,
            Abnaa,
            Armala_Abnaa
        }
        public enum CDMashHala : byte
        {
            A3da2 = 1,
            Warasa
        }
        public enum CDWarasaType : byte
        {
            Armala = 1,
            Abn,
            Abna
        }
        public enum SarfTypeedadId : int
        {
            Unknown_1 = 1,
            Unknown_2 = 2,
            astsnaa_3 = 3
        }
        public enum DeffType : int
        {
            Changes = 1,
            NotFound = 2,
        }
    }
}
