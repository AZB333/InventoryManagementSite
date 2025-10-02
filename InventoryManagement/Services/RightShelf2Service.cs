using InventoryManagement.Data;
using InventoryManagement.Models;

namespace InventoryManagement.Services
{
    public class RightShelf2Service
    {
        private readonly RightShelf2Context _context = default!;

        public RightShelf2Service(RightShelf2Context context) 
        {
            _context = context;
        }
        
        public IList<RightShelf2> GetRightShelf2Table()
        {
            if(_context.RightShelf2Table != null)
            {   
                return _context.RightShelf2Table.ToList();
            }
            return new List<RightShelf2>();
        }

        public void AddRightShelf2(RightShelf2 rightShelf2)
        {
            if (_context.RightShelf2Table != null)
            {
                _context.RightShelf2Table.Add(rightShelf2);
                _context.SaveChanges();
            }
        }

        public void DeleteRightShelf2(int id)
        {
            if (_context.RightShelf2Table != null)
            {
                var RightShelf2 = _context.RightShelf2Table.Find(id);
                if (RightShelf2 != null)
                {
                    _context.RightShelf2Table.Remove(RightShelf2);
                    _context.SaveChanges();
                }
            }            
        } 
    }
}
