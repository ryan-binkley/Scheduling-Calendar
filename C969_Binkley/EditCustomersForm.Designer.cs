
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            this.editCustomerDataGridView = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancelButtonECF = new System.Windows.Forms.Button();
            this.saveButtonECF = new System.Windows.Forms.Button();
            this.addButtonECF = new System.Windows.Forms.Button();
            this.modifyButtonECF = new System.Windows.Forms.Button();
            this.deleteButtonECF = new System.Windows.Forms.Button();
            this.customerNameTextboxECF = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.addressTextboxECF = new System.Windows.Forms.TextBox();
            this.phoneTextboxECF = new System.Windows.Forms.TextBox();
            this.cityTextboxECF = new System.Windows.Forms.TextBox();
            this.countryTextboxECF = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.editCustomerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // editCustomerDataGridView
            // 
            this.editCustomerDataGridView.AllowUserToAddRows = false;
            this.editCustomerDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.editCustomerDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.editCustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editCustomerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CustomerName});
            this.editCustomerDataGridView.Location = new System.Drawing.Point(349, 30);
            this.editCustomerDataGridView.MultiSelect = false;
            this.editCustomerDataGridView.Name = "editCustomerDataGridView";
            this.editCustomerDataGridView.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.editCustomerDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
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
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CustomerID.DefaultCellStyle = dataGridViewCellStyle22;
            this.CustomerID.HeaderText = "Cust. ID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerName.DataPropertyName = "CustomerName";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CustomerName.DefaultCellStyle = dataGridViewCellStyle23;
            this.CustomerName.HeaderText = "Cust. Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // cancelButtonECF
            // 
            this.cancelButtonECF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButtonECF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancelButtonECF.Location = new System.Drawing.Point(652, 390);
            this.cancelButtonECF.Name = "cancelButtonECF";
            this.cancelButtonECF.Size = new System.Drawing.Size(90, 32);
            this.cancelButtonECF.TabIndex = 9;
            this.cancelButtonECF.Text = "Cancel";
            this.cancelButtonECF.UseVisualStyleBackColor = true;
            this.cancelButtonECF.Click += new System.EventHandler(this.cancelButtonECF_Click);
            // 
            // saveButtonECF
            // 
            this.saveButtonECF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveButtonECF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saveButtonECF.Location = new System.Drawing.Point(534, 390);
            this.saveButtonECF.Name = "saveButtonECF";
            this.saveButtonECF.Size = new System.Drawing.Size(90, 32);
            this.saveButtonECF.TabIndex = 10;
            this.saveButtonECF.Text = "Save";
            this.saveButtonECF.UseVisualStyleBackColor = true;
            this.saveButtonECF.Click += new System.EventHandler(this.saveButtonECF_Click);
            // 
            // addButtonECF
            // 
            this.addButtonECF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addButtonECF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addButtonECF.Location = new System.Drawing.Point(383, 318);
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
            this.modifyButtonECF.Location = new System.Drawing.Point(502, 318);
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
            this.deleteButtonECF.Location = new System.Drawing.Point(624, 318);
            this.deleteButtonECF.Name = "deleteButtonECF";
            this.deleteButtonECF.Size = new System.Drawing.Size(90, 32);
            this.deleteButtonECF.TabIndex = 13;
            this.deleteButtonECF.Text = "Delete";
            this.deleteButtonECF.UseVisualStyleBackColor = true;
            this.deleteButtonECF.Click += new System.EventHandler(this.deleteButtonECF_Click);
            // 
            // customerNameTextboxECF
            // 
            this.customerNameTextboxECF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerNameTextboxECF.Location = new System.Drawing.Point(141, 88);
            this.customerNameTextboxECF.Name = "customerNameTextboxECF";
            this.customerNameTextboxECF.Size = new System.Drawing.Size(136, 20);
            this.customerNameTextboxECF.TabIndex = 14;
            this.customerNameTextboxECF.WordWrap = false;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(76, 89);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(45, 17);
            this.customerNameLabel.TabIndex = 15;
            this.customerNameLabel.Text = "Name";
            this.customerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addressTextboxECF
            // 
            this.addressTextboxECF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressTextboxECF.Location = new System.Drawing.Point(141, 130);
            this.addressTextboxECF.Name = "addressTextboxECF";
            this.addressTextboxECF.Size = new System.Drawing.Size(136, 20);
            this.addressTextboxECF.TabIndex = 16;
            this.addressTextboxECF.WordWrap = false;
            // 
            // phoneTextboxECF
            // 
            this.phoneTextboxECF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneTextboxECF.Location = new System.Drawing.Point(141, 177);
            this.phoneTextboxECF.Name = "phoneTextboxECF";
            this.phoneTextboxECF.Size = new System.Drawing.Size(136, 20);
            this.phoneTextboxECF.TabIndex = 17;
            this.phoneTextboxECF.WordWrap = false;
            // 
            // cityTextboxECF
            // 
            this.cityTextboxECF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cityTextboxECF.Location = new System.Drawing.Point(141, 223);
            this.cityTextboxECF.Name = "cityTextboxECF";
            this.cityTextboxECF.Size = new System.Drawing.Size(136, 20);
            this.cityTextboxECF.TabIndex = 18;
            this.cityTextboxECF.WordWrap = false;
            // 
            // countryTextboxECF
            // 
            this.countryTextboxECF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.countryTextboxECF.Location = new System.Drawing.Point(141, 271);
            this.countryTextboxECF.Name = "countryTextboxECF";
            this.countryTextboxECF.Size = new System.Drawing.Size(136, 20);
            this.countryTextboxECF.TabIndex = 19;
            this.countryTextboxECF.WordWrap = false;
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(53, 131);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(68, 17);
            this.addressLabel.TabIndex = 20;
            this.addressLabel.Text = "Address";
            this.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // phoneLabel
            // 
            this.phoneLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(53, 178);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(68, 17);
            this.phoneLabel.TabIndex = 21;
            this.phoneLabel.Text = "Phone";
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cityLabel
            // 
            this.cityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(53, 224);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(68, 17);
            this.cityLabel.TabIndex = 22;
            this.cityLabel.Text = "City";
            this.cityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // countryLabel
            // 
            this.countryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(53, 272);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(68, 17);
            this.countryLabel.TabIndex = 23;
            this.countryLabel.Text = "Country";
            this.countryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EditCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.countryTextboxECF);
            this.Controls.Add(this.cityTextboxECF);
            this.Controls.Add(this.phoneTextboxECF);
            this.Controls.Add(this.addressTextboxECF);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.customerNameTextboxECF);
            this.Controls.Add(this.deleteButtonECF);
            this.Controls.Add(this.modifyButtonECF);
            this.Controls.Add(this.addButtonECF);
            this.Controls.Add(this.saveButtonECF);
            this.Controls.Add(this.cancelButtonECF);
            this.Controls.Add(this.editCustomerDataGridView);
            this.Name = "EditCustomersForm";
            this.Text = "EditCustomersForm";
            ((System.ComponentModel.ISupportInitialize)(this.editCustomerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView editCustomerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.Button cancelButtonECF;
        private System.Windows.Forms.Button saveButtonECF;
        private System.Windows.Forms.Button addButtonECF;
        private System.Windows.Forms.Button modifyButtonECF;
        private System.Windows.Forms.Button deleteButtonECF;
        private System.Windows.Forms.TextBox customerNameTextboxECF;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox addressTextboxECF;
        private System.Windows.Forms.TextBox phoneTextboxECF;
        private System.Windows.Forms.TextBox cityTextboxECF;
        private System.Windows.Forms.TextBox countryTextboxECF;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label countryLabel;
    }
}