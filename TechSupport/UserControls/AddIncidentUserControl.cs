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

namespace TechSupport.UserControls
{
    public partial class AddIncidentUserControl : UserControl
    {
        private IncidentController IncidentController;
        
        /// <summary>
        /// Creates a new AddIncidentUserControl
        /// and initializes its IncidentController
        /// </summary>
        public AddIncidentUserControl()
        {
            InitializeComponent();
            IncidentController = new IncidentController();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ErrorMessage.Hide();

            try
            {
                Incident newIncident = new Incident(TitleTextBox.Text, DescriptionTextBox.Text, CustomerIDTextBox.Text);
                IncidentController.AddIncident(newIncident);
            }
            catch (Exception exception)
            {
                ErrorMessage.Text = exception.Message;
                ErrorMessage.Show();
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox)
                ErrorMessage.Hide();
        }

        /// <summary>
        /// Clears all of the text boxes in the UserControl.
        /// </summary>
        private void ClearAllTextBoxes()
        {
            TitleTextBox.Clear();
            DescriptionTextBox.Clear();
            CustomerIDTextBox.Clear();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ErrorMessage.Hide();
            ClearAllTextBoxes();
        }
    }
}
