using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Web.UI;

namespace LAB
{
    public partial class AddFeedback : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Laraib_DB.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            

            bool isValid = true;
            if (StudentName.Text ==" ")
            {
                StudentNameError.Text = "Student name is required.";
                isValid = false;
            }

            if (CourseName.Text =="")
            {
                CourseNameError.Text = "Course name is required.";
                isValid = false;
            }

            if (Comments.Text=="")
            {
                CommentsError.Text = "Comments are required.";
                isValid = false;
            }

            if(Phone.Text.Length != 11)
            {
                PhoneError.Text = "Phone must be a 11 digit number.";
                isValid = false;
            }

         
            
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Feedback (StudentName, CourseName, Comments, Phone) VALUES (@StudentName, @CourseName, @Comments, @Phone)", con);
            cmd.Parameters.AddWithValue("@StudentName", StudentName.Text);
            cmd.Parameters.AddWithValue("@CourseName", CourseName.Text);
            cmd.Parameters.AddWithValue("@Comments", Comments.Text);
            cmd.Parameters.AddWithValue("@Phone", Phone.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            
        }
    }
}
