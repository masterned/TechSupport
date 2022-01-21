
namespace TechSupport.View
{
    partial class MainForm
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
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.LogoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.AddIncidentButton = new System.Windows.Forms.Button();
            this.SearchIncidentButton = new System.Windows.Forms.Button();
            this.IncidentsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.IncidentsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(273, 9);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(0, 13);
            this.UsernameLabel.TabIndex = 0;
            // 
            // LogoutLinkLabel
            // 
            this.LogoutLinkLabel.AutoSize = true;
            this.LogoutLinkLabel.Location = new System.Drawing.Point(332, 9);
            this.LogoutLinkLabel.Name = "LogoutLinkLabel";
            this.LogoutLinkLabel.Size = new System.Drawing.Size(40, 13);
            this.LogoutLinkLabel.TabIndex = 1;
            this.LogoutLinkLabel.TabStop = true;
            this.LogoutLinkLabel.Text = "Logout";
            this.LogoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // AddIncidentButton
            // 
            this.AddIncidentButton.AutoSize = true;
            this.AddIncidentButton.Location = new System.Drawing.Point(315, 93);
            this.AddIncidentButton.Name = "AddIncidentButton";
            this.AddIncidentButton.Size = new System.Drawing.Size(77, 23);
            this.AddIncidentButton.TabIndex = 2;
            this.AddIncidentButton.Text = "Add Incident";
            this.AddIncidentButton.UseVisualStyleBackColor = true;
            this.AddIncidentButton.Click += new System.EventHandler(this.AddIncidentButton_Click);
            // 
            // SearchIncidentButton
            // 
            this.SearchIncidentButton.AutoSize = true;
            this.SearchIncidentButton.Location = new System.Drawing.Point(300, 64);
            this.SearchIncidentButton.Name = "SearchIncidentButton";
            this.SearchIncidentButton.Size = new System.Drawing.Size(92, 23);
            this.SearchIncidentButton.TabIndex = 3;
            this.SearchIncidentButton.Text = "Search Incident";
            this.SearchIncidentButton.UseVisualStyleBackColor = true;
            this.SearchIncidentButton.Click += new System.EventHandler(this.SearchIncidentButton_Click);
            // 
            // IncidentsGridView
            // 
            this.IncidentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IncidentsGridView.Location = new System.Drawing.Point(33, 64);
            this.IncidentsGridView.Name = "IncidentsGridView";
            this.IncidentsGridView.Size = new System.Drawing.Size(240, 150);
            this.IncidentsGridView.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.Controls.Add(this.IncidentsGridView);
            this.Controls.Add(this.SearchIncidentButton);
            this.Controls.Add(this.AddIncidentButton);
            this.Controls.Add(this.LogoutLinkLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tech Support";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.IncidentsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.LinkLabel LogoutLinkLabel;
        private System.Windows.Forms.Button AddIncidentButton;
        private System.Windows.Forms.Button SearchIncidentButton;
        private System.Windows.Forms.DataGridView IncidentsGridView;
    }
}