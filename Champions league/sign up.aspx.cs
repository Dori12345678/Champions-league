using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Champions_league.DataSet1TableAdapters;

namespace Champions_league
{
    public partial class sign_up : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void submit(object sender, EventArgs e)
        {
            TableTableAdapter adapter = new TableTableAdapter();
            int errorCount = 0;
            List<string> errorMessages = new List<string>();

            if (string.IsNullOrEmpty(userName.Text))
            {
                errorCount++;
                errorMessages.Add("Username is required.");
            }
            if (string.IsNullOrEmpty(firstName.Text) || !Regex.IsMatch(firstName.Text, @"^[a-zA-Z]+$"))
            {
                errorCount++;
                errorMessages.Add("First name is required and must contain only letters.");
            }
            if (string.IsNullOrEmpty(lastName.Text) || !Regex.IsMatch(lastName.Text, @"^[a-zA-Z]+$"))
            {
                errorCount++;
                errorMessages.Add("Last name is required and must contain only letters.");
            }
            if (string.IsNullOrEmpty(password.Text) || !IsValidPassword(password.Text))
            {
                errorCount++;
                errorMessages.Add("Password is required and must be at least 8 characters long and contain at least one number.");
            }
            if (sexChoise.SelectedIndex == -1)
            {
                errorCount++;
                errorMessages.Add("Gender selection is required.");
            }

            if (errorCount > 2)
            {
                updateText("Almost nothing is filled correctly. Please correct the following errors:<br />" + string.Join("<br />", errorMessages), Color.Red);
            }
            else if (errorCount > 0)
            {
                updateText($"You need to correct {errorCount} more field{(errorCount > 1 ? "s" : "")}:<br />" + string.Join("<br />", errorMessages), Color.Red);
            }
            else
            {
                if (adapter.CheckUserExist(userName.Text) == 0)
                {
                    updateText("All fields are filled correctly", Color.Green);
                    Session["username"] = userName.Text;
                    adapter.InsertQuery(userName.Text, password.Text);
                }
                else
                {
                    updateText("username already exists", Color.Red);
                }
            }
        }
        bool IsValidPassword(string password)
        {
            return password.Length >= 8 && Regex.IsMatch(password, @"\d");
        }

        void updateText(string text, Color color)
        {
            errorMessage.ForeColor = color;
            errorMessage.Text = text;
        }
    }
}