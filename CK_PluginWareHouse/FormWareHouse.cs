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

namespace CK_PluginWareHouse
{
    public partial class FormWareHouse : FormBase
    {
        public FormWareHouse(IApplication iapp, IDataService _ids)
        {
            InitializeComponent();
            _iapplication = iapp;
            ids = _ids;
        }
        public override void AfterShowForm()
        {
            if (this.FType == FormType.Edit)
                myEditComBoxTree1.Enabled = false;
            base.AfterShowForm();
        }

        void myEditTreeView1_MyItemCheck(object sender, EventArgs e)
        {
            lblType.Text = (string)sender;
            myEditTextBox5.FieldValue = lblType.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Commit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myEditComBoxTree1.SelectedByValue(2, "");
        }

        private void myEditComBoxTree1_ValueChanged(object sender, YongFa365.Controls.ComboBoxTree.DropDownValueChangedEventArgs e)
        {

        }
    }
}
