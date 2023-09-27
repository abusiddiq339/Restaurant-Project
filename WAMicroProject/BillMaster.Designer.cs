
namespace WAMicroProject
{
    partial class BillMaster
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtBillNumber = new System.Windows.Forms.TextBox();
            this.TxtBillDate = new System.Windows.Forms.TextBox();
            this.TxtBillAmount = new System.Windows.Forms.TextBox();
            this.TxtSGST = new System.Windows.Forms.TextBox();
            this.TxtCGST = new System.Windows.Forms.TextBox();
            this.TxtEnterDiscount = new System.Windows.Forms.TextBox();
            this.txtTotalBill = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnAddItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Bill Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bill Date Is";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bill Amount Is";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "SGST Is";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "CGST Is";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Enter Discount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total Bill";
            // 
            // TxtBillNumber
            // 
            this.TxtBillNumber.Location = new System.Drawing.Point(166, 41);
            this.TxtBillNumber.Name = "TxtBillNumber";
            this.TxtBillNumber.Size = new System.Drawing.Size(100, 22);
            this.TxtBillNumber.TabIndex = 7;
            // 
            // TxtBillDate
            // 
            this.TxtBillDate.Location = new System.Drawing.Point(166, 69);
            this.TxtBillDate.Name = "TxtBillDate";
            this.TxtBillDate.Size = new System.Drawing.Size(100, 22);
            this.TxtBillDate.TabIndex = 8;
            // 
            // TxtBillAmount
            // 
            this.TxtBillAmount.Location = new System.Drawing.Point(166, 97);
            this.TxtBillAmount.Name = "TxtBillAmount";
            this.TxtBillAmount.Size = new System.Drawing.Size(100, 22);
            this.TxtBillAmount.TabIndex = 9;
            // 
            // TxtSGST
            // 
            this.TxtSGST.Location = new System.Drawing.Point(166, 125);
            this.TxtSGST.Name = "TxtSGST";
            this.TxtSGST.Size = new System.Drawing.Size(100, 22);
            this.TxtSGST.TabIndex = 10;
            // 
            // TxtCGST
            // 
            this.TxtCGST.Location = new System.Drawing.Point(166, 153);
            this.TxtCGST.Name = "TxtCGST";
            this.TxtCGST.Size = new System.Drawing.Size(100, 22);
            this.TxtCGST.TabIndex = 11;
            // 
            // TxtEnterDiscount
            // 
            this.TxtEnterDiscount.Location = new System.Drawing.Point(166, 181);
            this.TxtEnterDiscount.Name = "TxtEnterDiscount";
            this.TxtEnterDiscount.Size = new System.Drawing.Size(100, 22);
            this.TxtEnterDiscount.TabIndex = 12;
            this.TxtEnterDiscount.TextChanged += new System.EventHandler(this.TxtEnterDiscount_TextChanged);
            // 
            // txtTotalBill
            // 
            this.txtTotalBill.Location = new System.Drawing.Point(166, 209);
            this.txtTotalBill.Name = "txtTotalBill";
            this.txtTotalBill.Size = new System.Drawing.Size(100, 22);
            this.txtTotalBill.TabIndex = 13;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(35, 271);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(88, 39);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "SAVE";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(134, 271);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(88, 39);
            this.BtnClear.TabIndex = 15;
            this.BtnClear.Text = "CLEAR";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(228, 271);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(88, 39);
            this.BtnClose.TabIndex = 16;
            this.BtnClose.Text = "CLOSE";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnAddItems
            // 
            this.BtnAddItems.Location = new System.Drawing.Point(283, 41);
            this.BtnAddItems.Name = "BtnAddItems";
            this.BtnAddItems.Size = new System.Drawing.Size(101, 34);
            this.BtnAddItems.TabIndex = 17;
            this.BtnAddItems.Text = "Add Items";
            this.BtnAddItems.UseVisualStyleBackColor = true;
            this.BtnAddItems.Click += new System.EventHandler(this.BtnAddItems_Click);
            // 
            // BillMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 361);
            this.Controls.Add(this.BtnAddItems);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.txtTotalBill);
            this.Controls.Add(this.TxtEnterDiscount);
            this.Controls.Add(this.TxtCGST);
            this.Controls.Add(this.TxtSGST);
            this.Controls.Add(this.TxtBillAmount);
            this.Controls.Add(this.TxtBillDate);
            this.Controls.Add(this.TxtBillNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BillMaster";
            this.Text = "BillMaster";
            this.Load += new System.EventHandler(this.BillMaster_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtBillNumber;
        private System.Windows.Forms.TextBox TxtBillDate;
        private System.Windows.Forms.TextBox TxtBillAmount;
        private System.Windows.Forms.TextBox TxtSGST;
        private System.Windows.Forms.TextBox TxtCGST;
        private System.Windows.Forms.TextBox TxtEnterDiscount;
        private System.Windows.Forms.TextBox txtTotalBill;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnAddItems;
    }
}