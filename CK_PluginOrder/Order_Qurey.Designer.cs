using Rock.Interface;
namespace CK_PluginOrder
{
    partial class Order_Qurey : Query
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.queryElement1 = new Rock.Interface.QueryElement();
            this.label1 = new System.Windows.Forms.Label();
            this.queryElement2 = new Rock.Interface.QueryElement();
            this.label2 = new System.Windows.Forms.Label();
            this.queryComboBox1 = new Rock.Interface.QueryComboBox(this.components);
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "采购单号";
            // 
            // queryElement1
            // 
            this.queryElement1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.queryElement1.Location = new System.Drawing.Point(79, 15);
            this.queryElement1.Name = "queryElement1";
            this.queryElement1.QActived = false;
            this.queryElement1.QField = "F_ORDERNUMBER";
            this.queryElement1.QFieldType = System.Data.SqlDbType.VarChar;
            this.queryElement1.QType = Rock.Interface.QueryType.Include;
            this.queryElement1.QValue = "";
            this.queryElement1.Size = new System.Drawing.Size(140, 21);
            this.queryElement1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "创建人";
            // 
            // queryElement2
            // 
            this.queryElement2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.queryElement2.Location = new System.Drawing.Point(336, 15);
            this.queryElement2.Name = "queryElement2";
            this.queryElement2.QActived = false;
            this.queryElement2.QField = "F_ORDERNUMBER";
            this.queryElement2.QFieldType = System.Data.SqlDbType.VarChar;
            this.queryElement2.QType = Rock.Interface.QueryType.Include;
            this.queryElement2.QValue = "";
            this.queryElement2.Size = new System.Drawing.Size(140, 21);
            this.queryElement2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "采购单状态";
            // 
            // queryComboBox1
            // 
            this.queryComboBox1.Datarow = null;
            this.queryComboBox1.EditField = "F_STATE";
            this.queryComboBox1.EditFieldType = System.Data.SqlDbType.BigInt;
            this.queryComboBox1.FieldMaxLength = 0;
            this.queryComboBox1.FieldMinLength = 0;
            this.queryComboBox1.FieldValue = "";
            this.queryComboBox1.FormattingEnabled = true;
            this.queryComboBox1.iapplication = null;
            this.queryComboBox1.IsCanEdit = false;
            this.queryComboBox1.IsIdentified = false;
            this.queryComboBox1.IsKeyField = false;
            this.queryComboBox1.IsValid = false;
            this.queryComboBox1.ItemsSql = "SELECT F_VALUE AS F_STATE,F_NAME FROM T_BASE_DICT WHERE F_CODE=\'CM_OSTATE\'";
            this.queryComboBox1.Location = new System.Drawing.Point(79, 59);
            this.queryComboBox1.Name = "queryComboBox1";
            this.queryComboBox1.QActived = false;
            this.queryComboBox1.QField = "F_STATE";
            this.queryComboBox1.QFieldType = System.Data.SqlDbType.BigInt;
            this.queryComboBox1.QType = Rock.Interface.QueryType.Equal;
            this.queryComboBox1.QValue = null;
            this.queryComboBox1.RegexDesc = "";
            this.queryComboBox1.RegexRule = "";
            this.queryComboBox1.ShowField = "F_NAME";
            this.queryComboBox1.ShowFieldValue = "";
            this.queryComboBox1.Size = new System.Drawing.Size(140, 20);
            this.queryComboBox1.TabIndex = 9;
            this.queryComboBox1.TableName = "";
            // 
            // Order_Qurey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.queryComboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.queryElement2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.queryElement1);
            this.Name = "Order_Qurey";
            this.Size = new System.Drawing.Size(553, 88);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Rock.Interface.QueryElement queryElement1;
        private System.Windows.Forms.Label label1;
        private QueryElement queryElement2;
        private System.Windows.Forms.Label label2;
        private QueryComboBox queryComboBox1;
    }
}
