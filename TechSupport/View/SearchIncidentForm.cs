using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{
    /// <summary>
    /// Form allows the user to search for incidents tied to a CustomerID.
    /// </summary>
    public partial class SearchIncidentForm : Form
    {
        private IncidentController IncidentController;

        /// <summary>
        /// Creates a SearchIncidentDialog
        /// and initializes its IncidentController
        /// </summary>
        public SearchIncidentForm()
        {
            InitializeComponent();
            IncidentController = new IncidentController();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            ErrorMessage.Visible = false;

            if (string.IsNullOrEmpty(CustomerIDTextBox.Text.Trim()))
            {
                ErrorMessage.Text = "Please enter a CustomerID";
                ErrorMessage.Visible = true;
                return;
            }

            try
            {
                List<Incident> customerIncidents =
                    IncidentController.GetIncidentsOfCustomer(int.Parse(CustomerIDTextBox.Text.Trim()));

                IncidentGridView.DataSource = null;
                IncidentGridView.DataSource = customerIncidents;
            }
            catch (KeyNotFoundException keyNotFoundException)
            {
                ErrorMessage.Text = keyNotFoundException.Message;
                ErrorMessage.Visible = true;
            }
        }

        private void CustomerIDTextBox_TextChanged(object sender, EventArgs e)
        {
            ErrorMessage.Visible = false;
        }
    }
}
