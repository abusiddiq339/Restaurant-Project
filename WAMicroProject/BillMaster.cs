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
    public partial class BillMaster : Form
    {
        string SqlConString = "server=DESKTOP-8QI1UOV\\MASSERVER; User Id=sa;Password=masserver; Database=MicroProject";
        SqlConnection Con;
        SqlCommand Cmd;
        DataSet DS;
        SqlDataReader DR;
        SqlParameter P1;
        SqlDataAdapter DA;
        SqlCommandBuilder CB;
        BillTrans BT;
        string Query, Invo;
        int Rows, BVal;
        double A, B, C, R, X, Y, Z;
        public BillMaster()
        {
            InitializeComponent();
        }

        private void BtnAddItems_Click(object sender, EventArgs e)
        {
            if (BT == null || BT.IsDisposed)
                BT = new BillTrans();
            BT.ShowDialog();
            TxtBillAmount.Text = GlobalData.BTTotal;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.BillMaster_Load(sender, e);
            foreach(Control C in this.Controls)
            {
                if (C is TextBox)
                    C.Text = "";
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            GlobalData.BTTotal = "";
            this.Close();
        }

        private void BillMaster_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection(SqlConString);
            Cmd = new SqlCommand("Select max(BillNumber) from BillMaster", Con);
            Cmd.CommandType = CommandType.Text;
            Con.Open();
            string BNum = Cmd.ExecuteScalar().ToString();
            if(BNum=="")
            {
                Invo = "B-00001";
                TxtBillNumber.Text = Invo;
                GlobalData.BillNumber = Invo;
            }
            else
            {
                BVal = Convert.ToInt32(BNum.Substring(2, 5));
                BVal++;
                Invo = string.Format("B-{0:00000}", BVal);
                GlobalData.BillNumber = Invo;
                TxtBillNumber.Text = Invo;
            }
            Con.Close();
            TxtBillDate.Text = DateTime.Now.ToString();
            Cmd = new SqlCommand("Select * from Tax",Con);
            Cmd.CommandType = CommandType.Text;
            Con.Open();
            DR = Cmd.ExecuteReader();
            while(DR.Read())
            {
                TxtSGST.Text = DR[0].ToString();
                TxtCGST.Text = DR[0].ToString();
            }
            Con.Close();
            if (GlobalData.BTTotal == "")
                TxtBillAmount.Text = "0";
            else
                TxtBillAmount.Text = GlobalData.BTTotal;
            if (TxtEnterDiscount.Text.Length > 0)
                if (TxtEnterDiscount.Text.Length <= 0)
                    txtTotalBill.Text = Z.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtTotalBill.Text.Length > 0)
            {
                Query = "Insert Into BillMaster Values(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8)";
                Cmd = new SqlCommand(Query, Con);
                Cmd.Parameters.AddWithValue("@P1", TxtBillNumber.Text);
                Cmd.Parameters.AddWithValue("@P2", TxtBillDate.Text);
                Cmd.Parameters.AddWithValue("@P3", TxtBillAmount.Text);
                Cmd.Parameters.AddWithValue("@P4", TxtSGST.Text);
                Cmd.Parameters.AddWithValue("@P5", TxtCGST.Text);
                Cmd.Parameters.AddWithValue("@P6", TxtEnterDiscount.Text);
                Cmd.Parameters.AddWithValue("@P7", txtTotalBill.Text);
                Cmd.Parameters.AddWithValue("@P8", GlobalData.Username);
                Con.Open();
                int Rows = Cmd.ExecuteNonQuery();
                Con.Close();
            }
            else
                MessageBox.Show("Error");
            if (GlobalData.DS.HasChanges())
            {
                Rows = GlobalData.DA.Update(GlobalData.DS, "BillTrans");
                MessageBox.Show(Rows + " Items(s) Updated into Database");
            }
            else
                MessageBox.Show("No Modification In Item Menu");
            this.BtnClear_Click(sender, e);
        }

        private void TxtEnterDiscount_TextChanged(object sender, EventArgs e)
        {
            if (TxtBillAmount.Text.Length > 0)
                A = Convert.ToDouble(TxtBillAmount.Text);
            B = Convert.ToDouble(TxtSGST.Text);
            C = Convert.ToDouble(TxtCGST.Text);
            X = (B * (A / 100));
            Y = (A * (B / 100));
            Z = A + X + Y;
            if (TxtEnterDiscount.Text.Length > 0)
            {
                R = Z - (Z * (Convert.ToDouble(TxtEnterDiscount.Text)) / 100);
                txtTotalBill.Text = R.ToString();
            }
            else
                txtTotalBill.Text = Z.ToString();
        }
    }
}
