namespace NorthwindFormsApp.Forms
{
    partial class AddEditProductForm
    {
        private Label lblHeading;
        private Label labelProductName;
        private Label labelCategory;
        private Label labelSupplier;
        private Label labelQuantityPerUnit;
        private Label labelUnitPrice;
        private Label labelUnitsInStock;
        private Label labelUnitsOnOrder;
        private Label labelReorderLevel;
        private Label labelDiscontinued;
        private TextBox txtProductName;
        private ComboBox cmbCategories;
        private ComboBox cmbSuppliers;
        private TextBox txtQuantityPerUnit;
        private TextBox txtUnitPrice;
        private TextBox txtUnitsInStock;
        private TextBox txtUnitsOnOrder;
        private TextBox txtReorderLevel;
        private CheckBox chkDiscontinued;
        private Button btnSave;
        private Button btnCancel;

        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            lblHeading = new Label();
            labelProductName = new Label();
            labelCategory = new Label();
            labelSupplier = new Label();
            labelQuantityPerUnit = new Label();
            labelUnitPrice = new Label();
            labelUnitsInStock = new Label();
            labelUnitsOnOrder = new Label();
            labelReorderLevel = new Label();
            labelDiscontinued = new Label();
            txtProductName = new TextBox();
            cmbCategories = new ComboBox();
            cmbSuppliers = new ComboBox();
            txtQuantityPerUnit = new TextBox();
            txtUnitPrice = new TextBox();
            txtUnitsInStock = new TextBox();
            txtUnitsOnOrder = new TextBox();
            txtReorderLevel = new TextBox();
            chkDiscontinued = new CheckBox();
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
            lblHeading.Size = new Size(272, 45);
            lblHeading.TabIndex = 1;
            lblHeading.Text = "Add/Edit Product";
            // 
            // labelProductName
            // 
            labelProductName.AutoSize = true;
            labelProductName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelProductName.Location = new Point(50, 146);
            labelProductName.Margin = new Padding(5, 0, 5, 0);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(157, 30);
            labelProductName.TabIndex = 23;
            labelProductName.Text = "Product Name:";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelCategory.Location = new Point(50, 223);
            labelCategory.Margin = new Padding(5, 0, 5, 0);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(107, 30);
            labelCategory.TabIndex = 22;
            labelCategory.Text = "Category:";
            // 
            // labelSupplier
            // 
            labelSupplier.AutoSize = true;
            labelSupplier.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelSupplier.Location = new Point(50, 300);
            labelSupplier.Margin = new Padding(5, 0, 5, 0);
            labelSupplier.Name = "labelSupplier";
            labelSupplier.Size = new Size(98, 30);
            labelSupplier.TabIndex = 21;
            labelSupplier.Text = "Supplier:";
            // 
            // labelQuantityPerUnit
            // 
            labelQuantityPerUnit.AutoSize = true;
            labelQuantityPerUnit.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelQuantityPerUnit.Location = new Point(50, 376);
            labelQuantityPerUnit.Margin = new Padding(5, 0, 5, 0);
            labelQuantityPerUnit.Name = "labelQuantityPerUnit";
            labelQuantityPerUnit.Size = new Size(184, 30);
            labelQuantityPerUnit.TabIndex = 20;
            labelQuantityPerUnit.Text = "Quantity per Unit:";
            // 
            // labelUnitPrice
            // 
            labelUnitPrice.AutoSize = true;
            labelUnitPrice.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelUnitPrice.Location = new Point(681, 146);
            labelUnitPrice.Margin = new Padding(5, 0, 5, 0);
            labelUnitPrice.Name = "labelUnitPrice";
            labelUnitPrice.Size = new Size(110, 30);
            labelUnitPrice.TabIndex = 19;
            labelUnitPrice.Text = "Unit Price:";
            // 
            // labelUnitsInStock
            // 
            labelUnitsInStock.AutoSize = true;
            labelUnitsInStock.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelUnitsInStock.Location = new Point(681, 223);
            labelUnitsInStock.Margin = new Padding(5, 0, 5, 0);
            labelUnitsInStock.Name = "labelUnitsInStock";
            labelUnitsInStock.Size = new Size(147, 30);
            labelUnitsInStock.TabIndex = 18;
            labelUnitsInStock.Text = "Units in Stock:";
            // 
            // labelUnitsOnOrder
            // 
            labelUnitsOnOrder.AutoSize = true;
            labelUnitsOnOrder.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelUnitsOnOrder.Location = new Point(681, 300);
            labelUnitsOnOrder.Margin = new Padding(5, 0, 5, 0);
            labelUnitsOnOrder.Name = "labelUnitsOnOrder";
            labelUnitsOnOrder.Size = new Size(161, 30);
            labelUnitsOnOrder.TabIndex = 17;
            labelUnitsOnOrder.Text = "Units on Order:";
            // 
            // labelReorderLevel
            // 
            labelReorderLevel.AutoSize = true;
            labelReorderLevel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelReorderLevel.Location = new Point(681, 377);
            labelReorderLevel.Margin = new Padding(5, 0, 5, 0);
            labelReorderLevel.Name = "labelReorderLevel";
            labelReorderLevel.Size = new Size(152, 30);
            labelReorderLevel.TabIndex = 16;
            labelReorderLevel.Text = "Reorder Level:";
            // 
            // labelDiscontinued
            // 
            labelDiscontinued.AutoSize = true;
            labelDiscontinued.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelDiscontinued.Location = new Point(50, 456);
            labelDiscontinued.Margin = new Padding(5, 0, 5, 0);
            labelDiscontinued.Name = "labelDiscontinued";
            labelDiscontinued.Size = new Size(143, 30);
            labelDiscontinued.TabIndex = 15;
            labelDiscontinued.Text = "Discontinued:";
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductName.Location = new Point(317, 146);
            txtProductName.Margin = new Padding(5, 6, 5, 6);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(309, 34);
            txtProductName.TabIndex = 1;
            // 
            // cmbCategories
            // 
            cmbCategories.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(317, 223);
            cmbCategories.Margin = new Padding(5, 6, 5, 6);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(309, 36);
            cmbCategories.TabIndex = 3;
            // 
            // cmbSuppliers
            // 
            cmbSuppliers.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbSuppliers.FormattingEnabled = true;
            cmbSuppliers.Location = new Point(317, 300);
            cmbSuppliers.Margin = new Padding(5, 6, 5, 6);
            cmbSuppliers.Name = "cmbSuppliers";
            cmbSuppliers.Size = new Size(309, 36);
            cmbSuppliers.TabIndex = 5;
            // 
            // txtQuantityPerUnit
            // 
            txtQuantityPerUnit.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantityPerUnit.Location = new Point(317, 376);
            txtQuantityPerUnit.Margin = new Padding(5, 6, 5, 6);
            txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            txtQuantityPerUnit.Size = new Size(309, 34);
            txtQuantityPerUnit.TabIndex = 7;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtUnitPrice.Location = new Point(948, 146);
            txtUnitPrice.Margin = new Padding(5, 6, 5, 6);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(309, 34);
            txtUnitPrice.TabIndex = 8;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtUnitsInStock.Location = new Point(948, 223);
            txtUnitsInStock.Margin = new Padding(5, 6, 5, 6);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(309, 34);
            txtUnitsInStock.TabIndex = 9;
            // 
            // txtUnitsOnOrder
            // 
            txtUnitsOnOrder.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtUnitsOnOrder.Location = new Point(948, 300);
            txtUnitsOnOrder.Margin = new Padding(5, 6, 5, 6);
            txtUnitsOnOrder.Name = "txtUnitsOnOrder";
            txtUnitsOnOrder.Size = new Size(309, 34);
            txtUnitsOnOrder.TabIndex = 10;
            // 
            // txtReorderLevel
            // 
            txtReorderLevel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtReorderLevel.Location = new Point(948, 377);
            txtReorderLevel.Margin = new Padding(5, 6, 5, 6);
            txtReorderLevel.Name = "txtReorderLevel";
            txtReorderLevel.Size = new Size(309, 34);
            txtReorderLevel.TabIndex = 11;
            // 
            // chkDiscontinued
            // 
            chkDiscontinued.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            chkDiscontinued.Location = new Point(317, 456);
            chkDiscontinued.Margin = new Padding(5, 6, 5, 6);
            chkDiscontinued.Name = "chkDiscontinued";
            chkDiscontinued.Size = new Size(301, 46);
            chkDiscontinued.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 200, 83);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(709, 541);
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
            btnCancel.Location = new Point(458, 541);
            btnCancel.Margin = new Padding(5, 6, 5, 6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(196, 56);
            btnCancel.TabIndex = 29;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddEditProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 924);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(chkDiscontinued);
            Controls.Add(txtReorderLevel);
            Controls.Add(txtUnitsOnOrder);
            Controls.Add(txtUnitsInStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtQuantityPerUnit);
            Controls.Add(labelDiscontinued);
            Controls.Add(labelReorderLevel);
            Controls.Add(labelUnitsOnOrder);
            Controls.Add(labelUnitsInStock);
            Controls.Add(labelUnitPrice);
            Controls.Add(labelQuantityPerUnit);
            Controls.Add(labelSupplier);
            Controls.Add(cmbSuppliers);
            Controls.Add(labelCategory);
            Controls.Add(cmbCategories);
            Controls.Add(txtProductName);
            Controls.Add(labelProductName);
            Controls.Add(lblHeading);
            Margin = new Padding(5, 6, 5, 6);
            Name = "AddEditProductForm";
            Text = "Add/Edit Product";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
