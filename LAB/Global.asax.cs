using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace LAB
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            Application["total_Submissions"] = 0;
            int count = (int)Application["total_Submissions"]+1;

        }
        protected void Session_Start(object sender, EventArgs e)
        {
            
            Application["Last_StudentNmae"] = (int)Application["totalsessions"] + 1;
        }
    }
}