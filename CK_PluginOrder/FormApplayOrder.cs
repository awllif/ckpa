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
    public partial class FormApplayOrder : FormBase
    {
        public FormApplayOrder(IApplication iapp,IDataService _ids)
        {
            InitializeComponent();
            _iapplication = iapp;
            ids = _ids;
        }
        public override void AfterShowForm()
        {
            myBuyOrder.ItemsSql = "select F_ORDERNUMBER,f_id as F_BuyOrderId from CK_BUYORDER  where F_STATE =2";
            myBuyOrder.EditField = "F_BuyOrderId";
            myBuyOrder.ShowField = "f_ordernumber";
            myBuyOrder.Reload();
            base.AfterShowForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void myBuyOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            myCompany.ItemsSql = "select distinct d.f_id as F_companyid,d.F_NAME as f_companyname from (select * from CK_BUYORDERDETAIL where F_PurchasNo ='" + myBuyOrder.ShowFieldValue.ToString() + "') c ,(select A.F_ID AS F_PRODUCTID,B.* from CK_PRODUCT a,CK_COMPANY b where a.F_COMPANYID = b.F_ID ) d where c.f_productid = d.f_productid";
            myCompany.EditField = "f_companyid";
            myCompany.ShowField = "f_companyname";
            myCompany.Reload();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Commit();

        }

        private void myCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
   
        }

        private void myListProduct_MyItemCheck(object sender, EventArgs e)
        {
          
        }

        private void myListProduct_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            
            float totalprice = 0.0f;
            foreach (ListViewItem lvi in myListProduct.CheckedItems)
            {

                totalprice = totalprice + Convert.ToInt32(lvi.SubItems[1].Text) * float.Parse(lvi.SubItems[2].Text);
            }
            myTotal.Text = totalprice.ToString();
        }

        private void myListProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void myCompany_CheckChanged(object sender, EventArgs e)
        {
            myListProduct.ItemsSql = "select C.F_ID AS f_products, c.F_COUNT,c.f_unitprice,d.f_name as f_productsname,d.f_code from (select * from CK_BUYORDERDETAIL where F_PurchasNo ='" + myBuyOrder.ShowFieldValue.ToString() + "') c ,CK_PRODUCT d where c.F_PRODUCTID = d.F_ID and d.F_COMPANYID = " + myCompany.FieldValue.ToString() + " and c.F_ID not in (select F_buyProductid  from CK_APPLAYORDERDETAIL)";
            myListProduct.Reload();
        }
    }
}
