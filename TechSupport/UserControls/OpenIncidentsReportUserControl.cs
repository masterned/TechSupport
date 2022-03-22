using System;
using System.Windows.Forms;

namespace TechSupport.UserControls
{
    public partial class OpenIncidentsReportUserControl : UserControl
    {
        public OpenIncidentsReportUserControl()
        {
            InitializeComponent();
            incidentsTableAdapter.ClearBeforeFill = true;
        }

        private void OpenIncidentsReportUserControl_Load(object sender, EventArgs e)
        {
            RefreshReport();
        }

        public void RefreshReport()
        {
            incidentsTableAdapter.Fill(techSupportDataSet.Incidents);
            OpenIncidentsReportViewer.RefreshReport();
        }
    }
}
