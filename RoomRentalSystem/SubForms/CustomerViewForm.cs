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
    public partial class CustomerViewForm : UserControl
    {
        public CustomerViewForm()
        {
            InitializeComponent();
        }
      
        private void btnCustomerNew_Click(object sender, EventArgs e)
        {
            if(MenuForm.View.Equals(MenuForm.customer)) return;
            MenuForm.customer.setPerson(null);
            MenuForm.customer.LoadText("Add new");
            MenuForm.customer.ClearBox();
            MenuForm.View.Visible = false;
            MenuForm.customer.Visible = true;
            MenuForm.View = MenuForm.customer;
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            if (MenuForm.View.Equals(MenuForm.customer)) return;
            Person per = null;
            if (dgvCustomer.Rows.Count != 0 && dgvCustomer.Rows != null)
                per = (Person)dgvCustomer.CurrentRow.DataBoundItem;
            MenuForm.customer.setPerson(per); // should be something imporove here
            MenuForm.customer.LoadText("Update");
            MenuForm.View.Visible = false;
            MenuForm.customer.Visible = true;
            MenuForm.View = MenuForm.customer;
        } 
        public void RefreshData()
        {
            EXCT(dgvCustomer, "select * from tbCustomer");
            Form1.FitColumn(dgvCustomer);
        }
        private List<Person> DataReader(IDataReader srd)
        {
            List<Person> lsp = new List<Person>();
            while (srd.Read())
            {
                lsp.Add(new Person(srd.GetString(srd.GetOrdinal("PersonID")),
                                      srd.GetString(srd.GetOrdinal("Name")),
                                      srd.GetString(srd.GetOrdinal("Gender")),
                                      srd.GetDateTime(srd.GetOrdinal("DOB")),
                                      srd.GetString(srd.GetOrdinal("Phone")),
                                      srd.GetString(srd.GetOrdinal("Addr")))
                           );
            }
            return lsp;
        }
        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            string sql = string.Format("delete from tbCustomer where PersonID = '{0}'", dgvCustomer.CurrentRow.Cells[0].Value.ToString());
            Form1.ExecuteQuery(sql);
            this.RefreshData();
        }

        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from tbCustomer where Name like '%" + txtCustomerSearch.Text + "%'";
            EXCT(dgvCustomer, sql);
        }
        public void EXCT(DataGridView dgv, string sql)
        {
            try
            {
                Form1.con.Open();
                SqlCommand cmd = Form1.con.CreateCommand();
                cmd.CommandText = sql;
                IDataReader idr = cmd.ExecuteReader();
                dgv.DataSource = DataReader(idr);
                Form1.con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Form1.con.Close();
            }
        }
    }
}
