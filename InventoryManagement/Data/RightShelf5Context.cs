using Microsoft.EntityFrameworkCore;
namespace InventoryManagement.Data
{
    public class RightShelf5Context : DbContext
    {
        public RightShelf5Context(DbContextOptions<RightShelf5Context> options)
            : base(options)
        {
        }
        public DbSet<InventoryManagement.Models.RightShelf5>? RightShelf5Table { get; set; }
    }
}
