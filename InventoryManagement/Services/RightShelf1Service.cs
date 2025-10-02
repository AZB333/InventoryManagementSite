using InventoryManagement.Data;
using InventoryManagement.Models;

namespace InventoryManagement.Services
{
    public class RightShelf1Service
    {
        private readonly RightShelf1Context _context = default!;

        public RightShelf1Service(RightShelf1Context context) 
        {
            _context = context;
        }
        
        public IList<RightShelf1> GetRightShelf1Table()
        {
            if(_context.RightShelf1Table != null)
            {   
                return _context.RightShelf1Table.ToList();
            }
            return new List<RightShelf1>();
        }

        public void AddRightShelf1(RightShelf1 rightShelf1)
        {
            if (_context.RightShelf1Table != null)
            {
                _context.RightShelf1Table.Add(rightShelf1);
                _context.SaveChanges();
            }
        }

        public void DeleteRightShelf1(int id)
        {
            if (_context.RightShelf1Table != null)
            {
                var RightShelf1 = _context.RightShelf1Table.Find(id);
                if (RightShelf1 != null)
                {
                    _context.RightShelf1Table.Remove(RightShelf1);
                    _context.SaveChanges();
                }
            }            
        } 
    }
}
