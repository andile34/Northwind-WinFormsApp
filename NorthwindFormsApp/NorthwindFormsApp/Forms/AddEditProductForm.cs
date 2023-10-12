using NorthwindFormsApp.Data;
using NorthwindFormsApp.Entities;
using NorthwindFormsApp.Helpers;

namespace NorthwindFormsApp.Forms
{
    public partial class AddEditProductForm : Form
    {
        private NorthwindDbContext _dbContext { get; set; }
        private Product? _product { get; set; }
        private Panel _panelContent { get; set; }
        private SharedFormLogic _sharedFormLogic { get; set; }

        public AddEditProductForm(NorthwindDbContext dbContext, Product? product, Panel panelContent)
        {
            _dbContext = dbContext;
            _product = product;
            _panelContent = panelContent;
            _sharedFormLogic = new SharedFormLogic(dbContext);

            InitializeComponent();

            // Load Categories and Suppliers into the ComboBoxes
            LoadCategories();
            LoadSuppliers();

            if (_product != null)
            {
                // Edit mode - populate the form with the product's data
                Text = "Edit Product";
                lblHeading.Text = "Edit Product";

                txtProductName.Text = _product.ProductName;
                cmbCategories.SelectedValue = _product.CategoryID;
                cmbSuppliers.SelectedValue = _product.SupplierID;
                txtQuantityPerUnit.Text = _product.QuantityPerUnit;
                txtUnitPrice.Text = _product.UnitPrice?.ToString();
                txtUnitsInStock.Text = _product.UnitsInStock?.ToString();
                txtUnitsOnOrder.Text = _product.UnitsOnOrder?.ToString();
                txtReorderLevel.Text = _product.ReorderLevel?.ToString();
                chkDiscontinued.Checked = _product.Discontinued;
            }
            else
            {
                // Add mode
                Text = "Add Product";
                lblHeading.Text = "Add Product";
            }
        }

        private void LoadCategories()
        {
            // Load category data from your data source and bind to the ComboBox
            cmbCategories.DataSource = _dbContext.Categories.ToList();
            cmbCategories.DisplayMember = "CategoryName";
            cmbCategories.ValueMember = "CategoryID";
        }

        private void LoadSuppliers()
        {
            // Load supplier data from your data source and bind to the ComboBox
            cmbSuppliers.DataSource = _dbContext.Suppliers.ToList();
            cmbSuppliers.DisplayMember = "CompanyName";
            cmbSuppliers.ValueMember = "SupplierID";
        }

        // Handle Save button click event to save or update the product
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Retrieve values from the form's controls
            string productName = txtProductName.Text;
            int? categoryID = (int?)cmbCategories.SelectedValue;
            int? supplierID = (int?)cmbSuppliers.SelectedValue;
            string quantityPerUnit = txtQuantityPerUnit.Text;

            if (string.IsNullOrWhiteSpace(productName))
            {
                MessageBox.Show("Please enter a valid Product Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice) &&
                     short.TryParse(txtUnitsInStock.Text, out short unitsInStock) &&
                     short.TryParse(txtUnitsOnOrder.Text, out short unitsOnOrder) &&
                     short.TryParse(txtReorderLevel.Text, out short reorderLevel))
            {
                bool discontinued = chkDiscontinued.Checked;

                // Create or update the product
                if (_product == null)
                {
                    _product = new Product
                    {
                        ProductName = productName,
                        CategoryID = categoryID,
                        SupplierID = supplierID,
                        QuantityPerUnit = quantityPerUnit,
                        UnitPrice = unitPrice,
                        UnitsInStock = unitsInStock,
                        UnitsOnOrder = unitsOnOrder,
                        ReorderLevel = reorderLevel,
                        Discontinued = discontinued
                    };

                    _dbContext.Products.Add(_product);
                }
                else
                {
                    _product.ProductName = productName;
                    _product.CategoryID = categoryID;
                    _product.SupplierID = supplierID;
                    _product.QuantityPerUnit = quantityPerUnit;
                    _product.UnitPrice = unitPrice;
                    _product.UnitsInStock = unitsInStock;
                    _product.UnitsOnOrder = unitsOnOrder;
                    _product.ReorderLevel = reorderLevel;
                    _product.Discontinued = discontinued;
                }

                _dbContext.SaveChanges();

                _sharedFormLogic.LoadForm<ProductsForm>(_panelContent);
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values for Unit Price, Units In Stock, Units On Order, and Reorder Level.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _sharedFormLogic.LoadForm<ProductsForm>(_panelContent);
        }
    }
}
