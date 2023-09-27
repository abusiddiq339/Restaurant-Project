using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WAMicroProject
{
    public partial class CreateUser : Form
    {
        SqlConnection Con;
        SqlCommand Cmd;
        SqlDataReader DR;

        public CreateUser()
        {
            InitializeComponent();
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            string SqlConString= "server=DESKTOP-8QI1UOV\\MASSERVER; User Id=sa;Password=masserver; Database=MicroProject";
            Con = new SqlConnection(SqlConString);
        }
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            foreach (Control C in this.Controls)
            {
                if (C is TextBox)
                {
                    if (C.Text.Length <= 0)
                    {
                        MessageBox.Show("Entering Data Is Mandatory");
                        return;
                    }
                }
            }
            string query = "Insert Into Users Values(@P1,@P2,@P3,@P4,@P5,@P6)";
                Cmd = new SqlCommand(query, Con);
                Cmd.CommandType = CommandType.Text;
                Cmd.Parameters.AddWithValue("@P1", TxtUsername.Text);
                Cmd.Parameters.AddWithValue("@P2", TxtPassword.Text);
                Cmd.Parameters.AddWithValue("@P3", TxtFName.Text);
                Cmd.Parameters.AddWithValue("@P4", TxtLName.Text);
                Cmd.Parameters.AddWithValue("@P5", CmbHQuestion.Text);
                Cmd.Parameters.AddWithValue("@P6", TxtHAnswer.Text);
                Con.Open();
                DR = Cmd.ExecuteReader();
                Con.Close();
                MessageBox.Show(DR.RecordsAffected + " User Created Successfully");
            foreach (Control C in this.Controls)
            {
                if (C is TextBox)
                    C.Text = "";
                if (C is ComboBox)
                    C.Text = "";
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            foreach(Control C in this.Controls)
            {
                if (C is TextBox)
                    C.Text = "";
                if (C is ComboBox)
                    C.Text = "";
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtConfirm_Leave(object sender, EventArgs e)
        {
            if (TxtConfirm.Text != TxtPassword.Text)
            {
                MessageBox.Show("Incorrect Password");
                TxtConfirm.Focus();
            }

        }
        private void CreateUser_Click(object sender, EventArgs e)
        {
            
        }

        private void CreateUser_Leave(object sender, EventArgs e)
        {
           
        }

    }

}
