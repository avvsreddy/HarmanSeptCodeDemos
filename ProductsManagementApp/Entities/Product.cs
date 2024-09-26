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
        public virtual List<Supplier> Suppliers { get; set; }
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

        public virtual List<Product> Products { get; set; }
    }

    public class Supplier : Person
    {
        public string GST { get; set; }
        public int Rating { get; set; }
        public virtual List<Product> Products { get; set; }
    }

    abstract public class Person
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
    }

    public class Customer : Person
    {
        public double Discount { get; set; }
        public Address Address { get; set; }
    }

    [ComplexType]

    public class Address
    {
        public string Area { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
    }
}
