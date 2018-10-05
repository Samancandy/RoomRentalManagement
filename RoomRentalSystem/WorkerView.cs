using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomRentalSystem
{
    public partial class WorkerView : UserControl
    {
        public WorkerView()
        {
            InitializeComponent();
            //int x = dgvCustomer.ClientSize.Width;
            //for (int i = 0; i < 5; i++)
            //    dgvCustomer.Rows[i].Height = x / 5;
        }

        private void btnCustomerNew_Click(object sender, EventArgs e)
        {
            OpenWorkerF("Add new", null);
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            OpenWorkerF("Update", (dgvCustomer.CurrentRow as object) as Worker);
        }
        void OpenWorkerF(string txt, Worker w)
        {
            MenuForm.worker.ChangeBtn(txt, w);
            MenuForm.View.Visible = false;
            MenuForm.worker.Visible = true;
            MenuForm.View = MenuForm.worker;
        }
        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
