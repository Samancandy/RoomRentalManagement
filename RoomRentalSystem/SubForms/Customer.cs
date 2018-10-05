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

namespace RoomRentalSystem
{
    public partial class Customer : UserControl
    {
        private Person p;
        public Customer()
        {
            InitializeComponent();;
        }

        public Customer(string p1, string p2, string p3, DateTime dateTime, string p4, string p5)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.dateTime = dateTime;
            this.p4 = p4;
            this.p5 = p5;
        }
        public void LoadText(string nu)
        {
            btnUpdate.Text = nu;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            HandleData(this.p);
            if(toClear.Equals("yes")) ClearBox();
        }
        private string message, toClear;
        private string p1;
        private string p2;
        private string p3;
        private DateTime dateTime;
        private string p4;
        private string p5;
        private void HandleData(Person person)
        {
            string sql;
            if (p == null)
            {
                sql = string.Format("insert into tbCustomer values('{0}','{1}', '{2}', '{3}', '{4}', '{5}')",
                    txtCustomerID.Text, txtCustomerName.Text, cboGender.Text, dtpDateBirth.Value, txtPhone.Text, txtAddress.Text);
                message = "Successfully Added!"; toClear = "yes";
            }
            else
            {
                sql = string.Format("update tbCustomer set Name = '{0}', Gender = '{1}', DOB = '{2}', Phone = '{3}', Addr = '{4}' where PersonID = '{5}'",
                    txtCustomerName.Text, cboGender.Text, dtpDateBirth.Value, txtPhone.Text, txtAddress.Text, txtCustomerID.Text);
                message = "Successfully updated!"; toClear = "no";
            }
            ExecuteQuery(sql);
        }
        internal void setPerson(Person p)
        {
            if (p == null) return;
            txtCustomerID.Text = p.ID; txtCustomerName.Text = p.Name;
            cboGender.SelectedItem = p.Gender; dtpDateBirth.Value = p.DOB;
            txtPhone.Text = p.Phone; txtAddress.Text = p.Address;
            this.p = p;
        }           
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearBox();
        }
        public void ClearBox()
        {
            txtCustomerID.Clear(); txtCustomerID.Clear(); txtCustomerName.Clear();
            txtAddress.Clear(); txtPhone.Clear(); dtpDateBirth.Value = DateTimePicker.MinimumDateTime;
            cboGender.SelectedIndex = -1;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuForm.View.Visible = false;
            MenuForm.customerView.Visible = true;
            MenuForm.View = MenuForm.customerView;
            MenuForm.customerView.RefreshData();
            this.p = null;
        }
        private SqlCommand ExecuteQuery(string sql)
        {
            try
            {
                Form1.con.Open();
                SqlCommand cmd = Form1.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                Form1.con.Close();
                MessageBox.Show(message);
                return cmd;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Form1.con.Close();
                if (p == null) MessageBox.Show("Adding transaction is failed!");
                else MessageBox.Show("Updating transaction is failed!");
                return null;
            }
        }
    }
}
