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
    public partial class RoomReportForm : UserControl
    {
        public RoomReportForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (MenuForm.View.Equals(MenuForm.roomAdd)) return;
            MenuForm.View.Visible = false;
            MenuForm.roomAdd.Visible = true;
            MenuForm.View = MenuForm.roomAdd;
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (MenuForm.View.Equals(MenuForm.roomUpdate)) return;
            MenuForm.View.Visible = false;
            MenuForm.roomUpdate.Visible = true;
            MenuForm.View = MenuForm.roomUpdate;
        }
    }
}
