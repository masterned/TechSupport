using System;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    public partial class UpdateIncidentUserControl : UserControl
    {
        private readonly IncidentController _incidentController;

        /// <summary>
        /// Creates a new UpdateIncidentUserControl and initializes its controller.
        /// </summary>
        public UpdateIncidentUserControl()
        {
            InitializeComponent();
            _incidentController = new IncidentController();
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
    }
}
