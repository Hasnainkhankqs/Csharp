using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;

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
                   
                    }
                    else
                    {
                        MessageBox.Show("login Successfull");
                        string Query1 = "select user_id  FROM user_registration_tbl WHERE email = '" + email_txt.Text +  "'";
                        SqlDataAdapter sda1 = new SqlDataAdapter(Query1, conn);
                        

                        this.Hide();
                        Admin_panal admin = new Admin_panal();
                        admin.Show();
                       

                    }

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
