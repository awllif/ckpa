using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rock.Interface;
using Rock.Container;

namespace CK_PluginBaseData
{
    [PlugNameAttribute("商品类别"),
    PlugQueryFormAttribute("CatalogType_Qurey"),
    PlugWriterAttribute(""),
    PlugQueryCmdAttribute("66df0c56-9c09-4e33-96b0-bd5625a007c2"),
    PlugActionAttribute("商品类别"),
    PlugDescriptionAttribute("商品类别 ")]
    public partial class CKPlugCatalogType : PluginNode
    {
        public CKPlugCatalogType()
        {
        }
        public override void Initialization()
        {
            //NodeBitmap = Resource.driver;
            //注册功能按钮
            Command cmdAdd = new Command("添加类别", iapplication, CommandTriger.OFF, (int)ImageType.ADD);
            Command cmdEdit = new Command("编辑类别", iapplication, CommandTriger.ON, (int)ImageType.EDIT);
            // Command cmdPrint = new Command("人员查看", iapplication, CommandTriger.ON, (int)ImageType.PRINT02);
            cmdAdd.Click+=new EventHandler(cmdAdd_Click);
            cmdEdit.Click+=new EventHandler(cmdEdit_Click);
            //建立功能按钮点击处理函数
            RegCommand(cmdAdd, cmdEdit);

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
        void cmdPrint_Click(object sender, EventArgs e)
        {
        
            //displayReport("f292a161-04fd-416a-8275-d4e4b6f35ffb", "71e05c88-7210-4a99-91a8-8e6247fe8baa");
        }
        void cmdSetting_Click(object sender, EventArgs e)
        {

        }
        void cmdEdit_Click(object sender, EventArgs e)
        {
            FormProType FPT = new FormProType(iapplication, idataservice);
            FPT.ShowForm(FormType.Edit);
        }
        void cmdAdd_Click(object sender, EventArgs e)
        {
            FormProType fpt = new FormProType(iapplication, idataservice);
            fpt.ShowForm(FormType.Insert);
        }
    }
    [PlugNameAttribute("供应商管理"),
    PlugQueryFormAttribute("CatalogCompany_Qurey"),
    PlugWriterAttribute(""),
    PlugQueryCmdAttribute("3a8f8f32-42af-4a80-b9bc-72006d63f5f6"),
    PlugActionAttribute("供应商管理"),
    PlugDescriptionAttribute("供应商管理")]
    public partial class CKPlugCatalogCompany : PluginNode
    {
        public CKPlugCatalogCompany()
        {
        }

        public override void Initialization()
        {
            //NodeBitmap = Resource.driver;
            //注册功能按钮
            Command cmdAdd = new Command("添加", iapplication, CommandTriger.OFF, (int)ImageType.ADD);
            Command cmdEdit = new Command("编辑", iapplication, CommandTriger.ON, (int)ImageType.EDIT);
            // Command cmdPrint = new Command("人员查看", iapplication, CommandTriger.ON, (int)ImageType.PRINT02);
            cmdAdd.Click += new EventHandler(cmdAdd_Click);
            cmdEdit.Click += new EventHandler(cmdEdit_Click);
            //建立功能按钮点击处理函数
            RegCommand(cmdAdd, cmdEdit);

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

        void cmdPrint_Click(object sender, EventArgs e)
        {

            //displayReport("f292a161-04fd-416a-8275-d4e4b6f35ffb", "71e05c88-7210-4a99-91a8-8e6247fe8baa");
        }
        void cmdSetting_Click(object sender, EventArgs e)
        {

        }

        void cmdEdit_Click(object sender, EventArgs e)
        {
            FormCatalogCompany fcc = new FormCatalogCompany(iapplication, idataservice);
            fcc.ShowForm(FormType.Edit);
        }

        void cmdAdd_Click(object sender, EventArgs e)
        {
            FormCatalogCompany fcc = new FormCatalogCompany(iapplication, idataservice);
            fcc.ShowForm(FormType.Insert);
        }

    }
    [PlugNameAttribute("采购商品管理"),
    PlugQueryFormAttribute("Catalog_Qurey"),
    PlugWriterAttribute(""),
    PlugQueryCmdAttribute("dd36f6c5-fe2b-4c73-bf42-3922876fdf31"),
    PlugActionAttribute("供应商管理"),
    PlugDescriptionAttribute("供应商管理")]
    public partial class CKPlugCatalog : PluginNode
    {
        public CKPlugCatalog()
        {
        }

        public override void Initialization()
        {
            //NodeBitmap = Resource.driver;
            //注册功能按钮
            Command cmdAdd = new Command("添加", iapplication, CommandTriger.OFF, (int)ImageType.ADD);
            Command cmdEdit = new Command("编辑", iapplication, CommandTriger.ON, (int)ImageType.EDIT);
            // Command cmdPrint = new Command("人员查看", iapplication, CommandTriger.ON, (int)ImageType.PRINT02);
            cmdAdd.Click += new EventHandler(cmdAdd_Click);
            cmdEdit.Click += new EventHandler(cmdEdit_Click);
            //建立功能按钮点击处理函数
            RegCommand(cmdAdd, cmdEdit);

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

        void cmdPrint_Click(object sender, EventArgs e)
        {

            //displayReport("f292a161-04fd-416a-8275-d4e4b6f35ffb", "71e05c88-7210-4a99-91a8-8e6247fe8baa");
        }
        void cmdSetting_Click(object sender, EventArgs e)
        {

        }

        void cmdEdit_Click(object sender, EventArgs e)
        {
            FormCatalogProduct fcp = new FormCatalogProduct(iapplication, idataservice);
            fcp.ShowForm(FormType.Edit);
        }

        void cmdAdd_Click(object sender, EventArgs e)
        {
            FormCatalogProduct fcp = new FormCatalogProduct(iapplication, idataservice);
            fcp.ShowForm(FormType.Insert);
        }

    }
}
