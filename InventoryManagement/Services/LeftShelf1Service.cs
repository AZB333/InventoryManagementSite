using InventoryManagement.Data;
using InventoryManagement.Models;

namespace InventoryManagement.Services
{
    public class LeftShelf1Service
    {
        private readonly LeftShelf1Context _context = default!;

        public LeftShelf1Service(LeftShelf1Context context) 
        {
            _context = context;
        }
        
        public IList<LeftShelf1> GetLeftShelf1Table()
        {
            if(_context.LeftShelf1Table != null)
            {   
                return _context.LeftShelf1Table.ToList();
            }
            return new List<LeftShelf1>();
        }

        public void AddLeftShelf1(LeftShelf1 leftShelf1)
        {
            if (_context.LeftShelf1Table != null)
            {
                _context.LeftShelf1Table.Add(leftShelf1);
                _context.SaveChanges();
            }
        }

        public void DeleteLeftShelf1(int id)
        {
            if (_context.LeftShelf1Table != null)
            {
                var LeftShelf1 = _context.LeftShelf1Table.Find(id);
                if (LeftShelf1 != null)
                {
                    _context.LeftShelf1Table.Remove(LeftShelf1);
                    _context.SaveChanges();
                }
            }            
        } 
    }
}
