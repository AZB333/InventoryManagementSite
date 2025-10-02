using InventoryManagement.Data;
using InventoryManagement.Models;

namespace InventoryManagement.Services
{
    public class RightShelf4Service
    {
        private readonly RightShelf4Context _context = default!;

        public RightShelf4Service(RightShelf4Context context) 
        {
            _context = context;
        }
        
        public IList<RightShelf4> GetRightShelf4Table()
        {
            if(_context.RightShelf4Table != null)
            {   
                return _context.RightShelf4Table.ToList();
            }
            return new List<RightShelf4>();
        }

        public void AddRightShelf4(RightShelf4 rightShelf4)
        {
            if (_context.RightShelf4Table != null)
            {
                _context.RightShelf4Table.Add(rightShelf4);
                _context.SaveChanges();
            }
        }

        public void DeleteRightShelf4(int id)
        {
            if (_context.RightShelf4Table != null)
            {
                var RightShelf4 = _context.RightShelf4Table.Find(id);
                if (RightShelf4 != null)
                {
                    _context.RightShelf4Table.Remove(RightShelf4);
                    _context.SaveChanges();
                }
            }            
        } 
    }
}
