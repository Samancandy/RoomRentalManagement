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
    public partial class RentalHistory : UserControl
    {
        public RentalHistory()
        {
            InitializeComponent(); 
        } 

        private void ReleaseRoom()
        {
            try
            {
                Form1.con.Open();
                SqlCommand cmd = Form1.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from tbRental where RentalID = '" + dgvRental.CurrentRow.Cells[0].Value.ToString() + "'";
                //IDataReader reader = cmd.ExecuteReader();
                //if (reader.Read())
                //{
                //    string sql = string.Format("insert into tbRentalHistory values('{0}','{1}','{2}','{3}')",
                //        /*reader.GetString(reader.GetOrdinal("RHID")),*/ reader.GetString(reader.GetOrdinal("PersonID")),
                //        reader.GetString(reader.GetOrdinal("RoomNo")), reader.GetDateTime(reader.GetOrdinal("StartDate")),
                //        reader.GetString(reader.GetOrdinal("EndDate")));
                //    cmd.CommandText = sql;
                //    cmd.ExecuteNonQuery();
                //} 
                cmd.ExecuteNonQuery();
                Form1.con.Close();
                RefreshData();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Form1.con.Close();
            }
        } 

        private List<Rental> rental = new List<Rental>();
        internal void RefreshData()
        {
            try
            {
                Form1.con.Open();
                SqlCommand cmd = Form1.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from tbRental";
                IDataReader srd = cmd.ExecuteReader();
                rental.Clear();
                while (srd.Read())
                {
                    rental.Add(new Rental(srd.GetInt32(srd.GetOrdinal("RentalID")).ToString(),
                                          srd.GetString(srd.GetOrdinal("PersonID")),
                                          srd.GetString(srd.GetOrdinal("RoomNo")),
                                          srd.GetDateTime(srd.GetOrdinal("RentedDate")))
                               );
                }
                Form1.con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = rental;
            dgvRental.DataSource = bs;
            Form1.FitColumn(dgvRental);
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string sql = "select * from tbRental where RoomNo like '%" + txtSearch.Text + "%'";
            DataTable dtb = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(Form1.ExecuteQuery(sql));
            adp.Fill(dtb);
            dgvRental.DataSource = dtb;
            Form1.FitColumn(dgvRental);
        }

        private void btnRelest_Click_1(object sender, EventArgs e)
        {
            ReleaseRoom();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            Rental rental = null;
            if (dgvRental.Rows.Count != 0 && dgvRental.Rows != null)
                rental = (Rental)dgvRental.CurrentRow.DataBoundItem;
            MenuForm.rentalUpdate.FillBox(rental);
            MenuForm.View.Visible = false;
            MenuForm.rentalUpdate.Visible = true;
            MenuForm.rentalUpdate.SBDT();
            MenuForm.View = MenuForm.rentalUpdate;
        }
    }
}
