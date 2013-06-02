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

namespace CK_PluginOrder
{
    public partial class FormProductInfo : FormBase
    {
        ListView listView1 = null;
        DataTable ds = null;
        int amount = 0;
        MyEditTextBox amountTextBox = null;
        public FormProductInfo(IApplication iapp, IDataService _ids, ListView _listView, DataTable dt, MyEditTextBox _amount)
        {
            InitializeComponent();
            dataBindControl1.IDS = _ids;
            _iapplication = iapp;
            ids = _ids;
            this.listView1 = _listView;
            amountTextBox = _amount;
            ds = dt;
            if (_amount.FieldValue.ToString().Length > 0)
            {
                amount = Int32.Parse(_amount.FieldValue.ToString());
            }
            else
            {
                amount = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (ds != null && ds.Rows.Count > 0)
            //{
            //    for (int i = 0; ds.Rows.Count > i; i++)
            //    {
                    
            //        //ListViewItem item = new ListViewItem(ds.Rows[0]["F_ID"].ToString());
            //        //item.SubItems.Add(ds.Rows[i]["F_CODE"].ToString());
            //        //item.SubItems.Add(ds.Rows[i]["F_NAME"].ToString());
            //        //item.SubItems.Add(this.textBox1.Text);
            //        //item.SubItems.Add(ds.Rows[i]["F_MESURE"].ToString());
            //        //item.SubItems.Add(ds.Rows[i]["F_IN_SPRICE"].ToString());
            //        //item.SubItems.Add(textBox2.Text);
            //        //listView1.Items.Add(item);

            //    }
            //}
            ListViewItem item = new ListViewItem(editrow["F_ID"].ToString());
            item.SubItems.Add(editrow["F_CODE"].ToString());
            item.SubItems.Add(editrow["F_NAME"].ToString());
            item.SubItems.Add(this.textBox1.Text);
            item.SubItems.Add(editrow["F_MESURE"].ToString());
            item.SubItems.Add(editrow["F_IN_SPRICE"].ToString());
            item.SubItems.Add(textBox2.Text);
            listView1.Items.Add(item);
            amount = Int32.Parse(textBox2.Text);
            amountTextBox.FieldValue = amount;
            amountTextBox.ShowFieldValue = amount;
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = (Int32.Parse(textBox1.Text) * Int32.Parse(myEditTextBox12.FieldValue.ToString())).ToString();
        }
    }
}
