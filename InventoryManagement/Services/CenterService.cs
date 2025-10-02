using InventoryManagement.Data;
using InventoryManagement.Models;

namespace InventoryManagement.Services
{
    public class CenterService
    {
        private readonly CenterContext _context = default!;

        public CenterService(CenterContext context) 
        {
            _context = context;
        }
        
        public IList<Center> GetCenterTable()
        {
            if(_context.CenterTable != null)
            {   
                return _context.CenterTable.ToList();
            }
            return new List<Center>();
        }

        public void AddCenter(Center center)
        {
            if (_context.CenterTable != null)
            {
                _context.CenterTable.Add(center);
                _context.SaveChanges();
            }
        }

        public void DeleteCenter(int id)
        {
            if (_context.CenterTable != null)
            {
                var Center = _context.CenterTable.Find(id);
                if (Center != null)
                {
                    _context.CenterTable.Remove(Center);
                    _context.SaveChanges();
                }
            }            
        } 
    }
}
