
namespace WAMicroProject
{
    partial class CreateUser
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
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtConfirm = new System.Windows.Forms.TextBox();
            this.TxtFName = new System.Windows.Forms.TextBox();
            this.TxtLName = new System.Windows.Forms.TextBox();
            this.TxtHAnswer = new System.Windows.Forms.TextBox();
            this.CmbHQuestion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(27, 330);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(117, 59);
            this.BtnCreate.TabIndex = 0;
            this.BtnCreate.Text = "CREATE";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(160, 330);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(117, 59);
            this.BtnClear.TabIndex = 1;
            this.BtnClear.Text = "CLEAR";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(292, 330);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(117, 59);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "CLOSE";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirm Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enter First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Enter Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Select Hint Question";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Enter Hint Answer";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(176, 18);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(233, 22);
            this.TxtUsername.TabIndex = 10;
            this.TxtUsername.Click += new System.EventHandler(this.CreateUser_Click);
            this.TxtUsername.Leave += new System.EventHandler(this.CreateUser_Leave);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(176, 60);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(233, 22);
            this.TxtPassword.TabIndex = 11;
            this.TxtPassword.Click += new System.EventHandler(this.CreateUser_Click);
            this.TxtPassword.Leave += new System.EventHandler(this.CreateUser_Leave);
            // 
            // TxtConfirm
            // 
            this.TxtConfirm.Location = new System.Drawing.Point(176, 103);
            this.TxtConfirm.Name = "TxtConfirm";
            this.TxtConfirm.PasswordChar = '*';
            this.TxtConfirm.Size = new System.Drawing.Size(233, 22);
            this.TxtConfirm.TabIndex = 12;
            this.TxtConfirm.Leave += new System.EventHandler(this.TxtConfirm_Leave);
            // 
            // TxtFName
            // 
            this.TxtFName.Location = new System.Drawing.Point(176, 146);
            this.TxtFName.Name = "TxtFName";
            this.TxtFName.Size = new System.Drawing.Size(233, 22);
            this.TxtFName.TabIndex = 13;
            this.TxtFName.Click += new System.EventHandler(this.CreateUser_Click);
            this.TxtFName.Leave += new System.EventHandler(this.CreateUser_Leave);
            // 
            // TxtLName
            // 
            this.TxtLName.Location = new System.Drawing.Point(176, 185);
            this.TxtLName.Name = "TxtLName";
            this.TxtLName.Size = new System.Drawing.Size(233, 22);
            this.TxtLName.TabIndex = 14;
            this.TxtLName.Click += new System.EventHandler(this.CreateUser_Click);
            this.TxtLName.Leave += new System.EventHandler(this.CreateUser_Leave);
            // 
            // TxtHAnswer
            // 
            this.TxtHAnswer.Location = new System.Drawing.Point(176, 273);
            this.TxtHAnswer.Name = "TxtHAnswer";
            this.TxtHAnswer.Size = new System.Drawing.Size(233, 22);
            this.TxtHAnswer.TabIndex = 16;
            this.TxtHAnswer.Click += new System.EventHandler(this.CreateUser_Click);
            this.TxtHAnswer.Leave += new System.EventHandler(this.CreateUser_Leave);
            // 
            // CmbHQuestion
            // 
            this.CmbHQuestion.FormattingEnabled = true;
            this.CmbHQuestion.Items.AddRange(new object[] {
            "What\'s Your Favourite Color?",
            "What\'s Your Pet Name?",
            "What\'s Your Favourite Hobby "});
            this.CmbHQuestion.Location = new System.Drawing.Point(176, 231);
            this.CmbHQuestion.Name = "CmbHQuestion";
            this.CmbHQuestion.Size = new System.Drawing.Size(233, 24);
            this.CmbHQuestion.TabIndex = 17;
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 401);
            this.Controls.Add(this.CmbHQuestion);
            this.Controls.Add(this.TxtHAnswer);
            this.Controls.Add(this.TxtLName);
            this.Controls.Add(this.TxtFName);
            this.Controls.Add(this.TxtConfirm);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnCreate);
            this.Name = "CreateUser";
            this.Text = "CreateUser";
            this.Load += new System.EventHandler(this.CreateUser_Load);
            this.Click += new System.EventHandler(this.CreateUser_Click);
            this.Leave += new System.EventHandler(this.CreateUser_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtConfirm;
        private System.Windows.Forms.TextBox TxtFName;
        private System.Windows.Forms.TextBox TxtLName;
        private System.Windows.Forms.TextBox TxtHAnswer;
        private System.Windows.Forms.ComboBox CmbHQuestion;
    }
}