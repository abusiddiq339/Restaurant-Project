
namespace WAMicroProject
{
    partial class ViewBill
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
            this.CmbBillNo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVBillDetails = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.DGVItemDetails = new System.Windows.Forms.DataGridView();
            this.BtnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBillDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVItemDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Bill Number";
            // 
            // CmbBillNo
            // 
            this.CmbBillNo.FormattingEnabled = true;
            this.CmbBillNo.Location = new System.Drawing.Point(361, 37);
            this.CmbBillNo.Name = "CmbBillNo";
            this.CmbBillNo.Size = new System.Drawing.Size(121, 24);
            this.CmbBillNo.TabIndex = 1;
            this.CmbBillNo.SelectedIndexChanged += new System.EventHandler(this.CmbBillNo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bill Details";
            // 
            // DGVBillDetails
            // 
            this.DGVBillDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBillDetails.Location = new System.Drawing.Point(23, 111);
            this.DGVBillDetails.Name = "DGVBillDetails";
            this.DGVBillDetails.RowHeadersWidth = 51;
            this.DGVBillDetails.RowTemplate.Height = 24;
            this.DGVBillDetails.Size = new System.Drawing.Size(734, 108);
            this.DGVBillDetails.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item Details";
            // 
            // DGVItemDetails
            // 
            this.DGVItemDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVItemDetails.Location = new System.Drawing.Point(23, 270);
            this.DGVItemDetails.Name = "DGVItemDetails";
            this.DGVItemDetails.RowHeadersWidth = 51;
            this.DGVItemDetails.RowTemplate.Height = 24;
            this.DGVItemDetails.Size = new System.Drawing.Size(734, 150);
            this.DGVItemDetails.TabIndex = 5;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(341, 436);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(93, 32);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.Text = "CLOSE";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // ViewBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.DGVItemDetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGVBillDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbBillNo);
            this.Controls.Add(this.label1);
            this.Name = "ViewBill";
            this.Text = "ViewBill";
            this.Load += new System.EventHandler(this.ViewBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVBillDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVItemDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbBillNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVBillDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGVItemDetails;
        private System.Windows.Forms.Button BtnClose;
    }
}