using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
