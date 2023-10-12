using NorthwindFormsApp.Data;
using NorthwindFormsApp.Entities;
using NorthwindFormsApp.Helpers;

namespace NorthwindFormsApp.Forms
{
    public partial class AddEditEmployeeForm : Form
    {
        private NorthwindDbContext _dbContext { get; set; }
        private Employee? _employee { get; set; }
        private Panel _panelContent { get; set; }
        private SharedFormLogic _sharedFormLogic { get; set; }

        public AddEditEmployeeForm(NorthwindDbContext dbContext, Employee? employee, Panel panelContent)
        {
            _dbContext = dbContext;
            _employee = employee;
            _panelContent = panelContent;
            _sharedFormLogic = new SharedFormLogic(dbContext);

            InitializeComponent();

            if (_employee != null)
            {
                // Edit mode - populate the form with the employee's data
                Text = "Edit Employee";
                lblHeading.Text = "Edit Employee";

                txtFirstName.Text = _employee.FirstName;
                txtLastName.Text = _employee.LastName;

                if (_employee.BirthDate.HasValue)
                {
                    dtBirthDate.Value = _employee.BirthDate.Value;
                }
                else
                {
                    dtBirthDate.Value = DateTime.Now;
                }

                txtTitle.Text = _employee.Title;
                txtAddress.Text = _employee.Address;
                txtCity.Text = _employee.City;
                txtRegion.Text = _employee.Region;
                txtPostalCode.Text = _employee.PostalCode;
                txtCountry.Text = _employee.Country;
                txtHomePhone.Text = _employee.HomePhone;
                txtExtension.Text = _employee.Extension;
            }
            else
            {
                // Add mode
                Text = "Add Employee";
                lblHeading.Text = "Add Employee";
            }
        }

        // Handle Save button click event to save or update the employee
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Retrieve values from the form's controls
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            DateTime birthDate = dtBirthDate.Value;
            string title = txtTitle.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string region = txtRegion.Text;
            string postalCode = txtPostalCode.Text;
            string country = txtCountry.Text;
            string homePhone = txtHomePhone.Text;
            string extension = txtExtension.Text;

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Please enter valid first and last names.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Create or update the employee
                if (_employee == null)
                {
                    _employee = new Employee
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        BirthDate = birthDate,
                        Title = title,
                        Address = address,
                        City = city,
                        Region = region,
                        PostalCode = postalCode,
                        Country = country,
                        HomePhone = homePhone,
                        Extension = extension
                    };

                    _dbContext.Employees.Add(_employee);
                }
                else
                {
                    _employee.FirstName = firstName;
                    _employee.LastName = lastName;
                    _employee.BirthDate = birthDate;
                    _employee.Title = title;
                    _employee.Address = address;
                    _employee.City = city;
                    _employee.Region = region;
                    _employee.PostalCode = postalCode;
                    _employee.Country = country;
                    _employee.HomePhone = homePhone;
                    _employee.Extension = extension;
                }

                _dbContext.SaveChanges();

                _sharedFormLogic.LoadForm<EmployeesForm>(_panelContent);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _sharedFormLogic.LoadForm<EmployeesForm>(_panelContent);
        }
    }
}
