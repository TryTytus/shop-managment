using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp2.Data;

public class Order
{
    public int Id { get; set; }
    [Required]
    [Range(0, int.MaxValue)]
    public int Quantity { get; set; }
    [DataType(DataType.Text)]
    public string? Description { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime ModifiedAt { get; set; }
    
    public Employee? Employee { get; set; }
    public Product Product { get; set; }
    public Client Client { get; set; }
}