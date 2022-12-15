
namespace C969_Binkley
{
    partial class Calender
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
            this.timePanelCurrentTimeLabel = new System.Windows.Forms.Label();
            this.timePanel = new System.Windows.Forms.Panel();
            this.UTCTimeTimer = new System.Windows.Forms.Label();
            this.currentTimeTimer = new System.Windows.Forms.Label();
            this.timePanelUTCTimeLabel = new System.Windows.Forms.Label();
            this.appointmentCalendarDataGridView = new System.Windows.Forms.DataGridView();
            this.ApptDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApptTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentCalendarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // timePanelCurrentTimeLabel
            // 
            this.timePanelCurrentTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timePanelCurrentTimeLabel.AutoSize = true;
            this.timePanelCurrentTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePanelCurrentTimeLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.timePanelCurrentTimeLabel.Location = new System.Drawing.Point(9, 0);
            this.timePanelCurrentTimeLabel.Name = "timePanelCurrentTimeLabel";
            this.timePanelCurrentTimeLabel.Size = new System.Drawing.Size(125, 24);
            this.timePanelCurrentTimeLabel.TabIndex = 0;
            this.timePanelCurrentTimeLabel.Text = "Current Time:";
            // 
            // timePanel
            // 
            this.timePanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.timePanel.Controls.Add(this.UTCTimeTimer);
            this.timePanel.Controls.Add(this.currentTimeTimer);
            this.timePanel.Controls.Add(this.timePanelUTCTimeLabel);
            this.timePanel.Controls.Add(this.timePanelCurrentTimeLabel);
            this.timePanel.Location = new System.Drawing.Point(0, 0);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(140, 100);
            this.timePanel.TabIndex = 1;
            // 
            // UTCTimeTimer
            // 
            this.UTCTimeTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UTCTimeTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.UTCTimeTimer.ForeColor = System.Drawing.SystemColors.Window;
            this.UTCTimeTimer.Location = new System.Drawing.Point(2, 70);
            this.UTCTimeTimer.Name = "UTCTimeTimer";
            this.UTCTimeTimer.Size = new System.Drawing.Size(135, 15);
            this.UTCTimeTimer.TabIndex = 4;
            this.UTCTimeTimer.Text = "0";
            this.UTCTimeTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentTimeTimer
            // 
            this.currentTimeTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentTimeTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.currentTimeTimer.ForeColor = System.Drawing.SystemColors.Window;
            this.currentTimeTimer.Location = new System.Drawing.Point(2, 25);
            this.currentTimeTimer.Name = "currentTimeTimer";
            this.currentTimeTimer.Size = new System.Drawing.Size(135, 15);
            this.currentTimeTimer.TabIndex = 3;
            this.currentTimeTimer.Text = "0";
            this.currentTimeTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timePanelUTCTimeLabel
            // 
            this.timePanelUTCTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timePanelUTCTimeLabel.AutoSize = true;
            this.timePanelUTCTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePanelUTCTimeLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.timePanelUTCTimeLabel.Location = new System.Drawing.Point(20, 45);
            this.timePanelUTCTimeLabel.Name = "timePanelUTCTimeLabel";
            this.timePanelUTCTimeLabel.Size = new System.Drawing.Size(101, 24);
            this.timePanelUTCTimeLabel.TabIndex = 1;
            this.timePanelUTCTimeLabel.Text = "UTC Time:";
            // 
            // appointmentCalendarDataGridView
            // 
            this.appointmentCalendarDataGridView.AllowUserToAddRows = false;
            this.appointmentCalendarDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.appointmentCalendarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentCalendarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ApptDate,
            this.ApptTime,
            this.User,
            this.Customer,
            this.Type});
            this.appointmentCalendarDataGridView.Location = new System.Drawing.Point(200, 197);
            this.appointmentCalendarDataGridView.MultiSelect = false;
            this.appointmentCalendarDataGridView.Name = "appointmentCalendarDataGridView";
            this.appointmentCalendarDataGridView.RowHeadersVisible = false;
            this.appointmentCalendarDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.appointmentCalendarDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentCalendarDataGridView.Size = new System.Drawing.Size(769, 381);
            this.appointmentCalendarDataGridView.TabIndex = 0;
            // 
            // ApptDate
            // 
            this.ApptDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ApptDate.HeaderText = "Appt. Date";
            this.ApptDate.Name = "ApptDate";
            // 
            // ApptTime
            // 
            this.ApptTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ApptTime.HeaderText = "Appt. Time";
            this.ApptTime.Name = "ApptTime";
            // 
            // User
            // 
            this.User.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.User.HeaderText = "Consultant";
            this.User.Name = "User";
            // 
            // Customer
            // 
            this.Customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // Calender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.appointmentCalendarDataGridView);
            this.Controls.Add(this.timePanel);
            this.Name = "Calender";
            this.Text = "Calender-Month";
            this.timePanel.ResumeLayout(false);
            this.timePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentCalendarDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label timePanelCurrentTimeLabel;
        private System.Windows.Forms.Panel timePanel;
        private System.Windows.Forms.Label timePanelUTCTimeLabel;
        private System.Windows.Forms.Label currentTimeTimer;
        private System.Windows.Forms.Label UTCTimeTimer;
        private System.Windows.Forms.DataGridView appointmentCalendarDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApptDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApptTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
    }
}