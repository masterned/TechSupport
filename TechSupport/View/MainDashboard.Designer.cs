﻿
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
            this.DisplayOpenIncidentsTabPage = new System.Windows.Forms.TabPage();
            this.LogoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.AddIncidentUserControl = new TechSupport.UserControls.AddIncidentUserControl();
            this.displayOpenIncidentsUserControl = new TechSupport.UserControls.DisplayOpenIncidentsUserControl();
            this.UpdateIncidentTabPage = new System.Windows.Forms.TabPage();
            this.UpdateIncidentUserControl = new TechSupport.UserControls.UpdateIncidentUserControl();
            this.MainDashboardTabControl.SuspendLayout();
            this.AddIncidentTabPage.SuspendLayout();
            this.DisplayOpenIncidentsTabPage.SuspendLayout();
            this.UpdateIncidentTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainDashboardTabControl
            // 
            this.MainDashboardTabControl.Controls.Add(this.DisplayOpenIncidentsTabPage);
            this.MainDashboardTabControl.Controls.Add(this.AddIncidentTabPage);
            this.MainDashboardTabControl.Controls.Add(this.UpdateIncidentTabPage);
            this.MainDashboardTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainDashboardTabControl.Location = new System.Drawing.Point(0, 40);
            this.MainDashboardTabControl.Name = "MainDashboardTabControl";
            this.MainDashboardTabControl.SelectedIndex = 0;
            this.MainDashboardTabControl.Size = new System.Drawing.Size(568, 372);
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
            this.AddIncidentTabPage.Text = "Add";
            this.AddIncidentTabPage.UseVisualStyleBackColor = true;
            this.AddIncidentTabPage.Enter += new System.EventHandler(this.AddIncidentTabPage_Enter);
            // 
            // DisplayOpenIncidentsTabPage
            // 
            this.DisplayOpenIncidentsTabPage.Controls.Add(this.displayOpenIncidentsUserControl);
            this.DisplayOpenIncidentsTabPage.Location = new System.Drawing.Point(4, 22);
            this.DisplayOpenIncidentsTabPage.Name = "DisplayOpenIncidentsTabPage";
            this.DisplayOpenIncidentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DisplayOpenIncidentsTabPage.Size = new System.Drawing.Size(560, 296);
            this.DisplayOpenIncidentsTabPage.TabIndex = 3;
            this.DisplayOpenIncidentsTabPage.Text = "Display Open Incidents";
            this.DisplayOpenIncidentsTabPage.UseVisualStyleBackColor = true;
            this.DisplayOpenIncidentsTabPage.Enter += new System.EventHandler(this.DisplayOpenIncidentsTabPage_Enter);
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
            // displayOpenIncidentsUserControl
            // 
            this.displayOpenIncidentsUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayOpenIncidentsUserControl.Location = new System.Drawing.Point(3, 3);
            this.displayOpenIncidentsUserControl.Name = "displayOpenIncidentsUserControl";
            this.displayOpenIncidentsUserControl.Size = new System.Drawing.Size(554, 290);
            this.displayOpenIncidentsUserControl.TabIndex = 0;
            // 
            // UpdateIncidentTabPage
            // 
            this.UpdateIncidentTabPage.Controls.Add(this.UpdateIncidentUserControl);
            this.UpdateIncidentTabPage.Location = new System.Drawing.Point(4, 22);
            this.UpdateIncidentTabPage.Name = "UpdateIncidentTabPage";
            this.UpdateIncidentTabPage.Size = new System.Drawing.Size(560, 346);
            this.UpdateIncidentTabPage.TabIndex = 4;
            this.UpdateIncidentTabPage.Text = "Update";
            this.UpdateIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // UpdateIncidentUserControl
            // 
            this.UpdateIncidentUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdateIncidentUserControl.Location = new System.Drawing.Point(0, 0);
            this.UpdateIncidentUserControl.Name = "UpdateIncidentUserControl";
            this.UpdateIncidentUserControl.Size = new System.Drawing.Size(560, 346);
            this.UpdateIncidentUserControl.TabIndex = 0;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 412);
            this.Controls.Add(this.LogoutLinkLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.MainDashboardTabControl);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tech Support";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainDashboard_FormClosing);
            this.MainDashboardTabControl.ResumeLayout(false);
            this.AddIncidentTabPage.ResumeLayout(false);
            this.DisplayOpenIncidentsTabPage.ResumeLayout(false);
            this.UpdateIncidentTabPage.ResumeLayout(false);
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
    }
}