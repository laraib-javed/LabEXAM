using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace LAB
{
    public partial class Statics : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
              
                int totalSubmissions = (Application["total_submissions"] != null) ? (int)Application["total_submissions"] : 0;
                Response.Write("Total Submissions: " + totalSubmissions.ToString() + "<br/>");

              
                string lastStudent = (Session["StudentName"] != null) ? Session["StudentName"].ToString() : "N/A";
                Response.Write("Last Student: " + lastStudent);
            }
        }

        }
}
