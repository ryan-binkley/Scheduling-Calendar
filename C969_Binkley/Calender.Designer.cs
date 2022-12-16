
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
            this.AppointmentDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allAppointmentsRadioButton = new System.Windows.Forms.RadioButton();
            this.monthAppointmentsRadioButton = new System.Windows.Forms.RadioButton();
            this.weekAppointmentsRadioButton = new System.Windows.Forms.RadioButton();
            this.dateLabel = new System.Windows.Forms.Label();
            this.nextDateButton = new System.Windows.Forms.Button();
            this.prevDateButton = new System.Windows.Forms.Button();
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
            this.AppointmentDay,
            this.AppointmentStartTime,
            this.AppointmentEndTime,
            this.UserName,
            this.CustomerName,
            this.Type});
            this.appointmentCalendarDataGridView.Location = new System.Drawing.Point(196, 197);
            this.appointmentCalendarDataGridView.MultiSelect = false;
            this.appointmentCalendarDataGridView.Name = "appointmentCalendarDataGridView";
            this.appointmentCalendarDataGridView.ReadOnly = true;
            this.appointmentCalendarDataGridView.RowHeadersVisible = false;
            this.appointmentCalendarDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.appointmentCalendarDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentCalendarDataGridView.Size = new System.Drawing.Size(769, 381);
            this.appointmentCalendarDataGridView.TabIndex = 0;
            // 
            // AppointmentDay
            // 
            this.AppointmentDay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AppointmentDay.DataPropertyName = "AppointmentDay";
            this.AppointmentDay.HeaderText = "Appt. Date";
            this.AppointmentDay.Name = "AppointmentDay";
            this.AppointmentDay.ReadOnly = true;
            // 
            // AppointmentStartTime
            // 
            this.AppointmentStartTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AppointmentStartTime.DataPropertyName = "AppointmentStartTime";
            this.AppointmentStartTime.HeaderText = "Appt. Start";
            this.AppointmentStartTime.Name = "AppointmentStartTime";
            this.AppointmentStartTime.ReadOnly = true;
            // 
            // AppointmentEndTime
            // 
            this.AppointmentEndTime.DataPropertyName = "AppointmentEndTime";
            this.AppointmentEndTime.HeaderText = "Appt. End";
            this.AppointmentEndTime.Name = "AppointmentEndTime";
            this.AppointmentEndTime.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Consultant";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Customer";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // allAppointmentsRadioButton
            // 
            this.allAppointmentsRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allAppointmentsRadioButton.AutoSize = true;
            this.allAppointmentsRadioButton.Checked = true;
            this.allAppointmentsRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.allAppointmentsRadioButton.Location = new System.Drawing.Point(257, 163);
            this.allAppointmentsRadioButton.Name = "allAppointmentsRadioButton";
            this.allAppointmentsRadioButton.Size = new System.Drawing.Size(170, 28);
            this.allAppointmentsRadioButton.TabIndex = 2;
            this.allAppointmentsRadioButton.TabStop = true;
            this.allAppointmentsRadioButton.Text = "All Appointments";
            this.allAppointmentsRadioButton.UseVisualStyleBackColor = true;
            this.allAppointmentsRadioButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.allAppointmentsRadioButton_MouseDown);
            // 
            // monthAppointmentsRadioButton
            // 
            this.monthAppointmentsRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthAppointmentsRadioButton.AutoSize = true;
            this.monthAppointmentsRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.monthAppointmentsRadioButton.Location = new System.Drawing.Point(507, 163);
            this.monthAppointmentsRadioButton.Name = "monthAppointmentsRadioButton";
            this.monthAppointmentsRadioButton.Size = new System.Drawing.Size(154, 28);
            this.monthAppointmentsRadioButton.TabIndex = 3;
            this.monthAppointmentsRadioButton.TabStop = true;
            this.monthAppointmentsRadioButton.Text = "View By Month";
            this.monthAppointmentsRadioButton.UseVisualStyleBackColor = true;
            this.monthAppointmentsRadioButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.monthAppointmentsRadioButton_MouseDown);
            // 
            // weekAppointmentsRadioButton
            // 
            this.weekAppointmentsRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.weekAppointmentsRadioButton.AutoSize = true;
            this.weekAppointmentsRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.weekAppointmentsRadioButton.Location = new System.Drawing.Point(746, 163);
            this.weekAppointmentsRadioButton.Name = "weekAppointmentsRadioButton";
            this.weekAppointmentsRadioButton.Size = new System.Drawing.Size(150, 28);
            this.weekAppointmentsRadioButton.TabIndex = 4;
            this.weekAppointmentsRadioButton.TabStop = true;
            this.weekAppointmentsRadioButton.Text = "View By Week";
            this.weekAppointmentsRadioButton.UseVisualStyleBackColor = true;
            this.weekAppointmentsRadioButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.weekAppointmentsRadioButton_MouseDown);
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(378, 85);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(411, 37);
            this.dateLabel.TabIndex = 5;
            this.dateLabel.Text = "MonthLabel";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateLabel.Visible = false;
            // 
            // nextDateButton
            // 
            this.nextDateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nextDateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.nextDateButton.Location = new System.Drawing.Point(806, 78);
            this.nextDateButton.Name = "nextDateButton";
            this.nextDateButton.Size = new System.Drawing.Size(50, 50);
            this.nextDateButton.TabIndex = 6;
            this.nextDateButton.Text = ">";
            this.nextDateButton.UseVisualStyleBackColor = true;
            this.nextDateButton.Visible = false;
            // 
            // prevDateButton
            // 
            this.prevDateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prevDateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.prevDateButton.Location = new System.Drawing.Point(311, 78);
            this.prevDateButton.Name = "prevDateButton";
            this.prevDateButton.Size = new System.Drawing.Size(50, 50);
            this.prevDateButton.TabIndex = 7;
            this.prevDateButton.Text = "<";
            this.prevDateButton.UseVisualStyleBackColor = true;
            this.prevDateButton.Visible = false;
            // 
            // Calender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.prevDateButton);
            this.Controls.Add(this.nextDateButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.weekAppointmentsRadioButton);
            this.Controls.Add(this.monthAppointmentsRadioButton);
            this.Controls.Add(this.allAppointmentsRadioButton);
            this.Controls.Add(this.appointmentCalendarDataGridView);
            this.Controls.Add(this.timePanel);
            this.Name = "Calender";
            this.Text = "Calender-Month";
            this.timePanel.ResumeLayout(false);
            this.timePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentCalendarDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timePanelCurrentTimeLabel;
        private System.Windows.Forms.Panel timePanel;
        private System.Windows.Forms.Label timePanelUTCTimeLabel;
        private System.Windows.Forms.Label currentTimeTimer;
        private System.Windows.Forms.Label UTCTimeTimer;
        private System.Windows.Forms.DataGridView appointmentCalendarDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.RadioButton allAppointmentsRadioButton;
        private System.Windows.Forms.RadioButton monthAppointmentsRadioButton;
        private System.Windows.Forms.RadioButton weekAppointmentsRadioButton;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button nextDateButton;
        private System.Windows.Forms.Button prevDateButton;
    }
}