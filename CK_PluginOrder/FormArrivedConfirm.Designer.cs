namespace CK_PluginOrder
{
    partial class FormArrivedConfirm
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
            this.myListProduct = new Rock.Interface.MyEditListView();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdMaxRes
            // 
            this.cmdMaxRes.Location = new System.Drawing.Point(583, 3);
            // 
            // cmdMin
            // 
            this.cmdMin.Location = new System.Drawing.Point(558, 3);
            // 
            // titleCaption
            // 
            this.titleCaption.Size = new System.Drawing.Size(628, 26);
            this.titleCaption.Text = "FormArrivedConfirm";
            // 
            // pnelMain
            // 
            this.pnelMain.Controls.Add(this.button2);
            this.pnelMain.Controls.Add(this.button1);
            this.pnelMain.Controls.Add(this.myListProduct);
            this.pnelMain.Controls.Add(this.label4);
            this.pnelMain.Size = new System.Drawing.Size(626, 270);
            // 
            // myListProduct
            // 
            this.myListProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myListProduct.CheckBoxes = true;
            this.myListProduct.Datarow = null;
            this.myListProduct.EditField = "f_products";
            this.myListProduct.EditFieldType = System.Data.SqlDbType.VarChar;
            this.myListProduct.FieldMaxLength = 0;
            this.myListProduct.FieldMinLength = 0;
            this.myListProduct.FieldValue = "";
            this.myListProduct.FullRowSelect = true;
            this.myListProduct.GridLines = true;
            this.myListProduct.iapplication = null;
            this.myListProduct.IsCanEdit = true;
            this.myListProduct.IsIdentified = false;
            this.myListProduct.IsKeyField = false;
            this.myListProduct.IsValid = true;
            this.myListProduct.ItemShowField = "f_productsname";
            this.myListProduct.ItemsSql = "";
            this.myListProduct.ListCaptions = "采购商品,采购数量,采购单价,商品编码";
            this.myListProduct.ListFields = "f_productsname,f_count,f_unitprice,f_code";
            this.myListProduct.Location = new System.Drawing.Point(12, 28);
            this.myListProduct.Name = "myListProduct";
            this.myListProduct.RegexDesc = "";
            this.myListProduct.RegexRule = "";
            this.myListProduct.ShowField = "f_products";
            this.myListProduct.ShowFieldValue = "";
            this.myListProduct.Size = new System.Drawing.Size(607, 195);
            this.myListProduct.TabIndex = 15;
            this.myListProduct.TableName = "";
            this.myListProduct.UseCompatibleStateImageBehavior = false;
            this.myListProduct.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "采购清单";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "到货";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(541, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "生成标签";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormArrivedConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 300);
            this.Name = "FormArrivedConfirm";
            this.Text = "FormArrivedConfirm";
            this.pnelMain.ResumeLayout(false);
            this.pnelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Rock.Interface.MyEditListView myListProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}