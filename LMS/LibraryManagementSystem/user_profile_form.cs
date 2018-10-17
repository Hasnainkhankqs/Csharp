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
        int user_id = 0;
        int item_counting ;
        public User_profile_form()
        {
            InitializeComponent();
        }
        
        
        private void User_profile_form_Load(object sender, EventArgs e)
        {
           
            remaining_count.Text = Convert.ToString("You have selected " + 0 +" /5 ");
            LoadCategory();
            Load_basic_info();
           /* using (conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    string Query = "select * FROM user_registration_tbl WHERE email = @email";
                    cmd = new SqlCommand(Query, conn);

                    cmd.Parameters.AddWithValue("@email", "tayyab@gmail.com");
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        user_id = Convert.ToInt32(dr["user_id"]);
                        name_lbl.Text = Convert.ToString(dr["name"]);
                        email_lbl.Text = Convert.ToString(dr["email"]);
                        phone_no_lbl.Text = Convert.ToString(dr["phone_no"]);
                    }

                   
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }*/
        }

        
            
        private void Loan_itm_btn_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string count = "select item_count from loan_tbl where user_id = @user_id";
                cmd = new SqlCommand(count, conn);
                cmd.Parameters.AddWithValue("@user_id", user_id);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    item_counting = Convert.ToInt32(dr["item_count"]);

                }
            }
            if (item_counting < 5)
            {
                
                item_counting++;

                if (LoanChecking() == true)
                {
                    using (conn = new SqlConnection(ConnectionString))
                    {
                        if (Convert.ToInt32(item_combo.SelectedValue) != 0)
                        {
                            conn.Open();
                            string item_due = "";
                            string query = "insert into loan_tbl (user_id,item_id,item_count,loan_date,category_id ,due_date) values  (@user_id ,  @item_id, @item_counting,@loan_date,@category_id,@due_date)";
                            cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@user_id", user_id);
                            cmd.Parameters.AddWithValue("@item_id", Convert.ToInt32(item_combo.SelectedValue));
                            cmd.Parameters.AddWithValue("@item_counting", item_counting);
                            cmd.Parameters.AddWithValue("@loan_date", DateTime.Now.ToString());
                            cmd.Parameters.AddWithValue("@category_id", Convert.ToInt32(catagory_combo.SelectedValue));
                            if (Convert.ToInt32(catagory_combo.SelectedValue) == 1)
                            {
                                item_due = DateTime.Now.AddDays(28).ToString();
                            }
                            else
                            {
                                item_due = DateTime.Now.AddDays(7).ToString();
                            }
                            cmd.Parameters.AddWithValue("@due_date", item_due);
                            int row = cmd.ExecuteNonQuery();

                            if (row > 0)
                            {
                                MessageBox.Show("added successfully");
                                remaining_count.Text = Convert.ToString("You have selected " + item_counting + " /5 ");
                            }
                            else
                            {
                                MessageBox.Show("Not added");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Select Category First");
                            item_counting = 0;
                        }

                    } 
                }
                else
                {
                    MessageBox.Show("Your dues are not clear");
                }
                
            }
            else
            {
                MessageBox.Show("You can not book more than 5 items");
            }
            
        }

        

        private void Catagory_combo_DropDownClosed(object sender, EventArgs e)
        {
            ItemLoad();
        }

        
        public void Fine()
        {
            string query = "select * from loan_tbl where user_id = @user_id";
            using (conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                cmd = new SqlCommand(query,conn);
                cmd.Parameters.AddWithValue("@user_id", user_id);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                   DateTime da = Convert.ToDateTime(dr["loan_date"]);
                    if(Convert.ToInt32(dr["category_id"]) == 1)
                    {
                       // if(DateTime() - da)
                       // int totalWeekSec = 2419200;
                    }
                    else
                    {

                    }
                }
            }
        }

        #region load item on select combo box event
        public void ItemLoad()
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
        #endregion


        #region Load item Category
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
        #endregion


        #region load user basic info // user id yad rakhna
        public void Load_basic_info()
        {
            using (conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    string Query = "select * FROM user_registration_tbl WHERE email = @email";
                    cmd = new SqlCommand(Query, conn);


                    if (login_form.getemail != null)
                    {

                        cmd.Parameters.AddWithValue("@email", login_form.getemail);
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                           user_id = Convert.ToInt32(dr["user_id"]);
                            name_lbl.Text = Convert.ToString(dr["name"]);
                            email_lbl.Text = Convert.ToString(dr["email"]);
                            phone_no_lbl.Text = Convert.ToString(dr["phone_no"]);
                        }
                    }
                    else
                    {

                        cmd.Parameters.AddWithValue("@email", Registration_form.getemail);
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            user_id = Convert.ToInt32(dr["user_id"]);
                            name_lbl.Text = Convert.ToString(dr["name"]);
                            email_lbl.Text = Convert.ToString(dr["email"]);
                            phone_no_lbl.Text = Convert.ToString(dr["phone_no"]);
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion


        #region // checking loan
        public bool LoanChecking()
        {
            using (conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    //Fill the DataTable with records from Table.
                    string Query = "select due_date from loan_tbl";
                    cmd = new SqlCommand(Query,conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        DateTime get_due_date = Convert.ToDateTime(dr["due_date"]);
                        if(get_due_date < DateTime.Now)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return true;
                
            }
        }
        #endregion
    }
}
