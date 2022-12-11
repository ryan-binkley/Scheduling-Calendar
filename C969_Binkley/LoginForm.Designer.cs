
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
            this.timePanel = new System.Windows.Forms.Panel();
            this.timePanelCurrentTimeLabel = new System.Windows.Forms.Label();
            this.loginTitleLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.submitCredentialsButton = new System.Windows.Forms.Button();
            this.timePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timePanel
            // 
            this.timePanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.timePanel.Controls.Add(this.timePanelCurrentTimeLabel);
            this.timePanel.Location = new System.Drawing.Point(0, 0);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(140, 60);
            this.timePanel.TabIndex = 0;
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
            // loginTitleLabel
            // 
            this.loginTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginTitleLabel.AutoSize = true;
            this.loginTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTitleLabel.Location = new System.Drawing.Point(230, 67);
            this.loginTitleLabel.Name = "loginTitleLabel";
            this.loginTitleLabel.Size = new System.Drawing.Size(107, 37);
            this.loginTitleLabel.TabIndex = 1;
            this.loginTitleLabel.Text = "Log-In";
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.usernameLabel.Location = new System.Drawing.Point(116, 131);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(97, 24);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.passwordLabel.Location = new System.Drawing.Point(121, 190);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(92, 24);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(219, 135);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(186, 20);
            this.usernameTextbox.TabIndex = 4;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(219, 194);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(186, 20);
            this.passwordTextbox.TabIndex = 5;
            // 
            // submitCredentialsButton
            // 
            this.submitCredentialsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitCredentialsButton.Location = new System.Drawing.Point(237, 241);
            this.submitCredentialsButton.Name = "submitCredentialsButton";
            this.submitCredentialsButton.Size = new System.Drawing.Size(91, 31);
            this.submitCredentialsButton.TabIndex = 6;
            this.submitCredentialsButton.Text = "Submit";
            this.submitCredentialsButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.submitCredentialsButton);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.loginTitleLabel);
            this.Controls.Add(this.timePanel);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.timePanel.ResumeLayout(false);
            this.timePanel.PerformLayout();
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
    }
}

