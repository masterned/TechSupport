
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
            this.IncidentsGridView = new System.Windows.Forms.DataGridView();
            this.PrimaryLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.SearchIncidentButton = new System.Windows.Forms.Button();
            this.IncidentsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IncidentsGridView)).BeginInit();
            this.PrimaryLayoutTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(273, 9);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(53, 13);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "username";
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
            this.AddIncidentButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddIncidentButton.AutoSize = true;
            this.AddIncidentButton.Location = new System.Drawing.Point(289, 59);
            this.AddIncidentButton.Name = "AddIncidentButton";
            this.AddIncidentButton.Size = new System.Drawing.Size(87, 23);
            this.AddIncidentButton.TabIndex = 2;
            this.AddIncidentButton.Text = "Add Incident";
            this.AddIncidentButton.UseVisualStyleBackColor = true;
            this.AddIncidentButton.Click += new System.EventHandler(this.AddIncidentButton_Click);
            // 
            // IncidentsGridView
            // 
            this.IncidentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IncidentsGridView.Location = new System.Drawing.Point(3, 23);
            this.IncidentsGridView.Name = "IncidentsGridView";
            this.PrimaryLayoutTable.SetRowSpan(this.IncidentsGridView, 2);
            this.IncidentsGridView.Size = new System.Drawing.Size(279, 198);
            this.IncidentsGridView.TabIndex = 4;
            // 
            // PrimaryLayoutTable
            // 
            this.PrimaryLayoutTable.ColumnCount = 2;
            this.PrimaryLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.PrimaryLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PrimaryLayoutTable.Controls.Add(this.SearchIncidentButton, 1, 2);
            this.PrimaryLayoutTable.Controls.Add(this.IncidentsGridView, 0, 1);
            this.PrimaryLayoutTable.Controls.Add(this.AddIncidentButton, 1, 1);
            this.PrimaryLayoutTable.Controls.Add(this.IncidentsLabel, 0, 0);
            this.PrimaryLayoutTable.Location = new System.Drawing.Point(12, 25);
            this.PrimaryLayoutTable.Name = "PrimaryLayoutTable";
            this.PrimaryLayoutTable.RowCount = 3;
            this.PrimaryLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PrimaryLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PrimaryLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PrimaryLayoutTable.Size = new System.Drawing.Size(380, 224);
            this.PrimaryLayoutTable.TabIndex = 5;
            // 
            // SearchIncidentButton
            // 
            this.SearchIncidentButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchIncidentButton.Location = new System.Drawing.Point(288, 125);
            this.SearchIncidentButton.Name = "SearchIncidentButton";
            this.SearchIncidentButton.Size = new System.Drawing.Size(89, 23);
            this.SearchIncidentButton.TabIndex = 3;
            this.SearchIncidentButton.Text = "Search Incident";
            this.SearchIncidentButton.UseVisualStyleBackColor = true;
            this.SearchIncidentButton.Click += new System.EventHandler(this.SearchIncidentButton_Click);
            // 
            // IncidentsLabel
            // 
            this.IncidentsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.IncidentsLabel.AutoSize = true;
            this.IncidentsLabel.Location = new System.Drawing.Point(3, 3);
            this.IncidentsLabel.Name = "IncidentsLabel";
            this.IncidentsLabel.Size = new System.Drawing.Size(50, 13);
            this.IncidentsLabel.TabIndex = 5;
            this.IncidentsLabel.Text = "Incidents";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.Controls.Add(this.PrimaryLayoutTable);
            this.Controls.Add(this.LogoutLinkLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tech Support";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.IncidentsGridView)).EndInit();
            this.PrimaryLayoutTable.ResumeLayout(false);
            this.PrimaryLayoutTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.LinkLabel LogoutLinkLabel;
        private System.Windows.Forms.Button AddIncidentButton;
        private System.Windows.Forms.DataGridView IncidentsGridView;
        private System.Windows.Forms.TableLayoutPanel PrimaryLayoutTable;
        private System.Windows.Forms.Button SearchIncidentButton;
        private System.Windows.Forms.Label IncidentsLabel;
    }
}