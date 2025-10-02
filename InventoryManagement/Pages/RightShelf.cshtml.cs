using InventoryManagement.Models;
using InventoryManagement.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace InventoryManagement.Pages
{
    public class RightShelfModel : PageModel
    {
        private readonly RightShelf6Service _shelf6Service;
        private readonly RightShelf5Service _shelf5Service;
        private readonly RightShelf4Service _shelf4Service;
        private readonly RightShelf3Service _shelf3Service;
        private readonly RightShelf2Service _shelf2Service;
        private readonly RightShelf1Service _shelf1Service;
        private readonly RightFloorService _shelfFloorService;


        [BindProperty]
        public RightShelf6 NewRightShelf6 { get; set; } = default!;

        public IList<RightShelf6> RightShelf6List { get; set; } = default!;

        [BindProperty]
        public RightShelf5 NewRightShelf5 { get; set; } = default!;

        public IList<RightShelf5> RightShelf5List { get; set; } = default!;

        [BindProperty]
        public RightShelf4 NewRightShelf4 { get; set; } = default!;

        public IList<RightShelf4> RightShelf4List { get; set; } = default!;
        
        [BindProperty]
        public RightShelf3 NewRightShelf3 { get; set; } = default!;

        public IList<RightShelf3> RightShelf3List { get; set; } = default!;
        
        [BindProperty]
        public RightShelf2 NewRightShelf2 { get; set; } = default!;

        public IList<RightShelf2> RightShelf2List { get; set; } = default!;
        
        [BindProperty]
        public RightShelf1 NewRightShelf1 { get; set; } = default!;

        public IList<RightShelf1> RightShelf1List { get; set; } = default!;
        
        [BindProperty]
        public RightFloor NewRightFloor { get; set; } = default!;

        public IList<RightFloor> RightFloorList { get; set; } = default!;

        public RightShelfModel(RightShelf6Service shelf6Service, RightShelf5Service shelf5Service, RightShelf4Service shelf4Service, RightShelf3Service shelf3Service, RightShelf2Service shelf2Service, RightShelf1Service shelf1Service, RightFloorService shelfFloorService)
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
            if (!ModelState.IsValid || NewRightShelf6 == null)
            {
                return Page();

            }
            _shelf6Service.AddRightShelf6(NewRightShelf6);
            return RedirectToAction("OnGet");
        }

        public IActionResult OnPostAdd5()
        {
            if (!ModelState.IsValid || NewRightShelf5 == null)
            {
                return Page();

            }
            _shelf5Service.AddRightShelf5(NewRightShelf5);
            return RedirectToAction("OnGet");
        }

        public IActionResult OnPostAdd4()
        {
            if (!ModelState.IsValid || NewRightShelf4 == null)
            {
                return Page();

            }
            _shelf4Service.AddRightShelf4(NewRightShelf4);
            return RedirectToAction("OnGet");
        }
        
        public IActionResult OnPostAdd3()
        {
            if (!ModelState.IsValid || NewRightShelf3 == null)
            {
                return Page();

            }
            _shelf3Service.AddRightShelf3(NewRightShelf3);
            return RedirectToAction("OnGet");
        }public IActionResult OnPostAdd2()
        {
            if (!ModelState.IsValid || NewRightShelf2 == null)
            {
                return Page();

            }
            _shelf2Service.AddRightShelf2(NewRightShelf2);
            return RedirectToAction("OnGet");
        }public IActionResult OnPostAdd1()
        {
            if (!ModelState.IsValid || NewRightShelf1 == null)
            {
                return Page();

            }
            _shelf1Service.AddRightShelf1(NewRightShelf1);
            return RedirectToAction("OnGet");
        }public IActionResult OnPostAddFloor()
        {
            if (!ModelState.IsValid || NewRightFloor == null)
            {
                return Page();

            }
            _shelfFloorService.AddRightFloor(NewRightFloor);
            return RedirectToAction("OnGet");
        }

        public IActionResult OnPostDelete(int id, string table)   {
            switch(table){
                case "shelf6":
                    _shelf6Service.DeleteRightShelf6(id);
                    break;
                case "shelf5":
                    _shelf5Service.DeleteRightShelf5(id);
                    break;
                    case "shelf4":
                    _shelf4Service.DeleteRightShelf4(id);
                    break;
                case "shelf3":
                    _shelf3Service.DeleteRightShelf3(id);
                    break;
                    case "shelf2":
                    _shelf2Service.DeleteRightShelf2(id);
                    break;
                case "shelf1":
                    _shelf1Service.DeleteRightShelf1(id);
                    break;
                case "floor":
                    _shelfFloorService.DeleteRightFloor(id);
                    break;
            }

            return RedirectToAction("OnGet");
        }

        public void OnGet(){
            RightShelf6List = _shelf6Service.GetRightShelf6Table() ?? new List<RightShelf6>();
            RightShelf5List = _shelf5Service.GetRightShelf5Table() ?? new List<RightShelf5>();
            RightShelf4List = _shelf4Service.GetRightShelf4Table() ?? new List<RightShelf4>();
            RightShelf3List = _shelf3Service.GetRightShelf3Table() ?? new List<RightShelf3>();
            RightShelf2List = _shelf2Service.GetRightShelf2Table() ?? new List<RightShelf2>();
            RightShelf1List = _shelf1Service.GetRightShelf1Table() ?? new List<RightShelf1>();
            RightFloorList = _shelfFloorService.GetRightFloorTable() ?? new List<RightFloor>();

        }

}

}