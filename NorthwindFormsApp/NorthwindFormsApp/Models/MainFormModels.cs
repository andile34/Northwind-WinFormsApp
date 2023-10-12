namespace NorthwindFormsApp.Models
{
    public class MainFormViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        // Supplier properties
        public int SupplierId { get; set; }
        public string SupplierCompanyName { get; set; }

        // Category properties
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}