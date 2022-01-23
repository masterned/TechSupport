﻿
namespace TechSupport.View
{
    partial class SearchIncidentForm
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
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.CustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.IncidentGridView = new System.Windows.Forms.DataGridView();
            this.ErrorMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IncidentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Location = new System.Drawing.Point(20, 14);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(65, 13);
            this.CustomerIDLabel.TabIndex = 0;
            this.CustomerIDLabel.Text = "Customer ID";
            // 
            // CustomerIDTextBox
            // 
            this.CustomerIDTextBox.Location = new System.Drawing.Point(91, 11);
            this.CustomerIDTextBox.Name = "CustomerIDTextBox";
            this.CustomerIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.CustomerIDTextBox.TabIndex = 1;
            this.CustomerIDTextBox.TextChanged += new System.EventHandler(this.CustomerIDTextBox_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(197, 9);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // IncidentGridView
            // 
            this.IncidentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IncidentGridView.Location = new System.Drawing.Point(23, 53);
            this.IncidentGridView.Name = "IncidentGridView";
            this.IncidentGridView.Size = new System.Drawing.Size(240, 150);
            this.IncidentGridView.TabIndex = 3;
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessage.Location = new System.Drawing.Point(20, 34);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(75, 13);
            this.ErrorMessage.TabIndex = 4;
            this.ErrorMessage.Text = "Error Message";
            this.ErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ErrorMessage.Visible = false;
            // 
            // SearchIncidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 215);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.IncidentGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.CustomerIDTextBox);
            this.Controls.Add(this.CustomerIDLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchIncidentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Incident";
            ((System.ComponentModel.ISupportInitialize)(this.IncidentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.TextBox CustomerIDTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView IncidentGridView;
        private System.Windows.Forms.Label ErrorMessage;
    }
}