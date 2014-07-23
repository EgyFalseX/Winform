using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nsLib.Opcode;

namespace Netsync.Opcode
{
   
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Struct, AllowMultiple = false, Inherited = false)]
    public class NetSyncAttributeAttribute : Attribute
    {
        public OpCodeProcess OpCode;
        public NetSyncAttributeAttribute(OpCodeProcess opcode)
        {
            OpCode = opcode;
        }

    }
}
