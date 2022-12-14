
namespace C969_Binkley
{
    partial class EditCustomersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.editCustomerDataGridView = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButtonECF = new System.Windows.Forms.Button();
            this.addButtonECF = new System.Windows.Forms.Button();
            this.modifyButtonECF = new System.Windows.Forms.Button();
            this.deleteButtonECF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.editCustomerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // editCustomerDataGridView
            // 
            this.editCustomerDataGridView.AllowUserToAddRows = false;
            this.editCustomerDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.editCustomerDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.editCustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editCustomerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CustomerName});
            this.editCustomerDataGridView.Location = new System.Drawing.Point(41, 29);
            this.editCustomerDataGridView.MultiSelect = false;
            this.editCustomerDataGridView.Name = "editCustomerDataGridView";
            this.editCustomerDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.editCustomerDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.editCustomerDataGridView.RowHeadersVisible = false;
            this.editCustomerDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.editCustomerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.editCustomerDataGridView.Size = new System.Drawing.Size(393, 282);
            this.editCustomerDataGridView.TabIndex = 0;
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerID.DataPropertyName = "CustomerId";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CustomerID.DefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerID.HeaderText = "Cust. ID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerName.DataPropertyName = "CustomerName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CustomerName.DefaultCellStyle = dataGridViewCellStyle3;
            this.CustomerName.HeaderText = "Cust. Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // backButtonECF
            // 
            this.backButtonECF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backButtonECF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.backButtonECF.Location = new System.Drawing.Point(194, 393);
            this.backButtonECF.Name = "backButtonECF";
            this.backButtonECF.Size = new System.Drawing.Size(90, 32);
            this.backButtonECF.TabIndex = 9;
            this.backButtonECF.Text = "Back";
            this.backButtonECF.UseVisualStyleBackColor = true;
            this.backButtonECF.Click += new System.EventHandler(this.backButtonECF_Click);
            // 
            // addButtonECF
            // 
            this.addButtonECF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addButtonECF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addButtonECF.Location = new System.Drawing.Point(75, 317);
            this.addButtonECF.Name = "addButtonECF";
            this.addButtonECF.Size = new System.Drawing.Size(90, 32);
            this.addButtonECF.TabIndex = 11;
            this.addButtonECF.Text = "Add";
            this.addButtonECF.UseVisualStyleBackColor = true;
            this.addButtonECF.Click += new System.EventHandler(this.addButtonECF_Click);
            // 
            // modifyButtonECF
            // 
            this.modifyButtonECF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modifyButtonECF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.modifyButtonECF.Location = new System.Drawing.Point(194, 317);
            this.modifyButtonECF.Name = "modifyButtonECF";
            this.modifyButtonECF.Size = new System.Drawing.Size(90, 32);
            this.modifyButtonECF.TabIndex = 12;
            this.modifyButtonECF.Text = "Modify";
            this.modifyButtonECF.UseVisualStyleBackColor = true;
            this.modifyButtonECF.Click += new System.EventHandler(this.modifyButtonECF_Click);
            // 
            // deleteButtonECF
            // 
            this.deleteButtonECF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteButtonECF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deleteButtonECF.Location = new System.Drawing.Point(316, 317);
            this.deleteButtonECF.Name = "deleteButtonECF";
            this.deleteButtonECF.Size = new System.Drawing.Size(90, 32);
            this.deleteButtonECF.TabIndex = 13;
            this.deleteButtonECF.Text = "Delete";
            this.deleteButtonECF.UseVisualStyleBackColor = true;
            this.deleteButtonECF.Click += new System.EventHandler(this.deleteButtonECF_Click);
            // 
            // EditCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 450);
            this.Controls.Add(this.deleteButtonECF);
            this.Controls.Add(this.modifyButtonECF);
            this.Controls.Add(this.addButtonECF);
            this.Controls.Add(this.backButtonECF);
            this.Controls.Add(this.editCustomerDataGridView);
            this.Name = "EditCustomersForm";
            this.Text = "EditCustomersForm";
            ((System.ComponentModel.ISupportInitialize)(this.editCustomerDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView editCustomerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.Button backButtonECF;
        private System.Windows.Forms.Button addButtonECF;
        private System.Windows.Forms.Button modifyButtonECF;
        private System.Windows.Forms.Button deleteButtonECF;
    }
}