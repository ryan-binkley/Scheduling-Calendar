
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
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 157);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(806, 440);
            this.textBox1.TabIndex = 12;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
    }
}