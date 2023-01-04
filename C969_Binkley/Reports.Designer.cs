
namespace C969_Binkley
{
    partial class Reports
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
            this.tbmButton = new System.Windows.Forms.Button();
            this.consultantScheduleButton = new System.Windows.Forms.Button();
            this.userScheduleButton = new System.Windows.Forms.Button();
            this.mainTextbox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbmButton
            // 
            this.tbmButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbmButton.Location = new System.Drawing.Point(88, 53);
            this.tbmButton.Name = "tbmButton";
            this.tbmButton.Size = new System.Drawing.Size(119, 56);
            this.tbmButton.TabIndex = 9;
            this.tbmButton.Text = "Types By Month";
            this.tbmButton.UseVisualStyleBackColor = true;
            this.tbmButton.Click += new System.EventHandler(this.tbmButton_Click);
            // 
            // consultantScheduleButton
            // 
            this.consultantScheduleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.consultantScheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.consultantScheduleButton.Location = new System.Drawing.Point(436, 53);
            this.consultantScheduleButton.Name = "consultantScheduleButton";
            this.consultantScheduleButton.Size = new System.Drawing.Size(119, 56);
            this.consultantScheduleButton.TabIndex = 10;
            this.consultantScheduleButton.Text = "Consultant Schedule";
            this.consultantScheduleButton.UseVisualStyleBackColor = true;
            this.consultantScheduleButton.Click += new System.EventHandler(this.consultantScheduleButton_Click);
            // 
            // userScheduleButton
            // 
            this.userScheduleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userScheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.userScheduleButton.Location = new System.Drawing.Point(775, 53);
            this.userScheduleButton.Name = "userScheduleButton";
            this.userScheduleButton.Size = new System.Drawing.Size(119, 56);
            this.userScheduleButton.TabIndex = 11;
            this.userScheduleButton.Text = "User Schedule";
            this.userScheduleButton.UseVisualStyleBackColor = true;
            this.userScheduleButton.Click += new System.EventHandler(this.userScheduleButton_Click);
            // 
            // mainTextbox
            // 
            this.mainTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTextbox.Location = new System.Drawing.Point(88, 157);
            this.mainTextbox.Multiline = true;
            this.mainTextbox.Name = "mainTextbox";
            this.mainTextbox.Size = new System.Drawing.Size(806, 440);
            this.mainTextbox.TabIndex = 12;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.exitButton.Location = new System.Drawing.Point(436, 659);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(119, 56);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mainTextbox);
            this.Controls.Add(this.userScheduleButton);
            this.Controls.Add(this.consultantScheduleButton);
            this.Controls.Add(this.tbmButton);
            this.Name = "Reports";
            this.Text = "Reports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbmButton;
        private System.Windows.Forms.Button consultantScheduleButton;
        private System.Windows.Forms.Button userScheduleButton;
        private System.Windows.Forms.TextBox mainTextbox;
        private System.Windows.Forms.Button exitButton;
    }
}