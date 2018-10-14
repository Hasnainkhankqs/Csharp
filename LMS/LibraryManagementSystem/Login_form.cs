using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        private string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
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
            using (conn = new SqlConnection(ConnectionString))
            {
                try
                {
                  
                        conn.Open();

                        string Query = "select user_id FROM user_registration_tbl WHERE email = @email and password = @password";
                         cmd = new SqlCommand(Query,conn);

                         cmd.Parameters.AddWithValue("@email",email_txt.Text);
                        cmd.Parameters.AddWithValue("@password",password_txt.Text);

                    var check = cmd.ExecuteScalar();
                    if(check != null)
                    {
                        MessageBox.Show("Login Succesful","Success!!",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password or email address", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                        //SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        //DataTable table = new DataTable();
                        //sda.Fill(table);
                        //if (table.Rows.Count <= 0)
                        //{
                        //    MessageBox.Show("Invalid Username Or Password");

                        //}
                        //else
                        //{
                        //    MessageBox.Show("login Successfull");
                        //    string Query1 = "select user_id  FROM user_registration_tbl WHERE email = '" + email_txt.Text + "'";
                        //    SqlDataAdapter sda1 = new SqlDataAdapter(Query1, conn);

                        //}


                    
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
}
