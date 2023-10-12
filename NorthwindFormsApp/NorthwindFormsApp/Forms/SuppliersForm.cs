using NorthwindFormsApp.Data;
using NorthwindFormsApp.Entities;
using NorthwindFormsApp.Helpers;
using System.ComponentModel;

namespace NorthwindFormsApp.Forms
{
    public partial class SuppliersForm : CommonUIElements
    {
        private NorthwindDbContext _dbContext { get; set; }
        private BindingList<Supplier> _bindingList { get; set; }

        public SuppliersForm(NorthwindDbContext dbContext)
        {
            _dbContext = dbContext;
            _bindingList = new BindingList<Supplier>();
            dataGridView.DataSource = _bindingList;
        }

        protected override string GetFormText()
        {
            return "Suppliers";
        }

        protected override void btnDeleteRow_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                var supplier = (Supplier)selectedRow.DataBoundItem;
                if (supplier != null)
                {
                    // Check if there are associated order details records
                    if (supplier.Products.Any())
                    {
                        MessageBox.Show("This row cannot be deleted because it has associated details.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Prompt the user for confirmation
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                // Remove the supplier from the database
                                _dbContext.Suppliers.Remove(supplier);
                                _dbContext.SaveChanges();

                                // Refresh the DataGridView by reloading the data
                                LoadSupplierData();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error deleting the item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        protected override void btnEdit_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                var supplier = (Supplier)selectedRow.DataBoundItem;
                LoadAddEdit(supplier);
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            LoadAddEdit(null);
        }

        private void LoadAddEdit(Supplier supplier)
        {
            panelContent.Controls.Clear();

            var addEditForm = new AddEditSupplierForm(_dbContext, supplier, panelContent);
            addEditForm.TopLevel = false;
            addEditForm.FormBorderStyle = FormBorderStyle.None;
            addEditForm.Dock = DockStyle.Fill;

            panelContent.Controls.Add(addEditForm);

            addEditForm.Show();
        }

        protected override void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                dataGridView.DataSource = _bindingList;
                return;
            }

            // Use LINQ to filter the list based on the search term
            var filteredSuppliers = _bindingList.Where(supplier =>
                (supplier.CompanyName ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (supplier.ContactName ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (supplier.ContactTitle ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (supplier.Address ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (supplier.City ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (supplier.Region ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (supplier.PostalCode ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (supplier.Country ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (supplier.Phone ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (supplier.Fax ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (supplier.HomePage ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase)
            ).ToList();

            dataGridView.DataSource = new BindingList<Supplier>(filteredSuppliers);
        }

        protected override void CommonUIElements_Load(object sender, EventArgs e)
        {
            var mainPanelContent = ((MainForm)Application.OpenForms["MainForm"]).GetPanelContent();
            panelContent.Size = new Size(mainPanelContent.Width, mainPanelContent.Height);
            dataGridView.Size = new Size((mainPanelContent.Width - 65), 568);
            ClientSize = new Size(mainPanelContent.Width, mainPanelContent.Height);

            base.CommonUIElements_Load(sender, e);

            LoadSupplierData();

            dataGridView.Columns["SupplierID"].Visible = false;
            dataGridView.Columns["Products"].Visible = false;
        }

        private void LoadSupplierData()
        {
            // Load all suppliers from the database
            var suppliers = _dbContext.Suppliers.ToList();

            // Clear the BindingList and add the suppliers
            _bindingList.Clear();

            foreach (var supplier in suppliers)
            {
                _bindingList.Add(supplier);
            }
        }
    }
}
