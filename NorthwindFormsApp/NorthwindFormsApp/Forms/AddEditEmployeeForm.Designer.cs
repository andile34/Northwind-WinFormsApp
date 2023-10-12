namespace NorthwindFormsApp.Forms
{
    partial class AddEditEmployeeForm
    {
        private Label lblHeading;
        private Label labelFirstName;
        private Label labelLastName;
        private Label labelBirthDate;
        private Label labelTitle;
        private Label labelAddress;
        private Label labelCity;
        private Label labelRegion;
        private Label labelPostalCode;
        private Label labelCountry;
        private Label labelHomePhone;
        private Label labelExtension;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private DateTimePicker dtBirthDate;
        private TextBox txtTitle;
        private TextBox txtAddress;
        private TextBox txtCity;
        private TextBox txtRegion;
        private TextBox txtPostalCode;
        private TextBox txtCountry;
        private TextBox txtHomePhone;
        private TextBox txtExtension;
        private Button btnSave;
        private Button btnCancel;

        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            lblHeading = new Label();
            labelFirstName = new Label();
            labelLastName = new Label();
            labelBirthDate = new Label();
            labelTitle = new Label();
            labelAddress = new Label();
            labelCity = new Label();
            labelRegion = new Label();
            labelPostalCode = new Label();
            labelCountry = new Label();
            labelHomePhone = new Label();
            labelExtension = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            dtBirthDate = new DateTimePicker();
            txtTitle = new TextBox();
            txtAddress = new TextBox();
            txtCity = new TextBox();
            txtRegion = new TextBox();
            txtPostalCode = new TextBox();
            txtCountry = new TextBox();
            txtHomePhone = new TextBox();
            txtExtension = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
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
            lblHeading.Text = "Add/Edit Employee";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelFirstName.Location = new Point(50, 146);
            labelFirstName.Margin = new Padding(5, 0, 5, 0);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(122, 30);
            labelFirstName.TabIndex = 23;
            labelFirstName.Text = "First Name:";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelLastName.Location = new Point(50, 223);
            labelLastName.Margin = new Padding(5, 0, 5, 0);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(119, 30);
            labelLastName.TabIndex = 22;
            labelLastName.Text = "Last Name:";
            // 
            // labelBirthDate
            // 
            labelBirthDate.AutoSize = true;
            labelBirthDate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelBirthDate.Location = new Point(50, 300);
            labelBirthDate.Margin = new Padding(5, 0, 5, 0);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(114, 30);
            labelBirthDate.TabIndex = 21;
            labelBirthDate.Text = "Birth Date:";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(50, 377);
            labelTitle.Margin = new Padding(5, 0, 5, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(59, 30);
            labelTitle.TabIndex = 20;
            labelTitle.Text = "Title:";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelAddress.Location = new Point(681, 146);
            labelAddress.Margin = new Padding(5, 0, 5, 0);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(96, 30);
            labelAddress.TabIndex = 19;
            labelAddress.Text = "Address:";
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelCity.Location = new Point(681, 223);
            labelCity.Margin = new Padding(5, 0, 5, 0);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(55, 30);
            labelCity.TabIndex = 18;
            labelCity.Text = "City:";
            // 
            // labelRegion
            // 
            labelRegion.AutoSize = true;
            labelRegion.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelRegion.Location = new Point(681, 300);
            labelRegion.Margin = new Padding(5, 0, 5, 0);
            labelRegion.Name = "labelRegion";
            labelRegion.Size = new Size(85, 30);
            labelRegion.TabIndex = 17;
            labelRegion.Text = "Region:";
            // 
            // labelPostalCode
            // 
            labelPostalCode.AutoSize = true;
            labelPostalCode.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelPostalCode.Location = new Point(681, 377);
            labelPostalCode.Margin = new Padding(5, 0, 5, 0);
            labelPostalCode.Name = "labelPostalCode";
            labelPostalCode.Size = new Size(132, 30);
            labelPostalCode.TabIndex = 16;
            labelPostalCode.Text = "Postal Code:";
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelCountry.Location = new Point(50, 456);
            labelCountry.Margin = new Padding(5, 0, 5, 0);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(95, 30);
            labelCountry.TabIndex = 15;
            labelCountry.Text = "Country:";
            // 
            // labelHomePhone
            // 
            labelHomePhone.AutoSize = true;
            labelHomePhone.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelHomePhone.Location = new Point(317, 456);
            labelHomePhone.Margin = new Padding(5, 0, 5, 0);
            labelHomePhone.Name = "labelHomePhone";
            labelHomePhone.Size = new Size(145, 30);
            labelHomePhone.TabIndex = 15;
            labelHomePhone.Text = "Home Phone:";
            // 
            // labelExtension
            // 
            labelExtension.AutoSize = true;
            labelExtension.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelExtension.Location = new Point(948, 456);
            labelExtension.Margin = new Padding(5, 0, 5, 0);
            labelExtension.Name = "labelExtension";
            labelExtension.Size = new Size(109, 30);
            labelExtension.TabIndex = 15;
            labelExtension.Text = "Extension:";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(317, 146);
            txtFirstName.Margin = new Padding(5, 6, 5, 6);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(309, 34);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(317, 223);
            txtLastName.Margin = new Padding(5, 6, 5, 6);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(309, 34);
            txtLastName.TabIndex = 2;
            // 
            // dtBirthDate
            // 
            dtBirthDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtBirthDate.Location = new Point(317, 300);
            dtBirthDate.Margin = new Padding(5, 6, 5, 6);
            dtBirthDate.Name = "dtBirthDate";
            dtBirthDate.Size = new Size(309, 34);
            dtBirthDate.TabIndex = 3;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitle.Location = new Point(317, 377);
            txtTitle.Margin = new Padding(5, 6, 5, 6);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(309, 34);
            txtTitle.TabIndex = 4;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(948, 146);
            txtAddress.Margin = new Padding(5, 6, 5, 6);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(309, 34);
            txtAddress.TabIndex = 5;
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCity.Location = new Point(948, 223);
            txtCity.Margin = new Padding(5, 6, 5, 6);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(309, 34);
            txtCity.TabIndex = 6;
            // 
            // txtRegion
            // 
            txtRegion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtRegion.Location = new Point(948, 300);
            txtRegion.Margin = new Padding(5, 6, 5, 6);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(309, 34);
            txtRegion.TabIndex = 7;
            // 
            // txtPostalCode
            // 
            txtPostalCode.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPostalCode.Location = new Point(948, 377);
            txtPostalCode.Margin = new Padding(5, 6, 5, 6);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(309, 34);
            txtPostalCode.TabIndex = 8;
            // 
            // txtCountry
            // 
            txtCountry.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCountry.Location = new Point(317, 456);
            txtCountry.Margin = new Padding(5, 6, 5, 6);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(309, 34);
            txtCountry.TabIndex = 9;
            // 
            // txtHomePhone
            // 
            txtHomePhone.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtHomePhone.Location = new Point(948, 456);
            txtHomePhone.Margin = new Padding(5, 6, 5, 6);
            txtHomePhone.Name = "txtHomePhone";
            txtHomePhone.Size = new Size(309, 34);
            txtHomePhone.TabIndex = 10;
            // 
            // txtExtension
            // 
            txtExtension.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtExtension.Location = new Point(317, 537);
            txtExtension.Margin = new Padding(5, 6, 5, 6);
            txtExtension.Name = "txtExtension";
            txtExtension.Size = new Size(309, 34);
            txtExtension.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 200, 83);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(709, 637);
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
            btnCancel.Location = new Point(458, 637);
            btnCancel.Margin = new Padding(5, 6, 5, 6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(196, 56);
            btnCancel.TabIndex = 29;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(50, 539);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 30);
            label1.TabIndex = 30;
            label1.Text = "Extension:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(681, 456);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 30);
            label2.TabIndex = 31;
            label2.Text = "Home Phone:";
            // 
            // AddEditEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 924);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtExtension);
            Controls.Add(txtHomePhone);
            Controls.Add(txtCountry);
            Controls.Add(txtPostalCode);
            Controls.Add(txtRegion);
            Controls.Add(txtCity);
            Controls.Add(txtAddress);
            Controls.Add(txtTitle);
            Controls.Add(dtBirthDate);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(labelExtension);
            Controls.Add(labelHomePhone);
            Controls.Add(labelCountry);
            Controls.Add(labelPostalCode);
            Controls.Add(labelRegion);
            Controls.Add(labelCity);
            Controls.Add(labelAddress);
            Controls.Add(labelTitle);
            Controls.Add(labelBirthDate);
            Controls.Add(labelLastName);
            Controls.Add(labelFirstName);
            Controls.Add(lblHeading);
            Margin = new Padding(5, 6, 5, 6);
            Name = "AddEditEmployeeForm";
            Text = "Add/Edit Employee";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
    }
}
