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
    public partial class FormProType : FormBase
    {
        public FormProType(IApplication iapp, IDataService _ids)
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
         
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (myEditTreeView1.FieldValue.ToString() == myEditTextBox1.FieldValue.ToString())
            {
                MessageBox.Show("类别归属不能为自身,请重新选择商品类别归属！", "错误", MessageBoxButtons.OK);
                return;
            }
            this.Commit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
