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
    public partial class RoomReportForm : UserControl
    {
        private List<Room> room = new List<Room>();
        public RoomReportForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (MenuForm.View.Equals(MenuForm.roomAdd)) return;
            MenuForm.View.Visible = false;
            MenuForm.roomAdd.Visible = true;
            MenuForm.View = MenuForm.roomAdd;
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (MenuForm.View.Equals(MenuForm.roomUpdate)) return;
            Room room = null;
            if(dgvRoom.Rows.Count != 0 && dgvRoom.Rows != null)
                 room = (Room)dgvRoom.CurrentRow.DataBoundItem;
            MenuForm.View.Visible = false;
            MenuForm.roomUpdate.SetBox(room);
            MenuForm.roomUpdate.Visible = true;
            MenuForm.View = MenuForm.roomUpdate;
        }

        internal void RefreshData()
        {
            try
            {
                Form1.con.Open();
                SqlCommand cmd = Form1.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from tbRoom";
                IDataReader srd = cmd.ExecuteReader();
                room.Clear();
                while (srd.Read())
                {
                    room.Add(new Room(srd.GetString(srd.GetOrdinal("RoomNo")),
                                          srd.GetString(srd.GetOrdinal("RoomType")),
                                          srd.GetString(srd.GetOrdinal("Size")),
                                          srd.GetDouble(srd.GetOrdinal("Price")),
                                          srd.GetString(srd.GetOrdinal("Status")))
                               );
                }
                Form1.con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = room;
            dgvRoom.DataSource = bs;
            Form1.FitColumn(dgvRoom);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = string.Format("delete from tbRoom where RoomNo = '{0}'", dgvRoom.CurrentRow.Cells[0].Value.ToString());
            Form1.ExecuteQuery(sql);
            this.RefreshData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from tbRoom where RoomNo like 'RM%" + txtSearch.Text + "%'";
            DataTable dtb = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(Form1.ExecuteQuery(sql));
            adp.Fill(dtb);
            dgvRoom.DataSource = dtb;
            Form1.FitColumn(dgvRoom);
        }

        private void btnView_Click(object sender, EventArgs e)
        { 
            MenuForm.View.Visible = false;
            MenuForm.roomCus.Visible = true;
            MenuForm.View = MenuForm.roomCus; 
            MenuForm.roomCus.GetRoomNo(dgvRoom.CurrentRow.Cells[0].Value.ToString());
            MenuForm.roomCus.FillDGV(GetListCustomer());
        }
        private List<Person> GetListCustomer()
        {
            List<Person> lsc = new List<Person>();
            string sql = "select PersonID, Name, Gender, DOB, Phone, Addr from tbCustomer cs inner join tbRoomMember rm on cs.PersonID = rm.CustomerID where RoomNo = '" + dgvRoom.CurrentRow.Cells[0].Value.ToString() + "'";
            try
            {
                Form1.con.Open();
                SqlCommand cmd = Form1.con.CreateCommand();
                cmd.CommandText = sql;
                IDataReader srd = cmd.ExecuteReader();
                while(srd.Read())
                {
                    lsc.Add(new Person(srd.GetString(srd.GetOrdinal("PersonID")),
                                      srd.GetString(srd.GetOrdinal("Name")),
                                      srd.GetString(srd.GetOrdinal("Gender")),
                                      srd.GetDateTime(srd.GetOrdinal("DOB")),
                                      srd.GetString(srd.GetOrdinal("Phone")),
                                      srd.GetString(srd.GetOrdinal("Addr")))
                           );
                }
                Form1.con.Close();
                return lsc;
            }
            catch (Exception e)
            {
                Form1.con.Close(); return null;
                MessageBox.Show(e.ToString()); 
            }  
        }
    }
}
