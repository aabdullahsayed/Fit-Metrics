using Microsoft.EntityFrameworkCore;
using FitnessTracker.Models;
namespace FitnessTracker.Data;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<User> users { get; set;}
    public DbSet<Report> reports { get; set;}
}