namespace CK_PluginWareHouse
{
    partial class FormWareHouse
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.myEditTextBox4 = new Rock.Interface.MyEditTextBox();
            this.myEditTextBox3 = new Rock.Interface.MyEditTextBox();
            this.myEditTextBox2 = new Rock.Interface.MyEditTextBox();
            this.myEditTextBox1 = new Rock.Interface.MyEditTextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.myEditTextBox5 = new Rock.Interface.MyEditTextBox();
            this.myEditComBoxTree1 = new Rock.Interface.MyEditComBoxTree();
            this.pnelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdMaxRes
            // 
            this.cmdMaxRes.Location = new System.Drawing.Point(204, 3);
            // 
            // cmdMin
            // 
            this.cmdMin.Location = new System.Drawing.Point(179, 3);
            // 
            // titleCaption
            // 
            this.titleCaption.Size = new System.Drawing.Size(249, 26);
            this.titleCaption.Text = "仓库管理";
            // 
            // pnelMain
            // 
            this.pnelMain.Controls.Add(this.myEditComBoxTree1);
            this.pnelMain.Controls.Add(this.myEditTextBox5);
            this.pnelMain.Controls.Add(this.lblType);
            this.pnelMain.Controls.Add(this.button2);
            this.pnelMain.Controls.Add(this.button1);
            this.pnelMain.Controls.Add(this.label3);
            this.pnelMain.Controls.Add(this.label2);
            this.pnelMain.Controls.Add(this.label4);
            this.pnelMain.Controls.Add(this.label1);
            this.pnelMain.Controls.Add(this.myEditTextBox4);
            this.pnelMain.Controls.Add(this.myEditTextBox3);
            this.pnelMain.Controls.Add(this.myEditTextBox2);
            this.pnelMain.Controls.Add(this.myEditTextBox1);
            this.pnelMain.Size = new System.Drawing.Size(247, 213);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "离开";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "用途";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "名称";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "仓库";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "编码";
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
            this.myEditTextBox4.Location = new System.Drawing.Point(46, 90);
            this.myEditTextBox4.Multiline = true;
            this.myEditTextBox4.Name = "myEditTextBox4";
            this.myEditTextBox4.RegexDesc = "";
            this.myEditTextBox4.RegexRule = "";
            this.myEditTextBox4.ShowField = "f_desc";
            this.myEditTextBox4.ShowFieldValue = null;
            this.myEditTextBox4.Size = new System.Drawing.Size(186, 83);
            this.myEditTextBox4.TabIndex = 3;
            this.myEditTextBox4.TableName = null;
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
            this.myEditTextBox3.Location = new System.Drawing.Point(46, 60);
            this.myEditTextBox3.Name = "myEditTextBox3";
            this.myEditTextBox3.RegexDesc = "";
            this.myEditTextBox3.RegexRule = "";
            this.myEditTextBox3.ShowField = "f_name";
            this.myEditTextBox3.ShowFieldValue = null;
            this.myEditTextBox3.Size = new System.Drawing.Size(186, 21);
            this.myEditTextBox3.TabIndex = 2;
            this.myEditTextBox3.TableName = null;
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
            this.myEditTextBox2.Location = new System.Drawing.Point(46, 33);
            this.myEditTextBox2.Name = "myEditTextBox2";
            this.myEditTextBox2.RegexDesc = "";
            this.myEditTextBox2.RegexRule = "";
            this.myEditTextBox2.ShowField = "f_code";
            this.myEditTextBox2.ShowFieldValue = null;
            this.myEditTextBox2.Size = new System.Drawing.Size(186, 21);
            this.myEditTextBox2.TabIndex = 1;
            this.myEditTextBox2.TableName = null;
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
            this.myEditTextBox1.Location = new System.Drawing.Point(18, 189);
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
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 211);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(0, 12);
            this.lblType.TabIndex = 18;
            // 
            // myEditTextBox5
            // 
            this.myEditTextBox5.Datarow = null;
            this.myEditTextBox5.EditField = "F_LOCATION";
            this.myEditTextBox5.EditFieldType = System.Data.SqlDbType.Text;
            this.myEditTextBox5.FieldMaxLength = 0;
            this.myEditTextBox5.FieldMinLength = 0;
            this.myEditTextBox5.FieldValue = "";
            this.myEditTextBox5.iapplication = null;
            this.myEditTextBox5.IsCanEdit = true;
            this.myEditTextBox5.IsIdentified = false;
            this.myEditTextBox5.IsKeyField = false;
            this.myEditTextBox5.IsValid = true;
            this.myEditTextBox5.Location = new System.Drawing.Point(3, 202);
            this.myEditTextBox5.Name = "myEditTextBox5";
            this.myEditTextBox5.RegexDesc = "";
            this.myEditTextBox5.RegexRule = "";
            this.myEditTextBox5.ShowField = "F_LOCATION";
            this.myEditTextBox5.ShowFieldValue = null;
            this.myEditTextBox5.Size = new System.Drawing.Size(160, 21);
            this.myEditTextBox5.TabIndex = 5;
            this.myEditTextBox5.TableName = null;
            this.myEditTextBox5.Visible = false;
            // 
            // myEditComBoxTree1
            // 
            this.myEditComBoxTree1.Datarow = null;
            this.myEditComBoxTree1.EditField = "f_pid";
            this.myEditComBoxTree1.EditFieldType = System.Data.SqlDbType.BigInt;
            this.myEditComBoxTree1.FieldMaxLength = 0;
            this.myEditComBoxTree1.FieldMinLength = 0;
            this.myEditComBoxTree1.FieldValue = "未将对象引用设置到对象的实例。";
            this.myEditComBoxTree1.iapplication = null;
            this.myEditComBoxTree1.IsCanEdit = true;
            this.myEditComBoxTree1.IsIdentified = false;
            this.myEditComBoxTree1.IsKeyField = false;
            this.myEditComBoxTree1.IsValid = true;
            this.myEditComBoxTree1.ItemParentField = "f_pid";
            this.myEditComBoxTree1.ItemParentValueField = "f_id";
            this.myEditComBoxTree1.ItemShowField = "f_name";
            this.myEditComBoxTree1.ItemsSql = "select f_id,f_name,f_pid from ck_warehouse order by f_pid asc";
            this.myEditComBoxTree1.Location = new System.Drawing.Point(46, 8);
            this.myEditComBoxTree1.Name = "myEditComBoxTree1";
            this.myEditComBoxTree1.RegexDesc = "";
            this.myEditComBoxTree1.RegexRule = "";
            this.myEditComBoxTree1.ShowField = "f_pid";
            this.myEditComBoxTree1.ShowFieldValue = "未将对象引用设置到对象的实例。";
            this.myEditComBoxTree1.Size = new System.Drawing.Size(186, 20);
            this.myEditComBoxTree1.TabIndex = 19;
            this.myEditComBoxTree1.TableName = "";
            this.myEditComBoxTree1.TreeNodeName = "树名称";
            this.myEditComBoxTree1.ValueChanged += new YongFa365.Controls.ComboBoxTree.DropDownValueChangedEventHandler(this.myEditComBoxTree1_ValueChanged);
            // 
            // FormWareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 243);
            this.Name = "FormWareHouse";
            this.Table = "CK_WAREHOUSE";
            this.Text = "仓库管理";
            this.pnelMain.ResumeLayout(false);
            this.pnelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Rock.Interface.MyEditTextBox myEditTextBox4;
        private Rock.Interface.MyEditTextBox myEditTextBox3;
        private Rock.Interface.MyEditTextBox myEditTextBox2;
        private Rock.Interface.MyEditTextBox myEditTextBox1;
        private System.Windows.Forms.Label lblType;
        private Rock.Interface.MyEditTextBox myEditTextBox5;
        private Rock.Interface.MyEditComBoxTree myEditComBoxTree1;
    }
}