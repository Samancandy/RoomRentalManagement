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
using System.Data.SqlClient;

namespace RoomRentalSystem
{
    public partial class RoomUpdate : UserControl
    {   
        public RoomUpdate()
        {
            InitializeComponent();
        }
        public void SetBox(Room room)
        {   
            if (room == null) return;
            txtID.Text = room.RoomNo;
            cboType.SelectedItem = room.RoomType;
            txtSize.Text = room.RoomSize;
            txtPrice.Text = room.Price.ToString();
            cboStatus.SelectedItem = room.Status;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuForm.View.Visible = false;
            MenuForm.roomReport.Visible = true;
            MenuForm.View = MenuForm.roomReport;
            ClearBox();
            MenuForm.roomReport.RefreshData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddingField();
        }
        private void AddingField()
        {
            string sql = string.Format("update tbRoom set RoomType = '{0}', Size = '{1}', Price = '{2}', Status = '{3}' where RoomNo = '{4}'",
                cboType.SelectedItem.ToString(), txtSize.Text, txtPrice.Text, cboStatus.SelectedItem.ToString(), txtID.Text);
            try
            {
                Form1.con.Open();
                SqlCommand cmd = Form1.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                Form1.con.Close();
                MessageBox.Show("Updated successfully!!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Form1.con.Close();
                MessageBox.Show("Updating is failed.");
            }
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
    }
}
