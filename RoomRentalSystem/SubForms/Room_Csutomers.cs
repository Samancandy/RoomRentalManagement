using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RoomRentalSystem.SubForms
{
    public partial class Room_Csutomers : UserControl
    {
        public Room_Csutomers()
        {
            InitializeComponent();
            btnNew.Enabled = false; // not to use yet.
        }

        internal void FillDGV(List<Person> list)
        {    
            dgvCustomer.DataSource = list;
            Form1.FitColumn(dgvCustomer);
        }
        private string RoomNo = "";
        internal void GetRoomNo(string roomNo)
        {
            lblRoomNo.Text = "Room No: " + roomNo;
            this.RoomNo = roomNo;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuForm.View.Visible = false;
            MenuForm.roomReport.Visible = true;
            MenuForm.View = MenuForm.roomReport;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // There's no time to add more form or event to right code, my fault that wasting too much time
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            string sql = string.Format("delete from tbRoomMember where CustomerID = '{0}'", dgvCustomer.CurrentRow.Cells[0].Value.ToString());
            Form1.ExecuteQuery(sql);
            RefreshData();
        }
        private void RefreshData(){
            string sql = "select PersonID, Name, Gender, DOB, Phone, Addr from tbCustomer cs inner join tbRoomMember rm on cs.PersonID = rm.CustomerID where RoomNo = '" + RoomNo + "'";
            MenuForm.customerView.EXCT(dgvCustomer, sql);
            Form1.FitColumn(dgvCustomer);
        }
    }
}
