
namespace TechSupport.UserControls
{
    partial class UpdateIncidentUserControl
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
            this.UpdateIncidentTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TextToAddTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.IncidentIDLabel = new System.Windows.Forms.Label();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.TechnicianLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DateOpenedLabel = new System.Windows.Forms.Label();
            this.ExecuteButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.TextToAddLabel = new System.Windows.Forms.Label();
            this.IncidentIDTextBox = new System.Windows.Forms.TextBox();
            this.GetButton = new System.Windows.Forms.Button();
            this.CustomerTextBox = new System.Windows.Forms.TextBox();
            this.ProductTextBox = new System.Windows.Forms.TextBox();
            this.DateOpenedTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.TechnicianComboBox = new System.Windows.Forms.ComboBox();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.UpdateIncidentTableLayoutPanel.SuspendLayout();
            this.ExecuteButtonsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpdateIncidentTableLayoutPanel
            // 
            this.UpdateIncidentTableLayoutPanel.ColumnCount = 3;
            this.UpdateIncidentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.UpdateIncidentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.UpdateIncidentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.UpdateIncidentTableLayoutPanel.Controls.Add(this.TextToAddTextBox, 1, 7);
            this.UpdateIncidentTableLayoutPanel.Controls.Add(this.TitleTextBox, 1, 4);
            this.UpdateIncidentTableLayoutPanel.Controls.Add(this.IncidentIDLabel, 0, 0);
            this.UpdateIncidentTableLayoutPanel.Controls.Add(this.CustomerLabel, 0, 1);
            this.UpdateIncidentTableLayoutPanel.Controls.Add(this.ProductLabel, 0, 2);
            this.UpdateIncidentTableLayoutPanel.Controls.Add(this.TechnicianLabel, 0, 3);
            this.UpdateIncidentTableLayoutPanel.Controls.Add(this.TitleLabel, 0, 4);
            this.UpdateIncidentTableLayoutPanel.Controls.Add(this.DateOpenedLabel, 0, 5);
            this.UpdateIncidentTableLayoutPanel.Controls.Add(this.ExecuteButtonsTableLayoutPanel, 1, 9);
            this.UpdateIncidentTableLayoutPanel.Controls.Add(this.DescriptionLabel, 0, 6);
            this.UpdateIncidentTableLayoutPanel.Controls.Add(this.TextToAddLabel, 0, 7);
            this.UpdateIncidentTableLayoutPanel.Controls.Add(this.IncidentIDTextBox, 1, 0);
            this.UpdateIncidentTableLayoutPanel.Controls.Add(this.GetButton, 2, 0);
            this.UpdateIncidentTableLayoutPanel.Controls.Add(this.CustomerTextBox, 1, 1);
            this.UpdateIncidentTableLayoutPanel.Controls.Add(this.ProductTextBox, 1, 2);
            this.UpdateIncidentTableLayoutPanel.Controls.Add(this.DateOpenedTextBox, 1, 5);
            this.UpdateIncidentTableLayoutPanel.Controls.Add(this.DescriptionTextBox, 1, 6);
            this.UpdateIncidentTableLayoutPanel.Controls.Add(this.TechnicianComboBox, 1, 3);
            this.UpdateIncidentTableLayoutPanel.Controls.Add(this.ErrorMessage, 0, 8);
            this.UpdateIncidentTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.UpdateIncidentTableLayoutPanel.Name = "UpdateIncidentTableLayoutPanel";
            this.UpdateIncidentTableLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.UpdateIncidentTableLayoutPanel.RowCount = 10;
            this.UpdateIncidentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.UpdateIncidentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.UpdateIncidentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.UpdateIncidentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.UpdateIncidentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.UpdateIncidentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.UpdateIncidentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.UpdateIncidentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.UpdateIncidentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.UpdateIncidentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.UpdateIncidentTableLayoutPanel.Size = new System.Drawing.Size(357, 336);
            this.UpdateIncidentTableLayoutPanel.TabIndex = 0;
            // 
            // TextToAddTextBox
            // 
            this.TextToAddTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UpdateIncidentTableLayoutPanel.SetColumnSpan(this.TextToAddTextBox, 2);
            this.TextToAddTextBox.Enabled = false;
            this.TextToAddTextBox.Location = new System.Drawing.Point(108, 224);
            this.TextToAddTextBox.Multiline = true;
            this.TextToAddTextBox.Name = "TextToAddTextBox";
            this.TextToAddTextBox.Size = new System.Drawing.Size(243, 50);
            this.TextToAddTextBox.TabIndex = 18;
            this.TextToAddTextBox.TextChanged += new System.EventHandler(this.HandleFormUpdated);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UpdateIncidentTableLayoutPanel.SetColumnSpan(this.TitleTextBox, 2);
            this.TitleTextBox.Location = new System.Drawing.Point(108, 116);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(243, 20);
            this.TitleTextBox.TabIndex = 15;
            // 
            // IncidentIDLabel
            // 
            this.IncidentIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.IncidentIDLabel.AutoSize = true;
            this.IncidentIDLabel.Location = new System.Drawing.Point(8, 13);
            this.IncidentIDLabel.Name = "IncidentIDLabel";
            this.IncidentIDLabel.Size = new System.Drawing.Size(62, 13);
            this.IncidentIDLabel.TabIndex = 2;
            this.IncidentIDLabel.Text = "Incident ID:";
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Location = new System.Drawing.Point(8, 40);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(54, 13);
            this.CustomerLabel.TabIndex = 3;
            this.CustomerLabel.Text = "Customer:";
            // 
            // ProductLabel
            // 
            this.ProductLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Location = new System.Drawing.Point(8, 66);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(47, 13);
            this.ProductLabel.TabIndex = 4;
            this.ProductLabel.Text = "Product:";
            // 
            // TechnicianLabel
            // 
            this.TechnicianLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TechnicianLabel.AutoSize = true;
            this.TechnicianLabel.Location = new System.Drawing.Point(8, 93);
            this.TechnicianLabel.Name = "TechnicianLabel";
            this.TechnicianLabel.Size = new System.Drawing.Size(63, 13);
            this.TechnicianLabel.TabIndex = 5;
            this.TechnicianLabel.Text = "Technician:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(8, 119);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(30, 13);
            this.TitleLabel.TabIndex = 6;
            this.TitleLabel.Text = "Title:";
            // 
            // DateOpenedLabel
            // 
            this.DateOpenedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DateOpenedLabel.AutoSize = true;
            this.DateOpenedLabel.Location = new System.Drawing.Point(8, 145);
            this.DateOpenedLabel.Name = "DateOpenedLabel";
            this.DateOpenedLabel.Size = new System.Drawing.Size(74, 13);
            this.DateOpenedLabel.TabIndex = 7;
            this.DateOpenedLabel.Text = "Date Opened:";
            // 
            // ExecuteButtonsTableLayoutPanel
            // 
            this.ExecuteButtonsTableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExecuteButtonsTableLayoutPanel.AutoSize = true;
            this.ExecuteButtonsTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExecuteButtonsTableLayoutPanel.ColumnCount = 3;
            this.UpdateIncidentTableLayoutPanel.SetColumnSpan(this.ExecuteButtonsTableLayoutPanel, 2);
            this.ExecuteButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ExecuteButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ExecuteButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ExecuteButtonsTableLayoutPanel.Controls.Add(this.CloseButton, 1, 0);
            this.ExecuteButtonsTableLayoutPanel.Controls.Add(this.ClearButton, 2, 0);
            this.ExecuteButtonsTableLayoutPanel.Controls.Add(this.UpdateButton, 0, 0);
            this.ExecuteButtonsTableLayoutPanel.Location = new System.Drawing.Point(108, 296);
            this.ExecuteButtonsTableLayoutPanel.Name = "ExecuteButtonsTableLayoutPanel";
            this.ExecuteButtonsTableLayoutPanel.RowCount = 1;
            this.ExecuteButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ExecuteButtonsTableLayoutPanel.Size = new System.Drawing.Size(243, 29);
            this.ExecuteButtonsTableLayoutPanel.TabIndex = 1;
            // 
            // CloseButton
            // 
            this.CloseButton.Enabled = false;
            this.CloseButton.Location = new System.Drawing.Point(84, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(165, 3);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Enabled = false;
            this.UpdateButton.Location = new System.Drawing.Point(3, 3);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 0;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(8, 165);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.DescriptionLabel.Size = new System.Drawing.Size(63, 18);
            this.DescriptionLabel.TabIndex = 8;
            this.DescriptionLabel.Text = "Description:";
            // 
            // TextToAddLabel
            // 
            this.TextToAddLabel.AutoSize = true;
            this.TextToAddLabel.Location = new System.Drawing.Point(8, 221);
            this.TextToAddLabel.Name = "TextToAddLabel";
            this.TextToAddLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.TextToAddLabel.Size = new System.Drawing.Size(69, 18);
            this.TextToAddLabel.TabIndex = 9;
            this.TextToAddLabel.Text = "Text To Add:";
            // 
            // IncidentIDTextBox
            // 
            this.IncidentIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.IncidentIDTextBox.Location = new System.Drawing.Point(108, 9);
            this.IncidentIDTextBox.Name = "IncidentIDTextBox";
            this.IncidentIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.IncidentIDTextBox.TabIndex = 10;
            this.IncidentIDTextBox.TextChanged += new System.EventHandler(this.IncidentIDTextBox_TextChanged);
            // 
            // GetButton
            // 
            this.GetButton.Location = new System.Drawing.Point(233, 8);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(75, 23);
            this.GetButton.TabIndex = 11;
            this.GetButton.Text = "Get";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // CustomerTextBox
            // 
            this.CustomerTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UpdateIncidentTableLayoutPanel.SetColumnSpan(this.CustomerTextBox, 2);
            this.CustomerTextBox.Location = new System.Drawing.Point(108, 37);
            this.CustomerTextBox.Name = "CustomerTextBox";
            this.CustomerTextBox.ReadOnly = true;
            this.CustomerTextBox.Size = new System.Drawing.Size(243, 20);
            this.CustomerTextBox.TabIndex = 12;
            // 
            // ProductTextBox
            // 
            this.ProductTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UpdateIncidentTableLayoutPanel.SetColumnSpan(this.ProductTextBox, 2);
            this.ProductTextBox.Location = new System.Drawing.Point(108, 63);
            this.ProductTextBox.Name = "ProductTextBox";
            this.ProductTextBox.ReadOnly = true;
            this.ProductTextBox.Size = new System.Drawing.Size(243, 20);
            this.ProductTextBox.TabIndex = 13;
            // 
            // DateOpenedTextBox
            // 
            this.DateOpenedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DateOpenedTextBox.Location = new System.Drawing.Point(108, 142);
            this.DateOpenedTextBox.Name = "DateOpenedTextBox";
            this.DateOpenedTextBox.ReadOnly = true;
            this.DateOpenedTextBox.Size = new System.Drawing.Size(119, 20);
            this.DateOpenedTextBox.TabIndex = 16;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UpdateIncidentTableLayoutPanel.SetColumnSpan(this.DescriptionTextBox, 2);
            this.DescriptionTextBox.Location = new System.Drawing.Point(108, 168);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ReadOnly = true;
            this.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionTextBox.Size = new System.Drawing.Size(243, 50);
            this.DescriptionTextBox.TabIndex = 17;
            // 
            // TechnicianComboBox
            // 
            this.TechnicianComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UpdateIncidentTableLayoutPanel.SetColumnSpan(this.TechnicianComboBox, 2);
            this.TechnicianComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TechnicianComboBox.Enabled = false;
            this.TechnicianComboBox.FormattingEnabled = true;
            this.TechnicianComboBox.Location = new System.Drawing.Point(108, 89);
            this.TechnicianComboBox.Name = "TechnicianComboBox";
            this.TechnicianComboBox.Size = new System.Drawing.Size(243, 21);
            this.TechnicianComboBox.TabIndex = 19;
            this.TechnicianComboBox.SelectedIndexChanged += new System.EventHandler(this.HandleFormUpdated);
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ErrorMessage.AutoSize = true;
            this.UpdateIncidentTableLayoutPanel.SetColumnSpan(this.ErrorMessage, 3);
            this.ErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessage.Location = new System.Drawing.Point(142, 277);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(75, 13);
            this.ErrorMessage.TabIndex = 20;
            this.ErrorMessage.Text = "Error Message";
            this.ErrorMessage.Visible = false;
            // 
            // UpdateIncidentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UpdateIncidentTableLayoutPanel);
            this.Name = "UpdateIncidentUserControl";
            this.Size = new System.Drawing.Size(364, 342);
            this.UpdateIncidentTableLayoutPanel.ResumeLayout(false);
            this.UpdateIncidentTableLayoutPanel.PerformLayout();
            this.ExecuteButtonsTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel UpdateIncidentTableLayoutPanel;
        private System.Windows.Forms.Label IncidentIDLabel;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.Label TechnicianLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DateOpenedLabel;
        private System.Windows.Forms.TableLayoutPanel ExecuteButtonsTableLayoutPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label TextToAddLabel;
        private System.Windows.Forms.TextBox IncidentIDTextBox;
        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.TextBox CustomerTextBox;
        private System.Windows.Forms.TextBox ProductTextBox;
        private System.Windows.Forms.TextBox TextToAddTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox DateOpenedTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.ComboBox TechnicianComboBox;
        private System.Windows.Forms.Label ErrorMessage;
    }
}
