using System.ComponentModel.DataAnnotations;

namespace BlazorApp2.Data;

public class Client
{
    public int Id { get; set; }
    [Required]
    [MinLength(5), MaxLength(50)]
    public string Name { get; set; }
    [Required]
    public string Address { get; set; }
    [Required]
    [DataType(DataType.EmailAddress)]
    [EmailAddress]
    public string Email { get; set; }
    
    
    public List<Order> Orders { get; set; }
}