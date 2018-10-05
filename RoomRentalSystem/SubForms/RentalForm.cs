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
using System.Data.SqlClient;

namespace RoomRentalSystem
{
    public partial class RentalForm : UserControl
    {
        public RentalForm()
        {
            InitializeComponent();
            txtID.Enabled = false;
        }

        private void btnCencel_Click(object sender, EventArgs e)
        {
            ClearBox();
        }

        public void SBD()
        {
            SetBoxesData(cboCusID, "PersonID", "tbCustomer");
            SetBoxesData(cboRoomNo, "RoomNo", "tbRoom");
        }

        public void SetBoxesData(ComboBox cbo, string field, string table)
        {
            try
            {
                string sql = string.Format("select {0} from {1}", field, table);
                Form1.con.Open();
                SqlCommand cmd = Form1.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                IDataReader rd = cmd.ExecuteReader();
                cbo.Items.Clear();
                while (rd.Read())
                {
                    cbo.Items.Add(rd.GetString(rd.GetOrdinal(field)));
                }
                Form1.con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void ClearBox()
        {
            txtID.Clear(); cboCusID.SelectedIndex = -1; cboRoomNo.SelectedIndex = -1;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string sql = string.Format("insert into tbRental values('{0}','{1}','{2}')",
               cboCusID.SelectedItem.ToString(), cboRoomNo.SelectedItem.ToString(), dtpDate.Text);
            EXCT(sql);
            sql = string.Format("insert into tbRoomMember values('{1}','{0}')", cboCusID.SelectedItem.ToString(), cboRoomNo.SelectedItem.ToString());
            EXCT(sql);
        }
        private void EXCT(string sql)
        {
            try
            {
                Form1.con.Open();
                SqlCommand cmd = Form1.con.CreateCommand();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                Form1.con.Close();
                MessageBox.Show("Successfully added!!!");
            }
            catch (Exception )
            {
                Form1.con.Close();
                MessageBox.Show("Adding is failed!!!");
            }
        }
    }
}
