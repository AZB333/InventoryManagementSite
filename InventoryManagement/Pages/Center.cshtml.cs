using InventoryManagement.Models;
using InventoryManagement.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace InventoryManagement.Pages
{
    public class CenterModel : PageModel
    {
        private readonly CenterService _service;

        [BindProperty]
        public Center NewCenter { get; set; } = default!;

        public IList<Center> CenterList { get; set; } = default!;

        public CenterModel(CenterService service)
        {
            _service = service;
        }

        public IActionResult OnPost(){

            if (!ModelState.IsValid || NewCenter == null)
            {
                return Page();

            }
            _service.AddCenter(NewCenter);
            return RedirectToAction("OnGet");
        }

        public IActionResult OnPostDelete(int id){
            _service.DeleteCenter(id);
            return RedirectToAction("OnGet");

        }

        public void OnGet(){
            CenterList = _service.GetCenterTable() ?? new List<Center>();
        }

}

}