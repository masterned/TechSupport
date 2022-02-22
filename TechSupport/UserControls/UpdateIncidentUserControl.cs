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
            try
            {
                Incident incident = _incidentController.GetIncident(IncidentIDTextBox.Text);

                CustomerTextBox.Text = incident.CustomerName;
                ProductTextBox.Text = incident.ProductCode;
                TitleTextBox.Text = incident.Title;
                DateOpenedTextBox.Text = incident.DateOpened.ToShortDateString();
                DescriptionTextBox.Text = incident.Description;

                ErrorMessage.Hide();

                // Enable disabled fields
                TechnicianComboBox.Enabled = true;
                TextToAddTextBox.Enabled = true;
                CloseButton.Enabled = true;
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
            TechnicianComboBox.Text = "";
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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextToAddTextBox.Text))
            {
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
                            MessageBox.Show("You said yes", "Result");
                            break;
                        case DialogResult.No:
                            MessageBox.Show("You said no", "Result");
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
}
