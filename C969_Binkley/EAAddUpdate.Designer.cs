
namespace C969_Binkley
{
    partial class EAAddUpdate
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
            this.saveButtonEAF = new System.Windows.Forms.Button();
            this.cancelButtonEAF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveButtonEAF
            // 
            this.saveButtonEAF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveButtonEAF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saveButtonEAF.Location = new System.Drawing.Point(44, 267);
            this.saveButtonEAF.Name = "saveButtonEAF";
            this.saveButtonEAF.Size = new System.Drawing.Size(90, 32);
            this.saveButtonEAF.TabIndex = 35;
            this.saveButtonEAF.Text = "Save";
            this.saveButtonEAF.UseVisualStyleBackColor = true;
            this.saveButtonEAF.Click += new System.EventHandler(this.saveButtonEAF_Click);
            // 
            // cancelButtonEAF
            // 
            this.cancelButtonEAF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButtonEAF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancelButtonEAF.Location = new System.Drawing.Point(180, 267);
            this.cancelButtonEAF.Name = "cancelButtonEAF";
            this.cancelButtonEAF.Size = new System.Drawing.Size(90, 32);
            this.cancelButtonEAF.TabIndex = 36;
            this.cancelButtonEAF.Text = "Cancel";
            this.cancelButtonEAF.UseVisualStyleBackColor = true;
            this.cancelButtonEAF.Click += new System.EventHandler(this.cancelButtonEAF_Click);
            // 
            // EAAddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 321);
            this.Controls.Add(this.cancelButtonEAF);
            this.Controls.Add(this.saveButtonEAF);
            this.Name = "EAAddUpdate";
            this.Text = "EAAddUpdate";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveButtonEAF;
        private System.Windows.Forms.Button cancelButtonEAF;
    }
}