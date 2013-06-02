namespace CK_PluginBaseData
{
    partial class FormProType
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
            this.myEditTextBox1 = new Rock.Interface.MyEditTextBox();
            this.myEditTextBox2 = new Rock.Interface.MyEditTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.myEditTextBox3 = new Rock.Interface.MyEditTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.myEditTextBox4 = new Rock.Interface.MyEditTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.myEditTreeView1 = new Rock.Interface.MyEditTreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.pnelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdMaxRes
            // 
            this.cmdMaxRes.Location = new System.Drawing.Point(392, 3);
            // 
            // cmdMin
            // 
            this.cmdMin.Location = new System.Drawing.Point(367, 3);
            // 
            // titleCaption
            // 
            this.titleCaption.Size = new System.Drawing.Size(437, 26);
            this.titleCaption.Text = "商品类别管理";
            // 
            // pnelMain
            // 
            this.pnelMain.Controls.Add(this.button2);
            this.pnelMain.Controls.Add(this.button1);
            this.pnelMain.Controls.Add(this.myEditTreeView1);
            this.pnelMain.Controls.Add(this.label3);
            this.pnelMain.Controls.Add(this.label2);
            this.pnelMain.Controls.Add(this.lblType);
            this.pnelMain.Controls.Add(this.label4);
            this.pnelMain.Controls.Add(this.label1);
            this.pnelMain.Controls.Add(this.myEditTextBox4);
            this.pnelMain.Controls.Add(this.myEditTextBox3);
            this.pnelMain.Controls.Add(this.myEditTextBox2);
            this.pnelMain.Controls.Add(this.myEditTextBox1);
            this.pnelMain.Size = new System.Drawing.Size(435, 252);
            // 
            // myEditTextBox1
            // 
            this.myEditTextBox1.Datarow = null;
            this.myEditTextBox1.EditField = "f_id";
            this.myEditTextBox1.EditFieldType = System.Data.SqlDbType.Int;
            this.myEditTextBox1.FieldMaxLength = 0;
            this.myEditTextBox1.FieldMinLength = 0;
            this.myEditTextBox1.FieldValue = "";
            this.myEditTextBox1.iapplication = null;
            this.myEditTextBox1.IsCanEdit = false;
            this.myEditTextBox1.IsIdentified = true;
            this.myEditTextBox1.IsKeyField = true;
            this.myEditTextBox1.IsValid = true;
            this.myEditTextBox1.Location = new System.Drawing.Point(25, 216);
            this.myEditTextBox1.Name = "myEditTextBox1";
            this.myEditTextBox1.RegexDesc = "";
            this.myEditTextBox1.RegexRule = "";
            this.myEditTextBox1.ShowField = "f_id";
            this.myEditTextBox1.ShowFieldValue = null;
            this.myEditTextBox1.Size = new System.Drawing.Size(100, 21);
            this.myEditTextBox1.TabIndex = 4;
            this.myEditTextBox1.TableName = null;
            this.myEditTextBox1.Visible = false;
            // 
            // myEditTextBox2
            // 
            this.myEditTextBox2.Datarow = null;
            this.myEditTextBox2.EditField = "f_code";
            this.myEditTextBox2.EditFieldType = System.Data.SqlDbType.VarChar;
            this.myEditTextBox2.FieldMaxLength = 0;
            this.myEditTextBox2.FieldMinLength = 0;
            this.myEditTextBox2.FieldValue = "";
            this.myEditTextBox2.iapplication = null;
            this.myEditTextBox2.IsCanEdit = true;
            this.myEditTextBox2.IsIdentified = false;
            this.myEditTextBox2.IsKeyField = false;
            this.myEditTextBox2.IsValid = true;
            this.myEditTextBox2.Location = new System.Drawing.Point(228, 9);
            this.myEditTextBox2.Name = "myEditTextBox2";
            this.myEditTextBox2.RegexDesc = "";
            this.myEditTextBox2.RegexRule = "";
            this.myEditTextBox2.ShowField = "f_code";
            this.myEditTextBox2.ShowFieldValue = null;
            this.myEditTextBox2.Size = new System.Drawing.Size(186, 21);
            this.myEditTextBox2.TabIndex = 1;
            this.myEditTextBox2.TableName = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "商品编码";
            // 
            // myEditTextBox3
            // 
            this.myEditTextBox3.Datarow = null;
            this.myEditTextBox3.EditField = "f_name";
            this.myEditTextBox3.EditFieldType = System.Data.SqlDbType.VarChar;
            this.myEditTextBox3.FieldMaxLength = 0;
            this.myEditTextBox3.FieldMinLength = 0;
            this.myEditTextBox3.FieldValue = "";
            this.myEditTextBox3.iapplication = null;
            this.myEditTextBox3.IsCanEdit = true;
            this.myEditTextBox3.IsIdentified = false;
            this.myEditTextBox3.IsKeyField = false;
            this.myEditTextBox3.IsValid = true;
            this.myEditTextBox3.Location = new System.Drawing.Point(228, 36);
            this.myEditTextBox3.Name = "myEditTextBox3";
            this.myEditTextBox3.RegexDesc = "";
            this.myEditTextBox3.RegexRule = "";
            this.myEditTextBox3.ShowField = "f_name";
            this.myEditTextBox3.ShowFieldValue = null;
            this.myEditTextBox3.Size = new System.Drawing.Size(186, 21);
            this.myEditTextBox3.TabIndex = 2;
            this.myEditTextBox3.TableName = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "类别名称";
            // 
            // myEditTextBox4
            // 
            this.myEditTextBox4.Datarow = null;
            this.myEditTextBox4.EditField = "f_desc";
            this.myEditTextBox4.EditFieldType = System.Data.SqlDbType.VarChar;
            this.myEditTextBox4.FieldMaxLength = 0;
            this.myEditTextBox4.FieldMinLength = 0;
            this.myEditTextBox4.FieldValue = "";
            this.myEditTextBox4.iapplication = null;
            this.myEditTextBox4.IsCanEdit = true;
            this.myEditTextBox4.IsIdentified = false;
            this.myEditTextBox4.IsKeyField = false;
            this.myEditTextBox4.IsValid = true;
            this.myEditTextBox4.Location = new System.Drawing.Point(228, 66);
            this.myEditTextBox4.Multiline = true;
            this.myEditTextBox4.Name = "myEditTextBox4";
            this.myEditTextBox4.RegexDesc = "";
            this.myEditTextBox4.RegexRule = "";
            this.myEditTextBox4.ShowField = "f_desc";
            this.myEditTextBox4.ShowFieldValue = null;
            this.myEditTextBox4.Size = new System.Drawing.Size(186, 138);
            this.myEditTextBox4.TabIndex = 3;
            this.myEditTextBox4.TableName = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "类别描述";
            // 
            // myEditTreeView1
            // 
            this.myEditTreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myEditTreeView1.Datarow = null;
            this.myEditTreeView1.EditField = "f_pid";
            this.myEditTreeView1.EditFieldType = System.Data.SqlDbType.BigInt;
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
            this.myEditTreeView1.ItemParentValueField = "f_id";
            this.myEditTreeView1.ItemShowField = "f_name";
            this.myEditTreeView1.ItemsSql = "select f_id,f_name,f_pid from ck_protype order by f_pid asc";
            this.myEditTreeView1.Location = new System.Drawing.Point(10, 27);
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
            this.myEditTreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            this.myEditTreeView1.RegexDesc = "";
            this.myEditTreeView1.RegexRule = "";
            this.myEditTreeView1.ShowField = "f_pid";
            this.myEditTreeView1.ShowFieldValue = "";
            this.myEditTreeView1.Size = new System.Drawing.Size(145, 177);
            this.myEditTreeView1.TabIndex = 0;
            this.myEditTreeView1.TableName = "";
            this.myEditTreeView1.TreeNodeName = "商品类别";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "离开";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "类别归属";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(8, 216);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(0, 12);
            this.lblType.TabIndex = 2;
            // 
            // FormProType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 282);
            this.Name = "FormProType";
            this.Table = "CK_PROTYPE";
            this.Text = "商品类别管理";
            this.pnelMain.ResumeLayout(false);
            this.pnelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Rock.Interface.MyEditTextBox myEditTextBox1;
        private System.Windows.Forms.Label label1;
        private Rock.Interface.MyEditTextBox myEditTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Rock.Interface.MyEditTextBox myEditTextBox4;
        private Rock.Interface.MyEditTextBox myEditTextBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Rock.Interface.MyEditTreeView myEditTreeView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblType;
    }
}