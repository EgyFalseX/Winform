using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;


namespace Members.Forms.Data
{
    public partial class TBLHafzawebNoTarhelFrm : DevExpress.XtraEditors.XtraForm
    {
        public TBLHafzawebNoTarhelFrm()
        {
            InitializeComponent();
        }
        private void ActivePriv()
        {
            return;//ActivePrivReady
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            SQLProvider.GetFormPriv(this.Name, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlData.Visible = Selecting;
            LUEHafza.Visible = Selecting;


            beesalno.Properties.Buttons[0].Visible = Updateing;
            repositoryItemButtonEditEdit.Buttons[0].Visible = Updateing;
        }
        private void LoadData()
        {
            // TODO: This line of code loads data into the 'dsTeachersUnionList.CDQualtype' table. You can move, or remove it, as needed.
            this.cDQualtypeTableAdapter.Fill(this.dsTeachersUnionList.CDQualtype);
            // TODO: This line of code loads data into the 'dsTeachersUnionList.CDSubCommitte' table. You can move, or remove it, as needed.
            this.cDSubCommitteTableAdapter.Fill(this.dsTeachersUnionList.CDSubCommitte);
            // TODO: This line of code loads data into the 'dsTeachersUnionList.CDSyndicate' table. You can move, or remove it, as needed.
            this.cDSyndicateTableAdapter.Fill(this.dsTeachersUnionList.CDSyndicate);
            // TODO: This line of code loads data into the 'dsTeachersUnionList.TBLHafzawebList' table. You can move, or remove it, as needed.
            this.tBLHafzawebListTableAdapter.Fill(this.dsTeachersUnionList.TBLHafzawebList);
        }
        private void TBLHafzawebFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
            LoadData();
        }
        private void LUEHafza_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEHafza.EditValue == null)
                return;
            tblMemberWebTableAdapter.FillByhafzaid(dsTeachersUnionList.TBLMemberWeb,Convert.ToDouble(LUEHafza.EditValue)); 
        }
        private void repositoryItemButtonEditEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsTeachersUnion.TBLMemberWebRow Row = (DataSources.dsTeachersUnion.TBLMemberWebRow)GV.GetFocusedDataRow();

            TBLHafzawebWFrm frm = new TBLHafzawebWFrm(Row);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {

                    tblMemberWebTableAdapter.Update(Row);
                    dsTeachersUnionList.TBLMemberWeb.AcceptChanges();
                    LUEHafza_EditValueChanged(LUEHafza.EditValue, new EventArgs());
                    Program.ShowMsg("تم الحفظ", false, this);
                    Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
                }
                catch (Exception ex)
                {
                    Program.ShowMsg(Misc.Misc.ExceptionMessage(ex), true, this);
                    Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
                }
               
            }
            else
            {
                dsTeachersUnionList.TBLMemberWeb.RejectChanges();
            }
        }
        private void beesalno_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (LUEHafza.EditValue == null)
                return;
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                int esalno = Convert.ToInt32(beesalno.EditValue);
                DataSources.dsTeachersUnion.TBLHafzawebDataTable tbl = (DataSources.dsTeachersUnion.TBLHafzawebDataTable)gridControlData.DataSource;
                DataSources.dsTeachersUnionTableAdapters.TBLMemberWebTableAdapter adp = new DataSources.dsTeachersUnionTableAdapters.TBLMemberWebTableAdapter();
                foreach (DataSources.dsTeachersUnion.TBLHafzawebRow row in tbl.Rows)
                {
                    if (row.IsesalnoNull())
                    {
                        adp.UpdateQueryesalnoForMember(esalno, row.MemberId);
                    }
                }
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (Exception ex)
            {
                Program.ShowMsg(Misc.Misc.ExceptionMessage(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
        }

    }
}