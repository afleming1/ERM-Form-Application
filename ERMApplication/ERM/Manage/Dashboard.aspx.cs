using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace ERMApplication.ERM.Manage
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DisplayGrid();
            }
        }

        protected void DisplayGrid()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ERMConnection"].ConnectionString;
            string SQL = "SELECT RegID, FirstName + ' ' + LastName AS Name, CONVERT(varchar, DateTimeCreated, 1) AS DateTimeCreated FROM RegistrationTable WHERE IsDeleted = 0 ORDER BY Name";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(SQL, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataSet data = new DataSet();

                adapter.Fill(data, "RegistrationTable");

                RegistrationGrid.DataSource = data;
                RegistrationGrid.DataBind();

                if (data.Tables[0].Rows.Count == 0)
                {
                    labelNoRecords.Visible = true;
                    RegistrationGrid.Visible = false;
                }
                else
                {
                    labelNoRecords.Visible = false;
                    RegistrationGrid.Visible = true;
                }
            }
        }

        protected void RegistrationGrid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            RegistrationGrid.PageIndex = e.NewPageIndex;

            DisplayGrid();
        }
    }
}