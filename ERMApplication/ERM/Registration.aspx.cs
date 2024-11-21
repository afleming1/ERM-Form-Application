using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
                ErrorPanel.Visible = false;
                ErrorMessage.Text = "Please provide your first name";

                textFirstName.Focus();

                return false;
            }
            else if (textLastName.Text == string.Empty)
            {
                ErrorPanel.Visible = false;
                ErrorMessage.Text = "Please provide your last first name";

                textLastName.Focus();

                return false;
            }
            else if (textEmail.Text == string.Empty)
            {
                ErrorPanel.Visible = false;
                ErrorMessage.Text = "Please provide your email address";

                textEmail.Focus();

                return false;
            }
            else if (textConfirmEmail.Text == string.Empty)
            {
                ErrorPanel.Visible = false;
                ErrorMessage.Text = "Please confirm your email address";

                textConfirmEmail.Focus();

                return false;
            }
            else if (textEmail != textConfirmEmail)
            {
                ErrorPanel.Visible = false;
                ErrorMessage.Text = "Please double check and confirm your email address";

                textConfirmEmail.Focus();

                return false;
            }
            else if (textAddress.Text == string.Empty)
            {
                ErrorPanel.Visible = false;
                ErrorMessage.Text = "Please provide your address";

                textAddress.Focus();

                return false;
            }
            else if (textCity.Text == string.Empty)
            {
                ErrorPanel.Visible = false;
                ErrorMessage.Text = "Please provide your city";

                textCity.Focus();

                return false;
            }
            else if (textState.Text == string.Empty)
            {
                ErrorPanel.Visible = false;
                ErrorMessage.Text = "Please provide your state";

                textState.Focus();

                return false;
            }
            else if (listRates.SelectedValue == "NULL")
            {
                ErrorPanel.Visible = false;
                ErrorMessage.Text = "Please select a rate";

                listRates.Focus();

                return false;
            }
            else if (optionRegular.Checked == false && optionKosher.Checked == false && optionVegetarian.Checked == false && optionVegan.Checked == false && optionFruit.Checked == false && optionGluten.Checked == false && optionLactose.Checked == false)
            {
                ErrorPanel.Visible = false;
                ErrorMessage.Text = "Please choose a lunch option";

                optionRegular.Focus();

                return false;
            }
            else
            {
                return true;
            }
        }

        protected void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (VerifyForm() == true)
            {
                Response.Redirect("ThankYou.aspx");
            }
        }        

        protected void buttonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.soa.org/");
        }
    }
}