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

namespace LibraryManagementSystem
{
    public partial class login_form : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=HASNAIN\\HASNAINDB;Initial Catalog=library_management_db;User ID=sa;Password=hasnaindb123");
        public login_form()
        {
            InitializeComponent();
        }

        private void Register_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration_form register = new Registration_form();
            register.Show();
           
            this.Hide();
        }

        private void Login_form_Load(object sender, EventArgs e)
        {
            if(conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    conn.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    
                    string Query = "select email, password FROM user_registration_tbl WHERE email = '" + email_txt.Text + "' AND password = '" + password_txt.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(Query, conn);
                    DataTable table = new DataTable();
                    sda.Fill(table);
                    if (table.Rows.Count <= 0)
                    {
                        MessageBox.Show("Invalid Username Or Password");
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("login Successfull");
                        Admin_panal admin = new Admin_panal();
                        admin.Show();
                        this.Hide();
                        conn.Close();
                    }
                   

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
