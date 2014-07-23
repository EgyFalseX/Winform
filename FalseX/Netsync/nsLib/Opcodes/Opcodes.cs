using System;
using System.Collections.Generic;

namespace nsLib.Opcode
{
    public enum OpCodeProcess : byte
    {
        NoOpcode = 0,
        C_Registration,
        C_Ping,
        C_RequestCheckExistFile,
        C_SendFile,
        C_SendFiles,
        C_ReciveFile,
        C_ReciveFiles,
        C_DeleteFile,
        S_OK,

    }
    public enum msg : byte
    {
        CantCreateFile = 1,

    }

}