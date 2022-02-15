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
        private readonly IncidentController _incidentController;

        /// <summary>
        /// Creates a new AddIncidentUserControl
        /// and initializes its IncidentController
        /// </summary>
        public AddIncidentUserControl()
        {
            InitializeComponent();
            _incidentController = new IncidentController();

            CustomerComboBox.Items.Clear();
            CustomerComboBox.Items.AddRange((new CustomerController()).GetAllCustomers().ToArray());
            CustomerComboBox.SelectedIndex = 0;

            ProductComboBox.Items.Clear();
            ProductComboBox.Items.AddRange((new ProductController()).GetAllProducts().ToArray());
            ProductComboBox.SelectedIndex = 0;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ErrorMessage.Hide();

            _incidentController.AddIncident(CustomerComboBox.Text, ProductComboBox.Text, TitleTextBox.Text, DescriptionTextBox.Text);
        }

        private void InputField_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox || sender is ComboBox)
                ErrorMessage.Hide();
        }

        /// <summary>
        /// Resets Customer & Product ComboBoxes to first items
        /// and clears Title & Description TextBoxes
        /// </summary>
        public void ResetInputFields()
        {
            CustomerComboBox.SelectedIndex = 0;
            ProductComboBox.SelectedIndex = 0;
            TitleTextBox.Clear();
            DescriptionTextBox.Clear();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ErrorMessage.Hide();
            ResetInputFields();
        }
    }
}
