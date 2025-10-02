using Microsoft.EntityFrameworkCore;
namespace InventoryManagement.Data
{
    public class LeftShelf4Context : DbContext
    {
        public LeftShelf4Context(DbContextOptions<LeftShelf4Context> options)
            : base(options)
        {
        }
        public DbSet<InventoryManagement.Models.LeftShelf4>? LeftShelf4Table { get; set; }
    }
}
