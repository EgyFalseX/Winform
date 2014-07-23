using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fellowship
{
    class SQLProvider
    {
        public static string ConnectionString { get; set; }
        public static DataSources.DSFellowship ds = new DataSources.DSFellowship();

        public static bool FillUserPrv()
        {
            DataSources.DSFellowshipTableAdapters.RoleDetialTableAdapter adp = new DataSources.DSFellowshipTableAdapters.RoleDetialTableAdapter();
            try
            {
                adp.FillByUserId(ds.RoleDetial, Program.UserInfo.UserId);
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        public static void GetFormPriv(string FormName, ref bool Selecting, ref bool Inserting, ref bool Updateing, ref bool Deleting)
        {
            Selecting = false; Inserting = false; Updateing = false; Deleting = false;

            if (FormName.Substring(FormName.Length - 3).ToLower() == "frm")
                FormName = FormName.Substring(0, FormName.Length - 3);
            FormName = Program.AppMenuName + FormName;

            foreach (DataSources.DSFellowship.RoleDetialRow row in ds.RoleDetial.Rows)
            {
                if (row.MenuItemName != FormName)
                    continue;

                if (row.Selecting)
                    Selecting = row.Selecting;
                if (row.Inserting)
                    Inserting = row.Inserting;
                if (row.Updateing)
                    Updateing = row.Updateing;
                if (row.Deleting)
                    Deleting = row.Deleting;
            }
        }

        public static bool PrepareBaseRole()
        {
            MainFrm frm = new MainFrm();
            DataSources.DSFellowshipTableAdapters.RoleDetialTableAdapter adp = new DataSources.DSFellowshipTableAdapters.RoleDetialTableAdapter();
            //DataSources.dsRetirementCenterTableAdapters.RoleDetialTableAdapter adp = new DataSources.dsRetirementCenterTableAdapters.RoleDetialTableAdapter();
            try
            {
                foreach (DevExpress.XtraBars.BarItem item in frm.ribbonControl.Items)
                {
                    if (item.Name != string.Empty)
                    {
                        adp.InsertBaseRole(1, item.Name, true, true, true, true);
                        //adp.InsertBaseRole(item.Name);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                //msgDlg.Show(ex.Message);
                Program.ShowMsg(ex.Message, true, null);
                Program.Logger.LogThis(null, "SQlProvider", FXFW.Logger.OpType.fail, null, null, null);
                throw ex;
            }
        }
    }
}
