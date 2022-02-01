
namespace TechSupport.UserControls
{
    partial class SearchIncidentUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.IncidentGridView = new System.Windows.Forms.DataGridView();
            this.SearchButton = new System.Windows.Forms.Button();
            this.CustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.SearchIncidentTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.IncidentGridView)).BeginInit();
            this.SearchIncidentTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ErrorMessage.AutoSize = true;
            this.SearchIncidentTableLayoutPanel.SetColumnSpan(this.ErrorMessage, 3);
            this.ErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessage.Location = new System.Drawing.Point(3, 29);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(75, 13);
            this.ErrorMessage.TabIndex = 9;
            this.ErrorMessage.Text = "Error Message";
            this.ErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ErrorMessage.Visible = false;
            // 
            // IncidentGridView
            // 
            this.IncidentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchIncidentTableLayoutPanel.SetColumnSpan(this.IncidentGridView, 3);
            this.IncidentGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IncidentGridView.Location = new System.Drawing.Point(3, 45);
            this.IncidentGridView.Name = "IncidentGridView";
            this.IncidentGridView.Size = new System.Drawing.Size(353, 247);
            this.IncidentGridView.TabIndex = 8;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SearchButton.Location = new System.Drawing.Point(180, 3);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CustomerIDTextBox
            // 
            this.CustomerIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CustomerIDTextBox.Location = new System.Drawing.Point(74, 4);
            this.CustomerIDTextBox.Name = "CustomerIDTextBox";
            this.CustomerIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.CustomerIDTextBox.TabIndex = 6;
            this.CustomerIDTextBox.TextChanged += new System.EventHandler(this.CustomerIDTextBox_TextChanged);
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Location = new System.Drawing.Point(3, 8);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(65, 13);
            this.CustomerIDLabel.TabIndex = 5;
            this.CustomerIDLabel.Text = "Customer ID";
            // 
            // SearchIncidentTableLayoutPanel
            // 
            this.SearchIncidentTableLayoutPanel.ColumnCount = 3;
            this.SearchIncidentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.SearchIncidentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.SearchIncidentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.SearchIncidentTableLayoutPanel.Controls.Add(this.CustomerIDLabel, 0, 0);
            this.SearchIncidentTableLayoutPanel.Controls.Add(this.IncidentGridView, 0, 2);
            this.SearchIncidentTableLayoutPanel.Controls.Add(this.ErrorMessage, 0, 1);
            this.SearchIncidentTableLayoutPanel.Controls.Add(this.CustomerIDTextBox, 1, 0);
            this.SearchIncidentTableLayoutPanel.Controls.Add(this.SearchButton, 2, 0);
            this.SearchIncidentTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchIncidentTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.SearchIncidentTableLayoutPanel.Name = "SearchIncidentTableLayoutPanel";
            this.SearchIncidentTableLayoutPanel.RowCount = 3;
            this.SearchIncidentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SearchIncidentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SearchIncidentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SearchIncidentTableLayoutPanel.Size = new System.Drawing.Size(359, 295);
            this.SearchIncidentTableLayoutPanel.TabIndex = 10;
            // 
            // SearchIncidentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SearchIncidentTableLayoutPanel);
            this.Name = "SearchIncidentUserControl";
            this.Size = new System.Drawing.Size(359, 295);
            ((System.ComponentModel.ISupportInitialize)(this.IncidentGridView)).EndInit();
            this.SearchIncidentTableLayoutPanel.ResumeLayout(false);
            this.SearchIncidentTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ErrorMessage;
        private System.Windows.Forms.TableLayoutPanel SearchIncidentTableLayoutPanel;
        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.DataGridView IncidentGridView;
        private System.Windows.Forms.TextBox CustomerIDTextBox;
        private System.Windows.Forms.Button SearchButton;
    }
}
