using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Netsync.Opcode;
using nsLib.Opcode;

namespace Netsync.Managers
{
    public class MethodManager
    {
        #region -   Variables   -
        public static MethodManager DefaultInstance = new MethodManager();
        public Dictionary<OpCodeProcess, MethodInfo> Methods;
        #endregion
        #region -   Functions   -
        public MethodManager()
        {
            Inti();
        }
        private void Inti()
        {
            Methods = new Dictionary<OpCodeProcess, MethodInfo>();
            Assembly asm = Assembly.GetAssembly(typeof(OpcodesHandler));
            foreach (Type typ in asm.GetTypes())
            {
                MethodInfo[] methods = typ.GetMethods();
                for (int i = 0; i < methods.Length; i++)
                {
                    foreach (object Att in methods[i].GetCustomAttributes(true))
                    {
                        if (((Attribute)Att).GetType() == typeof(NetSyncAttributeAttribute))
                            Methods.Add(((NetSyncAttributeAttribute)Att).OpCode, methods[i]);
                    }
                }
            }
            //Logger.Debug(Methods.Count + " OpCode Found");
        }
        #endregion

    }
}
