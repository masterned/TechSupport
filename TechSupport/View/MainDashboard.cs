using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechSupport.View
{
    public partial class MainDashboard : Form
    {
        private readonly LoginForm LoginForm;

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
    }
}
