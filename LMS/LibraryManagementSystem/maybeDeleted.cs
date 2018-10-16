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
    public partial class maybeDeleted : Form
    {
        public maybeDeleted()
        {
            InitializeComponent();
        }

        private void UsersDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registered_users users = new Registered_users();
            users.Show();
        }
    }
}
