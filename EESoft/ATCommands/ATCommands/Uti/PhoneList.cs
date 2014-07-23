using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATCommands.Uti
{
    class PhoneList
    {
        public PhoneList(string phone, string id, string asase = "", string manth = "")
        {
            Phone = phone;
            ID = id;
            asase_code = asase;
            manth_code = manth;
        }
        public string Phone { get; set; }
        public string ID { get; set; }
        public string asase_code { get; set; }
        public string manth_code { get; set; } 
    }
}
