using System.ComponentModel.DataAnnotations;

namespace NorthwindFormsApp.Entities
{
    public class Category
    {
        [Key]
        [Display(Name = "Category ID")]
        public int CategoryID { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Description")]
        public string Description { get; set; }

        public byte[] Picture { get; set; }

        // Navigation properties
        public virtual ICollection<Product> Products { get; set; }
    }
}