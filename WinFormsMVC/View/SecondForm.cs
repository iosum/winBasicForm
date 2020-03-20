using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsMVC.View
{
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
        }

        public UserInfo UserInfo { get; set; }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            UserInfo.firstName = txtFirstName.Text;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            UserInfo.lastName = txtLastName.Text;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            UserInfo.email = txtEmail.Text;
        }

        // populate the control
        private void SecondForm_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = UserInfo.firstName;
            txtLastName.Text = UserInfo.lastName;
            txtEmail.Text = UserInfo.email;
        }
    }
}
