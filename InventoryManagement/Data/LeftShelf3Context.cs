using Microsoft.EntityFrameworkCore;
namespace InventoryManagement.Data
{
    public class LeftShelf3Context : DbContext
    {
        public LeftShelf3Context(DbContextOptions<LeftShelf3Context> options)
            : base(options)
        {
        }
        public DbSet<InventoryManagement.Models.LeftShelf3>? LeftShelf3Table { get; set; }
    }
}
