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
    public partial class PaymentReport : UserControl
    {
        public PaymentReport()
        {
            InitializeComponent();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            EXCT("select * from tbPayment where RoomNo like '&" + txtSearch.Text + "'%");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // This might not be used
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Form1.ExecuteQuery("delete from tbPayment where PaymentID = '"+ dgvPReport.CurrentRow.Cells[0].Value.ToString() +"'");
            this.RefreshData();
        }

        public void RefreshData()
        {
            EXCT("select * from tbPayment");
            Form1.FitColumn(dgvPReport);
        }
        private void EXCT(string sql)
        {
            try
            {
                Form1.con.Open();
                SqlCommand cmd = Form1.con.CreateCommand();
                cmd.CommandText = sql;
                IDataReader idr = cmd.ExecuteReader();
                dgvPReport.DataSource = DataReader(idr);
                Form1.con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Form1.con.Close();
            }
        }
        private List<Payment> DataReader(IDataReader srd)
        {
            List<Payment> lsp = new List<Payment>();
            while (srd.Read())
            {
                lsp.Add(new Payment(  srd.GetInt32(srd.GetOrdinal("PaymentID")),
                                      srd.GetString(srd.GetOrdinal("PersonID")),
                                      srd.GetString(srd.GetOrdinal("RoomNo")), 0.00,
                                      //srd.GetDouble(srd.GetOrdinal("Price")),
                                      srd.GetDateTime(srd.GetOrdinal("PaymentDate"))
                                      )
                           );
            }
            return lsp;
        }
    }
}
