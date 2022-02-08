using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    /// <summary>
    /// Panel containing the list of open Incidents in the TechSupport DB.
    /// </summary>
    public partial class DisplayOpenIncidentsUserControl : UserControl
    {
        private IncidentController incidentController;

        /// <summary>
        /// Creates a new DisplayOpenIncidentsUserControl and initializes its component & controller.
        /// </summary>
        public DisplayOpenIncidentsUserControl()
        {
            InitializeComponent();
            incidentController = new IncidentController();
        }

        /// <summary>
        /// Refills the list with fresh data from the TechSupport DB.
        /// </summary>
        public void RefreshListView()
        {
            openIncidentsListView.Items.Clear();

            List<IncidentDB> openIncidentList;

            try
            {
                openIncidentList = incidentController.GetOpenIncidents();

                if (openIncidentList.Count > 0)
                {
                    IncidentDB incident;
                    for (int i = 0; i < openIncidentList.Count; i++)
                    {
                        incident = openIncidentList[i];

                        openIncidentsListView.Items.Add(incident.ProductCode);
                        openIncidentsListView.Items[i].SubItems.Add(incident.DateOpened.ToShortDateString());
                        openIncidentsListView.Items[i].SubItems.Add(incident.CustomerName);
                        openIncidentsListView.Items[i].SubItems.Add(incident.TechnicianName);
                        openIncidentsListView.Items[i].SubItems.Add(incident.Title);
                    }
                }
                else
                {
                    MessageBox.Show("There are no open incidents.",
                        "All incidents have been closed");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.GetType().ToString());
            }
        }
    }
}
