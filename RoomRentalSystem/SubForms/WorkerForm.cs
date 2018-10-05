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
using RoomRentalSystem.Classes;

namespace RoomRentalSystem
{
    public partial class WorkerForm : UserControl
    {
        public Person p;
        public WorkerForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuForm.View.Visible = false;
            MenuForm.workerView.Visible = true;
            MenuForm.View = MenuForm.workerView;
            MenuForm.workerView.RefreshData();
            this.p = null;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            HandleData(this.p);
            if (toClear.Equals("yes")) ClearBox();
        }

        internal void SetWorker(string txt, Worker w)
        {
            btnUpdate.Text = txt;
            if (w != null)
            {
                txtWorkerID.Text = w.ID; txtCustomerName.Text = w.Name;
                cboGender.SelectedItem = w.Gender; txtPhone.Text = w.Phone; txtAddress.Text = w.Address;
                dtpDateBirth.Value = w.DOB; txtSalary.Text = w.Salary.ToString();
                this.p = w;
            }
        }
        private string message, toClear;
        private void HandleData(Person person)
        {
            string sql;
            if (p == null)
            {
                sql = string.Format("insert into tbWorker values('{0}','{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                    txtWorkerID.Text, txtCustomerName.Text, cboGender.Text, dtpDateBirth.Value, 
                    txtPhone.Text, txtAddress.Text, txtSalary.Text);
                message = "Successfully Added!"; toClear = "yes";
            }
            else
            {
                sql = string.Format("update tbWorker set WorkerName = '{0}', Gender = '{1}', DOB = '{2}', Phone = '{3}', Addr = '{4}', Salary = '{5}' where WorkerID = '{6}'",
                    txtCustomerName.Text, cboGender.SelectedItem.ToString(), dtpDateBirth.Value, txtPhone.Text, txtAddress.Text, txtSalary.Text, txtWorkerID.Text);
                message = "Successfully updated!"; toClear = "no";
            }
            ExecuteQuery(sql);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearBox();
        }
        public void ClearBox()
        {
            txtWorkerID.Clear(); txtWorkerID.Clear(); txtCustomerName.Clear();
            txtAddress.Clear(); txtPhone.Clear(); dtpDateBirth.Value = DateTimePicker.MinimumDateTime;
            cboGender.SelectedIndex = -1; txtSalary.Clear();
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
