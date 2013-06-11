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
    public partial class FormCreateOrder : FormBase
    {
        public FormCreateOrder(IApplication iapp, IDataService _ids, string sqlguid)
        {
            InitializeComponent();
            _iapplication = iapp;
            ids = _ids;
            PlugSqlGuid = sqlguid;
        }
        public override void AfterShowForm()
        {
            IRight ir = (IRight)iapplication.GetService(typeof(IRight));
           
            //myOrderNumber.FieldValue = "CG" + ir.UserId + DateTime.Now.ToString("yyMMddhhmmss");
            myEditTreeView1.MyItemCheck += new EventHandler(myEditTreeView1_MyItemCheck);
            listView1.Columns.Add("商品ID", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("商品编码", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("商品名称", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("采购数量", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("单位", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("商品单价", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("小计金额", 60, HorizontalAlignment.Left);
            MyRealAmount.FieldValue = "0.0";
            string sql = "select * from ck_buyorderdetail where f_purchasno ='"+MyOrderNumber.FieldValue.ToString()+"'";
            IAdapter iadp = (IAdapter)iapplication.GetService(typeof(IAdapter));
            DataTable dt = (DataTable)iadp.RunCmdnoCheck("AFunction2", new object[] {sql });
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["f_productid"].ToString());
                    item.SubItems.Add(dr["F_CODE"].ToString());
                    item.SubItems.Add(dr["f_product"].ToString());
                    item.SubItems.Add(dr["f_count"].ToString());
                    item.SubItems.Add(dr["f_unit"].ToString());
                    item.SubItems.Add(dr["f_unitprice"].ToString());
                    item.SubItems.Add((Convert.ToInt32(dr["f_count"].ToString())*float.Parse(dr["f_unitprice"].ToString())).ToString());
                    item.Tag = dr["f_id"].ToString();
                    listView1.Items.Add(item);
                    MyRealAmount.FieldValue = (float.Parse(MyRealAmount.FieldValue.ToString()) + Convert.ToInt32(dr["f_count"].ToString()) * float.Parse(dr["f_unitprice"].ToString())).ToString();
                }
            }

            base.AfterShowForm();
        }

        /// <summary>
        /// 1选取商品
        /// 2选取供应商(一个商品多个供应商)
        /// 3显示信息
        /// 3输入数量
        /// 4加到列表
        /// 5创建同意采购号
        /// 5提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void myEditTreeView1_MyItemCheck(object sender, EventArgs e)
        {

        }


        private void butOk_Click(object sender, EventArgs e)
        {
            //IAdapter Iad = (IAdapter)iapplication.GetService(typeof(IAdapter));
            //int amount = 0;
            ////保存采购单明细
            //for (int i = 0; i < listView1.Items.Count; i++)
            //{
            //    Fields2Xml f2x = new Fields2Xml("CK_BUYORDERDETAIL");//定义要修改的表名
            //    f2x.addField("F_ID", SqlDbType.Int, "0", true, true);//指定主键值,没指定主键将添加
            //    f2x.addField("F_PurchasNo", SqlDbType.VarChar, MyOrderNumber.FieldValue.ToString(), false, false);//定义要修改的字段和值
            //    f2x.addField("F_PRODUCTID", SqlDbType.Int, listView1.Items[i].SubItems[0].Text.ToString(), false, false);//定义要修改的字段和值
            //    f2x.addField("F_COUNT", SqlDbType.Int, listView1.Items[i].SubItems[3].Text.ToString(), false, false);//定义要修改的字段和值
            //    f2x.addField("F_UnitPrice", SqlDbType.Int, listView1.Items[i].SubItems[5].Text.ToString(), false, false);//定义要修改的字段和值
            //    f2x.addField("F_Unit", SqlDbType.VarChar, listView1.Items[i].SubItems[4].Text.ToString(), false, false);//定义要修改的字段和值
            //    f2x.addField("F_PRODUCT", SqlDbType.VarChar, listView1.Items[i].SubItems[2].Text.ToString(), false, false);//定义要修改的字段和值
            //    f2x.addField("F_CODE", SqlDbType.VarChar, listView1.Items[i].SubItems[1].Text.ToString(), false, false);//定义要修改的字段和值
            //    String retxml = (string)Iad.RunCmdnoCheck("AFunction1", new object[] { f2x.getDataXml(FormType.Insert) });//指定执行类型,执行
            //    f2x.ReturnXmlAnalsy(retxml);//返回的执行结果;
            //    //amount =amount+ Int32.Parse(listView1.Items[i].SubItems[6].Text.ToString());
            //}
            //this.myEditTextBox2.FieldValue = amount;
            this.Commit();
            //listView1.Items.Clear();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void myEditTreeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            String id = myEditTreeView1.FieldValue.ToString();//单品ID
            String sql = "select *,(SELECT F_NAME FROM CK_COMPANY WHERE F_ID=F_COMPANYID)as F_COMPANYNAME from [CK_PRODUCT] where F_PROTYPE=" + id;//用于查询这个商品的全部信息
            IAdapter iad = (IAdapter)iapplication.GetService(typeof(IAdapter));
            DataTable ntable = (DataTable)iad.RunCmdnoCheck("AFunction2", new object[] { sql });
            if (ntable.Rows.Count > 0)
            {
                MyDataView mdv = new MyDataView();
                mdv.SetKey("f_id");
                foreach (DataRow dr in ntable.Rows)
                {
                    mdv.SelectedRows.Add(dr["f_id"].ToString(), dr);
                }
                mdv.iapplication = iapplication;
                FormProductInfo fpdi = new FormProductInfo(iapplication, mdv, listView1, ntable, MyRealAmount,MyOrderNumber.FieldValue.ToString());
                fpdi.ShowForm(FormType.Edit);
            }
            else
            {
                MessageBox.Show("商品信息不完整, 请到商品管理进行设置!");
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            if (MessageBox.Show("是否删除该明细", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                return;
            ListViewItem lvi = listView1.SelectedItems[0];
            IAdapter Iad = (IAdapter)iapplication.GetService(typeof(IAdapter));
            Fields2Xml f2x = new Fields2Xml("CK_BUYORDERDETAIL");//定义要修改的表名
            f2x.addField("F_ID", SqlDbType.Int, lvi.Tag.ToString(), true, true,true);//指定主键值,没指定主键将添加
            String retxml = (string)Iad.RunCmdnoCheck("AFunction1", new object[] { f2x.getDataXml(FormType.Delete) });//指定执行类型,执行
            if (f2x.ReturnXmlAnalsy(retxml))
                listView1.Items.Remove(lvi);

        }

    }
}
