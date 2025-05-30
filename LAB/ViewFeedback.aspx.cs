using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace LAB
{
    public partial class ViewFeedback : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Laraib_DB.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadFeedback();
            }
        }

        private void LoadFeedback()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Feedback", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Feedback WHERE FeedbackID = 2", con);
            cmd.ExecuteNonQuery();
            con.Close();
            LoadFeedback(); 
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Feedback SET CourseName = 'DSA', Comments = 'No Comment' WHERE FeedbackID = 1", con);
            cmd.ExecuteNonQuery();
            con.Close();
            LoadFeedback(); 
        }
    }
}
