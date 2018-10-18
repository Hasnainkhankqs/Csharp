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
    public partial class For_librarian_requests_form : Form
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        public For_librarian_requests_form()
        {
            InitializeComponent();
        }

        private void For_librarian_requests_form_Load(object sender, EventArgs e)
        {
            LoanHistory(requests_gridview);
        }
        public void LoanHistory(DataGridView x)
        {
            using (conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    DateTime now = DateTime.Now;
                    string query = "select R.user_id , R.name , R.email , R.phone_no , C.category_type , I.item_name , L.loan_date , L.due_date from user_registration_tbl R join loan_tbl L on R.user_id = L.user_id join item_tbl I on L.item_id = I.item_id join category_tbl C on I.category_name = C.category_id where L.due_date > @now";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@now", now);
                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable();
                    //ds.Tables["Loan History"];
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "1");
                    x.DataSource = ds.Tables["1"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }
    }
}
