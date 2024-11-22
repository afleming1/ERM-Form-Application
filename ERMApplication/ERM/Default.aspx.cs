using System;

namespace ERMApplication.ERM
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }
    }
}