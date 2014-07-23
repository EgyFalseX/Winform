using Microsoft.VisualBasic;
using System;

namespace DataCenter_Server
{
	public partial class EditUsersFrm
	{
		public EditUsersFrm()
		{
			InitializeComponent();
		}
		private string ErrorProvider;
		int Int1;

        public void UsersFrm_Load(Object sender, EventArgs e)
        {
            ErrorProvider = MainModule.FunLib.GetAllUsers(MainModule.AdminID, true);
            ErrorProvider = null;
            if (ErrorProvider == null && MainModule.FunLib.AllUsers != null)
            {
                LBUsers.Items.Clear();
                if (MainModule.FunLib.AllUsers.Length <= 0)
                    return;
                for (Int1 = 0; Int1 <= MainModule.FunLib.AllUsers.Length - 1; Int1++)
                    LBUsers.Items.Add(MainModule.FunLib.AllUsers[Int1].UserName);
            }
            else
            {
                MainModule.MsgBox_(ErrorProvider, (short)0, (short)20, false, this);
                Close();
            }
        }
        public void TxtNewUser_TextChanged(Object sender, EventArgs e)
        {
            if (TxtNewUser.Text.Trim().Length > 0)
                BtnAdd.Enabled = true;
            else
                BtnAdd.Enabled = false;
        }
        public void LBUsers_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (LBUsers.SelectedIndex != -1)
            {
                BtnRemove.Enabled = true;
                BtnReset.Enabled = true;
                TxtUpdate.ReadOnly = false;
                TxtUpdate.Text = (string)LBUsers.SelectedItem;
            }
            else
            {
                BtnRemove.Enabled = false;
                BtnReset.Enabled = false;
                TxtUpdate.Clear();
                TxtUpdate.ReadOnly = true;
            }
        }
        public void TxtUpdate_TextChanged(Object sender, EventArgs e)
        {
            if (TxtUpdate.Text.Trim().Length > 0)
                BtnUpdate.Enabled = true;
            else
                BtnUpdate.Enabled = false;
        }
        public void BtnAdd_Click(Object sender, EventArgs e)
        {
            ErrorProvider = "";
            ErrorProvider = MainModule.FunLib.AddUser(TxtNewUser.Text.Trim());
            if (ErrorProvider != "UserName In Used")
            {
                if (MainModule.FunLib.AllUsers == null)
                {
                    Array.Resize(ref MainModule.FunLib.AllUsers, 1);
                }
                else
                {
                    Array.Resize(ref MainModule.FunLib.AllUsers, MainModule.FunLib.AllUsers.Length + 1);
                }
                MainModule.FunLib.AllUsers[MainModule.FunLib.AllUsers.Length - 1].UsrID = ErrorProvider;
                MainModule.FunLib.AllUsers[MainModule.FunLib.AllUsers.Length - 1].UserName = TxtNewUser.Text.Trim();
                LBUsers.Items.Add(TxtNewUser.Text.Trim());
                MainModule.MsgBox_("تم الاضافه", 88, 23, true, this);
            }
            else
            {
                MainModule.MsgBox_(ErrorProvider, 0, 20, false, this);
            }
        }
        public void BtnUpdate_Click(Object sender, EventArgs e)
        {
            if (Interaction.MsgBox("هل انت متأكد؟", MsgBoxStyle.YesNo, "تحزير") == MsgBoxResult.Yes)
            {
                if (LBUsers.SelectedIndex != -1 && TxtUpdate.Text.Trim().Length > 0)
                {
                    ErrorProvider = null;
                    ErrorProvider = MainModule.FunLib.UpdateUserameOrPassword(MainModule.FunLib.AllUsers[LBUsers.SelectedIndex].UsrID, TxtUpdate.Text.Trim(), true);
                    if (ErrorProvider == null)
                    {
                        MainModule.FunLib.AllUsers[LBUsers.SelectedIndex].UserName = TxtUpdate.Text.Trim();
                        LBUsers.Items[LBUsers.SelectedIndex] = TxtUpdate.Text.Trim();
                        MainModule.MsgBox_("تم التعديل", 77, 23, true, this);
                    }
                    else
                        MainModule.MsgBox_("لم يتم التعديل", 98, 23, false, this);
                }
            }
        }
        public void BtnReset_Click(Object sender, EventArgs e)
        {
            if (Interaction.MsgBox("هل انت متأكد؟", MsgBoxStyle.YesNo, "تحزير") == MsgBoxResult.Yes)
            {
                if (LBUsers.SelectedIndex != -1 && TxtUpdate.Text.Trim().Length > 0)
                {
                    ErrorProvider = null;
                    ErrorProvider = MainModule.FunLib.UpdateUserameOrPassword(MainModule.FunLib.AllUsers[LBUsers.SelectedIndex].UsrID, MainModule.DefaultUserPassword, false);
                    if (ErrorProvider == null)
                    {
                        MainModule.FunLib.AllUsers[LBUsers.SelectedIndex].UserName = TxtUpdate.Text.Trim();
                        MainModule.MsgBox_("تم التعديل", 77, 23, true, this);
                    }
                    else
                        MainModule.MsgBox_("لم يتم التعديل", 98, 23, false, this);
                }
            }
        }
        public void BtnRemove_Click(Object sender, EventArgs e)
        {
            if (Interaction.MsgBox("هل انت متأكد؟", MsgBoxStyle.YesNo, "تحزير") == MsgBoxResult.Yes)
            {
                if (LBUsers.SelectedIndex != -1)
                {
                    ErrorProvider = null;
                    ErrorProvider = (string)MainModule.FunLib.UserActivation(MainModule.FunLib.AllUsers[LBUsers.SelectedIndex].UsrID, false);
                    if (ErrorProvider == null)
                    {
                        UsersFrm_Load(this, e);
                        BtnRemove.Enabled = false;
                        TxtUpdate.ReadOnly = true;
                        BtnUpdate.Enabled = false;
                        MainModule.MsgBox_("تم الحذف", (short)125, (short)23, true, this);
                    }
                    else
                        MainModule.MsgBox_("لم يتم الحذف", (short)111, (short)23, false, this);

                }
            }
        }
	}
}
