using Microsoft.EntityFrameworkCore;
namespace InventoryManagement.Data
{
    public class LeftShelf5Context : DbContext
    {
        public LeftShelf5Context(DbContextOptions<LeftShelf5Context> options)
            : base(options)
        {
        }
        public DbSet<InventoryManagement.Models.LeftShelf5>? LeftShelf5Table { get; set; }
    }
}
