using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rock.Interface;
using Rock.Container;

namespace CK_PluginWareHouse
{
    [PlugNameAttribute("仓库管理"),
    PlugQueryFormAttribute("QueryWareHouse"),
    PlugWriterAttribute(""),
    PlugQueryCmdAttribute("9882c7ec-3c32-4041-ad38-d66ffa1afdf0"),
    PlugActionAttribute("商品类别"),
    PlugDescriptionAttribute("商品类别 ")]
    public partial class CKPlugWarehouse : PluginNode
    {
        public CKPlugWarehouse()
        {
        }
        public override void Initialization()
        {
            //NodeBitmap = Resource.driver;
            //注册功能按钮
            Command cmdAdd = new Command("添加类别", iapplication, CommandTriger.OFF, (int)ImageType.ADD);
            Command cmdEdit = new Command("编辑类别", iapplication, CommandTriger.ON, (int)ImageType.EDIT);
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
            FormWareHouse fwh = new FormWareHouse(iapplication, idataservice);
            fwh.ShowForm(FormType.Edit);
        }
        void cmdAdd_Click(object sender, EventArgs e)
        {
            FormWareHouse FWH = new FormWareHouse(iapplication, idataservice);
            FWH.ShowForm(FormType.Insert);
        }
    }
}
