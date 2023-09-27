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
    public partial class ViewBill : Form
    {
        SqlConnection Con;
        SqlCommand Cmd;
        SqlDataAdapter DA;
        SqlDataReader DR;
        DataSet DS;
        SqlCommandBuilder CB;
        SqlParameter P1;
        DataRow Dr;
        int Rows;
        string Query;
        int Sum = 0;
        string SqlConString= "server=DESKTOP-8QI1UOV\\MASSERVER; User Id=sa;Password=masserver; Database=MicroProject";
        public ViewBill()
        {
            InitializeComponent();
        }

        private void ViewBill_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection(SqlConString);
            Cmd = new SqlCommand("Select BillNumber From BillMaster", Con);
            Cmd.CommandType = CommandType.Text;
            Con.Open();
            DR = Cmd.ExecuteReader();
            while (DR.Read())
                CmbBillNo.Items.Add(DR[0]);
            Con.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmbBillNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con = new SqlConnection(SqlConString);
            Query = "Select * from BillMaster where BillNumber='" + CmbBillNo.SelectedItem + "';Select * From BillTrans Where BillNumber='" + CmbBillNo.SelectedItem + "'";
            Con.Open();
            DA = new SqlDataAdapter(Query, Con);
            DS = new DataSet();
            DA.Fill(DS, "Items");
            DA.FillSchema(DS, SchemaType.Source, "Items");
            CB = new SqlCommandBuilder(DA);
            DGVBillDetails.DataSource = DS.Tables[0];
            DGVItemDetails.DataSource = DS.Tables[1];
            Con.Close();
        }
    }
}
