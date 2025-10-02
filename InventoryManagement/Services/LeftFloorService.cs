using InventoryManagement.Data;
using InventoryManagement.Models;

namespace InventoryManagement.Services
{
    public class LeftFloorService
    {
        private readonly LeftFloorContext _context = default!;

        public LeftFloorService(LeftFloorContext context) 
        {
            _context = context;
        }
        
        public IList<LeftFloor> GetLeftFloorTable()
        {
            if(_context.LeftFloorTable != null)
            {   
                return _context.LeftFloorTable.ToList();
            }
            return new List<LeftFloor>();
        }

        public void AddLeftFloor(LeftFloor leftFloor)
        {
            if (_context.LeftFloorTable != null)
            {
                _context.LeftFloorTable.Add(leftFloor);
                _context.SaveChanges();
            }
        }

        public void DeleteLeftFloor(int id)
        {
            if (_context.LeftFloorTable != null)
            {
                var LeftFloor = _context.LeftFloorTable.Find(id);
                if (LeftFloor != null)
                {
                    _context.LeftFloorTable.Remove(LeftFloor);
                    _context.SaveChanges();
                }
            }            
        } 
    }
}
