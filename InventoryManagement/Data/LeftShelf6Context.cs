using Microsoft.EntityFrameworkCore;
namespace InventoryManagement.Data
{
    public class LeftShelf6Context : DbContext
    {
        public LeftShelf6Context(DbContextOptions<LeftShelf6Context> options)
            : base(options)
        {
        }
        public DbSet<InventoryManagement.Models.LeftShelf6>? LeftShelf6Table { get; set; }
    }
}
