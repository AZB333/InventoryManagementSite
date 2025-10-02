using Microsoft.EntityFrameworkCore;
namespace InventoryManagement.Data
{
    public class LeftShelf1Context : DbContext
    {
        public LeftShelf1Context(DbContextOptions<LeftShelf1Context> options)
            : base(options)
        {
        }
        public DbSet<InventoryManagement.Models.LeftShelf1>? LeftShelf1Table { get; set; }
    }
}
