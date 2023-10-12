using System.ComponentModel.DataAnnotations;

namespace NorthwindFormsApp.Entities
{
    public class Supplier
    {
        [Key]
        public int SupplierID { get; set; }

        [Required]
        [StringLength(40)]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [StringLength(30)]
        [Display(Name = "Contact Name")]
        public string ContactName { get; set; }

        [StringLength(30)]
        [Display(Name = "Contact Title")]
        public string ContactTitle { get; set; }

        [StringLength(60)]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [StringLength(15)]
        [Display(Name = "City")]
        public string City { get; set; }

        [StringLength(15)]
        [Display(Name = "Region")]
        public string Region { get; set; }

        [StringLength(10)]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [StringLength(15)]
        [Display(Name = "Country")]
        public string Country { get; set; }

        [StringLength(24)]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [StringLength(24)]
        [Display(Name = "Fax")]
        public string Fax { get; set; }

        [StringLength(255)]
        [Display(Name = "Website")]
        public string HomePage { get; set; }

        // Navigation properties
        public virtual ICollection<Product> Products { get; set; }
    }
}