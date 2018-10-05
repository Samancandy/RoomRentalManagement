using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoomRentalSystem.Classes;

namespace RoomRentalSystem
{
    public partial class RoomAdd : UserControl
    {
        public RoomAdd()
        {
            InitializeComponent();
        } 
        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuForm.View.Visible = false;
            MenuForm.roomReport.Visible = true; 
            MenuForm.View = MenuForm.roomReport;
            MenuForm.roomReport.RefreshData();
        } 
        private void btnCencal_Click(object sender, EventArgs e)
        {
            ClearBox();
        }
        private void ClearBox()
        {
            txtID.Clear(); cboType.SelectedIndex = -1; txtSize.Clear();
            txtPrice.Clear(); cboStatus.SelectedIndex = -1;
        } 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = string.Format("insert into tbRoom values('{0}','{1}','{2}','{3}','{4}')",
                txtID.Text, cboType.SelectedItem.ToString(), txtSize.Text, txtPrice.Text, cboStatus.SelectedItem.ToString()); ;
            if (Form1.ExecuteQuery(sql) == null)
            {
                MessageBox.Show("Adding transaction is failed.");
            }
            else 
            { 
                MessageBox.Show("Added successfully");
                ClearBox();
            }
        }
    }
}
