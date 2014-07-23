using System;
using System.Collections.Generic;

namespace DbSyc_Client
{
    public enum OpCodeProcess : byte
    {
        NoOpcode = 0,
        C_Registration,
        C_Ping,
        C_RequestCheckExistFile,
        C_SendFile,
        C_ReciveFile,
        C_DeleteFile,
        S_OK,
        S_Error,
    }
    public enum msg : byte
    {
        CantCreateFile = 1,

    }

}