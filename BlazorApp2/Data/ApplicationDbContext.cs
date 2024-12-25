using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<Employee>(options)
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Employee> Employees { get;  set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
}