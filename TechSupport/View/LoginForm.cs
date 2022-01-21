using System;
using System.Windows.Forms;

namespace TechSupport.View
{
    /// <summary>
    /// This window displays the login form to the user.
    /// </summary>
    public partial class LoginForm : Form
    {
        MainForm mainForm;

        /// <summary>
        /// Initializes the LoginForm,
        /// and creates its main form.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            this.mainForm = new MainForm(this);
        }

        /// <summary>
        /// Handles the event fired when the login button is clicked.
        /// Tests the entered username and password,
        /// and either displays an error message on an unsuccessful attempt
        /// or hides the login form and shows the main form on a successful one.
        /// </summary>
        /// <param name="sender">The "Login" button</param>
        /// <param name="e">Arguments for the event</param>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            /*
             * This is most definitely *not* the way to do it,
             * but for the sake of this homework,
             * this solution should be sufficient.
             */
            const string username = "Jane";
            const string password = "test1234";

            if
            (
                usernameTextBox.Text != username
                || passwordTextBox.Text != password
            )
            {
                errorMessageLabel.Visible = true;
                return;
            }

            Hide();
            mainForm.SetUsername(usernameTextBox.Text);
            mainForm.Show();
        }

        /// <summary>
        /// Handles events fired when text is inputted into one of the TextBoxes.
        /// Hides the error message if it's visible.
        /// </summary>
        /// <param name="sender">The username or password TextBox</param>
        /// <param name="e">Event arguments</param>
        private void FieldTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox)
                errorMessageLabel.Visible = false;
        }

        /// <summary>
        /// Handles the event fired when the form is closing.
        /// Makes sure that the entire application closes.
        /// </summary>
        /// <param name="sender">The Login form</param>
        /// <param name="e">Event arguments</param>
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
