using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace DbSyc_Client
{
    public class DataManager
    {
        public static DataManager DefaultInstance = new DataManager();

        public List<FileInfo> FilesInformation = new List<FileInfo>();
        public void Save()
        {
            if (File.Exists("data.bin"))
                File.Delete("data.bin");
            try
            {
                using (Stream stream = File.Open("data.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, FilesInformation);
                }
            }
            catch (IOException ex)
            { System.Windows.Forms.msgDlg.Show(ex.Message); }
        }
        public void Load()
        {
            if (!File.Exists("data.bin"))
            {
                FilesInformation = new List<FileInfo>();
                return;
            }
            try
            {
                using (Stream stream = File.Open("data.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    FilesInformation = (List<FileInfo>)bin.Deserialize(stream);
                }
            }
            catch (IOException ex)
            { System.Windows.Forms.msgDlg.Show(ex.Message); }

        }
    }
}
