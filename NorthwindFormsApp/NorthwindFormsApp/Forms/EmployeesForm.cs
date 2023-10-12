using NorthwindFormsApp.Data;
using NorthwindFormsApp.Entities;
using NorthwindFormsApp.Helpers;
using System.ComponentModel;

namespace NorthwindFormsApp.Forms
{
    public partial class EmployeesForm : CommonUIElements
    {
        private NorthwindDbContext _dbContext { get; set; }
        private BindingList<Employee> _bindingList { get; set; }

        public EmployeesForm(NorthwindDbContext dbContext)
        {
            _dbContext = dbContext;
            _bindingList = new BindingList<Employee>();
            dataGridView.DataSource = _bindingList;
        }

        protected override string GetFormText()
        {
            return "Employees";
        }

        protected override void btnDeleteRow_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                var employee = (Employee)selectedRow.DataBoundItem;
                if (employee != null)
                {
                    // Check if there are associated order details records
                    if (employee.Orders.Any())
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
                                // Remove the employee from the database
                                _dbContext.Employees.Remove(employee);
                                _dbContext.SaveChanges();

                                // Refresh the DataGridView by reloading the data
                                LoadEmployeeData();
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

                var employee = (Employee)selectedRow.DataBoundItem;
                LoadAddEdit(employee);
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

        private void LoadAddEdit(Employee employee)
        {
            panelContent.Controls.Clear();

            var addEditForm = new AddEditEmployeeForm(_dbContext, employee, panelContent);
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
            var filteredEmployees = _bindingList.Where(employee =>
                (employee.LastName ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (employee.FirstName ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (employee.Title ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (employee.TitleOfCourtesy ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (employee.BirthDate?.ToString() ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (employee.HireDate?.ToString() ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (employee.Address ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (employee.City ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (employee.Region ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (employee.PostalCode ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (employee.Country ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (employee.HomePhone ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (employee.Extension ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (employee.Notes ?? "").Contains(searchTerm, StringComparison.OrdinalIgnoreCase)
            ).ToList();

            dataGridView.DataSource = new BindingList<Employee>(filteredEmployees);
        }

        protected override void CommonUIElements_Load(object sender, EventArgs e)
        {
            var mainPanelContent = ((MainForm)Application.OpenForms["MainForm"]).GetPanelContent();
            panelContent.Size = new Size(mainPanelContent.Width, mainPanelContent.Height);
            dataGridView.Size = new Size((mainPanelContent.Width - 65), 568);
            ClientSize = new Size(mainPanelContent.Width, mainPanelContent.Height);

            base.CommonUIElements_Load(sender, e);

            LoadEmployeeData();

            dataGridView.Columns["EmployeeID"].Visible = false;
            dataGridView.Columns["ReportsTo"].Visible = false;
            dataGridView.Columns["PhotoPath"].Visible = false;
            dataGridView.Columns["Orders"].Visible = false;
        }

        private void LoadEmployeeData()
        {
            // Load all employee from the database
            var employees = _dbContext.Employees.ToList();

            // Clear the BindingList and add the employees
            _bindingList.Clear();

            foreach (var employee in employees)
            {
                _bindingList.Add(employee);
            }
        }
    }
}
