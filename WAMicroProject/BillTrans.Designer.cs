
namespace WAMicroProject
{
    partial class BillTrans
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.TxtTPrice = new System.Windows.Forms.TextBox();
            this.CmbSelectItem = new System.Windows.Forms.ComboBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.DGVBillTrans = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBillTrans)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price Is";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Price Is";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(126, 73);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.ReadOnly = true;
            this.TxtPrice.Size = new System.Drawing.Size(121, 22);
            this.TxtPrice.TabIndex = 4;
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Location = new System.Drawing.Point(126, 106);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(121, 22);
            this.TxtQuantity.TabIndex = 5;
            this.TxtQuantity.TextChanged += new System.EventHandler(this.TxtQuantity_TextChanged);
            // 
            // TxtTPrice
            // 
            this.TxtTPrice.Location = new System.Drawing.Point(126, 138);
            this.TxtTPrice.Name = "TxtTPrice";
            this.TxtTPrice.ReadOnly = true;
            this.TxtTPrice.Size = new System.Drawing.Size(121, 22);
            this.TxtTPrice.TabIndex = 6;
            // 
            // CmbSelectItem
            // 
            this.CmbSelectItem.FormattingEnabled = true;
            this.CmbSelectItem.Location = new System.Drawing.Point(126, 39);
            this.CmbSelectItem.Name = "CmbSelectItem";
            this.CmbSelectItem.Size = new System.Drawing.Size(121, 24);
            this.CmbSelectItem.TabIndex = 7;
            this.CmbSelectItem.SelectedIndexChanged += new System.EventHandler(this.CmbSelectItem_SelectedIndexChanged);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(63, 188);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 28);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "ADD";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(144, 188);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 28);
            this.BtnOk.TabIndex = 9;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // DGVBillTrans
            // 
            this.DGVBillTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBillTrans.Location = new System.Drawing.Point(270, 39);
            this.DGVBillTrans.Name = "DGVBillTrans";
            this.DGVBillTrans.RowHeadersWidth = 51;
            this.DGVBillTrans.RowTemplate.Height = 24;
            this.DGVBillTrans.Size = new System.Drawing.Size(612, 177);
            this.DGVBillTrans.TabIndex = 10;
            // 
            // BillTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 241);
            this.Controls.Add(this.DGVBillTrans);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.CmbSelectItem);
            this.Controls.Add(this.TxtTPrice);
            this.Controls.Add(this.TxtQuantity);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BillTrans";
            this.Text = "BillTrans";
            this.Load += new System.EventHandler(this.BillTrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVBillTrans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.TextBox TxtQuantity;
        private System.Windows.Forms.TextBox TxtTPrice;
        private System.Windows.Forms.ComboBox CmbSelectItem;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.DataGridView DGVBillTrans;
    }
}