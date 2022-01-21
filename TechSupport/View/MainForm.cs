using System.Windows.Forms;

namespace TechSupport.View
{
    /// <summary>
    /// Serves as the application's main window.
    /// Will display the core functionality of the program.
    /// </summary>
    public partial class MainForm : Form
    {
        LoginForm LoginForm;

        AddIncidentForm AddIncidentForm;
        SearchIncidentForm SearchIncidentForm;

        /// <summary>
        /// Initializes the component and registers the loginForm.
        /// </summary>
        /// <param name="loginForm">Primarily given access in order to Show when needed.</param>
        public MainForm(LoginForm loginForm)
        {
            InitializeComponent();
            LoginForm = loginForm;

            AddIncidentForm = new AddIncidentForm();
            SearchIncidentForm = new SearchIncidentForm();
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
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AddIncidentButton_Click(object sender, System.EventArgs e)
        {
            AddIncidentForm.ShowDialog();
        }

        private void SearchIncidentButton_Click(object sender, System.EventArgs e)
        {
            SearchIncidentForm.ShowDialog();
        }
    }
}
