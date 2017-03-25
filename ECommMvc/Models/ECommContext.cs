using Microsoft.EntityFrameworkCore;

namespace ECommMvc.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string[] ImageUrls { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
    }

    public class ECommContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=db;Database=EComm;Username=postgres;Password=postgres;");
        }
    }
}
