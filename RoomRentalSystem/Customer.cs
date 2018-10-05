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
    public partial class Customer : UserControl
    {
        public Person p;
        public Customer()
        {
            InitializeComponent();;
        }
        public void LoadText(string nu)
        {
            btnUpdate.Text = nu;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCustomerID.Clear(); txtCustomerID.Clear(); txtCustomerName.Clear();
            txtAddress.Clear(); txtPhone.Clear(); dtpDateBirth.Value = DateTimePicker.MinimumDateTime;
            txtPhoto.Clear(); cboGender.SelectedIndex = -1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuForm.View.Visible = false;
            MenuForm.customerView.Visible = true;
            MenuForm.View = MenuForm.customerView;
        }
    }
}
