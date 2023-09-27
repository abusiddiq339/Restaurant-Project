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
    public partial class DeleteItem : Form
    {
        SqlConnection Con;
        SqlDataAdapter DA;
        DataSet DS;
        SqlCommandBuilder CB;
        DataRow Rec;
        public DeleteItem()
        {
            InitializeComponent();
        }

        private void DeleteItem_Load(object sender, EventArgs e)
        {
            string SqlConString = "server=DESKTOP-8QI1UOV\\MASSERVER; User Id=sa;Password=masserver; Database=MicroProject";
            Con = new SqlConnection(SqlConString);
            DA = new SqlDataAdapter("Select * From Items", Con);
            DS = new DataSet();
            DA.Fill(DS, "Items");
            DA.FillSchema(DS, SchemaType.Source, "Items");
            CB = new SqlCommandBuilder(DA);
            DGVAddItem.DataSource = DS.Tables[0];
            TxtItem.Enabled = false;
            TxtPrice.Enabled = false;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (TxtItem.Text.Length <= 0 || TxtPrice.Text.Length <= 0)
            {
                TxtItem.Focus();
                MessageBox.Show("Select Any Data To Delete");
            }
            else
            {
                Rec = DS.Tables[0].Select("Items='" + TxtItem.Text + "'")[0];
                Rec.Delete();
                TxtItem.Clear();
                TxtPrice.Clear();
                MessageBox.Show("Item Deleted Successfully");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (DS.HasChanges())
                DA.Update(DS.Tables[0]);
            MessageBox.Show("Data Stored In The DataBase Successfully");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGVAddItem_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TxtItem.Text = DGVAddItem.SelectedCells[0].Value.ToString();
            TxtPrice.Text = DGVAddItem.SelectedCells[1].Value.ToString();
        }
    }
}
