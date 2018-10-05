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
    public partial class LoginForm : UserControl
    {
        public LoginForm()
        {
            InitializeComponent();
            txtPassw.PasswordChar = '\u25CF';       // make text field as password field   ( '\u25CF' or '*' )
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckUser(txtUsername.Text, txtPassw.Text);
        }
        private void CheckUser(string usr, string pas)
        {
            try
            {
                Form1.con.Open();
                SqlCommand cmd = Form1.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = string.Format("select passw from tbUser where uname = '{0}'", usr);
                IDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (pas.Equals(reader.GetString(reader.GetOrdinal("passw"))))
                    {
                        Form1.loginform.Visible = false;
                        Form1.menu.Visible = true;
                    }
                    else MessageBox.Show("The password isn't match.");
                }
                else MessageBox.Show("The username is invalid.");
                Form1.con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUsername.Clear(); txtPassw.Clear();
        }
    }
}
