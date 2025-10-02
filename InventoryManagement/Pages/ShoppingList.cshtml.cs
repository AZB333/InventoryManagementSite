using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InventoryManagement.Pages
{
    public class ShoppingListModel : PageModel
    {
        private readonly ILogger<ShoppingListModel> _logger;

        public ShoppingListModel(ILogger<ShoppingListModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}