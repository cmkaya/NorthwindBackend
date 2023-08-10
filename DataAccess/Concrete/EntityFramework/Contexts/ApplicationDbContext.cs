using Core.DataAccess.Settings;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Contexts;

public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = 
            "Data Source=/Users/cemkaya/RiderProjects/NorthwindBackend/DataAccess/Data/Northwind.db";
        optionsBuilder.UseSqlite(connectionString);
    }
}