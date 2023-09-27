
namespace WAMicroProject
{
    partial class MDIParent1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ItemsSM = new System.Windows.Forms.ToolStripMenuItem();
            this.AddItemSM = new System.Windows.Forms.ToolStripMenuItem();
            this.EditItemSM = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteItemSM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitSM = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewUserSM = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteUserSM = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePasswordSM = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewUserSM = new System.Windows.Forms.ToolStripMenuItem();
            this.BillSM = new System.Windows.Forms.ToolStripMenuItem();
            this.NewBillSM = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewBillSM = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemsSM,
            this.userToolStripMenuItem,
            this.BillSM});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1785, 30);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            
            // 
            // ItemsSM
            // 
            this.ItemsSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddItemSM,
            this.EditItemSM,
            this.DeleteItemSM,
            this.toolStripMenuItem1,
            this.ExitSM});
            this.ItemsSM.Name = "ItemsSM";
            this.ItemsSM.Size = new System.Drawing.Size(59, 26);
            this.ItemsSM.Text = "Items";
            // 
            // AddItemSM
            // 
            this.AddItemSM.Name = "AddItemSM";
            this.AddItemSM.Size = new System.Drawing.Size(170, 26);
            this.AddItemSM.Text = "Add Item";
            this.AddItemSM.Click += new System.EventHandler(this.addItemToolStripMenuItem_Click);
            // 
            // EditItemSM
            // 
            this.EditItemSM.Name = "EditItemSM";
            this.EditItemSM.Size = new System.Drawing.Size(170, 26);
            this.EditItemSM.Text = "Edit Item";
            this.EditItemSM.Click += new System.EventHandler(this.EditItemSM_Click);
            // 
            // DeleteItemSM
            // 
            this.DeleteItemSM.Name = "DeleteItemSM";
            this.DeleteItemSM.Size = new System.Drawing.Size(170, 26);
            this.DeleteItemSM.Text = "Delete Item";
            this.DeleteItemSM.Click += new System.EventHandler(this.DeleteItemSM_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(167, 6);
            // 
            // ExitSM
            // 
            this.ExitSM.Name = "ExitSM";
            this.ExitSM.Size = new System.Drawing.Size(170, 26);
            this.ExitSM.Text = "Exit";
            this.ExitSM.Click += new System.EventHandler(this.ExitSM_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewUserSM,
            this.DeleteUserSM,
            this.ChangePasswordSM,
            this.ViewUserSM});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(52, 26);
            this.userToolStripMenuItem.Text = "User";
           
            // 
            // AddNewUserSM
            // 
            this.AddNewUserSM.Name = "AddNewUserSM";
            this.AddNewUserSM.Size = new System.Drawing.Size(207, 26);
            this.AddNewUserSM.Text = "Add New User";
            this.AddNewUserSM.Click += new System.EventHandler(this.AddNewUserSM_Click);
            // 
            // DeleteUserSM
            // 
            this.DeleteUserSM.Name = "DeleteUserSM";
            this.DeleteUserSM.Size = new System.Drawing.Size(207, 26);
            this.DeleteUserSM.Text = "Delete User";
            this.DeleteUserSM.Click += new System.EventHandler(this.DeleteUserSM_Click);
            // 
            // ChangePasswordSM
            // 
            this.ChangePasswordSM.Name = "ChangePasswordSM";
            this.ChangePasswordSM.Size = new System.Drawing.Size(207, 26);
            this.ChangePasswordSM.Text = "Change Password";
            this.ChangePasswordSM.Click += new System.EventHandler(this.ChangePasswordSM_Click);
            // 
            // ViewUserSM
            // 
            this.ViewUserSM.Name = "ViewUserSM";
            this.ViewUserSM.Size = new System.Drawing.Size(207, 26);
            this.ViewUserSM.Text = "View User";
            this.ViewUserSM.Click += new System.EventHandler(this.ViewUserSM_Click);
            // 
            // BillSM
            // 
            this.BillSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewBillSM,
            this.ViewBillSM});
            this.BillSM.Name = "BillSM";
            this.BillSM.Size = new System.Drawing.Size(44, 26);
            this.BillSM.Text = "Bill";
            // 
            // NewBillSM
            // 
            this.NewBillSM.Name = "NewBillSM";
            this.NewBillSM.Size = new System.Drawing.Size(149, 26);
            this.NewBillSM.Text = "New Bill";
            this.NewBillSM.Click += new System.EventHandler(this.NewBillSM_Click);
            // 
            // ViewBillSM
            // 
            this.ViewBillSM.Name = "ViewBillSM";
            this.ViewBillSM.Size = new System.Drawing.Size(149, 26);
            this.ViewBillSM.Text = "View Bill";
            this.ViewBillSM.Click += new System.EventHandler(this.ViewBillSM_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WAMicroProject.Properties.Resources.th;
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1848, 871);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1785, 726);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDIParent1";
            this.Text = "MDIParent1";
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ItemsSM;
        private System.Windows.Forms.ToolStripMenuItem AddItemSM;
        private System.Windows.Forms.ToolStripMenuItem EditItemSM;
        private System.Windows.Forms.ToolStripMenuItem DeleteItemSM;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExitSM;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewUserSM;
        private System.Windows.Forms.ToolStripMenuItem DeleteUserSM;
        private System.Windows.Forms.ToolStripMenuItem ChangePasswordSM;
        private System.Windows.Forms.ToolStripMenuItem ViewUserSM;
        private System.Windows.Forms.ToolStripMenuItem BillSM;
        private System.Windows.Forms.ToolStripMenuItem NewBillSM;
        private System.Windows.Forms.ToolStripMenuItem ViewBillSM;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}



