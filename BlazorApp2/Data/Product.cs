using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp2.Data;

public class Product
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [MaxLength(50, ErrorMessage = "Product name to exceed 50 characters")]
    public string Name { get; set; }
    [DataType(DataType.Text)]
    public string? Description { get; set; }
    [Required]
    [Range(0, int.MaxValue)]
    public int Quantity { get; set; }
    [Required]
    public decimal Price { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime ModifiedAt { get; set; }
    
    public List<Order> Orders { get; set; }
}