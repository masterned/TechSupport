
namespace TechSupport.View
{
    partial class MainDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainDashboardTabControl = new System.Windows.Forms.TabControl();
            this.DisplayOpenIncidentsTabPage = new System.Windows.Forms.TabPage();
            this.displayOpenIncidentsUserControl = new TechSupport.UserControls.DisplayOpenIncidentsUserControl();
            this.AddIncidentTabPage = new System.Windows.Forms.TabPage();
            this.AddIncidentUserControl = new TechSupport.UserControls.AddIncidentUserControl();
            this.UpdateIncidentTabPage = new System.Windows.Forms.TabPage();
            this.UpdateIncidentUserControl = new TechSupport.UserControls.UpdateIncidentUserControl();
            this.ViewIncidentsByTechnicianTabPage = new System.Windows.Forms.TabPage();
            this.viewIncidentsByTechnicianUserControl1 = new TechSupport.UserControls.ViewIncidentsByTechnicianUserControl();
            this.OpenIncidentReportTabPage = new System.Windows.Forms.TabPage();
            this.OpenIncidentsReportUserControl = new TechSupport.UserControls.OpenIncidentsReportUserControl();
            this.LogoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.MainDashboardTabControl.SuspendLayout();
            this.DisplayOpenIncidentsTabPage.SuspendLayout();
            this.AddIncidentTabPage.SuspendLayout();
            this.UpdateIncidentTabPage.SuspendLayout();
            this.ViewIncidentsByTechnicianTabPage.SuspendLayout();
            this.OpenIncidentReportTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainDashboardTabControl
            // 
            this.MainDashboardTabControl.Controls.Add(this.DisplayOpenIncidentsTabPage);
            this.MainDashboardTabControl.Controls.Add(this.AddIncidentTabPage);
            this.MainDashboardTabControl.Controls.Add(this.UpdateIncidentTabPage);
            this.MainDashboardTabControl.Controls.Add(this.ViewIncidentsByTechnicianTabPage);
            this.MainDashboardTabControl.Controls.Add(this.OpenIncidentReportTabPage);
            this.MainDashboardTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainDashboardTabControl.Location = new System.Drawing.Point(0, 40);
            this.MainDashboardTabControl.Name = "MainDashboardTabControl";
            this.MainDashboardTabControl.SelectedIndex = 0;
            this.MainDashboardTabControl.Size = new System.Drawing.Size(709, 372);
            this.MainDashboardTabControl.TabIndex = 0;
            // 
            // DisplayOpenIncidentsTabPage
            // 
            this.DisplayOpenIncidentsTabPage.Controls.Add(this.displayOpenIncidentsUserControl);
            this.DisplayOpenIncidentsTabPage.Location = new System.Drawing.Point(4, 22);
            this.DisplayOpenIncidentsTabPage.Name = "DisplayOpenIncidentsTabPage";
            this.DisplayOpenIncidentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DisplayOpenIncidentsTabPage.Size = new System.Drawing.Size(701, 346);
            this.DisplayOpenIncidentsTabPage.TabIndex = 3;
            this.DisplayOpenIncidentsTabPage.Text = "Display Open Incidents";
            this.DisplayOpenIncidentsTabPage.UseVisualStyleBackColor = true;
            this.DisplayOpenIncidentsTabPage.Enter += new System.EventHandler(this.DisplayOpenIncidentsTabPage_Enter);
            // 
            // displayOpenIncidentsUserControl
            // 
            this.displayOpenIncidentsUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayOpenIncidentsUserControl.Location = new System.Drawing.Point(3, 3);
            this.displayOpenIncidentsUserControl.Name = "displayOpenIncidentsUserControl";
            this.displayOpenIncidentsUserControl.Size = new System.Drawing.Size(695, 340);
            this.displayOpenIncidentsUserControl.TabIndex = 0;
            // 
            // AddIncidentTabPage
            // 
            this.AddIncidentTabPage.Controls.Add(this.AddIncidentUserControl);
            this.AddIncidentTabPage.Location = new System.Drawing.Point(4, 22);
            this.AddIncidentTabPage.Name = "AddIncidentTabPage";
            this.AddIncidentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AddIncidentTabPage.Size = new System.Drawing.Size(698, 346);
            this.AddIncidentTabPage.TabIndex = 0;
            this.AddIncidentTabPage.Text = "Add";
            this.AddIncidentTabPage.UseVisualStyleBackColor = true;
            this.AddIncidentTabPage.Enter += new System.EventHandler(this.AddIncidentTabPage_Enter);
            // 
            // AddIncidentUserControl
            // 
            this.AddIncidentUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddIncidentUserControl.Location = new System.Drawing.Point(3, 3);
            this.AddIncidentUserControl.Name = "AddIncidentUserControl";
            this.AddIncidentUserControl.Size = new System.Drawing.Size(692, 340);
            this.AddIncidentUserControl.TabIndex = 0;
            // 
            // UpdateIncidentTabPage
            // 
            this.UpdateIncidentTabPage.Controls.Add(this.UpdateIncidentUserControl);
            this.UpdateIncidentTabPage.Location = new System.Drawing.Point(4, 22);
            this.UpdateIncidentTabPage.Name = "UpdateIncidentTabPage";
            this.UpdateIncidentTabPage.Size = new System.Drawing.Size(698, 346);
            this.UpdateIncidentTabPage.TabIndex = 4;
            this.UpdateIncidentTabPage.Text = "Update";
            this.UpdateIncidentTabPage.UseVisualStyleBackColor = true;
            this.UpdateIncidentTabPage.Enter += new System.EventHandler(this.UpdateIncidentTabPage_Enter);
            // 
            // UpdateIncidentUserControl
            // 
            this.UpdateIncidentUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdateIncidentUserControl.Location = new System.Drawing.Point(0, 0);
            this.UpdateIncidentUserControl.Name = "UpdateIncidentUserControl";
            this.UpdateIncidentUserControl.Size = new System.Drawing.Size(698, 346);
            this.UpdateIncidentUserControl.TabIndex = 0;
            // 
            // ViewIncidentsByTechnicianTabPage
            // 
            this.ViewIncidentsByTechnicianTabPage.Controls.Add(this.viewIncidentsByTechnicianUserControl1);
            this.ViewIncidentsByTechnicianTabPage.Location = new System.Drawing.Point(4, 22);
            this.ViewIncidentsByTechnicianTabPage.Name = "ViewIncidentsByTechnicianTabPage";
            this.ViewIncidentsByTechnicianTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ViewIncidentsByTechnicianTabPage.Size = new System.Drawing.Size(698, 346);
            this.ViewIncidentsByTechnicianTabPage.TabIndex = 5;
            this.ViewIncidentsByTechnicianTabPage.Text = "View Incidents by Technician";
            this.ViewIncidentsByTechnicianTabPage.UseVisualStyleBackColor = true;
            // 
            // viewIncidentsByTechnicianUserControl1
            // 
            this.viewIncidentsByTechnicianUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewIncidentsByTechnicianUserControl1.Location = new System.Drawing.Point(3, 3);
            this.viewIncidentsByTechnicianUserControl1.Name = "viewIncidentsByTechnicianUserControl1";
            this.viewIncidentsByTechnicianUserControl1.Size = new System.Drawing.Size(692, 340);
            this.viewIncidentsByTechnicianUserControl1.TabIndex = 0;
            // 
            // OpenIncidentReportTabPage
            // 
            this.OpenIncidentReportTabPage.Controls.Add(this.OpenIncidentsReportUserControl);
            this.OpenIncidentReportTabPage.Location = new System.Drawing.Point(4, 22);
            this.OpenIncidentReportTabPage.Name = "OpenIncidentReportTabPage";
            this.OpenIncidentReportTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OpenIncidentReportTabPage.Size = new System.Drawing.Size(698, 346);
            this.OpenIncidentReportTabPage.TabIndex = 6;
            this.OpenIncidentReportTabPage.Text = "Report";
            this.OpenIncidentReportTabPage.UseVisualStyleBackColor = true;
            this.OpenIncidentReportTabPage.Enter += new System.EventHandler(this.OpenIncidentReportTabPage_Enter);
            // 
            // OpenIncidentsReportUserControl
            // 
            this.OpenIncidentsReportUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenIncidentsReportUserControl.Location = new System.Drawing.Point(3, 3);
            this.OpenIncidentsReportUserControl.Name = "OpenIncidentsReportUserControl";
            this.OpenIncidentsReportUserControl.Size = new System.Drawing.Size(692, 340);
            this.OpenIncidentsReportUserControl.TabIndex = 0;
            // 
            // LogoutLinkLabel
            // 
            this.LogoutLinkLabel.AutoSize = true;
            this.LogoutLinkLabel.Location = new System.Drawing.Point(654, 9);
            this.LogoutLinkLabel.Name = "LogoutLinkLabel";
            this.LogoutLinkLabel.Size = new System.Drawing.Size(40, 13);
            this.LogoutLinkLabel.TabIndex = 3;
            this.LogoutLinkLabel.TabStop = true;
            this.LogoutLinkLabel.Text = "Logout";
            this.LogoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(595, 9);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(53, 13);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "username";
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 412);
            this.Controls.Add(this.LogoutLinkLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.MainDashboardTabControl);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tech Support";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainDashboard_FormClosing);
            this.MainDashboardTabControl.ResumeLayout(false);
            this.DisplayOpenIncidentsTabPage.ResumeLayout(false);
            this.AddIncidentTabPage.ResumeLayout(false);
            this.UpdateIncidentTabPage.ResumeLayout(false);
            this.ViewIncidentsByTechnicianTabPage.ResumeLayout(false);
            this.OpenIncidentReportTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl MainDashboardTabControl;
        private System.Windows.Forms.TabPage AddIncidentTabPage;
        private System.Windows.Forms.LinkLabel LogoutLinkLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TabPage DisplayOpenIncidentsTabPage;
        private UserControls.DisplayOpenIncidentsUserControl displayOpenIncidentsUserControl;
        private UserControls.AddIncidentUserControl AddIncidentUserControl;
        private System.Windows.Forms.TabPage UpdateIncidentTabPage;
        private UserControls.UpdateIncidentUserControl UpdateIncidentUserControl;
        private System.Windows.Forms.TabPage ViewIncidentsByTechnicianTabPage;
        private UserControls.ViewIncidentsByTechnicianUserControl viewIncidentsByTechnicianUserControl1;
        private System.Windows.Forms.TabPage OpenIncidentReportTabPage;
        private UserControls.OpenIncidentsReportUserControl OpenIncidentsReportUserControl;
    }
}