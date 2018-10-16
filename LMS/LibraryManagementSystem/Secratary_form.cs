using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace LibraryManagementSystem
{
    public partial class Secratary_form : Form
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        public Secratary_form()
        {
            InitializeComponent();
        }

        private void Secratary_form_Load(object sender, EventArgs e)
        {
            LoadCategoryy();
           
        }

       
        public void LoadCategoryy()
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

                    Category_combo.DataSource = dt;
                    Category_combo.DisplayMember = "category_type";
                    Category_combo.ValueMember = "category_id";




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Insert_item_btn_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
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

            }
            
        }
    }
}
