using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomRentalSystem
{
    public partial class Form1 : Form
    {
        public static LoginForm loginform = new LoginForm();
        public static MenuForm menu = new MenuForm();
        internal static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9ODVSH7\SQLEXPRESS;
                                              Initial Catalog=RoomRentalManagement;User ID=sa;
                                              Password=123456");
        public Form1()
        {
            InitializeComponent();
            this.Controls.Add(loginform);
            this.Controls.Add(menu);  menu.Visible = false;
            
        }
        public static SqlCommand ExecuteQuery(string sql)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                con.Close();
                return cmd;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                con.Close();
                return null;
            }  
        }
        public static void FitColumn(DataGridView dgv)
        {
            int col = dgv.ColumnCount;
            for (int i = 0; i < col; i++)
            {
                dgv.Columns[i].Width = (dgv.Width - 37) / col;
            }
        }
    }
}
