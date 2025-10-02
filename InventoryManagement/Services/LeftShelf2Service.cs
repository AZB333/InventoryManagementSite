using InventoryManagement.Data;
using InventoryManagement.Models;

namespace InventoryManagement.Services
{
    public class LeftShelf2Service
    {
        private readonly LeftShelf2Context _context = default!;

        public LeftShelf2Service(LeftShelf2Context context) 
        {
            _context = context;
        }
        
        public IList<LeftShelf2> GetLeftShelf2Table()
        {
            if(_context.LeftShelf2Table != null)
            {   
                return _context.LeftShelf2Table.ToList();
            }
            return new List<LeftShelf2>();
        }

        public void AddLeftShelf2(LeftShelf2 leftShelf2)
        {
            if (_context.LeftShelf2Table != null)
            {
                _context.LeftShelf2Table.Add(leftShelf2);
                _context.SaveChanges();
            }
        }

        public void DeleteLeftShelf2(int id)
        {
            if (_context.LeftShelf2Table != null)
            {
                var LeftShelf2 = _context.LeftShelf2Table.Find(id);
                if (LeftShelf2 != null)
                {
                    _context.LeftShelf2Table.Remove(LeftShelf2);
                    _context.SaveChanges();
                }
            }            
        } 
    }
}
