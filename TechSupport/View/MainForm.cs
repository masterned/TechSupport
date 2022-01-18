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
    public partial class MainForm : Form
    {
        LoginForm loginForm;

        public MainForm()
        {
            InitializeComponent();
            loginForm = new LoginForm(this);
        }

        public void SetUsername(string username)
        {
            usernameLabel.Text = username;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Hide();
            loginForm.Show();
        }

        private void logoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            loginForm.Show();
        }
    }
}
