using NorthwindFormsApp.Data;
using NorthwindFormsApp.Entities;
using NorthwindFormsApp.Helpers;
using System.ComponentModel;
using System.Data;

namespace NorthwindFormsApp.Forms
{
    public partial class ProductsForm : CommonUIElements
    {
        private NorthwindDbContext _dbContext { get; set; }
        private BindingList<Product> _bindingList { get; set; }

        public ProductsForm(NorthwindDbContext dbContext)
        {
            _dbContext = dbContext;
            _bindingList = new BindingList<Product>();
            dataGridView.DataSource = _bindingList;
        }

        protected override string GetFormText()
        {
            return "Products";
        }

        protected override void btnDeleteRow_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                var product = (Product)selectedRow.DataBoundItem;
                if(product != null)
                {
                    // Check if there are associated order details records
                    if (product.OrderDetails.Any())
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
                                // Remove the product from the database
                                _dbContext.Products.Remove(product);
                                _dbContext.SaveChanges();

                                // Refresh the DataGridView by reloading the data
                                LoadProductData();
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

                var product = (Product)selectedRow.DataBoundItem;
                LoadAddEdit(product);
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

        private void LoadAddEdit(Product product)
        {
            panelContent.Controls.Clear();

            var addEditForm = new AddEditProductForm(_dbContext, product, panelContent);
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
            var filteredProducts = _bindingList.Where(product =>
                (product.ProductName ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (product.QuantityPerUnit ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (product.UnitPrice?.ToString() ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (product.UnitsInStock?.ToString() ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (product.UnitsOnOrder?.ToString() ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (product.ReorderLevel?.ToString() ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (product.Discontinued ? "true" : "false").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (product.CategoryName ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (product.SupplierName ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase)
            ).ToList();

            dataGridView.DataSource = new BindingList<Product>(filteredProducts);
        }

        protected override void CommonUIElements_Load(object sender, EventArgs e)
        {
            var mainPanelContent = ((MainForm)Application.OpenForms["MainForm"]).GetPanelContent();
            panelContent.Size = new Size(mainPanelContent.Width, mainPanelContent.Height);
            dataGridView.Size = new Size((mainPanelContent.Width - 65), 568);
            ClientSize = new Size(mainPanelContent.Width, mainPanelContent.Height);

            base.CommonUIElements_Load(sender, e);

            LoadProductData();

            dataGridView.Columns["ProductID"].Visible = false;
            dataGridView.Columns["SupplierID"].Visible = false;
            dataGridView.Columns["CategoryID"].Visible = false;
            dataGridView.Columns["Supplier"].Visible = false;
            dataGridView.Columns["Category"].Visible = false;
            dataGridView.Columns["OrderDetails"].Visible = false;
        }

        private void LoadProductData()
        {
            // Load all products from the database
            var products = _dbContext.Products.ToList();

            // Clear the BindingList and add the products
            _bindingList.Clear();

            foreach (var product in products)
            {
                _bindingList.Add(product);
            }
        }
    }
}