using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace NestleICSales
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();

            //linqServerModeSource1.QueryableSource = from q in new DataSources.Linq.dsLinqDataContext().vQryCustHierLevels select q;

            //this.realTimeSource1.DataSource = Managers.DataManager.XPSCSCustomer;
            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraForm1));
            //this.realTimeSource1.DisplayableProperties = resources.GetString("realTimeSource1.DisplayableProperties");
            //this.realTimeSource1.UseWeakEventHandler = true;

        }
    }
}