using Microsoft.EntityFrameworkCore;
using MyWebApi.Api.Models;

namespace MyWebApi.Api.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    public DbSet<User> Users { get; set; }
}