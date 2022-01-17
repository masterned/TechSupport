using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechSupport
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            /*
             * This is most definitely *not* the way to do it,
             * but for the sake of this homework,
             * this solution should be sufficient.
             */
            const string username = "Jane";
            const string password = "test1234";

            if (usernameTextBox.Text != username
                || passwordTextBox.Text != password)
            {
                errorMessageLabel.Visible = true;
            }
        }

        private void fieldTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                errorMessageLabel.Visible = false;
            }
        }
    }
}
