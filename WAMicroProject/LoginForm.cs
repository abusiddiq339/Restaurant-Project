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
    public partial class LoginForm : Form
    {
        SqlConnection Con;
        SqlCommand Cmd;
        SqlDataReader DR;
        MDIParent1 MDI1;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            string SqlConString = "server=DESKTOP-8QI1UOV\\MASSERVER; User Id=sa;Password=masserver; Database=MicroProject";
            Con = new SqlConnection(SqlConString);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string Query = "Select * From Users where Username=@P1 and Password=@P2";
            Cmd = new SqlCommand(Query, Con);
            Cmd.CommandType = CommandType.Text;
            Cmd.Parameters.AddWithValue("@P1", TxtUsername.Text);
            Cmd.Parameters.AddWithValue("@P2", TxtPassword.Text);
            Con.Open();
            DR = Cmd.ExecuteReader();
            if (DR.Read())
            {
                GlobalData.Username = TxtUsername.Text;
                GlobalData.Password = TxtPassword.Text;
                MDI1 = new MDIParent1();
                MDI1.Show();
                this.Hide();
                //MDI1.Show();
                //this.Close();
            }
            else
                MessageBox.Show("Invalid Credentials");
            Con.Close();
        }
    }
}
