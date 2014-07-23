using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Members.Misc
{
    class Types
    {
        public struct UserInfo
        {
            public string UserName;
            public int UserId;
            public List<int> UserRoles;
            public bool IsAdmin;
            public string RealName;

        }
    }
}
