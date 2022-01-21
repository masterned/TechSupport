using System.Windows.Forms;

namespace TechSupport.View
{
    /// <summary>
    /// Serves as the application's main window.
    /// Will display the core functionality of the program.
    /// </summary>
    public partial class MainForm : Form
    {
        LoginForm loginForm;

        /// <summary>
        /// Initializes the component and registers the loginForm.
        /// </summary>
        /// <param name="loginForm">Primarily given access in order to Show when needed.</param>
        public MainForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }

        /// <summary>
        /// Sets the username in the username Label to the passed value.
        /// </summary>
        /// <param name="username">The new string for the username Label text</param>
        public void SetUsername(string username)
        {
            usernameLabel.Text = username;
        }

        /// <summary>
        /// Handles the event fired when the logout LabelLink is clicked.
        /// </summary>
        /// <param name="sender">The logout LabelLink</param>
        /// <param name="e">Event arguments</param>
        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            loginForm.Show();
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
    }
}
