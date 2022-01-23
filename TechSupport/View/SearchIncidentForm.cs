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
using TechSupport.Model;

namespace TechSupport.View
{
    public partial class SearchIncidentForm : Form
    {
        private IncidentController IncidentController;

        public SearchIncidentForm()
        {
            InitializeComponent();
            IncidentController = new IncidentController();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<Incident> customerIncidents =
                    IncidentController.GetIncidentsOfCustomer(CustomerIDTextBox.Text);

                IncidentGridView.DataSource = null;
                IncidentGridView.DataSource = customerIncidents;
            }
            catch (KeyNotFoundException)
            {
            }
        }
    }
}
