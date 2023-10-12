using NorthwindFormsApp.Data;
using NorthwindFormsApp.Entities;
using NorthwindFormsApp.Helpers;
using System.ComponentModel;

namespace NorthwindFormsApp.Forms
{
    public partial class OrdersForm : CommonUIElements
    {
        private NorthwindDbContext _dbContext { get; set; }
        private BindingList<Order> _bindingList { get; set; }

        public OrdersForm(NorthwindDbContext dbContext)
        {
            _dbContext = dbContext;
            _bindingList = new BindingList<Order>();
            dataGridView.DataSource = _bindingList;
        }

        protected override string GetFormText()
        {
            return "Orders";
        }

        protected override void btnDeleteRow_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                var order = (Order)selectedRow.DataBoundItem;
                if (order != null)
                {
                    // Check if there are associated order details records
                    if (order.OrderDetails.Any())
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
                                // Remove the order from the database
                                _dbContext.Orders.Remove(order);
                                _dbContext.SaveChanges();

                                // Refresh the DataGridView by reloading the data
                                LoadOrderData();
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

                var order = (Order)selectedRow.DataBoundItem;
                LoadAddEdit(order);
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

        private void LoadAddEdit(Order order)
        {
            panelContent.Controls.Clear();

            var addEditForm = new AddEditOrderForm(_dbContext, order, panelContent);
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
            var filteredOrders = _bindingList.Where(order =>
                (order.OrderDate?.ToString() ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (order.RequiredDate?.ToString() ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (order.ShippedDate?.ToString() ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (order.ShipVia?.ToString() ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (order.Freight?.ToString() ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (order.ShipName ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (order.ShipAddress ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (order.ShipCity ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (order.ShipRegion ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (order.ShipPostalCode ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (order.ShipCountry ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (order.ContactName ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (order.EmployeeName ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase)
            ).ToList();

            dataGridView.DataSource = new BindingList<Order>(filteredOrders);
        }

        protected override void CommonUIElements_Load(object sender, EventArgs e)
        {
            var mainPanelContent = ((MainForm)Application.OpenForms["MainForm"]).GetPanelContent();
            panelContent.Size = new Size(mainPanelContent.Width, mainPanelContent.Height);
            dataGridView.Size = new Size((mainPanelContent.Width - 65), 568);
            ClientSize = new Size(mainPanelContent.Width, mainPanelContent.Height);

            base.CommonUIElements_Load(sender, e);

            LoadOrderData();

            dataGridView.Columns["OrderID"].Visible = false;
            dataGridView.Columns["CustomerID"].Visible = false;
            dataGridView.Columns["EmployeeID"].Visible = false;
            dataGridView.Columns["Customer"].Visible = false;
            dataGridView.Columns["Employee"].Visible = false;
            dataGridView.Columns["OrderDetails"].Visible = false;
        }

        private void LoadOrderData()
        {
            // Load all orders from the database
            var orders = _dbContext.Orders.ToList();

            // Clear the BindingList and add the orders
            _bindingList.Clear();

            foreach (var order in orders)
            {
                _bindingList.Add(order);
            }
        }
    }
}
