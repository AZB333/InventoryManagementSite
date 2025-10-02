using Microsoft.EntityFrameworkCore;
namespace InventoryManagement.Data
{
    public class LeftFloorContext : DbContext
    {
        public LeftFloorContext(DbContextOptions<LeftFloorContext> options)
            : base(options)
        {
        }
        public DbSet<InventoryManagement.Models.LeftFloor>? LeftFloorTable { get; set; }
    }
}
