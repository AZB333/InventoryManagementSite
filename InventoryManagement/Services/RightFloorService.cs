using InventoryManagement.Data;
using InventoryManagement.Models;

namespace InventoryManagement.Services
{
    public class RightFloorService
    {
        private readonly RightFloorContext _context = default!;

        public RightFloorService(RightFloorContext context) 
        {
            _context = context;
        }
        
        public IList<RightFloor> GetRightFloorTable()
        {
            if(_context.RightFloorTable != null)
            {   
                return _context.RightFloorTable.ToList();
            }
            return new List<RightFloor>();
        }

        public void AddRightFloor(RightFloor rightFloor)
        {
            if (_context.RightFloorTable != null)
            {
                _context.RightFloorTable.Add(rightFloor);
                _context.SaveChanges();
            }
        }

        public void DeleteRightFloor(int id)
        {
            if (_context.RightFloorTable != null)
            {
                var RightFloor = _context.RightFloorTable.Find(id);
                if (RightFloor != null)
                {
                    _context.RightFloorTable.Remove(RightFloor);
                    _context.SaveChanges();
                }
            }            
        } 
    }
}
