using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    public partial class ViewIncidentsByTechnicianUserControl : UserControl
    {
        private readonly TechnicianController _technicianController;
        private readonly IncidentController _incidentController;

        private List<Technician> technicians;
        private List<Incident> incidents;

        public ViewIncidentsByTechnicianUserControl()
        {
            InitializeComponent();

            _technicianController = new TechnicianController();
            _incidentController = new IncidentController();
        }

        private void ViewIncidentsByTechnicianUserControl_Load(object sender, EventArgs e)
        {
            technicians = _technicianController.GetTechniciansWithIncidents();

            nameComboBox.DataSource = technicians;
        }

        private void NameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nameComboBox.SelectedIndex < 0) return;

            Technician technician = technicians[nameComboBox.SelectedIndex];

            technicianBindingSource.Clear();

            technicianBindingSource.Add(technician);

            incidents = _incidentController.GetOpenIncidentsWithTech(technician.TechID);

            incidentDataGridView.DataSource = incidents;
        }
    }
}
