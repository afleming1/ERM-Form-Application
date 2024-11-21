using System;
using System.Configuration;
using System.Data.SqlClient;

namespace ERMApplication.ERM
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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

        protected bool AddRegistration()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ERMConnection"].ConnectionString;
                string SQL = "INSERT INTO RegistrationTable (RegID, FirstName, LastName, EmailAddress, Address, City, State, Rates, Lunch, Audio, Visual, Mobile, DateTimeCreated) VALUES (@RegID, @FirstName, @LastName, @EmailAddress, @Address, @City, @State, @Rate, @Lunch, @Audio, @Visual, @Mobile, @DateTimeCreated)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(SQL, connection);

                    command.Parameters.AddWithValue("@RegID", Guid.NewGuid().ToString());

                    command.Parameters.AddWithValue("@FirstName", textFirstName.Text);
                    command.Parameters.AddWithValue("@LastName", textLastName.Text);

                    command.Parameters.AddWithValue("@EmailAddress", textEmail.Text);

                    command.Parameters.AddWithValue("@Address", textAddress.Text);
                    command.Parameters.AddWithValue("@City", textCity.Text);
                    command.Parameters.AddWithValue("@State", textState.Text);

                    command.Parameters.AddWithValue("@Rate", listRates.SelectedValue);

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
                    command.Parameters.AddWithValue("@Visual", CheckVisual.Checked);
                    command.Parameters.AddWithValue("@Mobile", CheckMobile.Checked);

                    command.Parameters.AddWithValue("@DateTimeCreated", DateTime.Now);

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

        protected void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (VerifyForm() == true)
            {
                if (AddRegistration() == true)
                {
                    Response.Redirect("ThankYou.aspx");
                }
                else
                {
                    Response.Redirect("Error.aspx");
                }
            }
        }        

        protected void buttonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.soa.org/");
        }
    }
}