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
    public partial class CustomerViewForm : UserControl
    {
        public CustomerViewForm()
        {
            InitializeComponent();
        }

        private void btnCustomerNew_Click(object sender, EventArgs e)
        {
            if(MenuForm.View.Equals(MenuForm.customer)) return;
            MenuForm.customer.p = null;
            MenuForm.customer.LoadText("Add new");
            MenuForm.View.Visible = false;
            MenuForm.customer.Visible = true;
            MenuForm.View = MenuForm.customer;
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            if (MenuForm.View.Equals(MenuForm.customer)) return;
            MenuForm.customer.p = (dgvCustomer.CurrentRow as Object) as Person; // should be something imporove here
            MenuForm.customer.LoadText("Update");
            MenuForm.View.Visible = false;
            MenuForm.customer.Visible = true;
            MenuForm.View = MenuForm.customer;
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
