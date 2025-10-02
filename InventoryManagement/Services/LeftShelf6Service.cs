using InventoryManagement.Data;
using InventoryManagement.Models;

namespace InventoryManagement.Services
{
    public class LeftShelf6Service
    {
        private readonly LeftShelf6Context _context = default!;

        public LeftShelf6Service(LeftShelf6Context context) 
        {
            _context = context;
        }
        
        public IList<LeftShelf6> GetLeftShelf6Table()
        {
            if(_context.LeftShelf6Table != null)
            {   
                return _context.LeftShelf6Table.ToList();
            }
            return new List<LeftShelf6>();
        }

        public void AddLeftShelf6(LeftShelf6 leftLeftShelf6)
        {
            if (_context.LeftShelf6Table != null)
            {
                _context.LeftShelf6Table.Add(leftLeftShelf6);
                _context.SaveChanges();
            }
        }

        public void DeleteLeftShelf6(int id)
        {
            if (_context.LeftShelf6Table != null)
            {
                var LeftShelf6 = _context.LeftShelf6Table.Find(id);
                if (LeftShelf6 != null)
                {
                    _context.LeftShelf6Table.Remove(LeftShelf6);
                    _context.SaveChanges();
                }
            }            
        } 
    }
}
