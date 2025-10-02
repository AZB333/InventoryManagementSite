using Microsoft.EntityFrameworkCore;
namespace InventoryManagement.Data
{
    public class RightShelf6Context : DbContext
    {
        public RightShelf6Context(DbContextOptions<RightShelf6Context> options)
            : base(options)
        {
        }
        public DbSet<InventoryManagement.Models.RightShelf6>? RightShelf6Table { get; set; }
    }
}
