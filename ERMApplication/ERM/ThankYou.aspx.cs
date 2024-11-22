using System;

namespace ERMApplication.ERM
{
    public partial class ThankYou : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonDashboard_Click(object sender, EventArgs e)
        {
            Response.Redirect("/ERM/Manage/Dashboard.aspx");
        }
    }
}