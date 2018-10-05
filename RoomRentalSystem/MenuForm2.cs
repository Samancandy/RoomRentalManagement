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
    public partial class MenuForm2 : UserControl
    {
        //public static VehicleInputForm vehicleInput = new VehicleInputForm();
        //public static VehicleViewForm vehicleView = new VehicleViewForm();
        public static Customer customer = new Customer();
        //public static CustomerViewForm customerView = new CustomerViewForm();

        //public static RoomReportForm roomReport = new RoomReportForm();
        //public static RoomAdd roomAdd = new RoomAdd();
        //public static RoomUpdate roomUpdate = new RoomUpdate();

        //public static RentalForm rental = new RentalForm();
        //public static PaymentForm payment = new PaymentForm();
        //public static RentalHistory rentalHistory = new RentalHistory();

        //public static WorkerForm worker = new WorkerForm();
        //public static WorkingForm working = new WorkingForm();
        //public static WorkingHistoryForm workingHistory = new WorkingHistoryForm();
        public static UserControl View;
        public MenuForm2()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
