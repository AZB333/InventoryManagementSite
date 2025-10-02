using Microsoft.EntityFrameworkCore;
namespace InventoryManagement.Data
{
    public class RightShelf3Context : DbContext
    {
        public RightShelf3Context(DbContextOptions<RightShelf3Context> options)
            : base(options)
        {
        }
        public DbSet<InventoryManagement.Models.RightShelf3>? RightShelf3Table { get; set; }
    }
}
