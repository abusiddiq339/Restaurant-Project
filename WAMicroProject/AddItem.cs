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
    public partial class AddItem : Form
    {
        SqlConnection Con;
        SqlDataAdapter DA;
        DataSet DS;
        SqlCommandBuilder CB;
        DataRow Rec;
        public AddItem()
        {
            InitializeComponent();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            string SqlConString= "server=DESKTOP-8QI1UOV\\MASSERVER; User Id=sa;Password=masserver; Database=MicroProject";
            Con = new SqlConnection(SqlConString);
            DA = new SqlDataAdapter("Select * From Items", Con);
            DS = new DataSet();
            DA.Fill(DS, "Items");
            DA.FillSchema(DS, SchemaType.Source, "Items");
            CB = new SqlCommandBuilder(DA);
            DGVAddItem.DataSource = DS.Tables[0];
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtItem.Text.Length <= 0 || TxtPrice.Text.Length <= 0)
            {
                TxtItem.Focus();
                MessageBox.Show("Enter Any Data");
            }
            else if (!DS.Tables[0].Rows.Contains(TxtItem.Text))
            {
                Rec = DS.Tables[0].NewRow();
                Rec[0] = TxtItem.Text;
                Rec[1] = TxtPrice.Text;
                DS.Tables[0].Rows.Add(Rec);
                MessageBox.Show("Data Added Succesfully");
            }
            else
                MessageBox.Show("Data Already Exist");
            foreach(Control C in this.Controls)
            {
                if (C is TextBox)
                    C.Text = "";
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (DS.HasChanges())
            {
                DA.Update(DS.Tables[0]);
                MessageBox.Show("Data Stored In The DataBase Successfully");
            }
            else
                MessageBox.Show("No Modification In The Data");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
