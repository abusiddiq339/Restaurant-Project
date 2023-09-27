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
    public partial class EditItem : Form
    {
        SqlConnection Con;
        SqlDataAdapter DA;
        DataSet DS;
        SqlCommandBuilder CB;
        DataRow Rec;
        public EditItem()
        {
            InitializeComponent();
        }

        private void EditItem_Load(object sender, EventArgs e)
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

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Rec = DS.Tables[0].Select("Items='" + TxtItem.Text + "'")[0];
            Rec[1] = TxtPrice.Text;
            foreach (Control C in this.Controls)
            {
                if (C is TextBox)
                    C.Text = "";
            }
            MessageBox.Show("Data Edited Successfully");
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (DS.HasChanges())
            {
                DA.Update(DS.Tables[0]);
                MessageBox.Show("Data Stored In The DataBase Successfully");
            }
            else
                MessageBox.Show("No Modification In Data");
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
