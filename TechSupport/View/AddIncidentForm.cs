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
            DialogResult = DialogResult.Cancel;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Incident newIncident = new Incident(TitleTextBox.Text, DescriptionTextBox.Text, CustomerIDTextBox.Text);
            IncidentController.AddIncident(newIncident);
            DialogResult = DialogResult.OK;
        }
    }
}
