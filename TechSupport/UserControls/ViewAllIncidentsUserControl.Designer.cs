
namespace TechSupport.UserControls
{
    partial class ViewAllIncidentsUserControl
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
            this.PrimaryLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.IncidentsGridView = new System.Windows.Forms.DataGridView();
            this.IncidentsLabel = new System.Windows.Forms.Label();
            this.PrimaryLayoutTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IncidentsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PrimaryLayoutTable
            // 
            this.PrimaryLayoutTable.AutoSize = true;
            this.PrimaryLayoutTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PrimaryLayoutTable.ColumnCount = 1;
            this.PrimaryLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.PrimaryLayoutTable.Controls.Add(this.IncidentsGridView, 0, 1);
            this.PrimaryLayoutTable.Controls.Add(this.IncidentsLabel, 0, 0);
            this.PrimaryLayoutTable.Location = new System.Drawing.Point(3, 3);
            this.PrimaryLayoutTable.Name = "PrimaryLayoutTable";
            this.PrimaryLayoutTable.RowCount = 2;
            this.PrimaryLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PrimaryLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PrimaryLayoutTable.Size = new System.Drawing.Size(285, 224);
            this.PrimaryLayoutTable.TabIndex = 6;
            // 
            // IncidentsGridView
            // 
            this.IncidentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IncidentsGridView.Location = new System.Drawing.Point(3, 23);
            this.IncidentsGridView.Name = "IncidentsGridView";
            this.IncidentsGridView.Size = new System.Drawing.Size(279, 198);
            this.IncidentsGridView.TabIndex = 4;
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
            // ViewAllIncidentsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PrimaryLayoutTable);
            this.Name = "ViewAllIncidentsUserControl";
            this.Size = new System.Drawing.Size(292, 231);
            this.PrimaryLayoutTable.ResumeLayout(false);
            this.PrimaryLayoutTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IncidentsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PrimaryLayoutTable;
        private System.Windows.Forms.DataGridView IncidentsGridView;
        private System.Windows.Forms.Label IncidentsLabel;
    }
}
