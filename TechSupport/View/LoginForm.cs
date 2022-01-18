using System;
using System.Windows.Forms;

namespace TechSupport.View
{
    public partial class LoginForm : Form
    {
        MainForm mainForm;

        public LoginForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

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

            mainForm.SetUsername(usernameTextBox.Text);

            Hide();
            mainForm.Show();
        }

        private void FieldTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox)
                errorMessageLabel.Visible = false;
        }
    }
}
