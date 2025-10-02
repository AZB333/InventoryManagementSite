using Microsoft.EntityFrameworkCore;
namespace InventoryManagement.Data
{
    public class RightShelf4Context : DbContext
    {
        public RightShelf4Context(DbContextOptions<RightShelf4Context> options)
            : base(options)
        {
        }
        public DbSet<InventoryManagement.Models.RightShelf4>? RightShelf4Table { get; set; }
    }
}
