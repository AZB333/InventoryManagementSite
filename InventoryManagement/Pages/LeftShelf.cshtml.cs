using InventoryManagement.Models;
using InventoryManagement.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace InventoryManagement.Pages
{
    public class LeftShelfModel : PageModel
    {
        private readonly LeftShelf6Service _shelf6Service;
        private readonly LeftShelf5Service _shelf5Service;
        private readonly LeftShelf4Service _shelf4Service;
        private readonly LeftShelf3Service _shelf3Service;
        private readonly LeftShelf2Service _shelf2Service;
        private readonly LeftShelf1Service _shelf1Service;
        private readonly LeftFloorService _shelfFloorService;


        [BindProperty]
        public LeftShelf6 NewLeftShelf6 { get; set; } = default!;

        public IList<LeftShelf6> LeftShelf6List { get; set; } = default!;

        [BindProperty]
        public LeftShelf5 NewLeftShelf5 { get; set; } = default!;

        public IList<LeftShelf5> LeftShelf5List { get; set; } = default!;

        [BindProperty]
        public LeftShelf4 NewLeftShelf4 { get; set; } = default!;

        public IList<LeftShelf4> LeftShelf4List { get; set; } = default!;
        
        [BindProperty]
        public LeftShelf3 NewLeftShelf3 { get; set; } = default!;

        public IList<LeftShelf3> LeftShelf3List { get; set; } = default!;
        
        [BindProperty]
        public LeftShelf2 NewLeftShelf2 { get; set; } = default!;

        public IList<LeftShelf2> LeftShelf2List { get; set; } = default!;
        
        [BindProperty]
        public LeftShelf1 NewLeftShelf1 { get; set; } = default!;

        public IList<LeftShelf1> LeftShelf1List { get; set; } = default!;
        
        [BindProperty]
        public LeftFloor NewLeftFloor { get; set; } = default!;

        public IList<LeftFloor> LeftFloorList { get; set; } = default!;

        public LeftShelfModel(LeftShelf6Service shelf6Service, LeftShelf5Service shelf5Service, LeftShelf4Service shelf4Service, LeftShelf3Service shelf3Service, LeftShelf2Service shelf2Service, LeftShelf1Service shelf1Service, LeftFloorService shelfFloorService)
        {
            _shelf6Service = shelf6Service;
            _shelf5Service = shelf5Service;
            _shelf4Service = shelf4Service;
            _shelf3Service = shelf3Service;
            _shelf2Service = shelf2Service;
            _shelf1Service = shelf1Service;
            _shelfFloorService = shelfFloorService;

        }

        public IActionResult OnPostAdd6()
        {
            if (!ModelState.IsValid || NewLeftShelf6 == null)
            {
                return Page();

            }
            _shelf6Service.AddLeftShelf6(NewLeftShelf6);
            return RedirectToAction("OnGet");
        }

        public IActionResult OnPostAdd5()
        {
            if (!ModelState.IsValid || NewLeftShelf5 == null)
            {
                return Page();

            }
            _shelf5Service.AddLeftShelf5(NewLeftShelf5);
            return RedirectToAction("OnGet");
        }

        public IActionResult OnPostAdd4()
        {
            if (!ModelState.IsValid || NewLeftShelf4 == null)
            {
                return Page();

            }
            _shelf4Service.AddLeftShelf4(NewLeftShelf4);
            return RedirectToAction("OnGet");
        }
        
        public IActionResult OnPostAdd3()
        {
            if (!ModelState.IsValid || NewLeftShelf3 == null)
            {
                return Page();

            }
            _shelf3Service.AddLeftShelf3(NewLeftShelf3);
            return RedirectToAction("OnGet");
        }public IActionResult OnPostAdd2()
        {
            if (!ModelState.IsValid || NewLeftShelf2 == null)
            {
                return Page();

            }
            _shelf2Service.AddLeftShelf2(NewLeftShelf2);
            return RedirectToAction("OnGet");
        }public IActionResult OnPostAdd1()
        {
            if (!ModelState.IsValid || NewLeftShelf1 == null)
            {
                return Page();

            }
            _shelf1Service.AddLeftShelf1(NewLeftShelf1);
            return RedirectToAction("OnGet");
        }public IActionResult OnPostAddFloor()
        {
            if (!ModelState.IsValid || NewLeftFloor == null)
            {
                return Page();

            }
            _shelfFloorService.AddLeftFloor(NewLeftFloor);
            return RedirectToAction("OnGet");
        }

        public IActionResult OnPostDelete(int id, string table)   {
            switch(table){
                case "shelf6":
                    _shelf6Service.DeleteLeftShelf6(id);
                    break;
                case "shelf5":
                    _shelf5Service.DeleteLeftShelf5(id);
                    break;
                    case "shelf4":
                    _shelf4Service.DeleteLeftShelf4(id);
                    break;
                case "shelf3":
                    _shelf3Service.DeleteLeftShelf3(id);
                    break;
                    case "shelf2":
                    _shelf2Service.DeleteLeftShelf2(id);
                    break;
                case "shelf1":
                    _shelf1Service.DeleteLeftShelf1(id);
                    break;
                case "floor":
                    _shelfFloorService.DeleteLeftFloor(id);
                    break;
            }

            return RedirectToAction("OnGet");
        }

        public void OnGet(){
            LeftShelf6List = _shelf6Service.GetLeftShelf6Table() ?? new List<LeftShelf6>();
            LeftShelf5List = _shelf5Service.GetLeftShelf5Table() ?? new List<LeftShelf5>();
            LeftShelf4List = _shelf4Service.GetLeftShelf4Table() ?? new List<LeftShelf4>();
            LeftShelf3List = _shelf3Service.GetLeftShelf3Table() ?? new List<LeftShelf3>();
            LeftShelf2List = _shelf2Service.GetLeftShelf2Table() ?? new List<LeftShelf2>();
            LeftShelf1List = _shelf1Service.GetLeftShelf1Table() ?? new List<LeftShelf1>();
            LeftFloorList = _shelfFloorService.GetLeftFloorTable() ?? new List<LeftFloor>();

        }

}

}