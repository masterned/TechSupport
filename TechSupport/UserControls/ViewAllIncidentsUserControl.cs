using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    /// <summary>
    /// Panel contains DataViewGrid with all internally stored incidents and their information.
    /// </summary>
    public partial class ViewAllIncidentsUserControl : UserControl
    {
        private readonly IncidentController IncidentController;

        /// <summary>
        /// Creates new ViewAllIncidentsUserControl & initializes its component & controller.
        /// </summary>
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
