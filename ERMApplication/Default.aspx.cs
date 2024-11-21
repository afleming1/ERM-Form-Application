using System;

namespace ERMApplication
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Redirect("/ERM/Registration.aspx");
        }
    }
}