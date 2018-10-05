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
    public partial class VehicleViewForm : UserControl
    {
        public VehicleViewForm()
        {
            InitializeComponent();
        }

        private void btnVehicleNew_Click(object sender, EventArgs e)
        {
            OpenForm("Add new");
        }

        private void btnVehicleUpdate_Click(object sender, EventArgs e)
        {
            OpenForm("Update");
        }
        void OpenForm(string txt)
        {
            MenuForm.vehicleInput.ChangeBtn(txt);
            MenuForm.View.Visible = false;
            MenuForm.vehicleInput.Visible = true;
            MenuForm.View = MenuForm.vehicleInput;
        }
    }
}
