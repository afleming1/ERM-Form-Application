using System;

namespace ERMApplication.ERM.Manage
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Redirect("/ERM/Manage/Dashboard.aspx");
        }
    }
}