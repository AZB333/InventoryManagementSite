using Microsoft.EntityFrameworkCore;
namespace InventoryManagement.Data
{
    public class CenterContext : DbContext
    {
        public CenterContext(DbContextOptions<CenterContext> options)
            : base(options)
        {
        }
        public DbSet<InventoryManagement.Models.Center>? CenterTable { get; set; }
    }
}
