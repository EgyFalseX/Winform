using System;

namespace GM
{
    [Serializable]
    public class UserSkinSettings
    {
        [NonSerialized]
        public static string StyleSettingsPath = "StyleSettings";

        public string SkinName;

        public static UserSkinSettings LoadSettings(string fileName)
        {
            UserSkinSettings us = null;
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binFormat = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            System.IO.Stream fStream = new System.IO.FileStream(fileName, System.IO.FileMode.Open);
            try { us = binFormat.Deserialize(fStream) as UserSkinSettings; }
            finally { fStream.Close(); }
            return us;
        }
        public static void SaveSettings(UserSkinSettings us)
        {
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binFormat = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            using (System.IO.Stream fStream = new System.IO.FileStream(UserSkinSettings.StyleSettingsPath, System.IO.FileMode.Create, System.IO.FileAccess.Write, System.IO.FileShare.None))
            {
                binFormat.Serialize(fStream, us);
                fStream.Close();
            }
        }
    }
}
