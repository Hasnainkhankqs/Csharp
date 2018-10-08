using System;
using System.Data;
using System.Linq;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Registration_form : Form
    {
        
        SqlConnection conn = new SqlConnection("Data Source=HASNAIN\\HASNAINDB;Initial Catalog=library_management_db;User ID=sa;Password=hasnaindb123");
        public Registration_form()
        {
            InitializeComponent();
          
            
        }
        private void Registration_form_Load(object sender, EventArgs e)
        {
            
            //Fill the DataTable with records from Table.
            string Query = "select user_type_id, user_type from user_type_tbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //Insert the Default Item to DataTable.

            DataRow row = dt.NewRow();
            row[0] = 0;
            row[1] = "Select user type";
            dt.Rows.InsertAt(row, 0);
            //Assign DataTable as DataSource.
            user_type_combo.DataSource = dt;
            user_type_combo.DisplayMember = "user_type";
            user_type_combo.ValueMember = "user_type_id";
        }
       
        private void Submit_btn(object sender, EventArgs e)
        {
            
            
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                   // MessageBox.Show("Connection Have been made");// delete it after success
                    if(conn.State == ConnectionState.Open)
                    {
                        try
                        {
                            
                            string Query = "insert into user_registration_tbl (name,email,phone_no,password,type_combo_box , gender , user_register_date_time) values ('" + name_txt_box.Text + "','" + email_txt_box.Text + "','" + phone_no_txt_box.Text + "','" + password_txt_box.Text + "' , '" + Convert.ToInt32(user_type_combo.SelectedValue) + "' , '" + Getgender() +"','" + DateTime.Now.ToString() + "')";


                            SqlDataAdapter sda = new SqlDataAdapter(Query, conn);
                            sda.SelectCommand.ExecuteNonQuery();
                            MessageBox.Show("User registerd successfully");
                            login_form login = new login_form();
                            login.Show();
                            this.Hide();
                            

                            
                            conn.Close();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }
       private int Getgender()
        {
            if (male_radio_btn.Checked)
            {
                return 1;
            }
            else if (female_radio_btn.Checked)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
        
    }
}
