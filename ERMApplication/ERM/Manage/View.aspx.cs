using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ERMApplication.ERM.Manage
{
    public partial class View : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonEdit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Edit.aspx?id=" + Request.QueryString["id"]);
        }

        protected void buttonDelete_Click(object sender, EventArgs e)
        {
            Response.Redirect("Delete.aspx?id=" + Request.QueryString["id"]);
        }

        protected void buttonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dashboard.aspx");
        }
    }
}