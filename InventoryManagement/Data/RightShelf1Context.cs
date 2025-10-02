using Microsoft.EntityFrameworkCore;
namespace InventoryManagement.Data
{
    public class RightShelf1Context : DbContext
    {
        public RightShelf1Context(DbContextOptions<RightShelf1Context> options)
            : base(options)
        {
        }
        public DbSet<InventoryManagement.Models.RightShelf1>? RightShelf1Table { get; set; }
    }
}
