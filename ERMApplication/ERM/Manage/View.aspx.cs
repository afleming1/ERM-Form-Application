using System;
using System.Configuration;
using System.Data.SqlClient;

namespace ERMApplication.ERM.Manage
{
    public partial class View : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetDetails(Request.QueryString["id"]);
        }

        protected void GetDetails(string RegID)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ERMConnection"].ConnectionString;
                string SQL = "SELECT * FROM RegistrationTable WHERE RegID = '" + RegID + "';";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(SQL, connection)
                    {
                        Connection = connection
                    };

                    command.Connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            labelFirstName.Text = reader["FirstName"].ToString();
                            labelLastName.Text = reader["LastName"].ToString();

                            labelEmail.Text = reader["EmailAddress"].ToString();

                            labelAddress.Text = reader["Address"].ToString();
                            labelCity.Text = reader["City"].ToString();
                            labelState.Text = reader["State"].ToString();

                            labelRates.Text = reader["Rates"].ToString();
                            labelLunch.Text = reader["Lunch"].ToString();

                            if (reader["Audio"].ToString() == "1")
                            {
                                labelAudio.Text = "Yes";
                            }
                            else
                            {
                                labelAudio.Text = "No";
                            }

                            if (reader["Visual"].ToString() == "1")
                            {
                                labelVisual.Text = "Yes";
                            }
                            else
                            {
                                labelVisual.Text = "No";
                            }

                            if (reader["Mobile"].ToString() == "1")
                            {
                                labelMobile.Text = "Yes";
                            }
                            else
                            {
                                labelMobile.Text = "No";
                            }
                        }
                    }

                    reader.Close();
                    connection.Close();
                }
            }
            catch
            {

            }
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