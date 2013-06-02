using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rock.Base;
using Rock.Interface;

namespace CK_PluginBaseData
{
    public partial class FormCatalogProduct : FormBase
    {
        public FormCatalogProduct(IApplication iapp, IDataService _ids)
        {
            InitializeComponent();
            _iapplication = iapp;
            ids = _ids;
        }
        public override void AfterShowForm()
        {
            myEditTreeView1.MyItemCheck += new EventHandler(myEditTreeView1_MyItemCheck);
            base.AfterShowForm();
        }

        void myEditTreeView1_MyItemCheck(object sender, EventArgs e)
        {
            lblType.Text = (string)sender;
            String[] codeName=myEditTreeView1.ShowFieldValue.ToString().Split('-');
            this.myEditTextBox2.FieldValue=codeName[0];
            this.myEditTextBox3.FieldValue=codeName[1];
            //this.myEditTextBox4.FieldValue = myEditTreeView1.FieldValue;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Commit();
        }
    }
}
