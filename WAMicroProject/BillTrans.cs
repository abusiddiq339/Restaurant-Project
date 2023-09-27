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
    public partial class BillTrans : Form
    {
        SqlConnection Con;
        SqlCommand Cmd;
        SqlDataReader DR;
        String Query;
        SqlParameter P1;
        SqlCommandBuilder CB;
        SqlDataAdapter DA;
        DataSet DS;
        DataRow Dr;
        BillMaster BM;
        int sum = 0;
        public BillTrans()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if(TxtPrice.Text==""||TxtQuantity.Text==""||TxtTPrice.Text=="")
            {
                BtnOk.Enabled = false;
                Form.ActiveForm.Show();
            }
            for (int i = 0; i < DGVBillTrans.Rows.Count; i++)
                sum += Convert.ToInt32(DGVBillTrans.Rows[i].Cells[4].Value);
            GlobalData.BTTotal = sum.ToString();
            this.Close();
        }

        private void BillTrans_Load(object sender, EventArgs e)
        {
            string SqlConString= "server=DESKTOP-8QI1UOV\\MASSERVER; User Id=sa;Password=masserver; Database=MicroProject";
            Con = new SqlConnection(SqlConString);
            string Query = "Select Items from Items";
            Cmd = new SqlCommand(Query, Con);
            Cmd.CommandType = CommandType.Text;
            Con.Open();
            DR = Cmd.ExecuteReader();
            while (DR.Read())
                CmbSelectItem.Items.Add(DR[0].ToString());
            Con.Close();
            GlobalData.DA = new SqlDataAdapter("Select * from BillTrans Where BillNumber='" + GlobalData.BillNumber + "'", Con);
            GlobalData.DS = new DataSet();
            GlobalData.DA.Fill(GlobalData.DS, "BillTrans");
            GlobalData.DA.FillSchema(GlobalData.DS, SchemaType.Source, "BillTrans");
            GlobalData.CB = new SqlCommandBuilder(GlobalData.DA);
            DGVBillTrans.DataSource = GlobalData.DS.Tables[0];
            Con.Close();
        }
        private void CmbSelectItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Cmd = new SqlCommand("PBillTrans", Con);
            Cmd.CommandType = CommandType.StoredProcedure;

            P1=new SqlParameter("@PItems", SqlDbType.VarChar,20);
            P1.Value = CmbSelectItem.SelectedItem;
            Cmd.Parameters.Add(P1);

            P1 = new SqlParameter("@PPrice", SqlDbType.Money);
            P1.Direction = ParameterDirection.Output;
            Cmd.Parameters.Add(P1);

            Con.Open();
            Cmd.ExecuteNonQuery();
            TxtPrice.Text = Cmd.Parameters["@PPrice"].Value.ToString();
            Con.Close();*/
            Query = "Select * from Items Where Items='" + CmbSelectItem.SelectedItem + "'";
            Cmd = new SqlCommand(Query, Con);
            Cmd.CommandType = CommandType.Text;
            Con.Open();
            DR = Cmd.ExecuteReader();
            DR.Read();
            TxtPrice.Text = DR[1].ToString();
            Con.Close();
            TxtTPrice.Text = TxtPrice.Text;
        }

        private void TxtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (TxtQuantity.Text.Length > 0)
            {
                double P = Convert.ToDouble(TxtPrice.Text) * Convert.ToDouble(TxtQuantity.Text);
                TxtTPrice.Text = P.ToString();
            }
            else
                TxtTPrice.Clear();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!GlobalData.DS.Tables[0].Columns.Contains(GlobalData.BillNumber))
            {
                Dr = GlobalData.DS.Tables[0].NewRow();
                Dr[0] = GlobalData.BillNumber;
                Dr[1] = CmbSelectItem.Text;
                Dr[2] = TxtPrice.Text;
                if (TxtQuantity.Text.Length <= 0)
                    Dr[3] = "1";
                else
                    Dr[3] = TxtQuantity.Text;
                Dr[4] = TxtTPrice.Text;
                GlobalData.DS.Tables[0].Rows.Add(Dr);
            }
            else
                MessageBox.Show("Items Already Exist");
            foreach(Control C in this.Controls)
            {
                if (C is TextBox)
                    C.Text = "";
                if (C is ComboBox)
                    C.Text = "";
            }

        }
    }
}
