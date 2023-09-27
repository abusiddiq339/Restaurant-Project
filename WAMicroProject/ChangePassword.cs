using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WAMicroProject
{
    public partial class ChangePassword : Form
    {
        SqlConnection Con;
        SqlCommand Cmd;
        SqlDataReader DR;
        SqlParameter P1;
        SqlDataAdapter DA;
        DataSet DS;
        SqlCommandBuilder CB;
        string SqlConString;

        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

            SqlConString = "server=DESKTOP-8QI1UOV\\MASSERVER;User Id=sa;Password=masserver;Database=MicroProject";
            Con = new SqlConnection(SqlConString);
            if (RBOldPassword.Checked==default)
            {
                RBOldPassword.Checked = true;
                POldPassword.Visible = true;
                PHintQuestion.Visible = false;
            }
        }

        private void RBOldPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (RBOldPassword.Checked)
            {
                POldPassword.Visible = true;
                PHintQuestion.Visible = false;
            }
            else if (RBHQuestion.Checked)
            {
                POldPassword.Visible = false;
                PHintQuestion.Visible = true;
            }
        }

        private void RBHQuestion_CheckedChanged(object sender, EventArgs e)
        {
            if (RBHQuestion.Checked)
            {
                PHintQuestion.Visible = true;
                POldPassword.Visible = false;
            }
            else if(RBOldPassword.Checked)
            {
                PHintQuestion.Visible = false;
                POldPassword.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if(TxtUOPNewPassword.Text!=TxtUOPReEnter.Text)
            {
                MessageBox.Show("Password Not Match");
            }

            if (GlobalData.Password == TxtUOPOldPassword.Text)
            {
                Con.Open();
                String Query = "Update Users Set Password=@P1 where Username='" + GlobalData.Username + "'";
                Cmd = new SqlCommand(Query, Con);
                Cmd.Parameters.AddWithValue("@P1", TxtUOPNewPassword.Text);
                int Rows = Cmd.ExecuteNonQuery();
                Con.Close();
                if (Rows > 0)
                    MessageBox.Show("Password Updated");
                else
                    MessageBox.Show("Wrong Password");
            }
            else
                MessageBox.Show("Old Password Does Not Match");
            foreach (Control C in this.Controls)
            {
                if (C is TextBox)
                    C.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(TxtUHQNPassword!=TxtUHQReEnter)
            {
                MessageBox.Show("Password Not Matched");
                TxtUHQReEnter.Focus();
            }    
            Con = new SqlConnection(SqlConString);

            Cmd = new SqlCommand("HintChangePassword", Con);
            Cmd.CommandType = CommandType.StoredProcedure;

            P1 = new SqlParameter("@PUsername", SqlDbType.VarChar, 10);
            P1.Value = GlobalData.Username;
            Cmd.Parameters.Add(P1);

            P1 = new SqlParameter("@PHintQuestion", SqlDbType.VarChar, 50);
            P1.Direction = ParameterDirection.Output;
            Cmd.Parameters.Add(P1);

            P1 = new SqlParameter("@PHintAnswer", SqlDbType.VarChar, 50);
            P1.Direction = ParameterDirection.Output;
            Cmd.Parameters.Add(P1);

            Con.Open();
            DR = Cmd.ExecuteReader();
            Con.Close();

            string HQPassword = Cmd.Parameters["@PHintQuestion"].Value.ToString();
            string HAPassword = Cmd.Parameters["@PHintAnswer"].Value.ToString();
            CmbUHQ.Text = Cmd.Parameters["@PHintQuestion"].Value.ToString();

            if (HQPassword == CmbUHQ.Text && HAPassword == TxtUHQHAnswer.Text)
            {
                Con.Open();
                String Query = "Update Users Set Password=@P1 where Username='" + GlobalData.Username + "'";
                Cmd = new SqlCommand(Query, Con);
                Cmd.Parameters.AddWithValue("@P1", TxtUHQNPassword.Text);
                int Rows = Cmd.ExecuteNonQuery();
                Con.Close();
                if (Rows > 0)
                    MessageBox.Show("Password Updated");
                else
                    MessageBox.Show("Error");
            }
            foreach (Control C in this.Controls)
            {
                if (C is TextBox)
                    C.Text = "";
            }
        }


        private void TxtUHQReEnter_Leave(object sender, EventArgs e)
        {
            if (TxtUHQNPassword.Text != TxtUHQReEnter.Text)
            {
                MessageBox.Show("Password Not Matched");
                TxtUHQReEnter.Focus();
            }
        }
    }
}
