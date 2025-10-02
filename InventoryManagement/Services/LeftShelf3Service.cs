using InventoryManagement.Data;
using InventoryManagement.Models;

namespace InventoryManagement.Services
{
    public class LeftShelf3Service
    {
        private readonly LeftShelf3Context _context = default!;

        public LeftShelf3Service(LeftShelf3Context context) 
        {
            _context = context;
        }
        
        public IList<LeftShelf3> GetLeftShelf3Table()
        {
            if(_context.LeftShelf3Table != null)
            {   
                return _context.LeftShelf3Table.ToList();
            }
            return new List<LeftShelf3>();
        }

        public void AddLeftShelf3(LeftShelf3 leftShelf3)
        {
            if (_context.LeftShelf3Table != null)
            {
                _context.LeftShelf3Table.Add(leftShelf3);
                _context.SaveChanges();
            }
        }

        public void DeleteLeftShelf3(int id)
        {
            if (_context.LeftShelf3Table != null)
            {
                var LeftShelf3 = _context.LeftShelf3Table.Find(id);
                if (LeftShelf3 != null)
                {
                    _context.LeftShelf3Table.Remove(LeftShelf3);
                    _context.SaveChanges();
                }
            }            
        } 
    }
}
