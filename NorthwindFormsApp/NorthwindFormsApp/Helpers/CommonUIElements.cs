using NorthwindFormsApp.Forms;

namespace NorthwindFormsApp.Helpers
{
    public class CommonUIElements : Form
    {
        protected Panel panelContent;
        protected Button btnDelete;
        protected Button btnEdit;
        protected Button btnAdd;
        protected Button btnSearch;
        protected TextBox txtSearch;
        protected Label lblHeading;
        protected DataGridView dataGridView;
        protected System.Windows.Forms.Timer timer1;

        public CommonUIElements()
        {
            InitializeComponent();
        }

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

        /// <summary>
        /// Required method for Designer
        /// the contents of this method with the code editor.
        /// </summary>
        protected void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelContent = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblHeading = new Label();
            dataGridView = new DataGridView();
            timer1 = new System.Windows.Forms.Timer(components);
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(btnDelete);
            panelContent.Controls.Add(btnEdit);
            panelContent.Controls.Add(btnAdd);
            panelContent.Controls.Add(btnSearch);
            panelContent.Controls.Add(txtSearch);
            panelContent.Controls.Add(lblHeading);
            panelContent.Controls.Add(dataGridView);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 0);
            panelContent.Margin = new Padding(5, 6, 5, 6);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1360, 940);
            panelContent.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(768, 127);
            btnDelete.Margin = new Padding(5, 6, 5, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(133, 58);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDeleteRow_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(255, 193, 7);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(610, 127);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(133, 58);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(46, 204, 113);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(454, 127);
            btnAdd.Margin = new Padding(5, 6, 5, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(133, 58);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(52, 152, 219);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1193, 36);
            btnSearch.Margin = new Padding(5, 6, 5, 6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(133, 58);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.BackColor = Color.White;
            txtSearch.Location = new Point(908, 37);
            btnSearch.Margin = new Padding(5, 6, 5, 6);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(415, 57);
            txtSearch.TabIndex = 3;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeading.ForeColor = Color.FromArgb(52, 73, 94);
            lblHeading.Location = new Point(33, 37);
            lblHeading.Margin = new Padding(5, 0, 5, 0);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(149, 45);
            lblHeading.TabIndex = 1;
            lblHeading.Text = GetFormText();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(33, 217);
            dataGridView.Margin = new Padding(5, 6, 5, 6);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(1295, 568);
            dataGridView.TabIndex = 0;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 924);
            Controls.Add(panelContent);
            Margin = new Padding(5, 6, 5, 6);
            Name = $"{GetFormText()}Form";
            Text = $"{GetFormText()}Form";
            Load += CommonUIElements_Load;
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        // You can override this method in derived classes to set the form-specific heading text
        protected virtual string GetFormText()
        {
            return "FormName";
        }

        protected virtual void btnDeleteRow_Click(object sender, EventArgs e)
        {
            // Common delete logic
        }

        protected virtual void btnEdit_Click(object sender, EventArgs e)
        {
            // Common edit logic
        }

        protected virtual void btnAdd_Click(object sender, EventArgs e)
        {
            // Common add logic
        }

        protected virtual void btnSearch_Click(object sender, EventArgs e)
        {
            // Common search logic
        }

        protected virtual void CommonUIElements_Load(object sender, EventArgs e)
        {
            // Calculate the horizontal position for the buttons to be centered
            int buttonWidth = 133; // Set your desired button width
            int spacing = 20; // Adjust the spacing between buttons
            int totalButtonWidth = 3 * buttonWidth + 2 * spacing;
            int horizontalPosition = (panelContent.Width - totalButtonWidth) / 2;

            // Modify the button locations based on the calculated horizontal position
            btnDelete.Location = new Point(horizontalPosition, 127);
            btnEdit.Location = new Point(horizontalPosition + buttonWidth + spacing, 127);
            btnAdd.Location = new Point(horizontalPosition + 2 * (buttonWidth + spacing), 127);

            // Calculate the horizontal position for the button to be right-aligned with the end of the DataGridView
            btnSearch.Location = new Point(dataGridView.Location.X + dataGridView.Width - (btnSearch.Width - 10) - spacing, 36);
            txtSearch.Location = new Point(dataGridView.Location.X + dataGridView.Width - txtSearch.Width - 140, 36);

            //Set DataGridView common properties
            dataGridView.ReadOnly = true;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView.Font, FontStyle.Bold);
            dataGridView.DefaultCellStyle.BackColor = Color.LightGray;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
        }
    }
}