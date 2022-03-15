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

                TechnicianComboBox.SelectedIndex = incident.Technician != null
                    ? TechnicianComboBox.Items.IndexOf(incident.Technician)
                    : -1;

                ErrorMessage.Hide();

                TechnicianComboBox.Enabled = !incident.IsClosed;
                TextToAddTextBox.Enabled = !incident.IsClosed && (incident.Description.Length < 200);
                UpdateButton.Enabled = !incident.IsClosed;
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
            ClearTextBoxes(IncidentIDTextBox, CustomerTextBox, ProductTextBox, TitleTextBox, DateOpenedTextBox, DescriptionTextBox, TextToAddTextBox);
            
            TechnicianComboBox.SelectedIndex = -1;

            DisableControls(TechnicianComboBox, TextToAddTextBox, UpdateButton, CloseButton);
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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Incident oldIncident = _incidentController.GetIncident(IncidentIDTextBox.Text);
            
                if (oldIncident.IsClosed)
                {
                    ShowError("Cannot edit closed Incidents.");
                    return;
                }

                Technician selectedTechnician = (Technician) TechnicianComboBox.SelectedItem;

                if ((TechnicianComboBox.SelectedIndex == -1 || selectedTechnician.Equals(oldIncident.Technician)) && string.IsNullOrWhiteSpace(TextToAddTextBox.Text))
                {
                    MessageBox.Show("Nothing has changed.", "Incident Not Updated");
                    return;
                }

                try
                {
                    _incidentController.UpdateIncident(oldIncident, selectedTechnician, TextToAddTextBox.Text);

                    MessageBox.Show($"Incident has been updated.", "Confirmation");

                    ResetInputFields();
                }
                catch (IncidentDescriptionOverflowException exception)
                {
                    DialogResult result = MessageBox.Show($"{exception.Message}\nWould you like to truncate the message?"
                        , "Description too long."
                        , MessageBoxButtons.YesNo);

                    switch (result)
                    {
                        case DialogResult.Yes:
                            string newDescription = _incidentController.FormatDescriptionApend(oldIncident.Description, TextToAddTextBox.Text).Substring(0, 200);
                        
                            try
                            {
                                _incidentController.UpdateIncidentWithTruncatedDescription(oldIncident, selectedTechnician, newDescription);

                                MessageBox.Show($"Incident has been updated.", "Confirmation");

                                ResetInputFields();
                            }
                            catch (Exception ex)
                            {
                                ShowError(ex.Message);
                                return;
                            }

                            break;

                        case DialogResult.No:
                            return;

                        default:
                            MessageBox.Show("To be honest, I'm not sure how you got here...", "This shouldn't be seen.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    ShowError(ex.Message);
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            try
            {
                Incident oldIncident = _incidentController.GetIncident(IncidentIDTextBox.Text);

                if (oldIncident.IsClosed)
                {
                    CloseButton.Enabled = false;
                    return;
                }

                Technician selectedTechnician = (Technician)TechnicianComboBox.SelectedItem;

                if (TechnicianComboBox.SelectedIndex == -1 || selectedTechnician == null)
                {
                    ShowError("Technician must be set before Incident can be closed.");
                    return;
                }

                DialogResult canClose = MessageBox.Show(
                    $"Are you sure you want to close Incident {oldIncident.IncidentID}?\nOnce closed, it cannot be edited."
                    , "Are you sure?"
                    , MessageBoxButtons.YesNo
                    );

                if (canClose == DialogResult.Yes)
                {
                    try
                    {
                        _incidentController.CloseIncident(oldIncident, selectedTechnician, TextToAddTextBox.Text);

                        MessageBox.Show($"Incident has been closed.", "Confirmation");

                        ResetInputFields();
                    }
                    catch (IncidentDescriptionOverflowException exception)
                    {
                        DialogResult result = MessageBox.Show($"{exception.Message}\nWould you like to truncate the message?"
                            , "Description too long."
                            , MessageBoxButtons.YesNo);

                        switch (result)
                        {
                            case DialogResult.Yes:
                                string newDescription = _incidentController.FormatDescriptionApend(oldIncident.Description, TextToAddTextBox.Text).Substring(0, 200);

                                try
                                {
                                    _incidentController.CloseIncidentUsingDescription(oldIncident, selectedTechnician, newDescription);

                                    MessageBox.Show($"Incident has been closed.", "Confirmation");

                                    ResetInputFields();
                                }
                                catch (Exception ex)
                                {
                                    ShowError(ex.Message);
                                    return;
                                }

                                break;

                            case DialogResult.No:
                                return;

                            default:
                                MessageBox.Show("To be honest, I'm not sure how you got here...", "This shouldn't be seen.");
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        ShowError(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Incident has not been closed", "Close Canceled");
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void IncidentIDTextBox_TextChanged(object sender, EventArgs e)
        {
            ClearTextBoxes(CustomerTextBox, ProductTextBox, TitleTextBox, DateOpenedTextBox, DescriptionTextBox, TextToAddTextBox);

            DisableControls(TechnicianComboBox, TextToAddTextBox, UpdateButton, CloseButton);

            ErrorMessage.Hide();

            TechnicianComboBox.SelectedIndex = -1;
        }

        private void ClearTextBoxes(params TextBoxBase[] textboxes)
        {
            foreach (TextBoxBase textBox in textboxes) textBox.Clear();
        }

        private void DisableControls(params Control[] controls)
        {
            foreach (Control control in controls) if (control.Enabled) control.Enabled = false;
        }
    }
}
