using NorthwindFormsApp.Data;
using NorthwindFormsApp.Entities;
using NorthwindFormsApp.Helpers;
using System.ComponentModel;

namespace NorthwindFormsApp.Forms
{
    public partial class CustomersForm : CommonUIElements
    {
        private NorthwindDbContext _dbContext { get; set; }
        private BindingList<Customer> _bindingList { get; set; }

        public CustomersForm(NorthwindDbContext dbContext)
        {
            _dbContext = dbContext;
            _bindingList = new BindingList<Customer>();
            dataGridView.DataSource = _bindingList;
        }

        protected override string GetFormText()
        {
            return "Customers";
        }

        protected override void btnDeleteRow_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                var customer = (Customer)selectedRow.DataBoundItem;
                if (customer != null)
                {
                    // Check if there are associated order details records
                    if (customer.Orders.Any())
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
                                // Remove the customer from the database
                                _dbContext.Customers.Remove(customer);
                                _dbContext.SaveChanges();

                                // Refresh the DataGridView by reloading the data
                                LoadCustomerData();
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

                var customer = (Customer)selectedRow.DataBoundItem;
                LoadAddEdit(customer);
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

        private void LoadAddEdit(Customer customer)
        {
            panelContent.Controls.Clear();

            var addEditForm = new AddEditCustomerForm(_dbContext, customer, panelContent);
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
            var filteredCustomers = _bindingList.Where(customer =>
                (customer.CompanyName ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (customer.ContactName ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (customer.ContactTitle ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (customer.Address ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (customer.City ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (customer.Region ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (customer.PostalCode ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (customer.Country ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (customer.Phone ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (customer.Fax ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase)
            ).ToList();

            dataGridView.DataSource = new BindingList<Customer>(filteredCustomers);
        }

        protected override void CommonUIElements_Load(object sender, EventArgs e)
        {
            var mainPanelContent = ((MainForm)Application.OpenForms["MainForm"]).GetPanelContent();
            panelContent.Size = new Size(mainPanelContent.Width, mainPanelContent.Height);
            dataGridView.Size = new Size((mainPanelContent.Width - 65), 568);
            ClientSize = new Size(mainPanelContent.Width, mainPanelContent.Height);

            base.CommonUIElements_Load(sender, e);

            LoadCustomerData();

            dataGridView.Columns["CustomerID"].Visible = false;
            dataGridView.Columns["Orders"].Visible = false;
        }

        private void LoadCustomerData()
        {
            // Load all customers from the database
            var customers = _dbContext.Customers.ToList();

            // Clear the BindingList and add the customers
            _bindingList.Clear();

            foreach (var customer in customers)
            {
                _bindingList.Add(customer);
            }
        }
    }
}