
namespace WAMicroProject
{
    partial class ViewUser
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
            this.DGVViewUser = new System.Windows.Forms.DataGridView();
            this.BtnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVViewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVViewUser
            // 
            this.DGVViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVViewUser.Location = new System.Drawing.Point(12, 12);
            this.DGVViewUser.Name = "DGVViewUser";
            this.DGVViewUser.RowHeadersWidth = 51;
            this.DGVViewUser.RowTemplate.Height = 24;
            this.DGVViewUser.Size = new System.Drawing.Size(496, 306);
            this.DGVViewUser.TabIndex = 0;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(219, 340);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 39);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "CLOSE";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // ViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 391);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.DGVViewUser);
            this.Name = "ViewUser";
            this.Text = "ViewUser";
            this.Load += new System.EventHandler(this.ViewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVViewUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVViewUser;
        private System.Windows.Forms.Button BtnClose;
    }
}