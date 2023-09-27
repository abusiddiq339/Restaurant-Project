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
    public partial class DeleteUser : Form
    {
        SqlConnection Con;
        SqlDataAdapter DA;
        DataSet DS;
        SqlCommandBuilder CB;
        DataRow Rec;

        public DeleteUser()
        {
            InitializeComponent();
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            string SqlConString = "server=DESKTOP-8QI1UOV\\MASSERVER; User Id=sa;Password=masserver; Database=MicroProject";
            Con = new SqlConnection(SqlConString);
            DA = new SqlDataAdapter("Select Username,Firstname,Lastname from Users except select Username,Firstname,Lastname from Users Where Username='"+GlobalData.Username+"'", Con);
            DS = new DataSet();
            DA.Fill(DS, "Users");
            DA.FillSchema(DS, SchemaType.Source, "Users");
            CB = new SqlCommandBuilder(DA);
            DGVDelete.DataSource = DS.Tables[0];
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
                Rec = DS.Tables[0].Select("Username='" + DGVDelete.SelectedCells[0].Value + "'")[0];
                Rec.Delete();
                MessageBox.Show("User Deleted Successfully");
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (DS.HasChanges())
                DA.Update(DS.Tables[0]);
            MessageBox.Show("Data Saved To DataBase");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
