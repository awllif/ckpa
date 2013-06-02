using Rock.Interface;
namespace CK_PluginWareHouse
{
    partial class Warehouse_Qurey : Query
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
            this.label3 = new System.Windows.Forms.Label();
            this.queryElement1 = new Rock.Interface.QueryElement();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "仓库名";
            // 
            // queryElement1
            // 
            this.queryElement1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.queryElement1.Location = new System.Drawing.Point(79, 15);
            this.queryElement1.Name = "queryElement1";
            this.queryElement1.QActived = false;
            this.queryElement1.QField = "F_NAME";
            this.queryElement1.QFieldType = System.Data.SqlDbType.VarChar;
            this.queryElement1.QType = Rock.Interface.QueryType.Include;
            this.queryElement1.QValue = "";
            this.queryElement1.Size = new System.Drawing.Size(140, 21);
            this.queryElement1.TabIndex = 4;
            // 
            // Warehouse_Qurey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.queryElement1);
            this.Name = "Warehouse_Qurey";
            this.Size = new System.Drawing.Size(553, 48);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Rock.Interface.QueryElement queryElement1;
    }
}
