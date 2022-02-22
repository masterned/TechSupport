using System;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    public partial class UpdateIncidentUserControl : UserControl
    {
        private readonly IncidentController _incidentController;
        private readonly TechnicianController _technicianController;

        /// <summary>
        /// Creates a new UpdateIncidentUserControl and initializes its controller.
        /// </summary>
        public UpdateIncidentUserControl()
        {
            InitializeComponent();
            _incidentController = new IncidentController();
            _technicianController = new TechnicianController();
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            Incident incident = _incidentController.GetIncident(int.Parse(IncidentIDTextBox.Text));

            CustomerTextBox.Text = incident.CustomerName;
            ProductTextBox.Text = incident.ProductCode;
            TitleTextBox.Text = incident.Title;
            DateOpenedTextBox.Text = incident.DateOpened.ToShortDateString();
            DescriptionTextBox.Text = incident.Description;

            // Enable disabled fields
            TechnicianComboBox.Enabled = true;
            TextToAddTextBox.Enabled = true;
            CloseButton.Enabled = true;
        }

        public void PopulateTechnicianComboBox()
        {
            TechnicianComboBox.Items.Clear();
            TechnicianComboBox.Items.AddRange(_technicianController.GetTechnicians().ToArray());
        }

        private void HandleFormUpdated(object sender, EventArgs e)
        {
            UpdateButton.Enabled = true;
            ErrorMessage.Hide();
        }
    }
}
