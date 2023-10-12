using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthwindFormsApp.Entities
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        [StringLength(40)]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        public int? SupplierID { get; set; }

        public int? CategoryID { get; set; }

        [StringLength(20)]
        [Display(Name = "Quantity Per Unit")]
        public string QuantityPerUnit { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Unit Price")]
        public decimal? UnitPrice { get; set; }

        [Display(Name = "Units In Stock")]
        public short? UnitsInStock { get; set; }

        [Display(Name = "Units On Order")]
        public short? UnitsOnOrder { get; set; }

        [Display(Name = "Reorder Level")]
        public short? ReorderLevel { get; set; }

        [Display(Name = "Discontinued")]
        public bool Discontinued { get; set; }

        // Navigation properties
        public virtual Supplier Supplier { get; set; }

        [NotMapped]
        public string SupplierName
        {
            get
            {
                return Supplier != null ? Supplier.CompanyName : "No Supplier";
            }
        }

        public virtual Category Category { get; set; }

        [NotMapped]
        public string CategoryName
        {
            get
            {
                return Category != null ? Category.CategoryName : "No Category";
            }
        }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}