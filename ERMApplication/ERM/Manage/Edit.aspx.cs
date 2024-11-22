using System;
using System.Configuration;
using System.Data.SqlClient;

namespace ERMApplication.ERM.Manage
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetDetails(Request.QueryString["id"]);
            }            
        }

        protected void GetDetails(string RegID)
        {
            //try
            //{
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
                            textFirstName.Text = reader["FirstName"].ToString();
                            textLastName.Text = reader["LastName"].ToString();

                            textEmail.Text = reader["EmailAddress"].ToString();

                            textAddress.Text = reader["Address"].ToString();
                            textCity.Text = reader["City"].ToString();
                            textState.Text = reader["State"].ToString();

                            listRates.SelectedValue = reader["Rates"].ToString();
                            
                            switch (reader["Lunch"].ToString())
                            {
                                case "Regular":
                                    optionRegular.Checked = true;
                                    break;
                                case "Kosher":
                                    optionKosher.Checked = true;
                                    break;
                                case "Vegetarian":
                                    optionVegetarian.Checked = true;
                                    break;
                                case "Vegan":
                                    optionVegan.Checked = true;
                                    break;
                                case "Fruit Plate":
                                    optionFruit.Checked = true;
                                    break;
                                case "Gluten Free":
                                    optionGluten.Checked = true;
                                    break;
                                case "Lactose Free":
                                    optionLactose.Checked = true;
                                    break;
                                default:
                                    break;
                            }

                            if (reader["Audio"].ToString() == "1")
                            {
                                checkAudio.Checked = true;
                            }

                            if (reader["Visual"].ToString() == "1")
                            {
                                checkVisual.Checked = true;
                            }

                            if (reader["Mobile"].ToString() == "1")
                            {
                                checkMobile.Checked = true;
                            }
                        }
                    }

                    reader.Close();
                    connection.Close();
                }
            //}
            //catch
            //{

            //}
        }

        protected bool VerifyForm()
        {
            if (textFirstName.Text == string.Empty)
            {
                ErrorPanel.Visible = true;
                ErrorMessage.Text = "Please provide your first name";

                textFirstName.Focus();

                return false;
            }
            else if (textLastName.Text == string.Empty)
            {
                ErrorPanel.Visible = true;
                ErrorMessage.Text = "Please provide your last first name";

                textLastName.Focus();

                return false;
            }
            else if (textEmail.Text == string.Empty)
            {
                ErrorPanel.Visible = true;
                ErrorMessage.Text = "Please provide your email address";

                textEmail.Focus();

                return false;
            }
            else if (textConfirmEmail.Text == string.Empty)
            {
                ErrorPanel.Visible = true;
                ErrorMessage.Text = "Please confirm your email address";

                textConfirmEmail.Focus();

                return false;
            }
            else if (textEmail.Text != textConfirmEmail.Text)
            {
                ErrorPanel.Visible = true;
                ErrorMessage.Text = "Please double check and confirm your email address";

                textConfirmEmail.Focus();

                return false;
            }
            else if (textAddress.Text == string.Empty)
            {
                ErrorPanel.Visible = true;
                ErrorMessage.Text = "Please provide your address";

                textAddress.Focus();

                return false;
            }
            else if (textCity.Text == string.Empty)
            {
                ErrorPanel.Visible = true;
                ErrorMessage.Text = "Please provide your city";

                textCity.Focus();

                return false;
            }
            else if (textState.Text == string.Empty)
            {
                ErrorPanel.Visible = true;
                ErrorMessage.Text = "Please provide your state";

                textState.Focus();

                return false;
            }
            else if (listRates.SelectedValue == "NULL")
            {
                ErrorPanel.Visible = true;
                ErrorMessage.Text = "Please select a rate";

                listRates.Focus();

                return false;
            }
            else if (optionRegular.Checked == false && optionKosher.Checked == false && optionVegetarian.Checked == false && optionVegan.Checked == false && optionFruit.Checked == false && optionGluten.Checked == false && optionLactose.Checked == false)
            {
                ErrorPanel.Visible = true;
                ErrorMessage.Text = "Please choose a lunch option";

                optionRegular.Focus();

                return false;
            }
            else
            {
                return true;
            }
        }

        protected bool UpdateRegistration(string RegID)
        {
            //try
            //{
                string connectionString = ConfigurationManager.ConnectionStrings["ERMConnection"].ConnectionString;
            string SQL = "UPDATE RegistrationTable SET FirstName = @FirstName, LastName = @LastName, EmailAddress = @EmailAddress, Address = @Address, City = @City, State = @State, Rates = @Rates, Lunch = @Lunch, Audio = @Audio, Visual = @Visual, Mobile = @Mobile, DateTimeModified = @DateTimeModified WHERE RegID = @RegID;";

            using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(SQL, connection);

                    command.Parameters.AddWithValue("@RegID", RegID);

                    command.Parameters.AddWithValue("@FirstName", textFirstName.Text);
                    command.Parameters.AddWithValue("@LastName", textLastName.Text);

                    command.Parameters.AddWithValue("@EmailAddress", textEmail.Text);

                    command.Parameters.AddWithValue("@Address", textAddress.Text);
                    command.Parameters.AddWithValue("@City", textCity.Text);
                    command.Parameters.AddWithValue("@State", textState.Text);

                    command.Parameters.AddWithValue("@Rates", listRates.SelectedValue);

                    if (optionRegular.Checked == true)
                    {
                        command.Parameters.AddWithValue(@"Lunch", "Regular");
                    }
                    else if (optionKosher.Checked == true)
                    {
                        command.Parameters.AddWithValue(@"Lunch", "Kosher");
                    }
                    else if (optionVegetarian.Checked == true)
                    {
                        command.Parameters.AddWithValue(@"Lunch", "Vegetarian");
                    }
                    else if (optionVegan.Checked == true)
                    {
                        command.Parameters.AddWithValue(@"Lunch", "Vegan");
                    }
                    else if (optionFruit.Checked == true)
                    {
                        command.Parameters.AddWithValue(@"Lunch", "Fruit Plate");
                    }
                    else if (optionGluten.Checked == true)
                    {
                        command.Parameters.AddWithValue(@"Lunch", "Gluten Free");
                    }
                    else if (optionLactose.Checked == true)
                    {
                        command.Parameters.AddWithValue(@"Lunch", "Lactose Free");
                    }

                    command.Parameters.AddWithValue("@Audio", checkAudio.Checked);
                    command.Parameters.AddWithValue("@Visual", checkVisual.Checked);
                    command.Parameters.AddWithValue("@Mobile", checkMobile.Checked);

                    command.Parameters.AddWithValue("@DateTimeModified", DateTime.Now);

                    connection.Open();

                    command.ExecuteNonQuery();
                }

                return true;
            //}
            //catch
            //{
                //return false;
            //}
        }

        protected void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (VerifyForm() == true)
            {
                if (UpdateRegistration(Request.QueryString["id"]) == true)
                {
                    Response.Redirect("Dashboard.aspx");
                }
                else
                {
                    Response.Redirect("Error.aspx");
                }
            }
        }

        protected void buttonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("View.aspx?id=" + Request.QueryString["id"]);
        }
    }
}