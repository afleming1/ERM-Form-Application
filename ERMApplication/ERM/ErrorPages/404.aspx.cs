using System;

namespace ERMApplication.ERM.ErrorPages
{
    public partial class _404 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/ERM/Registration.aspx");
        }
    }
}