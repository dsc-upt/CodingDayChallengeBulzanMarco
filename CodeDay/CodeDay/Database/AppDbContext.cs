using CodeDay.Models;
using CodeDay.Request;
using Microsoft.EntityFrameworkCore;

namespace CodeDay.Database;
public class AppDbContext : DbContext
{
    public AppDbContext (DbContextOptions options) : base(options) {}

    public DbSet<Users> Users { get; set; }
}