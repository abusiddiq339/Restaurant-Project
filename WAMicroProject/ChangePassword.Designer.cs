
namespace WAMicroProject
{
    partial class ChangePassword
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
            this.POldPassword = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PHintQuestion = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbUHQ = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtUHQReEnter = new System.Windows.Forms.TextBox();
            this.TxtUHQNPassword = new System.Windows.Forms.TextBox();
            this.TxtUHQHAnswer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUOPReEnter = new System.Windows.Forms.TextBox();
            this.TxtUOPNewPassword = new System.Windows.Forms.TextBox();
            this.TxtUOPOldPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RBOldPassword = new System.Windows.Forms.RadioButton();
            this.RBHQuestion = new System.Windows.Forms.RadioButton();
            this.POldPassword.SuspendLayout();
            this.PHintQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // POldPassword
            // 
            this.POldPassword.Controls.Add(this.BtnClose);
            this.POldPassword.Controls.Add(this.BtnSubmit);
            this.POldPassword.Controls.Add(this.label4);
            this.POldPassword.Controls.Add(this.label3);
            this.POldPassword.Controls.Add(this.label2);
            this.POldPassword.Controls.Add(this.TxtUOPReEnter);
            this.POldPassword.Controls.Add(this.TxtUOPNewPassword);
            this.POldPassword.Controls.Add(this.TxtUOPOldPassword);
            this.POldPassword.Location = new System.Drawing.Point(13, 108);
            this.POldPassword.Name = "POldPassword";
            this.POldPassword.Size = new System.Drawing.Size(364, 293);
            this.POldPassword.TabIndex = 0;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(166, 172);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 7;
            this.BtnClose.Text = "CLOSE";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(62, 172);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(75, 23);
            this.BtnSubmit.TabIndex = 6;
            this.BtnSubmit.Text = "SUBMIT";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Re-Enter Password";
            // 
            // PHintQuestion
            // 
            this.PHintQuestion.Controls.Add(this.label8);
            this.PHintQuestion.Controls.Add(this.CmbUHQ);
            this.PHintQuestion.Controls.Add(this.button1);
            this.PHintQuestion.Controls.Add(this.button2);
            this.PHintQuestion.Controls.Add(this.label5);
            this.PHintQuestion.Controls.Add(this.label6);
            this.PHintQuestion.Controls.Add(this.label7);
            this.PHintQuestion.Controls.Add(this.TxtUHQReEnter);
            this.PHintQuestion.Controls.Add(this.TxtUHQNPassword);
            this.PHintQuestion.Controls.Add(this.TxtUHQHAnswer);
            this.PHintQuestion.Location = new System.Drawing.Point(12, 105);
            this.PHintQuestion.Name = "PHintQuestion";
            this.PHintQuestion.Size = new System.Drawing.Size(364, 293);
            this.PHintQuestion.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Select Hint Question";
            // 
            // CmbUHQ
            // 
            this.CmbUHQ.FormattingEnabled = true;
            this.CmbUHQ.Items.AddRange(new object[] {
            "Whats Your Favourite Color",
            "What\'s Your Pet Name",
            "What\'s Your Favourite Hobby"});
            this.CmbUHQ.Location = new System.Drawing.Point(165, 43);
            this.CmbUHQ.Name = "CmbUHQ";
            this.CmbUHQ.Size = new System.Drawing.Size(154, 24);
            this.CmbUHQ.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "CLOSE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(71, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "SUBMIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Re-Enter Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Enter New Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Enter Hint Answer";
            // 
            // TxtUHQReEnter
            // 
            this.TxtUHQReEnter.Location = new System.Drawing.Point(165, 154);
            this.TxtUHQReEnter.Name = "TxtUHQReEnter";
            this.TxtUHQReEnter.Size = new System.Drawing.Size(154, 22);
            this.TxtUHQReEnter.TabIndex = 10;
            this.TxtUHQReEnter.Leave += new System.EventHandler(this.TxtUHQReEnter_Leave);
            // 
            // TxtUHQNPassword
            // 
            this.TxtUHQNPassword.Location = new System.Drawing.Point(165, 119);
            this.TxtUHQNPassword.Name = "TxtUHQNPassword";
            this.TxtUHQNPassword.Size = new System.Drawing.Size(154, 22);
            this.TxtUHQNPassword.TabIndex = 9;
            // 
            // TxtUHQHAnswer
            // 
            this.TxtUHQHAnswer.Location = new System.Drawing.Point(165, 82);
            this.TxtUHQHAnswer.Name = "TxtUHQHAnswer";
            this.TxtUHQHAnswer.Size = new System.Drawing.Size(154, 22);
            this.TxtUHQHAnswer.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Old Password";
            // 
            // TxtUOPReEnter
            // 
            this.TxtUOPReEnter.Location = new System.Drawing.Point(156, 108);
            this.TxtUOPReEnter.Name = "TxtUOPReEnter";
            this.TxtUOPReEnter.Size = new System.Drawing.Size(154, 22);
            this.TxtUOPReEnter.TabIndex = 2;
            // 
            // TxtUOPNewPassword
            // 
            this.TxtUOPNewPassword.Location = new System.Drawing.Point(156, 73);
            this.TxtUOPNewPassword.Name = "TxtUOPNewPassword";
            this.TxtUOPNewPassword.Size = new System.Drawing.Size(154, 22);
            this.TxtUOPNewPassword.TabIndex = 1;
            // 
            // TxtUOPOldPassword
            // 
            this.TxtUOPOldPassword.Location = new System.Drawing.Point(156, 36);
            this.TxtUOPOldPassword.Name = "TxtUOPOldPassword";
            this.TxtUOPOldPassword.Size = new System.Drawing.Size(154, 22);
            this.TxtUOPOldPassword.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "SELECT TYPE";
            // 
            // RBOldPassword
            // 
            this.RBOldPassword.AutoSize = true;
            this.RBOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBOldPassword.Location = new System.Drawing.Point(12, 81);
            this.RBOldPassword.Name = "RBOldPassword";
            this.RBOldPassword.Size = new System.Drawing.Size(174, 21);
            this.RBOldPassword.TabIndex = 3;
            this.RBOldPassword.TabStop = true;
            this.RBOldPassword.Text = "Using Old Password";
            this.RBOldPassword.UseVisualStyleBackColor = true;
            this.RBOldPassword.CheckedChanged += new System.EventHandler(this.RBOldPassword_CheckedChanged);
            // 
            // RBHQuestion
            // 
            this.RBHQuestion.AutoSize = true;
            this.RBHQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBHQuestion.Location = new System.Drawing.Point(192, 81);
            this.RBHQuestion.Name = "RBHQuestion";
            this.RBHQuestion.Size = new System.Drawing.Size(174, 21);
            this.RBHQuestion.TabIndex = 4;
            this.RBHQuestion.TabStop = true;
            this.RBHQuestion.Text = "Using Hint Question";
            this.RBHQuestion.UseVisualStyleBackColor = true;
            this.RBHQuestion.CheckedChanged += new System.EventHandler(this.RBHQuestion_CheckedChanged);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 413);
            this.Controls.Add(this.RBHQuestion);
            this.Controls.Add(this.RBOldPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PHintQuestion);
            this.Controls.Add(this.POldPassword);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.POldPassword.ResumeLayout(false);
            this.POldPassword.PerformLayout();
            this.PHintQuestion.ResumeLayout(false);
            this.PHintQuestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel POldPassword;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUOPReEnter;
        private System.Windows.Forms.TextBox TxtUOPNewPassword;
        private System.Windows.Forms.TextBox TxtUOPOldPassword;
        private System.Windows.Forms.Panel PHintQuestion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CmbUHQ;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtUHQReEnter;
        private System.Windows.Forms.TextBox TxtUHQNPassword;
        private System.Windows.Forms.TextBox TxtUHQHAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RBOldPassword;
        private System.Windows.Forms.RadioButton RBHQuestion;
    }
}