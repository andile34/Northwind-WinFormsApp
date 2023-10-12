using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthwindFormsApp.Entities
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [StringLength(5)]
        public string CustomerID { get; set; }

        public int? EmployeeID { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Order Date")]
        public DateTime? OrderDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Required Date")]
        public DateTime? RequiredDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Shipped Date")]
        public DateTime? ShippedDate { get; set; }

        [Display(Name = "Ship Via")]
        public int? ShipVia { get; set; }

        [Display(Name = "Freight")]
        [DataType(DataType.Currency)]
        public decimal? Freight { get; set; }

        [StringLength(40)]
        [Display(Name = "Ship Name")]
        public string ShipName { get; set; }

        [StringLength(60)]
        [Display(Name = "Ship Address")]
        public string ShipAddress { get; set; }

        [StringLength(15)]
        [Display(Name = "Ship City")]
        public string ShipCity { get; set; }

        [StringLength(15)]
        [Display(Name = "Ship Region")]
        public string ShipRegion { get; set; }

        [StringLength(10)]
        [Display(Name = "Ship Postal Code")]
        public string ShipPostalCode { get; set; }

        [StringLength(15)]
        [Display(Name = "Ship Country")]
        public string ShipCountry { get; set; }

        // Navigation properties
        public virtual Customer Customer { get; set; }

        [NotMapped]
        public string ContactName
        {
            get
            {
                return Customer != null ? Customer.ContactName : "No Customer";
            }
        }

        public virtual Employee Employee { get; set; }

        [NotMapped]
        public string EmployeeName
        {
            get
            {
                return Employee != null ? Employee.FirstName + " " + Employee.LastName : "No Employee";
            }
        }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}