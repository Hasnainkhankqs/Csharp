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
    public partial class Librarian_form : Form
    {
        public Librarian_form()
        {
            InitializeComponent();
        }

        private void Librarian_form_Load(object sender, EventArgs e)
        {
            if(login_form.getemail != null)
            {
                librarain_txt.Text = login_form.getemail;
            }
            else
            {
                librarain_txt.Text = Registration_form.getemail;
            }
        }
    }
}
