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
    public partial class ViewUser : Form
    {
        SqlConnection Con;
        SqlDataAdapter DA;
        DataSet DS;
        SqlCommandBuilder CB;
        public ViewUser()
        {
            InitializeComponent();
        }

        private void ViewUser_Load(object sender, EventArgs e)
        {
            string SqlConString = "server=DESKTOP-8QI1UOV\\MASSERVER; User Id=sa;Password=masserver; Database=MicroProject";
            Con = new SqlConnection(SqlConString);
            DA = new SqlDataAdapter("Select * From Users", Con);
            DS = new DataSet();
            DA.Fill(DS, "Users");
            DA.FillSchema(DS, SchemaType.Source, "Users");
            CB = new SqlCommandBuilder(DA);
            DGVViewUser.DataSource = DS.Tables[0];
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
