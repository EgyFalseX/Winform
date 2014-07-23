using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.Windows.Forms;

namespace Members
{
    public partial class XRep02 : DevExpress.XtraReports.UI.XtraReport
    {
        ParameterInfo[] PramInfo = null;
        public XRep02()
        {
            InitializeComponent();
        }
        private void LoadDataSource(object SyndicateId, object[] salno, object start = null, object end = null)
        {
            DataTable dt = SQLProvider.SelectRep02(SyndicateId, salno, start, end);
            DataSource = dt;
            xtcMemberShipNumber.DataBindings.Add("Text", this.DataSource, "KideNumber");
            xtcMemberName.DataBindings.Add("Text", this.DataSource, "MemberName");
            xrlTotal.Text = dt.Rows.Count.ToString();
        }
        private void XRep02_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            PramInfo = e.ParametersInformation;

            foreach (ParameterInfo info in e.ParametersInformation)
            {
                if (info.Parameter.Name == "pramSyndicateId")
                {

                    GridLookUpEdit GLUE = new GridLookUpEdit();
                    GLUE.Properties.DataSource = SQLProvider.SelectCDSyndicate();
                    GLUE.Properties.DisplayMember = "Syndicate";
                    GLUE.Properties.ValueMember = "SyndicateId";

                    //DevExpress.XtraGrid.Columns.GridColumn col = new DevExpress.XtraGrid.Columns.GridColumn();
                    //col.FieldName = "Syndicate";
                    //col.Caption = "الاسم";
                    //col.BestFit();
                    //GLUE.Properties.View.Columns.Add(col);

                    GLUE.LostFocus += GLUE_LostFocus;
                    GLUE.Properties.NullText = string.Empty;
                    GLUE.Properties.TextEditStyle = TextEditStyles.Standard;
                    //LUE.Properties.NullText = "<اختر فرعيه>";
                    info.Editor = GLUE;
                    info.Parameter.Value = DBNull.Value;
                    continue;
                }
                if (info.Parameter.Name == "pramesalno")
                {
                    CheckedComboBoxEdit CCBE = new CheckedComboBoxEdit();
                    CCBE.Properties.PopupFormSize = new Size(100, 100);
                    CCBE.Properties.DisplayMember = "esalno";
                    CCBE.Properties.ValueMember = "esalno";
                    CCBE.Properties.TextEditStyle = TextEditStyles.Standard;
                    info.Editor = CCBE;
                    info.Parameter.Value = DBNull.Value;
                    continue;
                }
                if (info.Parameter.Name == "pramSelectCount")
                {
                    ButtonEdit be = new ButtonEdit() { EditValue = 0 };
                    be.Properties.Buttons.Clear();
                    be.Properties.Buttons.Add(new EditorButton(ButtonPredefines.OK));
                    be.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    be.Properties.Mask.EditMask = "n0";
                    be.ButtonClick += be_ButtonClick;
                    info.Editor = be;
                    info.Parameter.Value = 0;
                    continue;
                }
                if (info.Parameter.Name == "pramstart" || info.Parameter.Name == "pramend")
                {
                    info.Parameter.Value = null;
                    continue;
                }
            }
        }
        void be_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            ButtonEdit be = (ButtonEdit)sender;
            if (be.EditValue == null)
                return;

            int counter = Convert.ToInt32(be.EditValue);
            foreach (ParameterInfo info in PramInfo)
            {
                if (info.Parameter.Name == "pramesalno")
                {
                    CheckedComboBoxEdit CCBE = (CheckedComboBoxEdit)info.Editor;
                    CCBE.ShowPopup();
                    CCBE.ClosePopup();

                    for (int i = 0; i < CCBE.Properties.Items.Count; i++)
                    {
                        CCBE.Properties.Items[i].CheckState = CheckState.Unchecked;
                    }
                    for (int i = 0; i < CCBE.Properties.Items.Count; i++)
                    {
                        if (i == counter)
                            break;
                        CCBE.Properties.Items[i].CheckState = CheckState.Checked;
                    }
                    CCBE.RefreshEditValue();
                    CCBE.Refresh();

                }
            }
        }
        void GLUE_LostFocus(object sender, EventArgs e)
        {
            GridLookUpEdit GLUE = (GridLookUpEdit)sender;
            if (FXFW.SqlDB.IsNullOrEmpty(GLUE.EditValue))
                return;
            foreach (ParameterInfo info in PramInfo)
            {
                if (info.Parameter.Name == "pramesalno")
                {
                    CheckedComboBoxEdit CCBE = (CheckedComboBoxEdit)info.Editor;
                    DataTable dt = SQLProvider.Selectesalno(GLUE.EditValue);

                    CCBE.Properties.DataSource = dt;

                    CCBE.ShowPopup();
                    CCBE.ClosePopup();

                    //for (int i = 0; i < CCBE.Properties.Items.Count; i++)
                    //{
                    //    if (i == 50)
                    //        break;
                    //    CCBE.Properties.Items[i].InvertCheckState();
                    //    CCBE.RefreshEditValue();
                    //    CCBE.Refresh();
                    //}

                }
            }
        }
        private void XRep02_ParametersRequestSubmit(object sender, ParametersRequestEventArgs e)
        {
            object start = null;
            object end = null;
            foreach (ParameterInfo info in e.ParametersInformation)
            {
                if (info.Parameter.Name == "pramSyndicateId")
                {
                    GridLookUpEdit lue = (GridLookUpEdit)info.Editor;
                    xlSyndicateId.Text = lue.Text;
                    continue;
                }
                if (info.Parameter.Name == "pramesalno")
                {
                    xlesalno.Text = info.Parameter.Value + " , ";
                    continue;
                }
                if (info.Parameter.Name == "pramstart")
                {
                    start = info.Parameter.Value;
                    continue;
                }
                if (info.Parameter.Name == "pramend")
                {
                    end = info.Parameter.Value;
                    continue;
                }
            }
            object[] obj = e.ParametersInformation[1].Parameter.Value.ToString().Split(Convert.ToChar(","));
            LoadDataSource(e.ParametersInformation[0].Parameter.Value, obj, start, end);
        }

    }
}
