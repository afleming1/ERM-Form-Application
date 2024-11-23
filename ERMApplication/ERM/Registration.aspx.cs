using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ERMApplication.ERM
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Displays error panel
        /// </summary>
        /// <param name="shouldDisplay">Should the error panel display</param>
        /// <param name="errorText">The error text</param>
        /// <param name="textBox">The corresponding control</param>
        /// <returns>False</returns>
        protected bool DisplayErrorPanel(bool shouldDisplay, string errorText, Control control)
        {
            if (shouldDisplay == true)
            {
                ErrorPanel.Visible = true;
                ErrorMessage.Text = errorText;

                control.Focus();

                return false;
            }
            else
            {
                return true;
            }            
        }

        protected bool VerifyForm()
        {
            if (textFirstName.Text == string.Empty)
            {
                return DisplayErrorPanel(true, "Please provide your first name", textFirstName);
            }
            else if (textLastName.Text == string.Empty)
            {
                return DisplayErrorPanel(true, "Please provide your last first name", textLastName);
            }
            else if (textEmail.Text == string.Empty)
            {
                return DisplayErrorPanel(true, "Please provide your email address", textEmail);    
            }
            else if (textConfirmEmail.Text == string.Empty)
            {
                return DisplayErrorPanel(true, "Please confirm your email address", textConfirmEmail);
            }
            else if (textEmail.Text != textConfirmEmail.Text)
            {
                return DisplayErrorPanel(true, "Please double check and confirm your email address", textConfirmEmail);
            }
            else if (textAddress.Text == string.Empty)
            {
                return DisplayErrorPanel(true, "Please provide your address", textAddress);
            }
            else if (textCity.Text == string.Empty)
            {
                return DisplayErrorPanel(true, "Please provide your city", textCity);
            }
            else if (textState.Text == string.Empty)
            {
                return DisplayErrorPanel(true, "Please provide your state", textState);
            }
            else if (listRates.SelectedValue == "NULL")
            {
                return DisplayErrorPanel(true, "Please select a rate", listRates);
            }
            else if (optionRegular.Checked == false && optionKosher.Checked == false && optionVegetarian.Checked == false && optionVegan.Checked == false && optionFruit.Checked == false && optionGluten.Checked == false && optionLactose.Checked == false)
            {
                return DisplayErrorPanel(true, "Please choose a lunch option", optionRegular);
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
                    command.Parameters.AddWithValue("@Visual", checkVisual.Checked);
                    command.Parameters.AddWithValue("@Mobile", checkMobile.Checked);

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
                    Response.Redirect("/ERM/ErrorPages/Error.aspx");
                }
            }
        }        

        protected void buttonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.soa.org/");
        }
    }
}