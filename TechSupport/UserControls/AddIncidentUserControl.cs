using System;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    /// <summary>
    /// Panel containing controls necessary to create a new Incident via the GUI.
    /// </summary>
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
                Incident newIncident = new Incident(TitleTextBox.Text, DescriptionTextBox.Text, CustomerComboBox.SelectedText);
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
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ErrorMessage.Hide();
            ClearAllTextBoxes();
        }
    }
}
