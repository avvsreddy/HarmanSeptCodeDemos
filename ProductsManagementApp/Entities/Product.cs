using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsManagementApp.Entities
{
    [Table("tbl_items")]
    public class Product
    {
        //[Key]
        public int ProductId { get; set; } // maps to pk
        [MaxLength(50)]
        [MinLength(5)]
        [Required]
        public string Name { get; set; }
        public int Price { get; set; }
        [MaxLength(50)]
        [MinLength(5)]
        public string Brand { get; set; }
        [NotMapped]
        public int ProfitMargin { get; set; }
        public virtual Category Category { get; set; }
    }

    public class Category
    {
        public int CategoryID { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(3)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string? Description { get; set; }
    }
}
