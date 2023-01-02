
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
            this.EAFLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerDopdown = new System.Windows.Forms.ComboBox();
            this.userDropdown = new System.Windows.Forms.ComboBox();
            this.typeTextbox = new System.Windows.Forms.TextBox();
            this.datetimepickerDay = new System.Windows.Forms.DateTimePicker();
            this.datetimepickerTime = new System.Windows.Forms.DateTimePicker();
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
            // EAFLabel
            // 
            this.EAFLabel.AutoSize = true;
            this.EAFLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EAFLabel.Location = new System.Drawing.Point(12, 9);
            this.EAFLabel.Name = "EAFLabel";
            this.EAFLabel.Size = new System.Drawing.Size(0, 20);
            this.EAFLabel.TabIndex = 37;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.typeLabel.Location = new System.Drawing.Point(47, 53);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(43, 20);
            this.typeLabel.TabIndex = 38;
            this.typeLabel.Text = "Type";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customerLabel.Location = new System.Drawing.Point(12, 99);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(78, 20);
            this.customerLabel.TabIndex = 39;
            this.customerLabel.Text = "Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(46, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(4, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Consultant";
            // 
            // customerDopdown
            // 
            this.customerDopdown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerDopdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerDopdown.FormattingEnabled = true;
            this.customerDopdown.Location = new System.Drawing.Point(109, 99);
            this.customerDopdown.Name = "customerDopdown";
            this.customerDopdown.Size = new System.Drawing.Size(174, 21);
            this.customerDopdown.TabIndex = 42;
            // 
            // userDropdown
            // 
            this.userDropdown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userDropdown.FormattingEnabled = true;
            this.userDropdown.Location = new System.Drawing.Point(109, 189);
            this.userDropdown.Name = "userDropdown";
            this.userDropdown.Size = new System.Drawing.Size(174, 21);
            this.userDropdown.TabIndex = 43;
            // 
            // typeTextbox
            // 
            this.typeTextbox.Location = new System.Drawing.Point(109, 55);
            this.typeTextbox.Name = "typeTextbox";
            this.typeTextbox.Size = new System.Drawing.Size(174, 20);
            this.typeTextbox.TabIndex = 44;
            // 
            // datetimepickerDay
            // 
            this.datetimepickerDay.CustomFormat = "\"ddd, MMM dd\"";
            this.datetimepickerDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimepickerDay.Location = new System.Drawing.Point(109, 144);
            this.datetimepickerDay.Name = "datetimepickerDay";
            this.datetimepickerDay.Size = new System.Drawing.Size(94, 20);
            this.datetimepickerDay.TabIndex = 45;
            // 
            // datetimepickerTime
            // 
            this.datetimepickerTime.CustomFormat = "\"hh\':\'mm tt\"";
            this.datetimepickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimepickerTime.Location = new System.Drawing.Point(206, 144);
            this.datetimepickerTime.Name = "datetimepickerTime";
            this.datetimepickerTime.ShowUpDown = true;
            this.datetimepickerTime.Size = new System.Drawing.Size(77, 20);
            this.datetimepickerTime.TabIndex = 46;
            // 
            // EAAddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 321);
            this.Controls.Add(this.datetimepickerTime);
            this.Controls.Add(this.datetimepickerDay);
            this.Controls.Add(this.typeTextbox);
            this.Controls.Add(this.userDropdown);
            this.Controls.Add(this.customerDopdown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.EAFLabel);
            this.Controls.Add(this.cancelButtonEAF);
            this.Controls.Add(this.saveButtonEAF);
            this.Name = "EAAddUpdate";
            this.Text = "EAAddUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButtonEAF;
        private System.Windows.Forms.Button cancelButtonEAF;
        private System.Windows.Forms.Label EAFLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox customerDopdown;
        private System.Windows.Forms.ComboBox userDropdown;
        private System.Windows.Forms.TextBox typeTextbox;
        private System.Windows.Forms.DateTimePicker datetimepickerDay;
        private System.Windows.Forms.DateTimePicker datetimepickerTime;
    }
}