using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBHThu3
{
    public partial class frmHello : Form
    {
        public frmHello()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
         this.Close(); // Close the current form
            //  Application.Exit();// Exit the application
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Hello,Chào mừng bạn đến với C# !"; // Display greeting message
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            lblHello.Text= "Giao diện chào mừng"; // Change button text to a greeting
        }
    }
}
