namespace CK_PluginOrder
{
    partial class FormBuyApplay
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
            this.myEditTextBox1 = new Rock.Interface.MyEditTextBox();
            this.myEditTextBox2 = new Rock.Interface.MyEditTextBox();
            this.myOrderNumber = new Rock.Interface.MyEditTextBox();
            this.myEditComboBox1 = new Rock.Interface.MyEditComboBox();
            this.butOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.butCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.myEditTextBox3 = new Rock.Interface.MyEditTextBox();
            this.myEditTextBox4 = new Rock.Interface.MyEditTextBox();
            this.myUserName = new Rock.Interface.MyEditTextBox();
            this.myAgencyName = new Rock.Interface.MyEditTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdMaxRes
            // 
            this.cmdMaxRes.Location = new System.Drawing.Point(435, 3);
            // 
            // cmdMin
            // 
            this.cmdMin.Location = new System.Drawing.Point(410, 3);
            // 
            // titleCaption
            // 
            this.titleCaption.Size = new System.Drawing.Size(480, 26);
            this.titleCaption.Text = "采购申请单";
            // 
            // pnelMain
            // 
            this.pnelMain.Controls.Add(this.myAgencyName);
            this.pnelMain.Controls.Add(this.myUserName);
            this.pnelMain.Controls.Add(this.myEditTextBox4);
            this.pnelMain.Controls.Add(this.myEditTextBox3);
            this.pnelMain.Controls.Add(this.myEditTextBox1);
            this.pnelMain.Controls.Add(this.myEditTextBox2);
            this.pnelMain.Controls.Add(this.myOrderNumber);
            this.pnelMain.Controls.Add(this.myEditComboBox1);
            this.pnelMain.Controls.Add(this.butOk);
            this.pnelMain.Controls.Add(this.label1);
            this.pnelMain.Controls.Add(this.label7);
            this.pnelMain.Controls.Add(this.label6);
            this.pnelMain.Controls.Add(this.label4);
            this.pnelMain.Controls.Add(this.label5);
            this.pnelMain.Controls.Add(this.butCancel);
            this.pnelMain.Controls.Add(this.label8);
            this.pnelMain.Controls.Add(this.label3);
            this.pnelMain.Controls.Add(this.label2);
            this.pnelMain.Size = new System.Drawing.Size(478, 288);
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
            this.myEditTextBox1.Location = new System.Drawing.Point(366, 5);
            this.myEditTextBox1.Name = "myEditTextBox1";
            this.myEditTextBox1.RegexDesc = "";
            this.myEditTextBox1.RegexRule = "";
            this.myEditTextBox1.ShowField = "f_id";
            this.myEditTextBox1.ShowFieldValue = null;
            this.myEditTextBox1.Size = new System.Drawing.Size(100, 21);
            this.myEditTextBox1.TabIndex = 1;
            this.myEditTextBox1.TableName = null;
            this.myEditTextBox1.Visible = false;
            // 
            // myEditTextBox2
            // 
            this.myEditTextBox2.Datarow = null;
            this.myEditTextBox2.EditField = "F_AMOUNT";
            this.myEditTextBox2.EditFieldType = System.Data.SqlDbType.Float;
            this.myEditTextBox2.FieldMaxLength = 0;
            this.myEditTextBox2.FieldMinLength = 0;
            this.myEditTextBox2.FieldValue = "0";
            this.myEditTextBox2.iapplication = null;
            this.myEditTextBox2.IsCanEdit = true;
            this.myEditTextBox2.IsIdentified = false;
            this.myEditTextBox2.IsKeyField = false;
            this.myEditTextBox2.IsValid = true;
            this.myEditTextBox2.Location = new System.Drawing.Point(64, 42);
            this.myEditTextBox2.Name = "myEditTextBox2";
            this.myEditTextBox2.RegexDesc = "";
            this.myEditTextBox2.RegexRule = "";
            this.myEditTextBox2.ShowField = "F_AMOUNT";
            this.myEditTextBox2.ShowFieldValue = null;
            this.myEditTextBox2.Size = new System.Drawing.Size(100, 21);
            this.myEditTextBox2.TabIndex = 2;
            this.myEditTextBox2.TableName = null;
            this.myEditTextBox2.Text = "0";
            // 
            // myOrderNumber
            // 
            this.myOrderNumber.Datarow = null;
            this.myOrderNumber.EditField = "F_ORDERNUMBER";
            this.myOrderNumber.EditFieldType = System.Data.SqlDbType.VarChar;
            this.myOrderNumber.FieldMaxLength = 0;
            this.myOrderNumber.FieldMinLength = 0;
            this.myOrderNumber.FieldValue = "";
            this.myOrderNumber.iapplication = null;
            this.myOrderNumber.IsCanEdit = false;
            this.myOrderNumber.IsIdentified = false;
            this.myOrderNumber.IsKeyField = false;
            this.myOrderNumber.IsValid = true;
            this.myOrderNumber.Location = new System.Drawing.Point(64, 6);
            this.myOrderNumber.Name = "myOrderNumber";
            this.myOrderNumber.RegexDesc = "";
            this.myOrderNumber.RegexRule = "";
            this.myOrderNumber.ShowField = "F_ORDERNUMBER";
            this.myOrderNumber.ShowFieldValue = null;
            this.myOrderNumber.Size = new System.Drawing.Size(100, 21);
            this.myOrderNumber.TabIndex = 0;
            this.myOrderNumber.TableName = null;
            // 
            // myEditComboBox1
            // 
            this.myEditComboBox1.Datarow = null;
            this.myEditComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.myEditComboBox1.EditField = "F_STATE";
            this.myEditComboBox1.EditFieldType = System.Data.SqlDbType.Int;
            this.myEditComboBox1.FieldMaxLength = 0;
            this.myEditComboBox1.FieldMinLength = 0;
            this.myEditComboBox1.FieldValue = "";
            this.myEditComboBox1.FormattingEnabled = true;
            this.myEditComboBox1.iapplication = null;
            this.myEditComboBox1.IsCanEdit = true;
            this.myEditComboBox1.IsIdentified = false;
            this.myEditComboBox1.IsKeyField = false;
            this.myEditComboBox1.IsValid = true;
            this.myEditComboBox1.ItemsSql = "SELECT f_value as f_state,f_name from t_base_dict where f_code=\'CM_OSTATE\'";
            this.myEditComboBox1.Location = new System.Drawing.Point(64, 259);
            this.myEditComboBox1.Name = "myEditComboBox1";
            this.myEditComboBox1.RegexDesc = "";
            this.myEditComboBox1.RegexRule = "";
            this.myEditComboBox1.ShowField = "f_name";
            this.myEditComboBox1.ShowFieldValue = "";
            this.myEditComboBox1.Size = new System.Drawing.Size(90, 20);
            this.myEditComboBox1.TabIndex = 7;
            this.myEditComboBox1.TableName = "";
            // 
            // butOk
            // 
            this.butOk.Location = new System.Drawing.Point(303, 256);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(75, 23);
            this.butOk.TabIndex = 8;
            this.butOk.Text = "保存";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 74;
            this.label1.Text = "申请单号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 76;
            this.label4.Text = "预算金额:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 73;
            this.label5.Text = "部门";
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(384, 257);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 9;
            this.butCancel.Text = "离开";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 72;
            this.label3.Text = "创建人";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 75;
            this.label2.Text = "状态:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 76;
            this.label6.Text = "采购原因:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 76;
            this.label7.Text = "采购详情:";
            // 
            // myEditTextBox3
            // 
            this.myEditTextBox3.Datarow = null;
            this.myEditTextBox3.EditField = "f_reasion";
            this.myEditTextBox3.EditFieldType = System.Data.SqlDbType.VarChar;
            this.myEditTextBox3.FieldMaxLength = 500;
            this.myEditTextBox3.FieldMinLength = 0;
            this.myEditTextBox3.FieldValue = "";
            this.myEditTextBox3.iapplication = null;
            this.myEditTextBox3.IsCanEdit = true;
            this.myEditTextBox3.IsIdentified = false;
            this.myEditTextBox3.IsKeyField = false;
            this.myEditTextBox3.IsValid = true;
            this.myEditTextBox3.Location = new System.Drawing.Point(64, 78);
            this.myEditTextBox3.MaxLength = 1000;
            this.myEditTextBox3.Multiline = true;
            this.myEditTextBox3.Name = "myEditTextBox3";
            this.myEditTextBox3.RegexDesc = "";
            this.myEditTextBox3.RegexRule = "";
            this.myEditTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.myEditTextBox3.ShowField = "f_reasion";
            this.myEditTextBox3.ShowFieldValue = null;
            this.myEditTextBox3.Size = new System.Drawing.Size(402, 47);
            this.myEditTextBox3.TabIndex = 5;
            this.myEditTextBox3.TableName = null;
            // 
            // myEditTextBox4
            // 
            this.myEditTextBox4.Datarow = null;
            this.myEditTextBox4.EditField = "f_desc";
            this.myEditTextBox4.EditFieldType = System.Data.SqlDbType.VarChar;
            this.myEditTextBox4.FieldMaxLength = 500;
            this.myEditTextBox4.FieldMinLength = 0;
            this.myEditTextBox4.FieldValue = "";
            this.myEditTextBox4.iapplication = null;
            this.myEditTextBox4.IsCanEdit = true;
            this.myEditTextBox4.IsIdentified = false;
            this.myEditTextBox4.IsKeyField = false;
            this.myEditTextBox4.IsValid = true;
            this.myEditTextBox4.Location = new System.Drawing.Point(64, 128);
            this.myEditTextBox4.MaxLength = 1000;
            this.myEditTextBox4.Multiline = true;
            this.myEditTextBox4.Name = "myEditTextBox4";
            this.myEditTextBox4.RegexDesc = "";
            this.myEditTextBox4.RegexRule = "";
            this.myEditTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.myEditTextBox4.ShowField = "f_desc";
            this.myEditTextBox4.ShowFieldValue = null;
            this.myEditTextBox4.Size = new System.Drawing.Size(402, 122);
            this.myEditTextBox4.TabIndex = 6;
            this.myEditTextBox4.TableName = null;
            // 
            // myUserName
            // 
            this.myUserName.Datarow = null;
            this.myUserName.EditField = "F_CREATENAME";
            this.myUserName.EditFieldType = System.Data.SqlDbType.VarChar;
            this.myUserName.FieldMaxLength = 0;
            this.myUserName.FieldMinLength = 0;
            this.myUserName.FieldValue = "";
            this.myUserName.iapplication = null;
            this.myUserName.IsCanEdit = true;
            this.myUserName.IsIdentified = false;
            this.myUserName.IsKeyField = false;
            this.myUserName.IsValid = true;
            this.myUserName.Location = new System.Drawing.Point(219, 43);
            this.myUserName.Name = "myUserName";
            this.myUserName.RegexDesc = "";
            this.myUserName.RegexRule = "";
            this.myUserName.ShowField = "f_createname";
            this.myUserName.ShowFieldValue = null;
            this.myUserName.Size = new System.Drawing.Size(100, 21);
            this.myUserName.TabIndex = 3;
            this.myUserName.TableName = null;
            // 
            // myAgencyName
            // 
            this.myAgencyName.Datarow = null;
            this.myAgencyName.EditField = "F_AGENCYNAME";
            this.myAgencyName.EditFieldType = System.Data.SqlDbType.VarChar;
            this.myAgencyName.FieldMaxLength = 0;
            this.myAgencyName.FieldMinLength = 0;
            this.myAgencyName.FieldValue = "";
            this.myAgencyName.iapplication = null;
            this.myAgencyName.IsCanEdit = true;
            this.myAgencyName.IsIdentified = false;
            this.myAgencyName.IsKeyField = false;
            this.myAgencyName.IsValid = true;
            this.myAgencyName.Location = new System.Drawing.Point(366, 42);
            this.myAgencyName.Name = "myAgencyName";
            this.myAgencyName.RegexDesc = "";
            this.myAgencyName.RegexRule = "";
            this.myAgencyName.ShowField = "F_AGENCYNAME";
            this.myAgencyName.ShowFieldValue = null;
            this.myAgencyName.Size = new System.Drawing.Size(100, 21);
            this.myAgencyName.TabIndex = 4;
            this.myAgencyName.TableName = null;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 72;
            this.label8.Text = "完成时间";
            // 
            // FormBuyApplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 318);
            this.Name = "FormBuyApplay";
            this.Table = "CK_BUYORDER";
            this.Text = "采购申请单";
            this.pnelMain.ResumeLayout(false);
            this.pnelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Rock.Interface.MyEditTextBox myEditTextBox1;
        private Rock.Interface.MyEditTextBox myEditTextBox2;
        private Rock.Interface.MyEditTextBox myOrderNumber;
        private Rock.Interface.MyEditComboBox myEditComboBox1;
        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Rock.Interface.MyEditTextBox myEditTextBox4;
        private Rock.Interface.MyEditTextBox myEditTextBox3;
        private Rock.Interface.MyEditTextBox myAgencyName;
        private Rock.Interface.MyEditTextBox myUserName;
        private System.Windows.Forms.Label label8;
    }
}