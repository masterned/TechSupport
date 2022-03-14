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
        private List<Technician> technicians;

        public ViewIncidentsByTechnicianUserControl()
        {
            InitializeComponent();
            _technicianController = new TechnicianController();
        }

        private void ViewIncidentsByTechnicianUserControl_Load(object sender, EventArgs e)
        {
            technicians = _technicianController.GetTechnicians();

            nameComboBox.DataSource = technicians;
        }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nameComboBox.SelectedIndex < 0) return;

            Technician technician = technicians[nameComboBox.SelectedIndex];

            technicianBindingSource.Clear();

            technicianBindingSource.Add(technician);
        }
    }
}
