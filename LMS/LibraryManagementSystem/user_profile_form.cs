using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class User_profile_form : Form
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        public User_profile_form()
        {
            InitializeComponent();
        }
        
        
        private void User_profile_form_Load(object sender, EventArgs e)
        {
            LoadCategory();
            name_lbl.Text = login_form.getemail;// ruko check krta hun
        }

        public void LoadCategory()
        {
            using (conn = new SqlConnection(ConnectionString))
            {
                try
                {

                    //Fill the DataTable with records from Table.
                    string Query = "select * from category_tbl";
                    SqlDataAdapter sda = new SqlDataAdapter(Query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    //Insert the Default Item to DataTable.

                    DataRow row = dt.NewRow();
                    row[0] = 0;
                    row[1] = "Select Category";
                    dt.Rows.InsertAt(row, 0);

                    //Assign DataTable as DataSource

                    catagory_combo.DataSource = dt;
                    catagory_combo.DisplayMember = "category_type";
                    catagory_combo.ValueMember = "category_id";


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
            
        private void Loan_itm_btn_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(ConnectionString))
            {
             /*   conn.Open();
                string query = "insert into item_tbl (category_name, item_name,item_added_date) values  (@category_id ,  @item_name, @date)";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@category_id", Convert.ToInt32(Category_combo.SelectedValue));
                cmd.Parameters.AddWithValue("@item_name", item_name_txt.Text);
                cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("added successfully");
                }
                else
                {
                    MessageBox.Show("Not added");
                }
                */
            }
        }

        

        private void Catagory_combo_DropDownClosed(object sender, EventArgs e)
        {
            string selectedCatagory_id = Convert.ToString(catagory_combo.SelectedValue);
            using (conn = new SqlConnection(ConnectionString))
            {
                try
                {

                    //Fill the DataTable with records from Table.
                    string Query = "select * from item_tbl where category_name = " + selectedCatagory_id;
                    SqlDataAdapter sda = new SqlDataAdapter(Query, conn);
                    DataTable dt = new DataTable();

                    sda.Fill(dt);

                    item_combo.DataSource = dt;
                    item_combo.DisplayMember = "item_name";
                    item_combo.ValueMember = "item_id";


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
        }
       
    }
}
