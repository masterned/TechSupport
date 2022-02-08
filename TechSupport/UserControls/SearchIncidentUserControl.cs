using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    /// <summary>
    /// Panel contains all necessary controls to search for a specific incident.
    /// </summary>
    public partial class SearchIncidentUserControl : UserControl
    {
        private readonly IncidentController IncidentController;

        /// <summary>
        /// Creates new SearchIncidentUserControl & initializes its component & controller.
        /// </summary>
        public SearchIncidentUserControl()
        {
            InitializeComponent();

            IncidentController = new IncidentController();
        }

        private void ShowErrorMessage(string errorMessage)
        {
            ErrorMessage.Text = errorMessage;
            ErrorMessage.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            ErrorMessage.Hide();

            if (string.IsNullOrEmpty(CustomerIDTextBox.Text.Trim()))
            {
                ShowErrorMessage("Please enter a CustomerID");
                return;
            }

            try
            {
                List<Incident> customerIncidents =
                    IncidentController.GetIncidentsOfCustomer(int.Parse(CustomerIDTextBox.Text.Trim()));

                IncidentGridView.DataSource = null;
                IncidentGridView.DataSource = customerIncidents;
            }
            catch (FormatException)
            {
                ShowErrorMessage("CustomerID must be a whole number");
            }
            catch (Exception exception)
            {
                ShowErrorMessage(exception.Message);
            }
        }

        private void CustomerIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ErrorMessage.Visible)
                ErrorMessage.Hide();
        }
    }
}
