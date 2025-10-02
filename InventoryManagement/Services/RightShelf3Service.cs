using InventoryManagement.Data;
using InventoryManagement.Models;

namespace InventoryManagement.Services
{
    public class RightShelf3Service
    {
        private readonly RightShelf3Context _context = default!;

        public RightShelf3Service(RightShelf3Context context) 
        {
            _context = context;
        }
        
        public IList<RightShelf3> GetRightShelf3Table()
        {
            if(_context.RightShelf3Table != null)
            {   
                return _context.RightShelf3Table.ToList();
            }
            return new List<RightShelf3>();
        }

        public void AddRightShelf3(RightShelf3 rightShelf3)
        {
            if (_context.RightShelf3Table != null)
            {
                _context.RightShelf3Table.Add(rightShelf3);
                _context.SaveChanges();
            }
        }

        public void DeleteRightShelf3(int id)
        {
            if (_context.RightShelf3Table != null)
            {
                var RightShelf3 = _context.RightShelf3Table.Find(id);
                if (RightShelf3 != null)
                {
                    _context.RightShelf3Table.Remove(RightShelf3);
                    _context.SaveChanges();
                }
            }            
        } 
    }
}
