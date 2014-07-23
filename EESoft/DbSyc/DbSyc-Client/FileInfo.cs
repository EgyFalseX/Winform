using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace DbSyc_Client
{
    [Serializable()]    //Set this attribute to all the classes that want to serialize
    public class FileInfo
    {
        public string Filename;
        public string FilePath;
        public FileInfo(string filename, string filepath)
        {
            Filename = filename;
            FilePath = filepath;
        }
        public FileInfo()
        {
        }
    }
}
