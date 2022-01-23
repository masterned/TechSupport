
namespace TechSupport.View
{
    partial class AddIncidentDialog
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
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.CustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.IncidentDataPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ControlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.IncidentDataPanel.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleTextBox
            // 
            this.IncidentDataPanel.SetColumnSpan(this.TitleTextBox, 2);
            this.TitleTextBox.Location = new System.Drawing.Point(3, 16);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(275, 20);
            this.TitleTextBox.TabIndex = 0;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(3, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(27, 13);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Title";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(3, 39);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "Description";
            // 
            // DescriptionTextBox
            // 
            this.IncidentDataPanel.SetColumnSpan(this.DescriptionTextBox, 2);
            this.DescriptionTextBox.Location = new System.Drawing.Point(3, 55);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionTextBox.Size = new System.Drawing.Size(275, 60);
            this.DescriptionTextBox.TabIndex = 3;
            this.DescriptionTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Location = new System.Drawing.Point(3, 126);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(65, 13);
            this.CustomerIDLabel.TabIndex = 4;
            this.CustomerIDLabel.Text = "Customer ID";
            // 
            // CustomerIDTextBox
            // 
            this.CustomerIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CustomerIDTextBox.Location = new System.Drawing.Point(74, 122);
            this.CustomerIDTextBox.Name = "CustomerIDTextBox";
            this.CustomerIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.CustomerIDTextBox.TabIndex = 5;
            this.CustomerIDTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddButton.Location = new System.Drawing.Point(32, 25);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelButton.Location = new System.Drawing.Point(172, 25);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // IncidentDataPanel
            // 
            this.IncidentDataPanel.ColumnCount = 2;
            this.IncidentDataPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.IncidentDataPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.IncidentDataPanel.Controls.Add(this.TitleLabel, 0, 0);
            this.IncidentDataPanel.Controls.Add(this.TitleTextBox, 0, 1);
            this.IncidentDataPanel.Controls.Add(this.DescriptionLabel, 0, 2);
            this.IncidentDataPanel.Controls.Add(this.DescriptionTextBox, 0, 3);
            this.IncidentDataPanel.Controls.Add(this.CustomerIDTextBox, 1, 4);
            this.IncidentDataPanel.Controls.Add(this.CustomerIDLabel, 0, 4);
            this.IncidentDataPanel.Location = new System.Drawing.Point(12, 12);
            this.IncidentDataPanel.Name = "IncidentDataPanel";
            this.IncidentDataPanel.RowCount = 5;
            this.IncidentDataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.IncidentDataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.IncidentDataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.IncidentDataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.IncidentDataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.IncidentDataPanel.Size = new System.Drawing.Size(280, 147);
            this.IncidentDataPanel.TabIndex = 8;
            // 
            // ControlPanel
            // 
            this.ControlPanel.ColumnCount = 2;
            this.ControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ControlPanel.Controls.Add(this.AddButton, 0, 1);
            this.ControlPanel.Controls.Add(this.CancelButton, 1, 1);
            this.ControlPanel.Controls.Add(this.ErrorMessage, 0, 0);
            this.ControlPanel.Location = new System.Drawing.Point(12, 165);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.RowCount = 2;
            this.ControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ControlPanel.Size = new System.Drawing.Size(280, 61);
            this.ControlPanel.TabIndex = 9;
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ControlPanel.SetColumnSpan(this.ErrorMessage, 2);
            this.ErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessage.Location = new System.Drawing.Point(3, 0);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(75, 13);
            this.ErrorMessage.TabIndex = 8;
            this.ErrorMessage.Text = "Error Message";
            this.ErrorMessage.Visible = false;
            // 
            // AddIncidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 238);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.IncidentDataPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddIncidentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Incident";
            this.IncidentDataPanel.ResumeLayout(false);
            this.IncidentDataPanel.PerformLayout();
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.TextBox CustomerIDTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TableLayoutPanel IncidentDataPanel;
        private System.Windows.Forms.TableLayoutPanel ControlPanel;
        private System.Windows.Forms.Label ErrorMessage;
    }
}