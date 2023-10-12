using NorthwindFormsApp.Data;
using NorthwindFormsApp.Entities;
using NorthwindFormsApp.Helpers;

namespace NorthwindFormsApp.Forms
{
    public partial class AddEditCustomerForm : Form
    {
        private NorthwindDbContext _dbContext { get; set; }
        private Customer? _customer { get; set; }
        private Panel _panelContent { get; set; }
        private SharedFormLogic _sharedFormLogic { get; set; }

        public AddEditCustomerForm(NorthwindDbContext dbContext, Customer? customer, Panel panelContent)
        {
            _dbContext = dbContext;
            _customer = customer;
            _panelContent = panelContent;
            _sharedFormLogic = new SharedFormLogic(dbContext);

            InitializeComponent();

            if (_customer != null)
            {
                // Edit mode - populate the form with the customer's data
                Text = "Edit Customer";
                lblHeading.Text = "Edit Customer";

                // Populate customer data into the form controls
                txtCompanyName.Text = _customer.CompanyName;
                txtContactName.Text = _customer.ContactName;
                txtContactTitle.Text = _customer.ContactTitle;
                txtAddress.Text = _customer.Address;
                txtCity.Text = _customer.City;
                txtRegion.Text = _customer.Region;
                txtPostalCode.Text = _customer.PostalCode;
                txtCountry.Text = _customer.Country;
                txtPhone.Text = _customer.Phone;
                txtFax.Text = _customer.Fax;
            }
            else
            {
                // Add mode
                Text = "Add Customer";
                lblHeading.Text = "Add Customer";
            }
        }

        // Handle Save button click event to save or update the customer
        private void btnSave_Click(object sender, EventArgs e)
        {
            string companyName = txtCompanyName.Text;
            string contactName = txtContactName.Text;
            string contactTitle = txtContactTitle.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string region = txtRegion.Text;
            string postalCode = txtPostalCode.Text;
            string country = txtCountry.Text;
            string phone = txtPhone.Text;
            string fax = txtFax.Text;

            if (string.IsNullOrWhiteSpace(companyName))
            {
                MessageBox.Show("Please enter a valid Company Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (_customer == null)
                {
                    _customer = new Customer
                    {
                        CompanyName = companyName,
                        ContactName = contactName,
                        ContactTitle = contactTitle,
                        Address = address,
                        City = city,
                        Region = region,
                        PostalCode = postalCode,
                        Country = country,
                        Phone = phone,
                        Fax = fax
                    };

                    _dbContext.Customers.Add(_customer);
                }
                else
                {
                    _customer.CompanyName = companyName;
                    _customer.ContactName = contactName;
                    _customer.ContactTitle = contactTitle;
                    _customer.Address = address;
                    _customer.City = city;
                    _customer.Region = region;
                    _customer.PostalCode = postalCode;
                    _customer.Country = country;
                    _customer.Phone = phone;
                    _customer.Fax = fax;
                }

                _dbContext.SaveChanges();

                _sharedFormLogic.LoadForm<CustomersForm>(_panelContent);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _sharedFormLogic.LoadForm<CustomersForm>(_panelContent);
        }
    }
}
