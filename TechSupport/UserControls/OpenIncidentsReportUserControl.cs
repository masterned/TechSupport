using System;
using System.Windows.Forms;

namespace TechSupport.UserControls
{
    public partial class OpenIncidentsReportUserControl : UserControl
    {
        public OpenIncidentsReportUserControl()
        {
            InitializeComponent();
        }

        private void OpenIncidentsReportUserControl_Load(object sender, EventArgs e)
        {
            incidentsTableAdapter.Fill(techSupportDataSet.Incidents);

            OpenIncidentsReportViewer.RefreshReport();
        }
    }
}
