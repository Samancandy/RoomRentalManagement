using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomRentalSystem
{
    public partial class RoomUpdate : UserControl
    {
        public RoomUpdate()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuForm.View.Visible = false;
            MenuForm.roomReport.Visible = true;
            MenuForm.View = MenuForm.roomReport;
        }
    }
}
