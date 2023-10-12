namespace NorthwindFormsApp.Forms
{
    partial class AddEditCustomerForm
    {
        private Label lblHeading;
        private Label labelCompanyName;
        private Label labelContactName;
        private Label labelContactTitle;
        private Label labelAddress;
        private Label labelCity;
        private Label labelRegion;
        private Label labelPostalCode;
        private Label labelCountry;
        private Label labelPhone;
        private Label labelFax;
        private TextBox txtCompanyName;
        private TextBox txtContactName;
        private TextBox txtContactTitle;
        private TextBox txtAddress;
        private TextBox txtCity;
        private TextBox txtRegion;
        private TextBox txtPostalCode;
        private TextBox txtCountry;
        private TextBox txtPhone;
        private TextBox txtFax;
        private Button btnSave;
        private Button btnCancel;
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            lblHeading = new Label();
            labelCompanyName = new Label();
            labelContactName = new Label();
            labelContactTitle = new Label();
            labelAddress = new Label();
            labelCity = new Label();
            labelRegion = new Label();
            labelPostalCode = new Label();
            labelCountry = new Label();
            labelPhone = new Label();
            labelFax = new Label();
            txtCompanyName = new TextBox();
            txtContactName = new TextBox();
            txtContactTitle = new TextBox();
            txtAddress = new TextBox();
            txtCity = new TextBox();
            txtRegion = new TextBox();
            txtPostalCode = new TextBox();
            txtCountry = new TextBox();
            txtPhone = new TextBox();
            txtFax = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeading.ForeColor = Color.FromArgb(52, 73, 94);
            lblHeading.Location = new Point(33, 37);
            lblHeading.Margin = new Padding(5, 0, 5, 0);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(298, 45);
            lblHeading.TabIndex = 1;
            lblHeading.Text = "Add/Edit Customer";
            // 
            // labelCompanyName
            // 
            labelCompanyName.AutoSize = true;
            labelCompanyName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelCompanyName.Location = new Point(50, 146);
            labelCompanyName.Margin = new Padding(5, 0, 5, 0);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new Size(175, 30);
            labelCompanyName.TabIndex = 2;
            labelCompanyName.Text = "Company Name:";
            // 
            // labelContactName
            // 
            labelContactName.AutoSize = true;
            labelContactName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelContactName.Location = new Point(50, 223);
            labelContactName.Margin = new Padding(5, 0, 5, 0);
            labelContactName.Name = "labelContactName";
            labelContactName.Size = new Size(156, 30);
            labelContactName.TabIndex = 3;
            labelContactName.Text = "Contact Name:";
            // 
            // labelContactTitle
            // 
            labelContactTitle.AutoSize = true;
            labelContactTitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelContactTitle.Location = new Point(50, 300);
            labelContactTitle.Margin = new Padding(5, 0, 5, 0);
            labelContactTitle.Name = "labelContactTitle";
            labelContactTitle.Size = new Size(139, 30);
            labelContactTitle.TabIndex = 4;
            labelContactTitle.Text = "Contact Title:";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelAddress.Location = new Point(50, 377);
            labelAddress.Margin = new Padding(5, 0, 5, 0);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(96, 30);
            labelAddress.TabIndex = 5;
            labelAddress.Text = "Address:";
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelCity.Location = new Point(50, 454);
            labelCity.Margin = new Padding(5, 0, 5, 0);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(55, 30);
            labelCity.TabIndex = 6;
            labelCity.Text = "City:";
            // 
            // labelRegion
            // 
            labelRegion.AutoSize = true;
            labelRegion.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelRegion.Location = new Point(681, 146);
            labelRegion.Margin = new Padding(5, 0, 5, 0);
            labelRegion.Name = "labelRegion";
            labelRegion.Size = new Size(85, 30);
            labelRegion.TabIndex = 7;
            labelRegion.Text = "Region:";
            // 
            // labelPostalCode
            // 
            labelPostalCode.AutoSize = true;
            labelPostalCode.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelPostalCode.Location = new Point(681, 223);
            labelPostalCode.Margin = new Padding(5, 0, 5, 0);
            labelPostalCode.Name = "labelPostalCode";
            labelPostalCode.Size = new Size(132, 30);
            labelPostalCode.TabIndex = 8;
            labelPostalCode.Text = "Postal Code:";
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelCountry.Location = new Point(681, 300);
            labelCountry.Margin = new Padding(5, 0, 5, 0);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(95, 30);
            labelCountry.TabIndex = 9;
            labelCountry.Text = "Country:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelPhone.Location = new Point(681, 377);
            labelPhone.Margin = new Padding(5, 0, 5, 0);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(79, 30);
            labelPhone.TabIndex = 10;
            labelPhone.Text = "Phone:";
            // 
            // labelFax
            // 
            labelFax.AutoSize = true;
            labelFax.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelFax.Location = new Point(681, 454);
            labelFax.Margin = new Padding(5, 0, 5, 0);
            labelFax.Name = "labelFax";
            labelFax.Size = new Size(49, 30);
            labelFax.TabIndex = 11;
            labelFax.Text = "Fax:";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCompanyName.Location = new Point(317, 146);
            txtCompanyName.Margin = new Padding(5, 6, 5, 6);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(309, 34);
            txtCompanyName.TabIndex = 12;
            // 
            // txtContactName
            // 
            txtContactName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtContactName.Location = new Point(317, 223);
            txtContactName.Margin = new Padding(5, 6, 5, 6);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(309, 34);
            txtContactName.TabIndex = 13;
            // 
            // txtContactTitle
            // 
            txtContactTitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtContactTitle.Location = new Point(317, 300);
            txtContactTitle.Margin = new Padding(5, 6, 5, 6);
            txtContactTitle.Name = "txtContactTitle";
            txtContactTitle.Size = new Size(309, 34);
            txtContactTitle.TabIndex = 14;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(317, 377);
            txtAddress.Margin = new Padding(5, 6, 5, 6);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(309, 34);
            txtAddress.TabIndex = 15;
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCity.Location = new Point(317, 454);
            txtCity.Margin = new Padding(5, 6, 5, 6);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(309, 34);
            txtCity.TabIndex = 16;
            // 
            // txtRegion
            // 
            txtRegion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtRegion.Location = new Point(948, 146);
            txtRegion.Margin = new Padding(5, 6, 5, 6);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(309, 34);
            txtRegion.TabIndex = 17;
            // 
            // txtPostalCode
            // 
            txtPostalCode.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPostalCode.Location = new Point(948, 223);
            txtPostalCode.Margin = new Padding(5, 6, 5, 6);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(309, 34);
            txtPostalCode.TabIndex = 18;
            // 
            // txtCountry
            // 
            txtCountry.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCountry.Location = new Point(948, 300);
            txtCountry.Margin = new Padding(5, 6, 5, 6);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(309, 34);
            txtCountry.TabIndex = 19;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(948, 377);
            txtPhone.Margin = new Padding(5, 6, 5, 6);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(309, 34);
            txtPhone.TabIndex = 20;
            // 
            // txtFax
            // 
            txtFax.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtFax.Location = new Point(948, 454);
            txtFax.Margin = new Padding(5, 6, 5, 6);
            txtFax.Name = "txtFax";
            txtFax.Size = new Size(309, 34);
            txtFax.TabIndex = 21;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 200, 83);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(705, 541);
            btnSave.Margin = new Padding(5, 6, 5, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(196, 56);
            btnSave.TabIndex = 28;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(231, 76, 60);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(454, 541);
            btnCancel.Margin = new Padding(5, 6, 5, 6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(196, 56);
            btnCancel.TabIndex = 29;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddEditCustomerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 924);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtFax);
            Controls.Add(txtPhone);
            Controls.Add(txtCountry);
            Controls.Add(txtPostalCode);
            Controls.Add(txtRegion);
            Controls.Add(txtCity);
            Controls.Add(txtAddress);
            Controls.Add(txtContactTitle);
            Controls.Add(txtContactName);
            Controls.Add(txtCompanyName);
            Controls.Add(labelFax);
            Controls.Add(labelPhone);
            Controls.Add(labelCountry);
            Controls.Add(labelPostalCode);
            Controls.Add(labelRegion);
            Controls.Add(labelCity);
            Controls.Add(labelAddress);
            Controls.Add(labelContactTitle);
            Controls.Add(labelContactName);
            Controls.Add(labelCompanyName);
            Controls.Add(lblHeading);
            Margin = new Padding(5, 6, 5, 6);
            Name = "AddEditCustomerForm";
            Text = "Add/Edit Customer";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
