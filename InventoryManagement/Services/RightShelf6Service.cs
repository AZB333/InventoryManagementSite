using InventoryManagement.Data;
using InventoryManagement.Models;

namespace InventoryManagement.Services
{
    public class RightShelf6Service
    {
        private readonly RightShelf6Context _context = default!;

        public RightShelf6Service(RightShelf6Context context) 
        {
            _context = context;
        }
        
        public IList<RightShelf6> GetRightShelf6Table()
        {
            if(_context.RightShelf6Table != null)
            {   
                return _context.RightShelf6Table.ToList();
            }
            return new List<RightShelf6>();
        }

        public void AddRightShelf6(RightShelf6 rightShelf6)
        {
            if (_context.RightShelf6Table != null)
            {
                _context.RightShelf6Table.Add(rightShelf6);
                _context.SaveChanges();
            }
        }

        public void DeleteRightShelf6(int id)
        {
            if (_context.RightShelf6Table != null)
            {
                var RightShelf6 = _context.RightShelf6Table.Find(id);
                if (RightShelf6 != null)
                {
                    _context.RightShelf6Table.Remove(RightShelf6);
                    _context.SaveChanges();
                }
            }            
        } 
    }
}
