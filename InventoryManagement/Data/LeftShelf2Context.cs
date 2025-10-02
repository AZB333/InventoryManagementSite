using Microsoft.EntityFrameworkCore;
namespace InventoryManagement.Data
{
    public class LeftShelf2Context : DbContext
    {
        public LeftShelf2Context(DbContextOptions<LeftShelf2Context> options)
            : base(options)
        {
        }
        public DbSet<InventoryManagement.Models.LeftShelf2>? LeftShelf2Table { get; set; }
    }
}
