
namespace TechSupport.UserControls
{
    partial class AddIncidentUserControl
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
            this.AddIncidentTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.ProductComboBox = new System.Windows.Forms.ComboBox();
            this.CreateIncidentButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AddIncidentTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddIncidentTableLayoutPanel
            // 
            this.AddIncidentTableLayoutPanel.ColumnCount = 3;
            this.AddIncidentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.AddIncidentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.AddIncidentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.AddIncidentTableLayoutPanel.Controls.Add(this.CustomerLabel, 0, 0);
            this.AddIncidentTableLayoutPanel.Controls.Add(this.ProductLabel, 0, 1);
            this.AddIncidentTableLayoutPanel.Controls.Add(this.TitleLabel, 0, 2);
            this.AddIncidentTableLayoutPanel.Controls.Add(this.DescriptionLabel, 0, 3);
            this.AddIncidentTableLayoutPanel.Controls.Add(this.ErrorMessage, 1, 4);
            this.AddIncidentTableLayoutPanel.Controls.Add(this.TitleTextBox, 1, 2);
            this.AddIncidentTableLayoutPanel.Controls.Add(this.DescriptionTextBox, 1, 3);
            this.AddIncidentTableLayoutPanel.Controls.Add(this.CustomerComboBox, 1, 0);
            this.AddIncidentTableLayoutPanel.Controls.Add(this.ProductComboBox, 1, 1);
            this.AddIncidentTableLayoutPanel.Controls.Add(this.CreateIncidentButton, 1, 5);
            this.AddIncidentTableLayoutPanel.Controls.Add(this.ClearButton, 2, 5);
            this.AddIncidentTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.AddIncidentTableLayoutPanel.Name = "AddIncidentTableLayoutPanel";
            this.AddIncidentTableLayoutPanel.RowCount = 6;
            this.AddIncidentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AddIncidentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AddIncidentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AddIncidentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AddIncidentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AddIncidentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AddIncidentTableLayoutPanel.Size = new System.Drawing.Size(544, 314);
            this.AddIncidentTableLayoutPanel.TabIndex = 0;
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Location = new System.Drawing.Point(3, 7);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(54, 13);
            this.CustomerLabel.TabIndex = 0;
            this.CustomerLabel.Text = "Customer:";
            // 
            // ProductLabel
            // 
            this.ProductLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Location = new System.Drawing.Point(3, 34);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(47, 13);
            this.ProductLabel.TabIndex = 1;
            this.ProductLabel.Text = "Product:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(3, 60);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(30, 13);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Title:";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(3, 80);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.DescriptionLabel.Size = new System.Drawing.Size(63, 23);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.Text = "Description:";
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessage.Location = new System.Drawing.Point(210, 246);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(75, 13);
            this.ErrorMessage.TabIndex = 4;
            this.ErrorMessage.Text = "Error Message";
            this.ErrorMessage.Visible = false;
            // 
            // TitleTextBox
            // 
            this.AddIncidentTableLayoutPanel.SetColumnSpan(this.TitleTextBox, 2);
            this.TitleTextBox.Location = new System.Drawing.Point(103, 57);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(370, 20);
            this.TitleTextBox.TabIndex = 5;
            // 
            // DescriptionTextBox
            // 
            this.AddIncidentTableLayoutPanel.SetColumnSpan(this.DescriptionTextBox, 2);
            this.DescriptionTextBox.Location = new System.Drawing.Point(103, 83);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(370, 160);
            this.DescriptionTextBox.TabIndex = 6;
            // 
            // CustomerComboBox
            // 
            this.AddIncidentTableLayoutPanel.SetColumnSpan(this.CustomerComboBox, 2);
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(103, 3);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(370, 21);
            this.CustomerComboBox.TabIndex = 7;
            // 
            // ProductComboBox
            // 
            this.AddIncidentTableLayoutPanel.SetColumnSpan(this.ProductComboBox, 2);
            this.ProductComboBox.FormattingEnabled = true;
            this.ProductComboBox.Location = new System.Drawing.Point(103, 30);
            this.ProductComboBox.Name = "ProductComboBox";
            this.ProductComboBox.Size = new System.Drawing.Size(370, 21);
            this.ProductComboBox.TabIndex = 8;
            // 
            // CreateIncidentButton
            // 
            this.CreateIncidentButton.AutoSize = true;
            this.CreateIncidentButton.Location = new System.Drawing.Point(103, 262);
            this.CreateIncidentButton.Name = "CreateIncidentButton";
            this.CreateIncidentButton.Size = new System.Drawing.Size(89, 23);
            this.CreateIncidentButton.TabIndex = 9;
            this.CreateIncidentButton.Text = "Create Incident";
            this.CreateIncidentButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.AutoSize = true;
            this.ClearButton.Location = new System.Drawing.Point(398, 262);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // AddIncidentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddIncidentTableLayoutPanel);
            this.Name = "AddIncidentUserControl";
            this.Size = new System.Drawing.Size(550, 320);
            this.AddIncidentTableLayoutPanel.ResumeLayout(false);
            this.AddIncidentTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel AddIncidentTableLayoutPanel;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label ErrorMessage;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.ComboBox ProductComboBox;
        private System.Windows.Forms.Button CreateIncidentButton;
        private System.Windows.Forms.Button ClearButton;
    }
}
