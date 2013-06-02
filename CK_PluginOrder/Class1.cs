using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rock.Interface;
using Rock.Container;

namespace CK_PluginOrder
{
    [PlugNameAttribute("采购申请"),
    PlugQueryFormAttribute("Order_Qurey"),
    PlugWriterAttribute(""),
    PlugQueryCmdAttribute("8b904afc-6b23-4bd7-ae33-3ce8a7f93cdf"),
    PlugActionAttribute("商品类别"),
    PlugDescriptionAttribute("商品类别 ")]
    public partial class CKPlugApplyOrder : PluginNode
    {
        private System.ComponentModel.IContainer components;
    
        public CKPlugApplyOrder()
        {
        }
        public override void Initialization()
        {
            //NodeBitmap = Resource.driver;
            //注册功能按钮
            Command cmdAdd = new Command("创建订单", iapplication, CommandTriger.OFF, (int)ImageType.ADD);
            Command cmdEdit = new Command("订单编辑", iapplication, CommandTriger.ON, (int)ImageType.EDIT);
            Command cmdDetail = new Command("订单详情", iapplication, CommandTriger.ON, (int)ImageType.PRINT01);
            // Command cmdPrint = new Command("人员查看", iapplication, CommandTriger.ON, (int)ImageType.PRINT02);
            cmdAdd.Click += new EventHandler(cmdAdd_Click);
            cmdEdit.Click += new EventHandler(cmdEdit_Click);
            cmdDetail.Click += new EventHandler(cmdDetail_Click);
            //建立功能按钮点击处理函数
            RegCommand(cmdAdd, cmdEdit,cmdDetail);

            //标题,字段,宽度,是否主键,是否显示
            this.InitialCaption();
            ////颜色控制列表
            //this.RegWhere(new object[] { 
            //                            new object[]{ "F_StateName","草稿",Color.Red},
            //            new object[]{ "F_StateName","关闭",Color.Gray},
            //            new object[]{ "F_StateName","发布",Color.Green}});

            ////分组
            //this.RegGroup(new object[] { "F_EventName" });
        }

