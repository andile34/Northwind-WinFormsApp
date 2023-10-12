using System.ComponentModel.DataAnnotations;

namespace NorthwindFormsApp.Entities
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "LastName")]
        public string LastName { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [StringLength(30)]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [StringLength(25)]
        [Display(Name = "Title Of Courtesy")]
        public string TitleOfCourtesy { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Birth Date")]
        public DateTime? BirthDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Hire Date")]
        public DateTime? HireDate { get; set; }

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
        [Display(Name = "Home Phone")]
        public string HomePhone { get; set; }

        [StringLength(4)]
        [Display(Name = "Extension")]
        public string Extension { get; set; }

        public byte[] Photo { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Notes")]
        public string Notes { get; set; }

        [Display(Name = "Reports To")]
        public int? ReportsTo { get; set; }

        [StringLength(255)]
        [Display(Name = "Photo Path")]
        public string PhotoPath { get; set; }

        // Navigation properties
        public virtual ICollection<Order> Orders { get; set; }
    }
}