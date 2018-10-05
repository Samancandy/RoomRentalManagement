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
    public partial class WorkerView : UserControl
    {
        public WorkerView()
        {
            InitializeComponent();
            //int x = dgvCustomer.ClientSize.Width;
            //for (int i = 0; i < 5; i++)
            //    dgvCustomer.Rows[i].Height = x / 5;
        }

        private void btnCustomerNew_Click(object sender, EventArgs e)
        {
            OpenWorkerF("Add new", null);
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            Worker person = null;
            if(dgvWorker.Rows.Count != 0 && dgvWorker.Rows != null)
                person = (Worker) dgvWorker.CurrentRow.DataBoundItem;
            OpenWorkerF("Update", person);
        }
        void OpenWorkerF(string txt, Worker w)
        {
            MenuForm.worker.SetWorker(txt, w);
            MenuForm.View.Visible = false;
            MenuForm.worker.Visible = true;
            MenuForm.View = MenuForm.worker;
        }
        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            string sql = "delete from tbWorker where WorkerID = '" + dgvWorker.CurrentRow.Cells[1].Value.ToString() + "'";
            Form1.ExecuteQuery(sql);
            this.RefreshData();
        }
        
        internal void RefreshData(){
            EXCT("select * from tbWorker");
            Form1.FitColumn(dgvWorker);
        }

        private void EXCT(string sql)
        {
            try
            {
                Form1.con.Open();
                SqlCommand cmd = Form1.con.CreateCommand();
                cmd.CommandText = sql;
                IDataReader idr = cmd.ExecuteReader();
                dgvWorker.DataSource = DataReader(idr);
                Form1.con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Form1.con.Close();
            }
        }
        private List<Worker> DataReader(IDataReader srd)
        {
            List<Worker> lsp = new List<Worker>();
            while (srd.Read())
            {
                lsp.Add(new Worker(srd.GetString(srd.GetOrdinal("WorkerID")),
                                      srd.GetString(srd.GetOrdinal("WorkerName")),
                                      srd.GetString(srd.GetOrdinal("Gender")),
                                      srd.GetDateTime(srd.GetOrdinal("DOB")),
                                      srd.GetString(srd.GetOrdinal("Phone")),
                                      srd.GetString(srd.GetOrdinal("Addr")),
                                      srd.GetDouble(srd.GetOrdinal("Salary")))
                           );
            }
            return lsp;
        }
        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from tbWorker Name like '%" + txtCustomerSearch.Text + "%'";
            EXCT(sql);
        }
    }
}
