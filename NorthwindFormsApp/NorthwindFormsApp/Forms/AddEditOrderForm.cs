using System;
using System.Windows.Forms;
using NorthwindFormsApp.Data;
using NorthwindFormsApp.Entities;
using NorthwindFormsApp.Helpers;

namespace NorthwindFormsApp.Forms
{
    public partial class AddEditOrderForm : Form
    {
        private NorthwindDbContext _dbContext { get; set; }
        private Order? _order { get; set; }
        private Panel _panelContent { get; set; }
        private SharedFormLogic _sharedFormLogic { get; set; }

        public AddEditOrderForm(NorthwindDbContext dbContext, Order? order, Panel panelContent)
        {
            _dbContext = dbContext;
            _order = order;
            _panelContent = panelContent;
            _sharedFormLogic = new SharedFormLogic(dbContext);

            InitializeComponent();

            // Load Customers and Employees into the ComboBoxes
            LoadCustomers();
            LoadEmployees();

            if (_order != null)
            {
                // Edit mode - populate the form with the order's data
                Text = "Edit Order";
                lblHeading.Text = "Edit Order";

                // Populate order data into the form controls
                txtOrderDate.Text = _order.OrderDate?.ToShortDateString();
                txtRequiredDate.Text = _order.RequiredDate?.ToShortDateString();
                txtShippedDate.Text = _order.ShippedDate?.ToShortDateString();
                txtShipVia.Text = _order.ShipVia?.ToString();
                txtFreight.Text = _order.Freight?.ToString();
                txtShipName.Text = _order.ShipName;
                txtShipAddress.Text = _order.ShipAddress;
                txtShipCity.Text = _order.ShipCity;
                txtShipRegion.Text = _order.ShipRegion;
                txtShipPostalCode.Text = _order.ShipPostalCode;
                txtShipCountry.Text = _order.ShipCountry;
            }
            else
            {
                // Add mode
                Text = "Add Order";
                lblHeading.Text = "Add Order";
            }
        }

        private void LoadCustomers()
        {
            // Load category data from your data source and bind to the ComboBox
            cmbCustomers.DataSource = _dbContext.Customers.ToList();
            cmbCustomers.DisplayMember = "ContactName";
            cmbCustomers.ValueMember = "CustomerID";
        }

        private void LoadEmployees()
        {
            // Load supplier data from your data source and bind to the ComboBox
            cmbEmployees.DataSource = _dbContext.Employees.ToList();
            cmbEmployees.DisplayMember = "EmployeeName";
            cmbEmployees.ValueMember = "EmployeeID";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Retrieve values from the form's controls
            DateTime? orderDate = DateTime.TryParse(txtOrderDate.Text, out var date) ? date : (DateTime?)null;
            DateTime? requiredDate = DateTime.TryParse(txtRequiredDate.Text, out date) ? date : (DateTime?)null;
            DateTime? shippedDate = DateTime.TryParse(txtShippedDate.Text, out date) ? date : (DateTime?)null;

            if (decimal.TryParse(txtFreight.Text, out decimal freight) &&
                int.TryParse(txtShipVia.Text, out int shipVia))
            {
                string shipName = txtShipName.Text;
                string shipAddress = txtShipAddress.Text;
                string shipCity = txtShipCity.Text;
                string shipRegion = txtShipRegion.Text;
                string shipPostalCode = txtShipPostalCode.Text;
                string shipCountry = txtShipCountry.Text;

                // Retrieve selected customer and employee values
                string customerID = cmbCustomers.SelectedValue?.ToString() ?? string.Empty;
                int? employeeID = (int?)cmbEmployees.SelectedValue;

                // Create or update the order
                if (_order == null)
                {
                    _order = new Order
                    {
                        OrderDate = orderDate,
                        RequiredDate = requiredDate,
                        ShippedDate = shippedDate,
                        ShipVia = shipVia,
                        Freight = freight,
                        ShipName = shipName,
                        ShipAddress = shipAddress,
                        ShipCity = shipCity,
                        ShipRegion = shipRegion,
                        ShipPostalCode = shipPostalCode,
                        ShipCountry = shipCountry,
                        CustomerID = customerID,
                        EmployeeID = employeeID
                    };

                    _dbContext.Orders.Add(_order);
                }
                else
                {
                    _order.OrderDate = orderDate;
                    _order.RequiredDate = requiredDate;
                    _order.ShippedDate = shippedDate;
                    _order.ShipVia = shipVia;
                    _order.Freight = freight;
                    _order.ShipName = shipName;
                    _order.ShipAddress = shipAddress;
                    _order.ShipCity = shipCity;
                    _order.ShipRegion = shipRegion;
                    _order.ShipPostalCode = shipPostalCode;
                    _order.ShipCountry = shipCountry;
                    _order.CustomerID = customerID;
                    _order.EmployeeID = employeeID;
                }

                _dbContext.SaveChanges();
                _sharedFormLogic.LoadForm<OrdersForm>(_panelContent);
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values for Freight and Ship Via.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _sharedFormLogic.LoadForm<OrdersForm>(_panelContent);
        }
    }
}
