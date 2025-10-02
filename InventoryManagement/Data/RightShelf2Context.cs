using Microsoft.EntityFrameworkCore;
namespace InventoryManagement.Data
{
    public class RightShelf2Context : DbContext
    {
        public RightShelf2Context(DbContextOptions<RightShelf2Context> options)
            : base(options)
        {
        }
        public DbSet<InventoryManagement.Models.RightShelf2>? RightShelf2Table { get; set; }
    }
}
