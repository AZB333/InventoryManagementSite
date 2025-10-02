using InventoryManagement.Data;
using InventoryManagement.Models;

namespace InventoryManagement.Services
{
    public class LeftShelf4Service
    {
        private readonly LeftShelf4Context _context = default!;

        public LeftShelf4Service(LeftShelf4Context context) 
        {
            _context = context;
        }
        
        public IList<LeftShelf4> GetLeftShelf4Table()
        {
            if(_context.LeftShelf4Table != null)
            {   
                return _context.LeftShelf4Table.ToList();
            }
            return new List<LeftShelf4>();
        }

        public void AddLeftShelf4(LeftShelf4 leftShelf4)
        {
            if (_context.LeftShelf4Table != null)
            {
                _context.LeftShelf4Table.Add(leftShelf4);
                _context.SaveChanges();
            }
        }

        public void DeleteLeftShelf4(int id)
        {
            if (_context.LeftShelf4Table != null)
            {
                var LeftShelf4 = _context.LeftShelf4Table.Find(id);
                if (LeftShelf4 != null)
                {
                    _context.LeftShelf4Table.Remove(LeftShelf4);
                    _context.SaveChanges();
                }
            }            
        } 
    }
}
