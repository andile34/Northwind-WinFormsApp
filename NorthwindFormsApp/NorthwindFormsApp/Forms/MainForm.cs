using NorthwindFormsApp.Data;
using NorthwindFormsApp.Helpers;

namespace NorthwindFormsApp.Forms
{
    public partial class MainForm : Form
    {
        private NorthwindDbContext _dbContext { get; set; }
        private SharedFormLogic _sharedFormLogic { get; set; }

        public MainForm(NorthwindDbContext dbContext)
        {
            InitializeComponent();

            _dbContext = dbContext;
            _sharedFormLogic = new SharedFormLogic(dbContext);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            // Calculate the location for center alignment
            //int labelTitleWidth = labelTitle.GetPreferredSize(panelHeader.Size).Width;
            //int labelTitleX = (panelHeader.Width - labelTitleWidth) / 2;
            //labelTitle.Location = new Point(labelTitleX, 35);

            HighlightMenuItem(btnDashboard);

            _sharedFormLogic.LoadForm<DashboardForm>(panelContent);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Clean up and dispose of the database context on close
            _dbContext.Dispose();
        }

        private void HighlightMenuItem(Button menuItem)
        {
            btnDashboard.BackColor = Color.FromArgb(40, 60, 100);
            btnEmployees.BackColor = Color.FromArgb(40, 60, 100);
            btnSuppliers.BackColor = Color.FromArgb(40, 60, 100);
            btnOrders.BackColor = Color.FromArgb(40, 60, 100);
            btnCustomers.BackColor = Color.FromArgb(40, 60, 100);
            btnProducts.BackColor = Color.FromArgb(40, 60, 100);

            // Highlight the selected menu item
            menuItem.BackColor = Color.FromArgb(52, 152, 219);
        }

        public Panel GetPanelContent()
        {
            return panelContent;
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HighlightMenuItem(btnEmployees);

            _sharedFormLogic.LoadForm<EmployeesForm>(panelContent);
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HighlightMenuItem(btnSuppliers);

            _sharedFormLogic.LoadForm<SuppliersForm>(panelContent);
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HighlightMenuItem(btnOrders);

            _sharedFormLogic.LoadForm<OrdersForm>(panelContent);
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HighlightMenuItem(btnCustomers);

            _sharedFormLogic.LoadForm<CustomersForm>(panelContent);
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HighlightMenuItem(btnProducts);

            _sharedFormLogic.LoadForm<ProductsForm>(panelContent);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Update the date and time in the status strip
            UpdateStatusStrip();
        }

        private void UpdateStatusStrip()
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}