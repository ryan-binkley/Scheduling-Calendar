
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
            this.timePanelUTCTimeLabel = new System.Windows.Forms.Label();
            this.currentTimeTimer = new System.Windows.Forms.Label();
            this.UTCTimeTimer = new System.Windows.Forms.Label();
            this.timePanel.SuspendLayout();
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
            // Calender_Month
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.timePanel);
            this.Name = "Calender_Month";
            this.Text = "Calender-Month";
            this.timePanel.ResumeLayout(false);
            this.timePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label timePanelCurrentTimeLabel;
        private System.Windows.Forms.Panel timePanel;
        private System.Windows.Forms.Label timePanelUTCTimeLabel;
        private System.Windows.Forms.Label currentTimeTimer;
        private System.Windows.Forms.Label UTCTimeTimer;
    }
}