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
            loginForm = new LoginForm();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loginForm.ShowDialog();
        }
    }
}
