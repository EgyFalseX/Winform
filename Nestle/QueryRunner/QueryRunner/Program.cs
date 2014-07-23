using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace QueryRunner
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrm());
        }
        public static void WriteFile(Macro Obj, string FilePath)
        {
            try
            {
                Stream stream = File.Open(FilePath, FileMode.Create);
                BinaryFormatter bformatter = new BinaryFormatter();
                bformatter.Serialize(stream, Obj);
                stream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void ReadFile(ref Macro Obj, string FilePath)
        {
            try
            {
                Stream stream = File.Open(FilePath, FileMode.Open);
                BinaryFormatter bformatter = new BinaryFormatter();
                Obj = (Macro)bformatter.Deserialize(stream);
                stream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Obj = new Macro();
            }
        }

    }
}
