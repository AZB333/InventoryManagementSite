using InventoryManagement.Data;
using InventoryManagement.Models;

namespace InventoryManagement.Services
{
    public class RightShelf5Service
    {
        private readonly RightShelf5Context _context = default!;

        public RightShelf5Service(RightShelf5Context context) 
        {
            _context = context;
        }
        
        public IList<RightShelf5> GetRightShelf5Table()
        {
            if(_context.RightShelf5Table != null)
            {   
                return _context.RightShelf5Table.ToList();
            }
            return new List<RightShelf5>();
        }

        public void AddRightShelf5(RightShelf5 rightShelf5)
        {
            if (_context.RightShelf5Table != null)
            {
                _context.RightShelf5Table.Add(rightShelf5);
                _context.SaveChanges();
            }
        }

        public void DeleteRightShelf5(int id)
        {
            if (_context.RightShelf5Table != null)
            {
                var RightShelf5 = _context.RightShelf5Table.Find(id);
                if (RightShelf5 != null)
                {
                    _context.RightShelf5Table.Remove(RightShelf5);
                    _context.SaveChanges();
                }
            }            
        } 
    }
}
