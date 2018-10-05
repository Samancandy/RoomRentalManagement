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
    public partial class VehicleInputForm : UserControl
    {
        public Vehicle vehicle = null;
        public VehicleInputForm()
        {
            InitializeComponent();
            Reload();
        }
        public void Reload()
        {
            if (vehicle != null)
            {
                txtVehicleId.Text = vehicle.ID;
                txtVehicleModel.Text = vehicle.Model;
                txtColor.Text = vehicle.Color;
                //cboVehicleType.SelectedItem = vehicle.Type;
                //txtVehiclePlate.Text = vehicle.Plate;
            }
            else btnVechicleUpdate.Text = "Add new";
        }

        public void ChangeBtn(string txt)
        {
            btnVechicleUpdate.Text = txt;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuForm.View.Visible = false;
            MenuForm.vehicleView.Visible = true;
            MenuForm.View = MenuForm.vehicleView;
        }

        private void btnVechicleCancle_Click(object sender, EventArgs e)
        {

        }

        private void btnVechicleUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
