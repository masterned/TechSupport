
namespace TechSupport.UserControls
{
    partial class DisplayOpenIncidentsUserControl
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
            this.openIncidentsListView = new System.Windows.Forms.ListView();
            this.productCodeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateOpenedColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.technicianColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titleColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // openIncidentsListView
            // 
            this.openIncidentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productCodeColumnHeader,
            this.dateOpenedColumnHeader,
            this.customerColumnHeader,
            this.technicianColumnHeader,
            this.titleColumnHeader});
            this.openIncidentsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openIncidentsListView.HideSelection = false;
            this.openIncidentsListView.Location = new System.Drawing.Point(0, 0);
            this.openIncidentsListView.Name = "openIncidentsListView";
            this.openIncidentsListView.Size = new System.Drawing.Size(512, 360);
            this.openIncidentsListView.TabIndex = 0;
            this.openIncidentsListView.UseCompatibleStateImageBehavior = false;
            this.openIncidentsListView.View = System.Windows.Forms.View.Details;
            // 
            // productCodeColumnHeader
            // 
            this.productCodeColumnHeader.Text = "Product Code";
            this.productCodeColumnHeader.Width = 100;
            // 
            // dateOpenedColumnHeader
            // 
            this.dateOpenedColumnHeader.Text = "Date Opened";
            this.dateOpenedColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateOpenedColumnHeader.Width = 100;
            // 
            // customerColumnHeader
            // 
            this.customerColumnHeader.Text = "Customer";
            this.customerColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.customerColumnHeader.Width = 100;
            // 
            // technicianColumnHeader
            // 
            this.technicianColumnHeader.Text = "Technician";
            this.technicianColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.technicianColumnHeader.Width = 100;
            // 
            // titleColumnHeader
            // 
            this.titleColumnHeader.Text = "Title";
            this.titleColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.titleColumnHeader.Width = 100;
            // 
            // DisplayOpenIncidentsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.openIncidentsListView);
            this.Name = "DisplayOpenIncidentsUserControl";
            this.Size = new System.Drawing.Size(512, 360);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView openIncidentsListView;
        private System.Windows.Forms.ColumnHeader productCodeColumnHeader;
        private System.Windows.Forms.ColumnHeader dateOpenedColumnHeader;
        private System.Windows.Forms.ColumnHeader customerColumnHeader;
        private System.Windows.Forms.ColumnHeader technicianColumnHeader;
        private System.Windows.Forms.ColumnHeader titleColumnHeader;
    }
}
