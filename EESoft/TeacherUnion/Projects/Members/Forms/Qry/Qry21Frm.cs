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


namespace Members.Forms.Qry
{
    public partial class Qry21Frm : DevExpress.XtraEditors.XtraForm
    {
        public Qry21Frm()
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

        }
        private void TBLHafzawebFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
            // TODO: This line of code loads data into the 'dsTeachersUnionList.TBLHafzawebList' table. You can move, or remove it, as needed.
            this.tBLHafzawebListTableAdapter.Fill(this.dsTeachersUnionList.TBLHafzawebList);
            //btnPrintExport.Visible = Program.UserInfo.IsAdmin;
        }
        private void LUEHafza_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEHafza.EditValue == null)
                return;
            qry21TableAdapter.FillByhafzaid(dsTeachersUnionQuery.Qry21, Convert.ToDouble(LUEHafza.EditValue));
            gridControlData.Enabled = false;
            pbc.Properties.Maximum = dsTeachersUnionQuery.Qry21.Rows.Count;
            pbc.EditValue = 0;
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                System.Threading.Thread.Sleep(500);
                for (int i = dsTeachersUnionQuery.Qry21.Rows.Count - 1; i >= 0; i--)
                {
                    DataSources.dsTeachersUnionQuery.Qry21Row row = (DataSources.dsTeachersUnionQuery.Qry21Row)dsTeachersUnionQuery.Qry21.Rows[i];
                    if (System.IO.File.Exists(row.imagepath))
                    {
                        gridControlData.Invoke(
                            new Action(() =>
                            {
                                gridViewData.DeleteRow(i);
                                pbc.EditValue = Convert.ToInt32(pbc.EditValue) + 1;
                            })
                            );
                    }
                    pbc.Invoke( new Action(() => { pbc.EditValue = Convert.ToInt32(pbc.EditValue) + 1; }) );
                }
                gridControlData.Invoke(
                    new Action(() =>
                    {
                        gridControlData.Enabled = true;
                        pbc.EditValue = 0;
                    })
                    );
            });
        }
        private void repositoryItemButtonEditEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsTeachersUnionQuery.Qry21Row Row = (DataSources.dsTeachersUnionQuery.Qry21Row)GV.GetFocusedDataRow();

            Members.Forms.Data.TBLHafzawebFrm frm = new Members.Forms.Data.TBLHafzawebFrm();
            frm.LUEHafza.EditValue = Row.hafzaid;
            frm.ShowDialog();
        }

    }
}