using Microsoft.EntityFrameworkCore;
namespace InventoryManagement.Data
{
    public class RightFloorContext : DbContext
    {
        public RightFloorContext(DbContextOptions<RightFloorContext> options)
            : base(options)
        {
        }
        public DbSet<InventoryManagement.Models.RightFloor>? RightFloorTable { get; set; }
    }
}
