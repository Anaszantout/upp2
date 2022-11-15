using Microsoft.EntityFrameworkCore;
using upp2.Models;
namespace upp2.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<ProductModel> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>().ToContainer("Products").HasPartitionKey(x => x.PartitionKey);
        }
    }
}

