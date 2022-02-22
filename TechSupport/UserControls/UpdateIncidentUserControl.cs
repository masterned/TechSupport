using System;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    /// <summary>
    /// UserControl Used to Update Incidents in the database
    /// </summary>
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
            try
            {
                Incident incident = _incidentController.GetIncident(IncidentIDTextBox.Text);

                CustomerTextBox.Text = incident.CustomerName;
                ProductTextBox.Text = incident.ProductCode;
                TitleTextBox.Text = incident.Title;
                DateOpenedTextBox.Text = incident.DateOpened.ToShortDateString();
                DescriptionTextBox.Text = incident.Description;

                TechnicianComboBox.SelectedIndex = incident.TechID >= 0
                    ? TechnicianComboBox.Items.IndexOf(_technicianController.GetTechnician(incident.TechID))
                    : -1;

                ErrorMessage.Hide();

                TechnicianComboBox.Enabled = !incident.IsClosed;
                TextToAddTextBox.Enabled = !incident.IsClosed;
                CloseButton.Enabled = !incident.IsClosed;
            }
            catch (Exception exception)
            {
                ShowError(exception.Message);
            }
        }

        private void ShowError(string message)
        {
            ErrorMessage.Text = message;
            ErrorMessage.Show();
        }

        /// <summary>
        /// Populates the TechnicianComboBox with Technicians in the TechSupport db
        /// </summary>
        public void PopulateTechnicianComboBox()
        {
            TechnicianComboBox.Items.Clear();
            TechnicianComboBox.Items.AddRange(_technicianController.GetTechnicians().ToArray());
        }

        /// <summary>
        /// Resets all input fields to empty and disables appropriate fields.
        /// </summary>
        public void ResetInputFields()
        {
            IncidentIDTextBox.Clear();
            CustomerTextBox.Clear();
            ProductTextBox.Clear();
            TechnicianComboBox.SelectedIndex = -1;
            TitleTextBox.Clear();
            DateOpenedTextBox.Clear();
            DescriptionTextBox.Clear();
            TextToAddTextBox.Clear();

            TechnicianComboBox.Enabled = false;
            TextToAddTextBox.Enabled = false;
            UpdateButton.Enabled = false;
            CloseButton.Enabled = false;
        }

        private void HandleFormUpdated(object sender, EventArgs e)
        {
            UpdateButton.Enabled = true;
            ErrorMessage.Hide();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ResetInputFields();
            ErrorMessage.Hide();
        }

        private void UpdateDescription(Incident incident)
        {
            if (DescriptionTextBox.Text.Length >= 200)
            {
                ShowError("Description already at max length.\nCannot add more text.");
                return;
            }

            try
            {
                bool wasSuccessful = _incidentController.AppendToDescription(IncidentIDTextBox.Text, DescriptionTextBox.Text, TextToAddTextBox.Text);

                if (wasSuccessful)
                {
                    DialogResult result = MessageBox.Show("Incident description successfully updated.", "Confirmation");

                    string incidentIDString = IncidentIDTextBox.Text;

                    ResetInputFields();

                    IncidentIDTextBox.Text = incidentIDString;

                    GetButton_Click(GetButton, null);
                }
                else
                {
                    ShowError("System was unable to update Incident");
                }
            }
            catch (IncidentDescriptionOverflowException exception)
            {
                DialogResult result = MessageBox.Show($"{exception.Message}\nWould you like to truncate the message?"
                    , "Description too long."
                    , MessageBoxButtons.YesNo);

                switch (result)
                {
                    case DialogResult.Yes:
                        _incidentController.UpdateDescription(incident
                            , _incidentController.TruncateNewDescription(
                                _incidentController.CreateNewDescription(incident
                                    , TextToAddTextBox.Text)
                                )
                            );

                        string incidentIDString = IncidentIDTextBox.Text;

                        ResetInputFields();

                        IncidentIDTextBox.Text = incidentIDString;

                        GetButton_Click(GetButton, null);

                        break;

                    case DialogResult.No:
                        break;

                    default:
                        MessageBox.Show("To be honest, I'm not sure how you got here...", "This shouldn't be seen.");
                        break;
                }
            }
            catch (Exception exception)
            {
                ShowError(exception.Message);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Incident incident = _incidentController.GetIncident(IncidentIDTextBox.Text);

                if (incident.IsClosed)
                {
                    ShowError("Cannot edit closed Incidents.");
                    return;
                }

                if (!string.IsNullOrEmpty(TextToAddTextBox.Text))
                {
                    UpdateDescription(incident);
                }

                Technician selectedTechnician = (Technician)TechnicianComboBox.SelectedItem;

                if (TechnicianComboBox.SelectedIndex != -1 && _incidentController.TechnicianIsDifferent(incident, selectedTechnician.TechID))
                {
                    _incidentController.UpdateTechnician(incident, selectedTechnician.TechID);
                    MessageBox.Show("Technician Successfully Updated", "Confirmation");
                }
            }
            catch (Exception exception)
            {
                ShowError(exception.Message);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            try
            {
                Incident incident = _incidentController.GetIncident(IncidentIDTextBox.Text);

                if (incident.IsClosed)
                {
                    CloseButton.Enabled = false;
                    return;
                }

                if (incident.TechID == -1 && TechnicianComboBox.SelectedIndex == -1)
                {
                    ShowError("Cannot close Incident without assigning a Technician.");
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to close this Incident?\nOnce closed, it can no longer be edited."
                    , "Close this Incident?"
                    , MessageBoxButtons.YesNo);

                switch (result)
                {
                    case DialogResult.Yes:

                        Technician selectedTechnician = (Technician)TechnicianComboBox.SelectedItem;

                        if (TechnicianComboBox.SelectedIndex != -1 && _incidentController.TechnicianIsDifferent(incident, selectedTechnician.TechID))
                            _incidentController.UpdateTechnician(incident, selectedTechnician.TechID);

                        if(!string.IsNullOrEmpty(TextToAddTextBox.Text))
                        {
                            string newDescription = _incidentController.CreateNewDescription(incident, TextToAddTextBox.Text);

                            if (newDescription.Length > 200)
                            {
                                DialogResult shouldTruncate = MessageBox.Show("The description exceeds the 200 character maximum.\nWould you like to truncate the message?"
                                    , "Description too long."
                                    , MessageBoxButtons.YesNo);

                                if (shouldTruncate == DialogResult.Yes)
                                    _incidentController.UpdateDescription(incident, _incidentController.TruncateNewDescription(newDescription));
                                else
                                    return;
                            }
                            else
                            {
                                _incidentController.UpdateDescription(incident, newDescription);
                            }
                        }

                        _incidentController.CloseIncident(incident);

                        MessageBox.Show("Incident has been closed.", "Confirmation");

                        ResetInputFields();

                        IncidentIDTextBox.Text = incident.IncidentID.ToString();

                        GetButton_Click(GetButton, null);

                        break;

                    case DialogResult.No:
                        break;

                    default:
                        MessageBox.Show("To be honest, I'm not sure how you got here...", "This shouldn't be seen.");
                        break;
                }
            }
            catch (Exception exception)
            {
                ShowError(exception.Message);
            }
        }
    }
}
