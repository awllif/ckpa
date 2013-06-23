using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rock.Container;
using Rock.Interface;

namespace CK_PluginOrder
{
    public partial class FormBuyApplay : FormBase
    {
        public FormBuyApplay(IApplication iapp, IDataService _ids, string sqlguid)
        {
            InitializeComponent();
            _iapplication = iapp;
            ids = _ids;
            PlugSqlGuid = sqlguid;
        }
        public override void AfterShowForm()
        {
            IRight ir = (IRight)iapplication.GetService(typeof(IRight));
            myUserName.FieldValue = ir.UserName;
            myAgencyName.FieldValue = ir.AgencyName;
            if(FType == FormType.Insert)
                myOrderNumber.FieldValue = "SQ"+ ir.UserId + DateTime.Now.ToString("yyMMddhhmmss");
            myState.ShowFieldValue = "0";
            base.AfterShowForm();
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            this.Commit();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