        void cmdDetail_Click(object sender, EventArgs e)
        {
//            throw new NotImplementedException();
        }
        void cmdPrint_Click(object sender, EventArgs e)
        {

            //displayReport("f292a161-04fd-416a-8275-d4e4b6f35ffb", "71e05c88-7210-4a99-91a8-8e6247fe8baa");
        }
        void cmdSetting_Click(object sender, EventArgs e)
        {

        }
        void cmdEdit_Click(object sender, EventArgs e)
        {

        }
        void cmdAdd_Click(object sender, EventArgs e)
        {
            FormCreateOrder FCO = new FormCreateOrder(iapplication,idataservice,GetPlugQueryCmdInfo());
            IRight ir = (IRight)iapplication.GetService(typeof(IRight));
            FCO.RegStatickElement("F_CREATEUSER", System.Data.SqlDbType.Int, ir.UserId);
            FCO.RegStatickElement("F_CREATEAGENCY", System.Data.SqlDbType.Int, ir.AgencyId);
           // FCO.RegStatickElement("F_CREATENAME", System.Data.SqlDbType.VarChar, ir.UserName);
           // FCO.RegStatickElement("F_CREATEAGENCY", System.Data.SqlDbType.VarChar, ir.AgencyName);
            FCO.ShowForm(FormType.Insert);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
    [PlugNameAttribute("采购下单"),
    PlugQueryFormAttribute("Order_Qurey"),
    PlugWriterAttribute(""),
    PlugQueryCmdAttribute("8b904afc-6b23-4bd7-ae33-3ce8a7f93cdf"),
    PlugActionAttribute("商品类别"),
    PlugDescriptionAttribute("商品类别 ")]
    public partial class CKPlugBuyOrder : PluginNode
    {
        public CKPlugBuyOrder()
        {
        }
        public override void Initialization()
        {
            //NodeBitmap = Resource.driver;
            //注册功能按钮
            Command cmdAdd = new Command("采购下单", iapplication, CommandTriger.OFF, (int)ImageType.ADD);
            Command cmdEdit = new Command("", iapplication, CommandTriger.ON, (int)ImageType.EDIT);
            Command cmdDetail = new Command("订单详情", iapplication, CommandTriger.ON, (int)ImageType.PRINT01);
            // Command cmdPrint = new Command("人员查看", iapplication, CommandTriger.ON, (int)ImageType.PRINT02);
            cmdAdd.Click += new EventHandler(cmdAdd_Click);
            cmdEdit.Click += new EventHandler(cmdEdit_Click);
            cmdDetail.Click += new EventHandler(cmdDetail_Click);
            //建立功能按钮点击处理函数
            RegCommand(cmdAdd, cmdEdit, cmdDetail);
            //标题,字段,宽度,是否主键,是否显示
            this.InitialCaption();
            ////颜色控制列表
            //this.RegWhere(new object[] { 
            //                            new object[]{ "F_StateName","草稿",Color.Red},
            //            new object[]{ "F_StateName","关闭",Color.Gray},
            //            new object[]{ "F_StateName","发布",Color.Green}});

            ////分组
            //this.RegGroup(new object[] { "F_EventName" });
        }

        void cmdDetail_Click(object sender, EventArgs e)
        {
            //            throw new NotImplementedException();
        }
        void cmdPrint_Click(object sender, EventArgs e)
        {

            //displayReport("f292a161-04fd-416a-8275-d4e4b6f35ffb", "71e05c88-7210-4a99-91a8-8e6247fe8baa");
        }
        void cmdSetting_Click(object sender, EventArgs e)
        {

        }
        void cmdEdit_Click(object sender, EventArgs e)
        {

        }
        void cmdAdd_Click(object sender, EventArgs e)
        {
            FormCreateOrder FCO = new FormCreateOrder(iapplication, idataservice,GetPlugQueryCmdInfo());
            IRight ir = (IRight)iapplication.GetService(typeof(IRight));
            FCO.RegStatickElement("F_CREATEUSER", System.Data.SqlDbType.Int, ir.UserId);
            // FCO.RegStatickElement("F_CREATENAME", System.Data.SqlDbType.VarChar, ir.UserName);
            // FCO.RegStatickElement("F_CREATEAGENCY", System.Data.SqlDbType.VarChar, ir.AgencyName);
            FCO.ShowForm(FormType.Insert);
        }
    }

    [PlugNameAttribute("采购处理"),
    PlugQueryFormAttribute("Order_Qurey"),
    PlugWriterAttribute(""),
    PlugQueryCmdAttribute("8b904afc-6b23-4bd7-ae33-3ce8a7f93cdf"),
    PlugActionAttribute("商品类别"),
    PlugDescriptionAttribute("商品类别 ")]
    public partial class CKPlugOrderDeal : PluginNode
    {
        public CKPlugOrderDeal()
        {
        }
        public override void Initialization()
        {
            //NodeBitmap = Resource.driver;
            //注册功能按钮
            Command cmdAdd = new Command("到货验收", iapplication, CommandTriger.OFF, (int)ImageType.ADD);
            Command cmdEdit = new Command("采购付款", iapplication, CommandTriger.ON, (int)ImageType.EDIT);
            Command cmdDetail = new Command("采购入库", iapplication, CommandTriger.ON, (int)ImageType.PRINT01);
            // Command cmdPrint = new Command("人员查看", iapplication, CommandTriger.ON, (int)ImageType.PRINT02);
            cmdAdd.Click += new EventHandler(cmdAdd_Click);
            cmdEdit.Click += new EventHandler(cmdEdit_Click);
            cmdDetail.Click += new EventHandler(cmdDetail_Click);
            //建立功能按钮点击处理函数
            RegCommand(cmdAdd, cmdEdit, cmdDetail);

            //标题,字段,宽度,是否主键,是否显示
            this.InitialCaption();
            ////颜色控制列表
            //this.RegWhere(new object[] { 
            //                            new object[]{ "F_StateName","草稿",Color.Red},
            //            new object[]{ "F_StateName","关闭",Color.Gray},
            //            new object[]{ "F_StateName","发布",Color.Green}});

            ////分组
            //this.RegGroup(new object[] { "F_EventName" });
        }

        void cmdDetail_Click(object sender, EventArgs e)
        {
            //            throw new NotImplementedException();
        }
        void cmdPrint_Click(object sender, EventArgs e)
        {

            //displayReport("f292a161-04fd-416a-8275-d4e4b6f35ffb", "71e05c88-7210-4a99-91a8-8e6247fe8baa");
        }
        void cmdSetting_Click(object sender, EventArgs e)
        {

        }
        void cmdEdit_Click(object sender, EventArgs e)
        {

        }
        void cmdAdd_Click(object sender, EventArgs e)
        {
            FormCreateOrder FCO = new FormCreateOrder(iapplication, idataservice,GetPlugQueryCmdInfo());
            IRight ir = (IRight)iapplication.GetService(typeof(IRight));
            FCO.RegStatickElement("F_CREATEUSER", System.Data.SqlDbType.Int, ir.UserId);
            // FCO.RegStatickElement("F_CREATENAME", System.Data.SqlDbType.VarChar, ir.UserName);
            // FCO.RegStatickElement("F_CREATEAGENCY", System.Data.SqlDbType.VarChar, ir.AgencyName);
            FCO.ShowForm(FormType.Insert);
        }
    }
}
