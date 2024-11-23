using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ERMApplication.ERM.Manage
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected bool VerifyForm()
        {
            if (checkConfirm.Checked == false)
            {
                ErrorPanel.Visible = true;
                ErrorMessage.Text = "Please confirm your removal request";

                return false;
            }
            else
            {
                return true;
            }
        }

        protected bool DeleteRegistration(string RegID)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ERMConnection"].ConnectionString;
                string SQL = "UPDATE RegistrationTable SET IsDeleted = 1, DateTimeDeleted = @DateTimeDeleted WHERE RegID = @RegID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(SQL, connection);

                    command.Parameters.AddWithValue("@RegID", RegID);
                    command.Parameters.AddWithValue("@DateTimeDeleted", DateTime.Now);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        protected void buttonDelete_Click(object sender, EventArgs e)
        {
            if (VerifyForm() == true)
            {
                if (DeleteRegistration(Request.QueryString["id"]) == true)
                {
                    Response.Redirect("Dashboard.aspx");
                }
                else
                {
                    Response.Redirect("/ERM/ErrorPages/Error.aspx");
                }
            }
        }

        protected void buttonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("View.aspx?id=" + Request.QueryString["id"]);
        }
    }
}