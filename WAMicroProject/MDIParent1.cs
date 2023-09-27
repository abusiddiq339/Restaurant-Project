using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WAMicroProject
{
    public partial class MDIParent1 : Form
    {
        AddItem AI;
        DeleteItem DE;
        EditItem EI;
        CreateUser CU;
        DeleteUser DU;
        ChangePassword CP;
        ViewUser VU;
        BillMaster BM;
        ViewBill VB;
        
        public MDIParent1()
        {
            InitializeComponent();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AI == null || AI.IsDisposed)
                AI = new AddItem();
            AI.Show();
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
           
        }

        private void EditItemSM_Click(object sender, EventArgs e)
        {
            if (EI == null || EI.IsDisposed)
                EI = new EditItem();
            EI.Show();
        }

        private void DeleteItemSM_Click(object sender, EventArgs e)
        {
            if (DE == null || DE.IsDisposed)
                DE = new DeleteItem();
            DE.Show();
        }

        private void ExitSM_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Form.ActiveForm.Close();
        }

        private void AddNewUserSM_Click(object sender, EventArgs e)
        {
            if (CU == null || CU.IsDisposed)
                CU = new CreateUser();
            CU.Show();
        }

        private void DeleteUserSM_Click(object sender, EventArgs e)
        {
            if (DU == null || DU.IsDisposed)
                DU = new DeleteUser();
            DU.Show();
        }

        private void ChangePasswordSM_Click(object sender, EventArgs e)
        {
            if (CP == null || CP.IsDisposed)
                CP = new ChangePassword();
            CP.Show();
        }

        private void ViewUserSM_Click(object sender, EventArgs e)
        {
            if (VU == null || VU.IsDisposed)
                VU = new ViewUser();
            VU.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void NewBillSM_Click(object sender, EventArgs e)
        {
            if (BM == null || BM.IsDisposed)
                BM = new BillMaster();
            BM.Show();
        }

        private void ViewBillSM_Click(object sender, EventArgs e)
        {
            if (VB == null || VB.IsDisposed)
                VB = new ViewBill();
            VB.Show();
        }
    }
}
