using System.Resources;

namespace NorthwindFormsApp.Forms
{
    partial class AddEditOrderForm
    {
        private Label lblHeading;
        private Label labelCustomer;
        private Label labelEmployee;
        private Label labelOrderDate;
        private Label labelRequiredDate;
        private Label labelShippedDate;
        private Label labelShipVia;
        private Label labelFreight;
        private Label labelShipName;
        private Label labelShipAddress;
        private Label labelShipCity;
        private Label labelShipRegion;
        private Label labelShipPostalCode;
        private Label labelShipCountry;
        private ComboBox cmbCustomers;
        private ComboBox cmbEmployees;
        private TextBox txtOrderDate;
        private TextBox txtRequiredDate;
        private TextBox txtShippedDate;
        private TextBox txtShipVia;
        private TextBox txtFreight;
        private TextBox txtShipName;
        private TextBox txtShipAddress;
        private TextBox txtShipCity;
        private TextBox txtShipRegion;
        private TextBox txtShipPostalCode;
        private TextBox txtShipCountry;
        private Button btnSave;
        private Button btnCancel;

        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            lblHeading = new Label();
            labelCustomer = new Label();
            labelEmployee = new Label();
            labelOrderDate = new Label();
            labelRequiredDate = new Label();
            labelShippedDate = new Label();
            labelShipVia = new Label();
            labelFreight = new Label();
            labelShipName = new Label();
            labelShipAddress = new Label();
            labelShipCity = new Label();
            labelShipRegion = new Label();
            labelShipPostalCode = new Label();
            labelShipCountry = new Label();
            cmbCustomers = new ComboBox();
            cmbEmployees = new ComboBox();
            txtOrderDate = new TextBox();
            txtRequiredDate = new TextBox();
            txtShippedDate = new TextBox();
            txtShipVia = new TextBox();
            txtFreight = new TextBox();
            txtShipName = new TextBox();
            txtShipAddress = new TextBox();
            txtShipCity = new TextBox();
            txtShipRegion = new TextBox();
            txtShipPostalCode = new TextBox();
            txtShipCountry = new TextBox();
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
            lblHeading.Size = new Size(241, 45);
            lblHeading.TabIndex = 1;
            lblHeading.Text = "Add/Edit Order";
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelCustomer.Location = new Point(50, 146);
            labelCustomer.Margin = new Padding(5, 0, 5, 0);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(112, 30);
            labelCustomer.TabIndex = 2;
            labelCustomer.Text = "Customer:";
            // 
            // labelEmployee
            // 
            labelEmployee.AutoSize = true;
            labelEmployee.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmployee.Location = new Point(681, 146);
            labelEmployee.Margin = new Padding(5, 0, 5, 0);
            labelEmployee.Name = "labelEmployee";
            labelEmployee.Size = new Size(114, 30);
            labelEmployee.TabIndex = 3;
            labelEmployee.Text = "Employee:";
            // 
            // labelOrderDate
            // 
            labelOrderDate.AutoSize = true;
            labelOrderDate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelOrderDate.Location = new Point(50, 223);
            labelOrderDate.Margin = new Padding(5, 0, 5, 0);
            labelOrderDate.Name = "labelOrderDate";
            labelOrderDate.Size = new Size(127, 30);
            labelOrderDate.TabIndex = 4;
            labelOrderDate.Text = "Order Date:";
            // 
            // labelRequiredDate
            // 
            labelRequiredDate.AutoSize = true;
            labelRequiredDate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelRequiredDate.Location = new Point(50, 300);
            labelRequiredDate.Margin = new Padding(5, 0, 5, 0);
            labelRequiredDate.Name = "labelRequiredDate";
            labelRequiredDate.Size = new Size(156, 30);
            labelRequiredDate.TabIndex = 5;
            labelRequiredDate.Text = "Required Date:";
            // 
            // labelShippedDate
            // 
            labelShippedDate.AutoSize = true;
            labelShippedDate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelShippedDate.Location = new Point(50, 377);
            labelShippedDate.Margin = new Padding(5, 0, 5, 0);
            labelShippedDate.Name = "labelShippedDate";
            labelShippedDate.Size = new Size(149, 30);
            labelShippedDate.TabIndex = 6;
            labelShippedDate.Text = "Shipped Date:";
            // 
            // labelShipVia
            // 
            labelShipVia.AutoSize = true;
            labelShipVia.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelShipVia.Location = new Point(681, 223);
            labelShipVia.Margin = new Padding(5, 0, 5, 0);
            labelShipVia.Name = "labelShipVia";
            labelShipVia.Size = new Size(96, 30);
            labelShipVia.TabIndex = 7;
            labelShipVia.Text = "Ship Via:";
            // 
            // labelFreight
            // 
            labelFreight.AutoSize = true;
            labelFreight.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelFreight.Location = new Point(681, 300);
            labelFreight.Margin = new Padding(5, 0, 5, 0);
            labelFreight.Name = "labelFreight";
            labelFreight.Size = new Size(86, 30);
            labelFreight.TabIndex = 8;
            labelFreight.Text = "Freight:";
            // 
            // labelShipName
            // 
            labelShipName.AutoSize = true;
            labelShipName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelShipName.Location = new Point(681, 377);
            labelShipName.Margin = new Padding(5, 0, 5, 0);
            labelShipName.Name = "labelShipName";
            labelShipName.Size = new Size(124, 30);
            labelShipName.TabIndex = 9;
            labelShipName.Text = "Ship Name:";
            // 
            // labelShipAddress
            // 
            labelShipAddress.AutoSize = true;
            labelShipAddress.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelShipAddress.Location = new Point(50, 454);
            labelShipAddress.Margin = new Padding(5, 0, 5, 0);
            labelShipAddress.Name = "labelShipAddress";
            labelShipAddress.Size = new Size(144, 30);
            labelShipAddress.TabIndex = 10;
            labelShipAddress.Text = "Ship Address:";
            // 
            // labelShipCity
            // 
            labelShipCity.AutoSize = true;
            labelShipCity.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelShipCity.Location = new Point(50, 531);
            labelShipCity.Margin = new Padding(5, 0, 5, 0);
            labelShipCity.Name = "labelShipCity";
            labelShipCity.Size = new Size(103, 30);
            labelShipCity.TabIndex = 11;
            labelShipCity.Text = "Ship City:";
            // 
            // labelShipRegion
            // 
            labelShipRegion.AutoSize = true;
            labelShipRegion.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelShipRegion.Location = new Point(681, 454);
            labelShipRegion.Margin = new Padding(5, 0, 5, 0);
            labelShipRegion.Name = "labelShipRegion";
            labelShipRegion.Size = new Size(133, 30);
            labelShipRegion.TabIndex = 12;
            labelShipRegion.Text = "Ship Region:";
            // 
            // labelShipPostalCode
            // 
            labelShipPostalCode.AutoSize = true;
            labelShipPostalCode.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelShipPostalCode.Location = new Point(50, 608);
            labelShipPostalCode.Margin = new Padding(5, 0, 5, 0);
            labelShipPostalCode.Name = "labelShipPostalCode";
            labelShipPostalCode.Size = new Size(180, 30);
            labelShipPostalCode.TabIndex = 13;
            labelShipPostalCode.Text = "Ship Postal Code:";
            // 
            // labelShipCountry
            // 
            labelShipCountry.AutoSize = true;
            labelShipCountry.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelShipCountry.Location = new Point(681, 531);
            labelShipCountry.Margin = new Padding(5, 0, 5, 0);
            labelShipCountry.Name = "labelShipCountry";
            labelShipCountry.Size = new Size(143, 30);
            labelShipCountry.TabIndex = 14;
            labelShipCountry.Text = "Ship Country:";
            // 
            // cmbCustomers
            // 
            cmbCustomers.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCustomers.FormattingEnabled = true;
            cmbCustomers.Location = new Point(317, 146);
            cmbCustomers.Margin = new Padding(5, 6, 5, 6);
            cmbCustomers.Name = "cmbCustomers";
            cmbCustomers.Size = new Size(309, 36);
            cmbCustomers.TabIndex = 15;
            // 
            // cmbEmployees
            // 
            cmbEmployees.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbEmployees.FormattingEnabled = true;
            cmbEmployees.Location = new Point(948, 146);
            cmbEmployees.Margin = new Padding(5, 6, 5, 6);
            cmbEmployees.Name = "cmbEmployees";
            cmbEmployees.Size = new Size(309, 36);
            cmbEmployees.TabIndex = 16;
            // 
            // txtOrderDate
            // 
            txtOrderDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtOrderDate.Location = new Point(317, 223);
            txtOrderDate.Margin = new Padding(5, 6, 5, 6);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new Size(309, 34);
            txtOrderDate.TabIndex = 17;
            // 
            // txtRequiredDate
            // 
            txtRequiredDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtRequiredDate.Location = new Point(317, 300);
            txtRequiredDate.Margin = new Padding(5, 6, 5, 6);
            txtRequiredDate.Name = "txtRequiredDate";
            txtRequiredDate.Size = new Size(309, 34);
            txtRequiredDate.TabIndex = 18;
            // 
            // txtShippedDate
            // 
            txtShippedDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtShippedDate.Location = new Point(317, 377);
            txtShippedDate.Margin = new Padding(5, 6, 5, 6);
            txtShippedDate.Name = "txtShippedDate";
            txtShippedDate.Size = new Size(309, 34);
            txtShippedDate.TabIndex = 19;
            // 
            // txtShipVia
            // 
            txtShipVia.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtShipVia.Location = new Point(948, 223);
            txtShipVia.Margin = new Padding(5, 6, 5, 6);
            txtShipVia.Name = "txtShipVia";
            txtShipVia.Size = new Size(309, 34);
            txtShipVia.TabIndex = 20;
            // 
            // txtFreight
            // 
            txtFreight.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtFreight.Location = new Point(948, 300);
            txtFreight.Margin = new Padding(5, 6, 5, 6);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(309, 34);
            txtFreight.TabIndex = 21;
            // 
            // txtShipName
            // 
            txtShipName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtShipName.Location = new Point(948, 377);
            txtShipName.Margin = new Padding(5, 6, 5, 6);
            txtShipName.Name = "txtShipName";
            txtShipName.Size = new Size(309, 34);
            txtShipName.TabIndex = 22;
            // 
            // txtShipAddress
            // 
            txtShipAddress.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtShipAddress.Location = new Point(317, 454);
            txtShipAddress.Margin = new Padding(5, 6, 5, 6);
            txtShipAddress.Name = "txtShipAddress";
            txtShipAddress.Size = new Size(309, 34);
            txtShipAddress.TabIndex = 23;
            // 
            // txtShipCity
            // 
            txtShipCity.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtShipCity.Location = new Point(317, 531);
            txtShipCity.Margin = new Padding(5, 6, 5, 6);
            txtShipCity.Name = "txtShipCity";
            txtShipCity.Size = new Size(309, 34);
            txtShipCity.TabIndex = 24;
            // 
            // txtShipRegion
            // 
            txtShipRegion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtShipRegion.Location = new Point(948, 454);
            txtShipRegion.Margin = new Padding(5, 6, 5, 6);
            txtShipRegion.Name = "txtShipRegion";
            txtShipRegion.Size = new Size(309, 34);
            txtShipRegion.TabIndex = 25;
            // 
            // txtShipPostalCode
            // 
            txtShipPostalCode.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtShipPostalCode.Location = new Point(317, 608);
            txtShipPostalCode.Margin = new Padding(5, 6, 5, 6);
            txtShipPostalCode.Name = "txtShipPostalCode";
            txtShipPostalCode.Size = new Size(309, 34);
            txtShipPostalCode.TabIndex = 26;
            // 
            // txtShipCountry
            // 
            txtShipCountry.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtShipCountry.Location = new Point(948, 531);
            txtShipCountry.Margin = new Padding(5, 6, 5, 6);
            txtShipCountry.Name = "txtShipCountry";
            txtShipCountry.Size = new Size(309, 34);
            txtShipCountry.TabIndex = 27;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 200, 83);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(677, 690);
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
            btnCancel.Location = new Point(426, 690);
            btnCancel.Margin = new Padding(5, 6, 5, 6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(196, 56);
            btnCancel.TabIndex = 29;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddEditOrderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1300, 800);
            Controls.Add(labelShipCountry);
            Controls.Add(labelShipPostalCode);
            Controls.Add(labelShipRegion);
            Controls.Add(labelShipCity);
            Controls.Add(labelShipAddress);
            Controls.Add(labelShipName);
            Controls.Add(labelFreight);
            Controls.Add(labelShipVia);
            Controls.Add(labelShippedDate);
            Controls.Add(labelRequiredDate);
            Controls.Add(labelOrderDate);
            Controls.Add(labelEmployee);
            Controls.Add(labelCustomer);
            Controls.Add(lblHeading);
            Controls.Add(cmbCustomers);
            Controls.Add(cmbEmployees);
            Controls.Add(txtShipCountry);
            Controls.Add(txtShipPostalCode);
            Controls.Add(txtShipRegion);
            Controls.Add(txtShipCity);
            Controls.Add(txtShipAddress);
            Controls.Add(txtShipName);
            Controls.Add(txtFreight);
            Controls.Add(txtShipVia);
            Controls.Add(txtShippedDate);
            Controls.Add(txtRequiredDate);
            Controls.Add(txtOrderDate);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 6, 5, 6);
            Name = "AddEditOrderForm";
            Text = "Add/Edit Order";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
