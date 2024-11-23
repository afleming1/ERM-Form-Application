using System;

namespace ERMApplication.ERM.ErrorPages
{
    public partial class Error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonReturn_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == "management")
            {
                Response.Redirect("/ERM/Manage/View.aspx");
            }
            else
            {
                Response.Redirect("/ERM/Registration.aspx");
            }
        }
    }
}