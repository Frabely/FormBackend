using FormBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace FormBackend.Data;

public class ApiContext : DbContext
{
    public DbSet<Client>? Clients { get; set; }
    public DbSet<Company>? Companies { get; set; }
    public DbSet<Industry>? Industries { get; set; }
    
    public ApiContext()
    {
    }
    
    public ApiContext(DbContextOptions<ApiContext> options) : base(options)
    {
        
    }
}