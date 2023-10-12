using NorthwindFormsApp.Data;
using NorthwindFormsApp.Entities;
using NorthwindFormsApp.Helpers;

namespace NorthwindFormsApp.Forms
{
    public partial class AddEditSupplierForm : Form
    {
        private NorthwindDbContext _dbContext { get; set; }
        private Supplier? _supplier { get; set; }
        private Panel _panelContent { get; set; }
        private SharedFormLogic _sharedFormLogic { get; set; }

        public AddEditSupplierForm(NorthwindDbContext dbContext, Supplier? supplier, Panel panelContent)
        {
            _dbContext = dbContext;
            _supplier = supplier;
            _panelContent = panelContent;
            _sharedFormLogic = new SharedFormLogic(dbContext);

            InitializeComponent();

            if (_supplier != null)
            {
                // Edit mode - populate the form with the supplier's data
                Text = "Edit Supplier";
                lblHeading.Text = "Edit Supplier";

                txtCompanyName.Text = _supplier.CompanyName;
                txtContactName.Text = _supplier.ContactName;
                txtContactTitle.Text = _supplier.ContactTitle;
                txtAddress.Text = _supplier.Address;
                txtCity.Text = _supplier.City;
                txtRegion.Text = _supplier.Region;
                txtPostalCode.Text = _supplier.PostalCode;
                txtCountry.Text = _supplier.Country;
                txtPhone.Text = _supplier.Phone;
                txtFax.Text = _supplier.Fax;
                txtHomePage.Text = _supplier.HomePage;
            }
            else
            {
                // Add mode
                Text = "Add Supplier";
                lblHeading.Text = "Add Supplier";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Retrieve values from the form's controls
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
            string homePage = txtHomePage.Text;

            if (string.IsNullOrWhiteSpace(companyName))
            {
                MessageBox.Show("Please enter a valid Company Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Create or update the supplier
                if (_supplier == null)
                {
                    _supplier = new Supplier
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
                        Fax = fax,
                        HomePage = homePage
                    };

                    _dbContext.Suppliers.Add(_supplier);
                }
                else
                {
                    _supplier.CompanyName = companyName;
                    _supplier.ContactName = contactName;
                    _supplier.ContactTitle = contactTitle;
                    _supplier.Address = address;
                    _supplier.City = city;
                    _supplier.Region = region;
                    _supplier.PostalCode = postalCode;
                    _supplier.Country = country;
                    _supplier.Phone = phone;
                    _supplier.Fax = fax;
                    _supplier.HomePage = homePage;
                }

                _dbContext.SaveChanges();

                _sharedFormLogic.LoadForm<SuppliersForm>(_panelContent);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _sharedFormLogic.LoadForm<SuppliersForm>(_panelContent);
        }
    }
}
