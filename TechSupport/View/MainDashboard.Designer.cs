
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
            this.AddIncidentTabPage = new System.Windows.Forms.TabPage();
            this.ViewAllIncidentsTabPage = new System.Windows.Forms.TabPage();
            this.ViewAllIncidentsUserControl = new TechSupport.UserControls.ViewAllIncidentsUserControl();
            this.SearchIncidentTabPage = new System.Windows.Forms.TabPage();
            this.SearchIncidentUserControl = new TechSupport.UserControls.SearchIncidentUserControl();
            this.displayOpenIncidentsTabPage = new System.Windows.Forms.TabPage();
            this.displayOpenIncidentsUserControl = new TechSupport.UserControls.DisplayOpenIncidentsUserControl();
            this.LogoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.AddIncidentUserControl = new TechSupport.UserControls.AddIncidentUserControl();
            this.MainDashboardTabControl.SuspendLayout();
            this.AddIncidentTabPage.SuspendLayout();
            this.ViewAllIncidentsTabPage.SuspendLayout();
            this.SearchIncidentTabPage.SuspendLayout();
            this.displayOpenIncidentsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainDashboardTabControl
            // 
            this.MainDashboardTabControl.Controls.Add(this.AddIncidentTabPage);
            this.MainDashboardTabControl.Controls.Add(this.ViewAllIncidentsTabPage);
            this.MainDashboardTabControl.Controls.Add(this.SearchIncidentTabPage);
            this.MainDashboardTabControl.Controls.Add(this.displayOpenIncidentsTabPage);
            this.MainDashboardTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainDashboardTabControl.Location = new System.Drawing.Point(0, 25);
            this.MainDashboardTabControl.Name = "MainDashboardTabControl";
            this.MainDashboardTabControl.SelectedIndex = 0;
            this.MainDashboardTabControl.Size = new System.Drawing.Size(568, 322);
            this.MainDashboardTabControl.TabIndex = 0;
            // 
            // AddIncidentTabPage
            // 
            this.AddIncidentTabPage.Controls.Add(this.AddIncidentUserControl);
            this.AddIncidentTabPage.Location = new System.Drawing.Point(4, 22);
            this.AddIncidentTabPage.Name = "AddIncidentTabPage";
            this.AddIncidentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AddIncidentTabPage.Size = new System.Drawing.Size(560, 296);
            this.AddIncidentTabPage.TabIndex = 0;
            this.AddIncidentTabPage.Text = "Add Incident";
            this.AddIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // ViewAllIncidentsTabPage
            // 
            this.ViewAllIncidentsTabPage.Controls.Add(this.ViewAllIncidentsUserControl);
            this.ViewAllIncidentsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ViewAllIncidentsTabPage.Name = "ViewAllIncidentsTabPage";
            this.ViewAllIncidentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ViewAllIncidentsTabPage.Size = new System.Drawing.Size(560, 296);
            this.ViewAllIncidentsTabPage.TabIndex = 1;
            this.ViewAllIncidentsTabPage.Text = "View All Incidents";
            this.ViewAllIncidentsTabPage.UseVisualStyleBackColor = true;
            this.ViewAllIncidentsTabPage.Enter += new System.EventHandler(this.ViewAllIncidentsTabPage_Enter);
            // 
            // ViewAllIncidentsUserControl
            // 
            this.ViewAllIncidentsUserControl.AutoSize = true;
            this.ViewAllIncidentsUserControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ViewAllIncidentsUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewAllIncidentsUserControl.Location = new System.Drawing.Point(3, 3);
            this.ViewAllIncidentsUserControl.Name = "ViewAllIncidentsUserControl";
            this.ViewAllIncidentsUserControl.Size = new System.Drawing.Size(554, 290);
            this.ViewAllIncidentsUserControl.TabIndex = 0;
            // 
            // SearchIncidentTabPage
            // 
            this.SearchIncidentTabPage.Controls.Add(this.SearchIncidentUserControl);
            this.SearchIncidentTabPage.Location = new System.Drawing.Point(4, 22);
            this.SearchIncidentTabPage.Name = "SearchIncidentTabPage";
            this.SearchIncidentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SearchIncidentTabPage.Size = new System.Drawing.Size(560, 296);
            this.SearchIncidentTabPage.TabIndex = 2;
            this.SearchIncidentTabPage.Text = "Search Incident";
            this.SearchIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // SearchIncidentUserControl
            // 
            this.SearchIncidentUserControl.AutoSize = true;
            this.SearchIncidentUserControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchIncidentUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchIncidentUserControl.Location = new System.Drawing.Point(3, 3);
            this.SearchIncidentUserControl.Name = "SearchIncidentUserControl";
            this.SearchIncidentUserControl.Size = new System.Drawing.Size(554, 290);
            this.SearchIncidentUserControl.TabIndex = 0;
            // 
            // displayOpenIncidentsTabPage
            // 
            this.displayOpenIncidentsTabPage.Controls.Add(this.displayOpenIncidentsUserControl);
            this.displayOpenIncidentsTabPage.Location = new System.Drawing.Point(4, 22);
            this.displayOpenIncidentsTabPage.Name = "displayOpenIncidentsTabPage";
            this.displayOpenIncidentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.displayOpenIncidentsTabPage.Size = new System.Drawing.Size(560, 296);
            this.displayOpenIncidentsTabPage.TabIndex = 3;
            this.displayOpenIncidentsTabPage.Text = "Display Open Incidents";
            this.displayOpenIncidentsTabPage.UseVisualStyleBackColor = true;
            this.displayOpenIncidentsTabPage.Enter += new System.EventHandler(this.DisplayOpenIncidentsTabPage_Enter);
            // 
            // displayOpenIncidentsUserControl
            // 
            this.displayOpenIncidentsUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayOpenIncidentsUserControl.Location = new System.Drawing.Point(3, 3);
            this.displayOpenIncidentsUserControl.Name = "displayOpenIncidentsUserControl";
            this.displayOpenIncidentsUserControl.Size = new System.Drawing.Size(554, 290);
            this.displayOpenIncidentsUserControl.TabIndex = 0;
            // 
            // LogoutLinkLabel
            // 
            this.LogoutLinkLabel.AutoSize = true;
            this.LogoutLinkLabel.Location = new System.Drawing.Point(516, 9);
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
            this.UsernameLabel.Location = new System.Drawing.Point(457, 9);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(53, 13);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "username";
            // 
            // AddIncidentUserControl
            // 
            this.AddIncidentUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddIncidentUserControl.Location = new System.Drawing.Point(3, 3);
            this.AddIncidentUserControl.Name = "AddIncidentUserControl";
            this.AddIncidentUserControl.Size = new System.Drawing.Size(554, 290);
            this.AddIncidentUserControl.TabIndex = 0;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 347);
            this.Controls.Add(this.LogoutLinkLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.MainDashboardTabControl);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tech Support";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainDashboard_FormClosing);
            this.MainDashboardTabControl.ResumeLayout(false);
            this.AddIncidentTabPage.ResumeLayout(false);
            this.ViewAllIncidentsTabPage.ResumeLayout(false);
            this.ViewAllIncidentsTabPage.PerformLayout();
            this.SearchIncidentTabPage.ResumeLayout(false);
            this.SearchIncidentTabPage.PerformLayout();
            this.displayOpenIncidentsTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl MainDashboardTabControl;
        private System.Windows.Forms.TabPage AddIncidentTabPage;
        private System.Windows.Forms.TabPage ViewAllIncidentsTabPage;
        private System.Windows.Forms.TabPage SearchIncidentTabPage;
        private System.Windows.Forms.LinkLabel LogoutLinkLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private UserControls.ViewAllIncidentsUserControl ViewAllIncidentsUserControl;
        private UserControls.SearchIncidentUserControl SearchIncidentUserControl;
        private System.Windows.Forms.TabPage displayOpenIncidentsTabPage;
        private UserControls.DisplayOpenIncidentsUserControl displayOpenIncidentsUserControl;
        private UserControls.AddIncidentUserControl AddIncidentUserControl;
    }
}