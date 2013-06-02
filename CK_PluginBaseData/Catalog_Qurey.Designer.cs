using Rock.Interface;
namespace CK_PluginBaseData
{
    partial class Catalog_Qurey : Query
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.queryElement2 = new Rock.Interface.QueryElement();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.queryElement1 = new Rock.Interface.QueryElement();
            this.queryElement4 = new Rock.Interface.QueryElement();
            this.queryElement3 = new Rock.Interface.QueryElement();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "编码";
            // 
            // queryElement2
            // 
            this.queryElement2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.queryElement2.Location = new System.Drawing.Point(331, 31);
            this.queryElement2.Name = "queryElement2";
            this.queryElement2.QActived = false;
            this.queryElement2.QField = "F_CODE";
            this.queryElement2.QFieldType = System.Data.SqlDbType.VarChar;
            this.queryElement2.QType = Rock.Interface.QueryType.Include;
            this.queryElement2.QValue = "";
            this.queryElement2.Size = new System.Drawing.Size(100, 21);
            this.queryElement2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "型号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "规格";
            // 
            // queryElement1
            // 
            this.queryElement1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.queryElement1.Location = new System.Drawing.Point(331, 69);
            this.queryElement1.Name = "queryElement1";
            this.queryElement1.QActived = false;
            this.queryElement1.QField = "F_STYLE";
            this.queryElement1.QFieldType = System.Data.SqlDbType.VarChar;
            this.queryElement1.QType = Rock.Interface.QueryType.Include;
            this.queryElement1.QValue = "";
            this.queryElement1.Size = new System.Drawing.Size(100, 21);
            this.queryElement1.TabIndex = 6;
            // 
            // queryElement4
            // 
            this.queryElement4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.queryElement4.Location = new System.Drawing.Point(54, 31);
            this.queryElement4.Name = "queryElement4";
            this.queryElement4.QActived = false;
            this.queryElement4.QField = "F_NAME";
            this.queryElement4.QFieldType = System.Data.SqlDbType.VarChar;
            this.queryElement4.QType = Rock.Interface.QueryType.Include;
            this.queryElement4.QValue = "";
            this.queryElement4.Size = new System.Drawing.Size(140, 21);
            this.queryElement4.TabIndex = 8;
            // 
            // queryElement3
            // 
            this.queryElement3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.queryElement3.Location = new System.Drawing.Point(54, 70);
            this.queryElement3.Name = "queryElement3";
            this.queryElement3.QActived = false;
            this.queryElement3.QField = "F_TYPE";
            this.queryElement3.QFieldType = System.Data.SqlDbType.BigInt;
            this.queryElement3.QType = Rock.Interface.QueryType.Equal;
            this.queryElement3.QValue = "";
            this.queryElement3.Size = new System.Drawing.Size(140, 21);
            this.queryElement3.TabIndex = 4;
            // 
            // CatalogType_Qurey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.queryElement4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.queryElement1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.queryElement3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.queryElement2);
            this.Controls.Add(this.label1);
            this.Name = "CatalogType_Qurey";
            this.Size = new System.Drawing.Size(553, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Rock.Interface.QueryElement queryElement2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private QueryElement queryElement1;
        private QueryElement queryElement4;
        private QueryElement queryElement3;
    }
}
