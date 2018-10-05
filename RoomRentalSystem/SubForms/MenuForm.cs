using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoomRentalSystem.SubForms;

namespace RoomRentalSystem
{
    public partial class MenuForm : UserControl
    {
        //public static VehicleInputForm vehicleInput = new VehicleInputForm();
        //public static VehicleViewForm vehicleView = new VehicleViewForm();
        public static Customer customer = new Customer();
        public static CustomerViewForm customerView = new CustomerViewForm();

        public static RoomReportForm roomReport = new RoomReportForm();
        public static RoomAdd roomAdd = new RoomAdd();
        public static RoomUpdate roomUpdate = new RoomUpdate();
        public static Room_Csutomers roomCus = new Room_Csutomers();

        public static RentalForm rental = new RentalForm();
        public static RentalUpdate rentalUpdate = new RentalUpdate();
        public static PaymentForm payment = new PaymentForm();
        public static PaymentReport paymentReport = new PaymentReport();
        public static RentalHistory rentalHistory = new RentalHistory();

        public static WorkerForm worker = new WorkerForm();
        public static WorkerView workerView = new WorkerView();
        //public static WorkingForm working = new WorkingForm();
        //public static WorkingUpdate workingUpdate = new WorkingUpdate();
        //public static WorkingHistoryForm workingHistory = new WorkingHistoryForm();

        public static About about = new About();
        public static UserControl View;
        public MenuForm()
        {
            InitializeComponent();
            View = new UserControl();
            this.Controls.Add(roomReport); roomReport.Visible = false;
            //this.Controls.Add(vehicleInput); vehicleInput.Visible = false;
            //this.Controls.Add(vehicleView); vehicleView.Visible = false;
            this.Controls.Add(rental); rental.Visible = false;
            this.Controls.Add(payment); payment.Visible = false;
            this.Controls.Add(rentalHistory); rentalHistory.Visible = false;
            this.Controls.Add(customer); customer.Visible = false;
            //this.Controls.Add(working); working.Visible = false;
            //this.Controls.Add(workingHistory); workingHistory.Visible = false;
            this.Controls.Add(roomAdd); roomAdd.Visible = false;
            this.Controls.Add(roomUpdate); roomUpdate.Visible = false;
            this.Controls.Add(customerView); customerView.Visible = false;
            this.Controls.Add(worker); worker.Visible = false;
            this.Controls.Add(paymentReport); paymentReport.Visible = false;
            this.Controls.Add(about); about.Visible = false;
            this.Controls.Add(workerView); workerView.Visible = false;
            this.Controls.Add(rentalUpdate); rentalUpdate.Visible = false;
            //this.Controls.Add(workingUpdate); workingUpdate.Visible = false;
            this.Controls.Add(roomCus); roomCus.Visible = false;
        }
        private Color colorB = Color.Teal;
        private Color colorF = Color.FromArgb(255,0, 192, 192);
        private Button btn = new Button();
        private void btnCustormer_Click(object sender, EventArgs e)
        {
            if (View.Equals(customerView)) return;
            btn.BackColor = colorF;
            btn = btnCustormer;
            btn.BackColor = colorB;
            View.Visible = false;
            customerView.Visible = true;
            View = customerView; 
            customerView.RefreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (View.Equals(roomReport)) return;
            btn.BackColor = colorF;
            btn = btnRoomReport;
            btn.BackColor = colorB;
            View.Visible = false;
            roomReport.Visible = true;
            View = roomReport;
            MenuForm.roomReport.RefreshData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if (View.Equals(vehicleView)) return;
            //View.Visible = false;
            //vehicleView.Visible = true;
            //View = vehicleView;
            //btn.BackColor = colorF;
            //btn = btnVehicle;
            //btn.BackColor = colorB;
            //vehicleView.RefreshData();
        }

        private void btnRental_Click(object sender, EventArgs e)
        {
            if (View.Equals(rental)) return;
            btn.BackColor = colorF;
            btn = btnRental;
            btn.BackColor = colorB;
            View.Visible = false;
            rental.Visible = true;
            View = rental;
            rental.SBD();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (View.Equals(payment)) return;
            btn.BackColor = colorF;
            btn = btnPayment;
            btn.BackColor = colorB;
            View.Visible = false;
            payment.Visible = true;
            payment.SBDT();
            View = payment; 
        }

        private void btnRentalHistory_Click(object sender, EventArgs e)
        {
            if (View.Equals(rentalHistory)) return;
            btn.BackColor = colorF;
            btn = btnRentalReport;
            btn.BackColor = colorB;
            View.Visible = false;
            rentalHistory.Visible = true;
            View = rentalHistory;
            rentalHistory.RefreshData();
        }

        private void btnWorking_Click(object sender, EventArgs e)
        {
            //if (View.Equals(working)) return;
            //View.Visible = false;
            //working.FillWorkerID();
            //working.Visible = true;
            //View = working;
            //btn.BackColor = colorF;
            //btn = btnWorking;
            //btn.BackColor = colorB;

        }

        private void btnWorkingHistory_Click(object sender, EventArgs e)
        {
            //if (View.Equals(workingHistory)) return;
            //View.Visible = false;
            //workingHistory.Visible = true;
            //View = workingHistory;
            //btn.BackColor = colorF;
            //btn = btnWorkingHistory;
            //btn.BackColor = colorB;
            //workingHistory.RefreshData("tbWorking");
        }

        private void btnWorker_Click(object sender, EventArgs e)
        {
            if (View.Equals(workerView)) return;
            btn.BackColor = colorF;
            btn = btnWorker;
            btn.BackColor = colorB;
            View.Visible = false;
            workerView.Visible = true;
            View = workerView;
            MenuForm.workerView.RefreshData();
        }

        private void btnPReport_Click(object sender, EventArgs e)
        {
            if (View.Equals(paymentReport)) return;
            btn.BackColor = colorF;
            btn = btnPReport;
            btn.BackColor = colorB;
            View.Visible = false;
            paymentReport.Visible = true;
            paymentReport.RefreshData();
            View = paymentReport;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (View.Equals(about)) return;
            btn.BackColor = colorF;
            btn = btnAbout;
            btn.BackColor = colorB;
            View.Visible = false;
            about.Visible = true;
            View = about;
        }
    }
}
