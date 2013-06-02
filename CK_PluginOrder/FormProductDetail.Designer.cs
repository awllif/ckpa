namespace CK_PluginOrder
{
    partial class FormProductDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("树名称");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("树名称");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("树名称");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("树名称");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("树名称");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("树名称");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("树名称");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("树名称");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("树名称");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("树名称");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("树名称");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("树名称");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("树名称");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("树名称");
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.lstInfo = new System.Windows.Forms.ListView();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.myEditTreeView1 = new Rock.Interface.MyEditTreeView();
            this.pnelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdMaxRes
            // 
            this.cmdMaxRes.Location = new System.Drawing.Point(685, 3);
            // 
            // cmdMin
            // 
            this.cmdMin.Location = new System.Drawing.Point(660, 3);
            // 
            // titleCaption
            // 
            this.titleCaption.Size = new System.Drawing.Size(730, 26);
            this.titleCaption.Text = "FormProductDetail";
            // 
            // pnelMain
            // 
            this.pnelMain.Controls.Add(this.myEditTreeView1);
            this.pnelMain.Controls.Add(this.lstInfo);
            this.pnelMain.Controls.Add(this.button1);
            this.pnelMain.Controls.Add(this.label18);
            this.pnelMain.Controls.Add(this.label20);
            this.pnelMain.Controls.Add(this.label19);
            this.pnelMain.Controls.Add(this.label3);
            this.pnelMain.Size = new System.Drawing.Size(728, 198);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 68;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 70;
            this.label3.Text = "货物名称";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "名称";
            this.columnHeader5.Width = 54;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "编码";
            this.columnHeader6.Width = 96;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "型号";
            this.columnHeader7.Width = 115;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "采购单价";
            this.columnHeader8.Width = 112;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "拆分数量";
            this.columnHeader9.Width = 110;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "单位";
            // 
            // lstInfo
            // 
            this.lstInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader1});
            this.lstInfo.FullRowSelect = true;
            this.lstInfo.GridLines = true;
            this.lstInfo.Location = new System.Drawing.Point(158, 6);
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.Size = new System.Drawing.Size(561, 149);
            this.lstInfo.TabIndex = 67;
            this.lstInfo.UseCompatibleStateImageBehavior = false;
            this.lstInfo.View = System.Windows.Forms.View.Details;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 167);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 12);
            this.label18.TabIndex = 70;
            this.label18.Text = "物料编号";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(469, 171);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 70;
            this.label19.Text = "交货日期";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(320, 171);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 12);
            this.label20.TabIndex = 70;
            this.label20.Text = "数量";
            // 
            // myEditTreeView1
            // 
            this.myEditTreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myEditTreeView1.Datarow = null;
            this.myEditTreeView1.EditField = "F_PROTYPE";
            this.myEditTreeView1.EditFieldType = System.Data.SqlDbType.Int;
            this.myEditTreeView1.FieldMaxLength = 0;
            this.myEditTreeView1.FieldMinLength = 0;
            this.myEditTreeView1.FieldValue = "0";
            this.myEditTreeView1.FullRowSelect = true;
            this.myEditTreeView1.HideSelection = false;
            this.myEditTreeView1.iapplication = null;
            this.myEditTreeView1.IsCanEdit = true;
            this.myEditTreeView1.IsIdentified = false;
            this.myEditTreeView1.IsKeyField = false;
            this.myEditTreeView1.IsValid = true;
            this.myEditTreeView1.ItemParentField = "f_pid";
            this.myEditTreeView1.ItemParentValueField = "F_PROTYPE";
            this.myEditTreeView1.ItemShowField = "F_PROTYPENAME";
            this.myEditTreeView1.ItemsSql = "select f_id AS F_PROTYPE,f_name AS F_PROTYPENAME,f_pid from ck_protype order by f" +
                "_pid asc";
            this.myEditTreeView1.Location = new System.Drawing.Point(6, 6);
            this.myEditTreeView1.Name = "myEditTreeView1";
            treeNode1.Name = "";
            treeNode1.Tag = "0";
            treeNode1.Text = "树名称";
            treeNode2.Name = "";
            treeNode2.Tag = "0";
            treeNode2.Text = "树名称";
            treeNode3.Name = "";
            treeNode3.Tag = "0";
            treeNode3.Text = "树名称";
            treeNode4.Name = "";
            treeNode4.Tag = "0";
            treeNode4.Text = "树名称";
            treeNode5.Name = "";
            treeNode5.Tag = "0";
            treeNode5.Text = "树名称";
            treeNode6.Name = "";
            treeNode6.Tag = "0";
            treeNode6.Text = "树名称";
            treeNode7.Name = "";
            treeNode7.Tag = "0";
            treeNode7.Text = "树名称";
            treeNode8.Name = "";
            treeNode8.Tag = "0";
            treeNode8.Text = "树名称";
            treeNode9.Name = "";
            treeNode9.Tag = "0";
            treeNode9.Text = "树名称";
            treeNode10.Name = "";
            treeNode10.Tag = "0";
            treeNode10.Text = "树名称";
            treeNode11.Name = "";
            treeNode11.Tag = "0";
            treeNode11.Text = "树名称";
            treeNode12.Name = "";
            treeNode12.Tag = "0";
            treeNode12.Text = "树名称";
            treeNode13.Name = "";
            treeNode13.Tag = "0";
            treeNode13.Text = "树名称";
            treeNode14.Name = "";
            treeNode14.Tag = "0";
            treeNode14.Text = "树名称";
            this.myEditTreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            this.myEditTreeView1.RegexDesc = "";
            this.myEditTreeView1.RegexRule = "";
            this.myEditTreeView1.ShowField = "F_PROTYPE";
            this.myEditTreeView1.ShowFieldValue = "";
            this.myEditTreeView1.Size = new System.Drawing.Size(145, 149);
            this.myEditTreeView1.TabIndex = 76;
            this.myEditTreeView1.TableName = "";
            this.myEditTreeView1.TreeNodeName = "商品类别";
            // 
            // FormProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 228);
            this.Name = "FormProductDetail";
            this.Table = "CK_ORDER";
            this.Text = "FormProductDetail";
            this.pnelMain.ResumeLayout(false);
            this.pnelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lstInfo;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private Rock.Interface.MyEditTreeView myEditTreeView1;
    }
}