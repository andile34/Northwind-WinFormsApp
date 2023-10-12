using NorthwindFormsApp.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace NorthwindFormsApp.Forms
{
    public partial class DashboardForm : Form
    {
        private NorthwindDbContext _dbContext { get; set; }

        public DashboardForm(NorthwindDbContext dbContext)
        {
            _dbContext = dbContext;

            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            // Populate the chart with sample data
            PopulateChart();
        }

        private void PopulateChart()
        {
            var salesData = _dbContext.Products.GroupBy(p => p.Category.CategoryName).Select(g => new
            {
                CategoryName = g.Key,
                SalesAmount = g.Sum(p => p.OrderDetails.Sum(od => od.Quantity * od.UnitPrice))
            }).ToList();

            if (salesData.Count == 0)
            {
                MessageBox.Show("No sales data available.");
                return;
            }

            // Extract the category names and sales amounts
            string[] categories = salesData.Select(s => s.CategoryName).ToArray();
            double[] values = salesData.Select(s => (double)s.SalesAmount).ToArray();

            // Clear any existing data series
            chart1.Series.Clear();

            // Create a new data series
            Series series = new Series("Sales");
            chart1.Series.Add(series);

            // Bind the numeric Y values
            chart1.Series["Sales"].Points.DataBindY(values);

            // Customize the appearance of the chart
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;
            series.LabelBackColor = Color.FromArgb(52, 152, 219);
            series.LabelForeColor = Color.White;

            // Set category names as X-axis labels
            chart1.ChartAreas[0].AxisX.CustomLabels.Clear();
            for (int i = 0; i < categories.Length; i++)
            {
                chart1.ChartAreas[0].AxisX.CustomLabels.Add(i + 0.5, i + 1.5, categories[i]);
            }

            // Set chart title and labels
            chart1.Titles.Add("Sales by Category");
            chart1.ChartAreas[0].AxisX.Title = "Category";
            chart1.ChartAreas[0].AxisY.Title = "Sales Amount (R)";

            // Format the label text with R currency symbol and two decimal places
            foreach (var point in series.Points)
            {
                point.Label = string.Format("R{0:F2}", point.YValues[0]);
            }

            // Refresh the chart
            chart1.Invalidate();
        }
    }
}