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
    public partial class PaymentForm : UserControl
    {
        public PaymentForm()
        {
            InitializeComponent();
            txtPrice.Enabled = false;       //I don't have much time to organize these thing, just leave it with these little mistak :")
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //Sudently clicked it out of pupose
        }

        internal void SBDT()
        {
            MenuForm.rental.SetBoxesData(cboCusID, "PersonID", "tbCustomer");
            MenuForm.rental.SetBoxesData(cboRoomNo, "RoomNo", "tbRoom");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string sql = string.Format("insert into tbPayment values('{0}', '{1}', '{2}')",
                cboCusID.SelectedItem.ToString(), cboRoomNo.SelectedItem.ToString(), dtcPayDate.Text);
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
                MessageBox.Show("Renting process is successfully!");
            }
            catch (Exception e)
            {
                Form1.con.Close();
                MessageBox.Show(e.ToString());
                MessageBox.Show("Renting proccess is failed!!!");
            }
        }
        private void btnCencal_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }
        private void ClearBoxes()
        {
            cboCusID.SelectedIndex = -1; cboRoomNo.SelectedIndex = -1; txtPrice.Clear();
        }
    }
}
