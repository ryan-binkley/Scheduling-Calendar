
namespace C969_Binkley
{
	partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.timePanel = new System.Windows.Forms.Panel();
            this.UTCTimeTimer = new System.Windows.Forms.Label();
            this.currentTimeTimer = new System.Windows.Forms.Label();
            this.timePanelUTCTimeLabel = new System.Windows.Forms.Label();
            this.timePanelCurrentTimeLabel = new System.Windows.Forms.Label();
            this.loginTitleLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.submitCredentialsButton = new System.Windows.Forms.Button();
            this.languageLabel = new System.Windows.Forms.Label();
            this.loginErrorLabel = new System.Windows.Forms.Label();
            this.timePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timePanel
            // 
            resources.ApplyResources(this.timePanel, "timePanel");
            this.timePanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.timePanel.Controls.Add(this.UTCTimeTimer);
            this.timePanel.Controls.Add(this.currentTimeTimer);
            this.timePanel.Controls.Add(this.timePanelUTCTimeLabel);
            this.timePanel.Controls.Add(this.timePanelCurrentTimeLabel);
            this.timePanel.Name = "timePanel";
            // 
            // UTCTimeTimer
            // 
            resources.ApplyResources(this.UTCTimeTimer, "UTCTimeTimer");
            this.UTCTimeTimer.ForeColor = System.Drawing.SystemColors.Window;
            this.UTCTimeTimer.Name = "UTCTimeTimer";
            // 
            // currentTimeTimer
            // 
            resources.ApplyResources(this.currentTimeTimer, "currentTimeTimer");
            this.currentTimeTimer.ForeColor = System.Drawing.SystemColors.Window;
            this.currentTimeTimer.Name = "currentTimeTimer";
            // 
            // timePanelUTCTimeLabel
            // 
            resources.ApplyResources(this.timePanelUTCTimeLabel, "timePanelUTCTimeLabel");
            this.timePanelUTCTimeLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.timePanelUTCTimeLabel.Name = "timePanelUTCTimeLabel";
            // 
            // timePanelCurrentTimeLabel
            // 
            resources.ApplyResources(this.timePanelCurrentTimeLabel, "timePanelCurrentTimeLabel");
            this.timePanelCurrentTimeLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.timePanelCurrentTimeLabel.Name = "timePanelCurrentTimeLabel";
            // 
            // loginTitleLabel
            // 
            resources.ApplyResources(this.loginTitleLabel, "loginTitleLabel");
            this.loginTitleLabel.Name = "loginTitleLabel";
            // 
            // usernameLabel
            // 
            resources.ApplyResources(this.usernameLabel, "usernameLabel");
            this.usernameLabel.Name = "usernameLabel";
            // 
            // passwordLabel
            // 
            resources.ApplyResources(this.passwordLabel, "passwordLabel");
            this.passwordLabel.Name = "passwordLabel";
            // 
            // usernameTextbox
            // 
            resources.ApplyResources(this.usernameTextbox, "usernameTextbox");
            this.usernameTextbox.Name = "usernameTextbox";
            // 
            // passwordTextbox
            // 
            resources.ApplyResources(this.passwordTextbox, "passwordTextbox");
            this.passwordTextbox.Name = "passwordTextbox";
            // 
            // submitCredentialsButton
            // 
            resources.ApplyResources(this.submitCredentialsButton, "submitCredentialsButton");
            this.submitCredentialsButton.Name = "submitCredentialsButton";
            this.submitCredentialsButton.UseVisualStyleBackColor = true;
            this.submitCredentialsButton.Click += new System.EventHandler(this.submitCredentialsButton_Click);
            // 
            // languageLabel
            // 
            resources.ApplyResources(this.languageLabel, "languageLabel");
            this.languageLabel.Name = "languageLabel";
            // 
            // loginErrorLabel
            // 
            resources.ApplyResources(this.loginErrorLabel, "loginErrorLabel");
            this.loginErrorLabel.CausesValidation = false;
            this.loginErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.loginErrorLabel.Name = "loginErrorLabel";
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loginErrorLabel);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.submitCredentialsButton);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.loginTitleLabel);
            this.Controls.Add(this.timePanel);
            this.Name = "LoginForm";
            this.timePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Panel timePanel;
        private System.Windows.Forms.Label timePanelCurrentTimeLabel;
        private System.Windows.Forms.Label loginTitleLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Button submitCredentialsButton;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Label loginErrorLabel;
        private System.Windows.Forms.Label timePanelUTCTimeLabel;
        private System.Windows.Forms.Label currentTimeTimer;
        private System.Windows.Forms.Label UTCTimeTimer;
    }
}

