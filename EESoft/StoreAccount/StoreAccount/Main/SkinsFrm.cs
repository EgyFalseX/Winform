using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Runtime.Serialization.Formatters.Binary;
using DevExpress.LookAndFeel;

namespace StoreAccount
{
    public partial class SkinsFrm : DevExpress.XtraEditors.XtraForm
    {
       
        #region -   Variables   -
             
        #endregion
        #region -   Functions   -
        public SkinsFrm()
        {
            InitializeComponent();
            UserLookAndFeel.Default.StyleChanged += Default_StyleChanged;
        }
        private static void SaveSettings(UserSettings us)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (System.IO.Stream fStream = new System.IO.FileStream(MCls.StyleSettingsPath, System.IO.FileMode.Create, System.IO.FileAccess.Write, System.IO.FileShare.None))
            {
                binFormat.Serialize(fStream, us);
                fStream.Close();
            }
        }
        #endregion
        #region - Event Handlers -
        private void SkinsFrm_Load(object sender, EventArgs e)
        {
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(galleryControlSkins, true);
        }
        private void Default_StyleChanged(object sender, EventArgs e)
        {
            UserSettings us = new UserSettings { SkinName = UserLookAndFeel.Default.ActiveSkinName };
            SaveSettings(us);
        }
        #endregion         #region -   Variables   -
   
    }
}