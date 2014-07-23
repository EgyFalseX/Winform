using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nsLib.Utilities
{
    public static class Buffers
    {
        public static int BufferSize = 4096;
        public static byte[] GetBuffer()
        {
            return new byte[BufferSize];
        }
        public static byte[] GetBuffer(int size)
        {
            return new byte[size];
        }
    }
}
