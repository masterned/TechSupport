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

namespace TechSupport.UserControls
{
    public partial class ViewAllIncidentsUserControl : UserControl
    {
        private readonly IncidentController IncidentController;

        public ViewAllIncidentsUserControl()
        {
            InitializeComponent();

            IncidentController = new IncidentController();
        }

        /// <summary>
        /// Refreshes the data in the incidents DataGrid to match the stored data.
        /// </summary>
        public void RefreshDataGrid()
        {
            IncidentsGridView.DataSource = null;
            IncidentsGridView.DataSource = IncidentController.GetIncidents();
        }
    }
}
