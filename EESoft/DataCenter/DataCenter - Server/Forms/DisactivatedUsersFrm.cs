using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;

namespace DataCenter_Server
{
	public partial class DisactivatedUsersFrm
	{
		public DisactivatedUsersFrm()
		{
			InitializeComponent();
		}
		short Int1;
		string ErrorProvider;
		private void RefreshList()
		{
			BtnActivate.Enabled = false;
			BtnDelete.Enabled = false;
			LBUsers.Items.Clear();
			ErrorProvider = null;
			ErrorProvider = MainModule.FunLib.GetAllUsers(MainModule.AdminID, false);
			if (ErrorProvider == null)
			{
				if (MainModule.FunLib.AllUsers == null)
				{
					MainModule.MsgBox_("لا يوجد مستخدمين معطلين", (short) 90, (short) 23, false, this);
					this.Close();
				}
				else
				{
					for (Int1 = 0; Int1 <= MainModule.FunLib.AllUsers.Length - 1; Int1++)
					{
						LBUsers.Items.Add(MainModule.FunLib.AllUsers[Int1].UserName);
					}
				}
			}
			else
			{
				MainModule.MsgBox_(ErrorProvider, (short) 0, (short) 20, false, this);
				this.Close();
			}
		}
        public void DisactivatedUsersFrm_Load(Object sender, EventArgs e)
        {
            RefreshList();
        }
        public void BtnActivate_Click(Object sender, EventArgs e)
        {
            if (Interaction.MsgBox("هل انت متأكد؟", MsgBoxStyle.YesNo, "تحزير") == MsgBoxResult.Yes)
            {
                if (LBUsers.SelectedIndex != -1)
                {
                    MainModule.FunLib.UserActivation(MainModule.FunLib.AllUsers[LBUsers.SelectedIndex].UsrID, true);
                    RefreshList();
                    MainModule.MsgBox_("تم التفعيـــل", 134, 23, true, this);
                }
            }
        }
        public void LBUsers_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (LBUsers.SelectedIndex != -1)
            {
                BtnActivate.Enabled = true;
                BtnDelete.Enabled = true;
            }
        }
        public void BtnClose_Click(Object sender, EventArgs e)
        {
            Close();
        }
        public void BtnDelete_Click(Object sender, EventArgs e)
        {
            if (Interaction.MsgBox("هل انت متأكد؟", MsgBoxStyle.YesNo, "تحزير") == MsgBoxResult.Yes)
            {
                if (LBUsers.SelectedIndex != -1)
                {
                    ErrorProvider = MainModule.FunLib.DeleteUser(MainModule.FunLib.AllUsers[LBUsers.SelectedIndex].UsrID);
                    switch (ErrorProvider)
                    {
                        case null:
                            //cant delete this user
                            MainModule.MsgBox_("لا يمكن حزف المستخدم", 126, 23, false, this);
                            break;
                        case "1":
                            //User deleted
                            MainModule.MsgBox_("تم حزف المستخدم", (short)133, (short)23, true, this);
                            RefreshList();
                            break;
                        default:
                            //Sql error
                            MainModule.MsgBox_(ErrorProvider, (short)0, (short)20, false, this);
                            break;
                    }
                }
            }
        }
	}
}
