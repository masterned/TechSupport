using System;
using System.Windows.Forms;

namespace TechSupport.View
{
    /// <summary>
    /// Serves as a primary container for all of the sub-application tabs.
    /// </summary>
    public partial class MainDashboard : Form
    {
        private readonly LoginForm LoginForm;

        /// <summary>
        /// Stores reference to parent LoginForm & initializes the component & object.
        /// </summary>
        /// <param name="loginForm"></param>
        public MainDashboard(LoginForm loginForm)
        {
            InitializeComponent();

            LoginForm = loginForm;
        }

        /// <summary>
        /// Sets the username in the username Label to the passed value.
        /// </summary>
        /// <param name="username">The new string for the username Label text</param>
        public void SetUsername(string username)
        {
            UsernameLabel.Text = username;
        }

        /// <summary>
        /// Handles the event fired when the logout LabelLink is clicked.
        /// </summary>
        /// <param name="sender">The logout LabelLink</param>
        /// <param name="e">Event arguments</param>
        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            LoginForm.Show();
        }

        /// <summary>
        /// Handles the event fired when the form is closing.
        /// Makes sure that the entire application closes.
        /// </summary>
        /// <param name="sender">The Main form</param>
        /// <param name="e">Event arguments</param>
        private void MainDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void DisplayOpenIncidentsTabPage_Enter(object sender, EventArgs e)
        {
            displayOpenIncidentsUserControl.RefreshListView();
        }

        private void AddIncidentTabPage_Enter(object sender, EventArgs e)
        {
            AddIncidentUserControl.ResetInputFields();
        }

        private void UpdateIncidentTabPage_Enter(object sender, EventArgs e)
        {
            UpdateIncidentUserControl.PopulateTechnicianComboBox();
        }
    }
}
