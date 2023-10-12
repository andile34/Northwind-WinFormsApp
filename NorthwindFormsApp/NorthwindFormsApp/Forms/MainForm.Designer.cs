namespace NorthwindFormsApp.Forms
{
    partial class MainForm
    {
        private Panel panelSidebar;
        private Button btnExit;
        private Button btnDashboard;
        private Button btnEmployees;
        private Button btnSuppliers;
        private Button btnOrders;
        private Button btnCustomers;
        private Button btnProducts;
        private PictureBox pictureBoxLogo;
        private Panel panelHeader;
        private Label labelTitle;
        internal Panel panelContent;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timer1;

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelSidebar = new Panel();
            btnExit = new Button();
            btnDashboard = new Button();
            pictureBoxLogo = new PictureBox();
            btnEmployees = new Button();
            btnSuppliers = new Button();
            btnOrders = new Button();
            btnCustomers = new Button();
            btnProducts = new Button();
            panelHeader = new Panel();
            labelTitle = new Label();
            panelContent = new Panel();
            statusStrip = new StatusStrip();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelHeader.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(40, 60, 100);
            panelSidebar.Controls.Add(btnExit);
            panelSidebar.Controls.Add(btnDashboard);
            panelSidebar.Controls.Add(pictureBoxLogo);
            panelSidebar.Controls.Add(btnEmployees);
            panelSidebar.Controls.Add(btnSuppliers);
            panelSidebar.Controls.Add(btnOrders);
            panelSidebar.Controls.Add(btnCustomers);
            panelSidebar.Controls.Add(btnProducts);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(307, 1050);
            panelSidebar.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(0, 807);
            btnExit.Margin = new Padding(0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(307, 96);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += exitToolStripMenuItem_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.AutoSize = true;
            btnDashboard.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(58, 42);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(189, 55);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.Click += MainForm_Load;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Location = new Point(40, 33);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(226, 75);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // btnEmployees
            // 
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmployees.ForeColor = Color.White;
            btnEmployees.Location = new Point(0, 692);
            btnEmployees.Margin = new Padding(0);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(307, 96);
            btnEmployees.TabIndex = 5;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = true;
            btnEmployees.Click += employeesToolStripMenuItem_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.FlatAppearance.BorderSize = 0;
            btnSuppliers.FlatStyle = FlatStyle.Flat;
            btnSuppliers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSuppliers.ForeColor = Color.White;
            btnSuppliers.Location = new Point(0, 577);
            btnSuppliers.Margin = new Padding(0);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(307, 96);
            btnSuppliers.TabIndex = 4;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += suppliersToolStripMenuItem_Click;
            // 
            // btnOrders
            // 
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrders.ForeColor = Color.White;
            btnOrders.Location = new Point(0, 462);
            btnOrders.Margin = new Padding(0);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(307, 96);
            btnOrders.TabIndex = 3;
            btnOrders.Text = "Orders";
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += ordersToolStripMenuItem_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Location = new Point(0, 346);
            btnCustomers.Margin = new Padding(0);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(307, 96);
            btnCustomers.TabIndex = 2;
            btnCustomers.Text = "Customers";
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += customersToolStripMenuItem_Click;
            // 
            // btnProducts
            // 
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(0, 231);
            btnProducts.Margin = new Padding(0);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(307, 96);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += productsToolStripMenuItem_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(50, 80, 130);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(307, 0);
            panelHeader.Margin = new Padding(0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1360, 126);
            panelHeader.TabIndex = 1;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(31, 35);
            labelTitle.Margin = new Padding(0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(521, 60);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Northwind Management";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(307, 126);
            panelContent.Margin = new Padding(0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1360, 924);
            panelContent.TabIndex = 2;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel2, toolStripStatusLabel3 });
            statusStrip.Location = new Point(307, 1018);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(2, 0, 23, 0);
            statusStrip.Size = new Size(1360, 32);
            statusStrip.TabIndex = 3;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(1285, 25);
            toolStripStatusLabel2.Spring = true;
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(50, 25);
            toolStripStatusLabel3.Text = "Time";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1667, 1050);
            Controls.Add(statusStrip);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Controls.Add(panelSidebar);
            Margin = new Padding(0);
            Name = "MainForm";
            Text = "Northwind Management System";
            Load += MainForm_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}