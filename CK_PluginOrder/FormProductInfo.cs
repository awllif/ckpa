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
        float amount = 0;
        MyEditTextBox amountTextBox = null;
        string OrderNum = "";
        public FormProductInfo(IApplication iapp, IDataService _ids, ListView _listView, DataTable dt, MyEditTextBox _amount,string orderno)
        {
            InitializeComponent();
            dataBindControl1.IDS = _ids;
            _iapplication = iapp;
            ids = _ids;
            this.listView1 = _listView;
            amountTextBox = _amount;
            OrderNum = orderno;
            ds = dt;
            if (_amount.FieldValue.ToString().Length > 0)
            {
                amount = float.Parse(_amount.FieldValue.ToString());
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
            string key = "";
            IAdapter Iad = (IAdapter)iapplication.GetService(typeof(IAdapter));
            Fields2Xml f2x = new Fields2Xml("CK_BUYORDERDETAIL");//定义要修改的表名
            f2x.addField("F_ID", SqlDbType.Int, "0", true, true);//指定主键值,没指定主键将添加
            f2x.addField("F_PurchasNo", SqlDbType.VarChar, OrderNum);//定义要修改的字段和值
            f2x.addField("F_PRODUCTID", SqlDbType.Int, editrow["F_ID"].ToString());//定义要修改的字段和值
            f2x.addField("F_COUNT", SqlDbType.Int, this.textBox1.Text);//定义要修改的字段和值
            f2x.addField("F_UnitPrice", SqlDbType.Int, editrow["F_IN_SPRICE"].ToString());//定义要修改的字段和值
            f2x.addField("F_Unit", SqlDbType.VarChar, editrow["F_MESURE"].ToString());//定义要修改的字段和值
            f2x.addField("F_PRODUCT", SqlDbType.VarChar, editrow["F_NAME"].ToString());//定义要修改的字段和值
            f2x.addField("F_CODE", SqlDbType.VarChar, editrow["F_CODE"].ToString());//定义要修改的字段和值
            String retxml = (string)Iad.RunCmdnoCheck("AFunction1", new object[] { f2x.getDataXml(FormType.Insert) });//指定执行类型,执行
            MessageBox.Show(retxml);
            if (f2x.ReturnXmlAnalsy(retxml, ref key))
            {
                ListViewItem item = new ListViewItem(editrow["F_ID"].ToString());
                item.SubItems.Add(editrow["F_CODE"].ToString());
                item.SubItems.Add(editrow["F_NAME"].ToString());
                item.SubItems.Add(this.textBox1.Text);
                item.SubItems.Add(editrow["F_MESURE"].ToString());
                item.SubItems.Add(editrow["F_IN_SPRICE"].ToString());
                item.SubItems.Add(textBox2.Text);
                item.Tag = key;
                listView1.Items.Add(item);
                amount = amount + float.Parse(textBox2.Text);
                amountTextBox.FieldValue = amount;
                amountTextBox.ShowFieldValue = amount;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = (Int32.Parse(textBox1.Text) * float.Parse(myEditTextBox12.FieldValue.ToString())).ToString();
        }
    }
}
