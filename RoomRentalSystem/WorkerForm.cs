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
    public partial class WorkerForm : UserControl
    {
        public WorkerForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuForm.View.Visible = false;
            MenuForm.workerView.Visible = true;
            MenuForm.View = MenuForm.workerView;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtWorkerID.Clear(); txtCardID.Clear(); txtCustomerName.Clear();
            cboGender.SelectedIndex = -1; txtPhone.Clear(); txtAddress.Clear();
            dtpDateBirth.Text = "";
            //txtPhoto.Clear();
            
        } 

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        internal void ChangeBtn(string txt, Worker w)
        {
            btnUpdate.Text = txt;
            if (w != null)
            {
                txtWorkerID.Text = w.ID; txtCardID.Text = w.CardID; txtCustomerName.Text = w.Name;
                cboGender.SelectedItem = w.Gender; txtPhone.Text = w.Phone; txtAddress.Text = w.Address;
                dtpDateBirth.Text = w.DOB;
                txtPhoto.Text = w.Photo;
            }
        }
    }
}
