using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TermProjectSolution
{
    public partial class Feed : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ProfileButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }
    }
}