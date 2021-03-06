﻿using System;
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
            Command cmdAdd = new Command("创建申请", iapplication, CommandTriger.OFF, (int)ImageType.ADD);
            Command cmdEdit = new Command("申请编辑", iapplication, CommandTriger.ON, (int)ImageType.EDIT,"F_STATE","0");
            Command cmdDetail = new Command("申请查看", iapplication, CommandTriger.ON, (int)ImageType.PRINT01);
            // Command cmdPrint = new Command("人员查看", iapplication, CommandTriger.ON, (int)ImageType.PRINT02);
            cmdAdd.Click += new EventHandler(cmdAdd_Click);
            cmdEdit.Click += new EventHandler(cmdEdit_Click);
            cmdDetail.Click += new EventHandler(cmdDetail_Click);
            //建立功能按钮点击处理函数
            RegCommand(cmdAdd, cmdEdit,cmdDetail);

            //标题,字段,宽度,是否主键,是否显示
            this.InitialCaption();
            TipField = "审批流程:,f_stepname,\r\n详细描述:,f_desc";
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
            //从应用程序中获得打印服务实例
            IReport Ir = (IReport)iapplication.GetService(typeof(IReport));
            //从应用程序中获得数据访问服务实例
            IAdapter iadp = (IAdapter)iapplication.GetService(typeof(IAdapter));
            // ILog llll = (ILog)iapplication.GetService(typeof(ILog));
            string ReportTemple = (string)iadp.RunCmdnoCheck("AFunction3", new Object[] { "b0e5c8a8-37bc-4d85-b086-0f733616e9a5" });
            Ir.PrintPreView(ReportTemple, iapplication.MainDataView.XmlData.Replace("$f_printuser$", ((IRight)iapplication.GetService(typeof(IRight))).UserName));

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
            IRight ir = (IRight)iapplication.GetService(typeof(IRight));
            FormBuyApplay FBA = new FormBuyApplay(iapplication, idataservice, GetPlugQueryCmdInfo());
            FBA.RegStatickElement("F_CREATEUSER", System.Data.SqlDbType.Int, ir.UserId);
            FBA.RegStatickElement("F_CREATEAGENCY", System.Data.SqlDbType.Int, ir.AgencyId);
            FBA.ShowForm(FormType.Edit);
        }
        void cmdAdd_Click(object sender, EventArgs e)
        {
            IRight ir = (IRight)iapplication.GetService(typeof(IRight));
            FormBuyApplay FBA = new FormBuyApplay(iapplication, idataservice, GetPlugQueryCmdInfo());
            FBA.RegStatickElement("F_CREATEUSER", System.Data.SqlDbType.Int, ir.UserId);
            FBA.RegStatickElement("F_CREATEAGENCY", System.Data.SqlDbType.Int, ir.AgencyId);
            
            FBA.ShowForm(FormType.Insert);
           // FormCreateOrder FCO = new FormCreateOrder(iapplication,idataservice,GetPlugQueryCmdInfo());
           // 
           // 
           //// FCO.RegStatickElement("F_CREATENAME", System.Data.SqlDbType.VarChar, ir.UserName);
           //// FCO.RegStatickElement("F_CREATEAGENCY", System.Data.SqlDbType.VarChar, ir.AgencyName);
           // FCO.ShowForm(FormType.Insert);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
    [PlugNameAttribute("采购咨询"),
    PlugQueryFormAttribute("Order_Qurey"),
    PlugWriterAttribute(""),
    PlugQueryCmdAttribute("8b904afc-6b23-4bd7-ae33-3ce8a7f93cdf"),
    PlugActionAttribute("采购咨询"),
    PlugDescriptionAttribute("采购部门按照采购申请要求咨询相关供应商，收集商品信息")]
    public partial class CKPlugBuyOrder : PluginNode
    {
        public CKPlugBuyOrder()
        {
        }
        public override void Initialization()
        {
            //NodeBitmap = Resource.driver;
            //注册功能按钮
            Command cmdAdd = new Command("采购咨询", iapplication, CommandTriger.ON, (int)ImageType.ADD);
            //Command cmdEdit = new Command("", iapplication, CommandTriger.ON, (int)ImageType.EDIT);
            //Command cmdDetail = new Command("订单详情", iapplication, CommandTriger.ON, (int)ImageType.PRINT01);
            // Command cmdPrint = new Command("人员查看", iapplication, CommandTriger.ON, (int)ImageType.PRINT02);
            cmdAdd.Click += new EventHandler(cmdAdd_Click);
            //cmdEdit.Click += new EventHandler(cmdEdit_Click);
            //cmdDetail.Click += new EventHandler(cmdDetail_Click);
            //建立功能按钮点击处理函数
            RegCommand(cmdAdd);
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
            FormCreateOrder FCO = new FormCreateOrder(iapplication, idataservice);
            IRight ir = (IRight)iapplication.GetService(typeof(IRight));
            FCO.RegStatickElement("F_APPLAYUSER", System.Data.SqlDbType.Int, ir.UserId);//谁负责咨询，采购下单由谁负责；
            // FCO.RegStatickElement("F_CREATENAME", System.Data.SqlDbType.VarChar, ir.UserName);
            // FCO.RegStatickElement("F_CREATEAGENCY", System.Data.SqlDbType.VarChar, ir.AgencyName);
            FCO.ShowForm(FormType.Edit);
        }
    }

    [PlugNameAttribute("采购处理"),
    PlugQueryFormAttribute("Order_Qurey"),
    PlugWriterAttribute(""),
    PlugQueryCmdAttribute("47700dff-8add-406a-a861-7a0eaab84f90"),
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
            Command cmdAdd = new Command("采购下单", iapplication, CommandTriger.OFF, (int)ImageType.ADD);
            Command cmdEdit = new Command("订单编辑", iapplication, CommandTriger.ON, (int)ImageType.EDIT);
            Command cmdPackage = new Command("到货确认", iapplication, CommandTriger.ON, (int)ImageType.EDIT);
            Command cmdPay = new Command("订单付款", iapplication, CommandTriger.ON, (int)ImageType.PRINT01);
            Command cmdPrint = new Command("订单详情", iapplication, CommandTriger.ON, (int)ImageType.PRINT02);
            Command cmdStore = new Command("采购入库", iapplication, CommandTriger.ON, (int)ImageType.CONFIG01);
            cmdAdd.Click += new EventHandler(cmdAdd_Click);
            cmdEdit.Click+=new EventHandler(cmdEdit_Click);
            //建立功能按钮点击处理函数
            RegCommand(cmdAdd, cmdEdit,cmdPackage, cmdPay,cmdPrint);

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
            FormApplayOrder fao = new FormApplayOrder(iapplication, idataservice);
            fao.ShowForm(FormType.Edit);
        }
        void cmdAdd_Click(object sender, EventArgs e)
        {
            FormApplayOrder fao = new FormApplayOrder(iapplication, idataservice);
            fao.ShowForm(FormType.Insert);
            //FormCreateOrder FCO = new FormCreateOrder(iapplication, idataservice,GetPlugQueryCmdInfo());
            //IRight ir = (IRight)iapplication.GetService(typeof(IRight));
            //FCO.RegStatickElement("F_CREATEUSER", System.Data.SqlDbType.Int, ir.UserId);
            //// FCO.RegStatickElement("F_CREATENAME", System.Data.SqlDbType.VarChar, ir.UserName);
            //// FCO.RegStatickElement("F_CREATEAGENCY", System.Data.SqlDbType.VarChar, ir.AgencyName);
            //FCO.ShowForm(FormType.Insert);
        }
    }
}
