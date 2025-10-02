using InventoryManagement.Data;
using InventoryManagement.Models;

namespace InventoryManagement.Services
{
    public class LeftShelf5Service
    {
        private readonly LeftShelf5Context _context = default!;

        public LeftShelf5Service(LeftShelf5Context context) 
        {
            _context = context;
        }
        
        public IList<LeftShelf5> GetLeftShelf5Table()
        {
            if(_context.LeftShelf5Table != null)
            {   
                return _context.LeftShelf5Table.ToList();
            }
            return new List<LeftShelf5>();
        }

        public void AddLeftShelf5(LeftShelf5 leftShelf5)
        {
            if (_context.LeftShelf5Table != null)
            {
                _context.LeftShelf5Table.Add(leftShelf5);
                _context.SaveChanges();
            }
        }

        public void DeleteLeftShelf5(int id)
        {
            if (_context.LeftShelf5Table != null)
            {
                var LeftShelf5 = _context.LeftShelf5Table.Find(id);
                if (LeftShelf5 != null)
                {
                    _context.LeftShelf5Table.Remove(LeftShelf5);
                    _context.SaveChanges();
                }
            }            
        } 
    }
}
