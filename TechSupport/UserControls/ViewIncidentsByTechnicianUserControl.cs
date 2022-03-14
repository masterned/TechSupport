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

        public ViewIncidentsByTechnicianUserControl()
        {
            InitializeComponent();
            _technicianController = new TechnicianController();
        }

        private void ViewIncidentsByTechnicianUserControl_Load(object sender, EventArgs e)
        {
            List<Technician> technicians = _technicianController.GetTechnicians();

            nameComboBox.DataSource = technicians;
        }
    }
}
