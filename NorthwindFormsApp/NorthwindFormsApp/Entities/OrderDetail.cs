using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthwindFormsApp.Entities
{
    [Table("Order Details")]
    public class OrderDetail
    {
        [Key]
        [Column(Order = 0)]
        [Required]
        public int OrderID { get; set; }

        [Key]
        [Column(Order = 1)]
        [Required]
        public int ProductID { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Unit Price")]
        public decimal UnitPrice { get; set; }

        [Display(Name = "Quantity")]
        public short Quantity { get; set; }

        [Display(Name = "Discount")]
        [Range(0, 1, ErrorMessage = "Discount must be between 0 and 1.")]
        public float Discount { get; set; }

        // Navigation properties
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}