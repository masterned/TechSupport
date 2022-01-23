using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{
    public partial class AddIncidentForm : Form
    {
        private IncidentController IncidentController;

        public AddIncidentForm()
        {
            InitializeComponent();
            IncidentController = new IncidentController();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ErrorMessage.Visible = false;

            DialogResult = DialogResult.Cancel;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ErrorMessage.Visible = false;

            try
            {
                Incident newIncident = new Incident(TitleTextBox.Text, DescriptionTextBox.Text, CustomerIDTextBox.Text);
                IncidentController.AddIncident(newIncident);
                DialogResult = DialogResult.OK;
            }
            catch (Exception exception)
            {
                ErrorMessage.Text = exception.Message;
                ErrorMessage.Visible = true;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                ErrorMessage.Visible = false;
            }
        }
    }
}
