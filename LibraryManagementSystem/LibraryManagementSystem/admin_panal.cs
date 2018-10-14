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
    public partial class Admin_panal : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=HASNAIN\\HASNAINDB;Initial Catalog=library_management_db;User ID=sa;Password=hasnaindb123");
        public Admin_panal()
        {
            InitializeComponent();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string Query = "select * from user_registration_tbl where name like" + "'%" + search_txt_box.Text.Trim() + "%'";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = ds.Tables[0].ToString(); 
                    conn.Close();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void Admin_panal_Load(object sender, EventArgs e)
        {
            try
            {
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string Query = "select * from user_registration_tbl ";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = ds.Tables[0].ToString();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void Delete_btn(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string Query = "delete from user_registration_tbl where user_id = " + 1 ;
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = ds.Tables[0].ToString();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            string Query = "update Customers SET ContactName = 'ali', City = 'karacho' WHERE CustomerName = 'farhan'; ";
            SqlCommand cmd = new SqlCommand(Query, conn);
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables[0].ToString();
            conn.Close();
        }
        
        
    }
}
