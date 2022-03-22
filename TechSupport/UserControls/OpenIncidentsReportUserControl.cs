using System;
using System.Windows.Forms;

namespace TechSupport.UserControls
{
    /// <summary>
    /// Displays a report containing all open incidents assigned to technicians.
    /// </summary>
    public partial class OpenIncidentsReportUserControl : UserControl
    {
        /// <summary>
        /// Initializes view and sets property values.
        /// </summary>
        public OpenIncidentsReportUserControl()
        {
            InitializeComponent();
            incidentsTableAdapter.ClearBeforeFill = true;
        }

        private void OpenIncidentsReportUserControl_Load(object sender, EventArgs e)
        {
            RefreshReport();
        }

        /// <summary>
        /// Refreshes the data in the report view.
        /// </summary>
        public void RefreshReport()
        {
            incidentsTableAdapter.Fill(techSupportDataSet.Incidents);
            OpenIncidentsReportViewer.RefreshReport();
        }
    }
}
