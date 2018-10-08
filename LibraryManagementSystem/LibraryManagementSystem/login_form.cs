using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void register_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration_form register = new Registration_form();
            register.Show();
        }

        private void login_form_Load(object sender, EventArgs e)
        {

        }
    }
}
