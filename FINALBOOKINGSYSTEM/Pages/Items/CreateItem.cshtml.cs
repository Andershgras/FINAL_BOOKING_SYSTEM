using FINALBOOKINGSYSTEM.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FINALBOOKINGSYSTEM.Pages.Items
{
    public class GetAllItemsModel : PageModel
    {
        [BindProperty] public string SearchString { get; set; }

        [BindProperty] public int MaxId { get; set; }
        [BindProperty] public int MinId { get; set; }
        
        [BindProperty]
        public bool HasWhiteBoard { get; set; }

        public ItemService _itemService; //Instancefield
        public List<Models.Item> Items { get; set; }
        public void OnGet()
        {
            Items = MockData.MockItems.GetMockItems();
            Items = _itemService.GetItems(); //Refaktorer onGet() metoden så den henter Mock-Data via servicen istedet for direkte via GetAllItems()
        }
        public GetAllItemsModel(ItemService itemService) //Dependency Injection
        {
            this._itemService = itemService;
        }

        public IActionResult OnPostNameSearch()
        {
            Items = _itemService.NameSearch(SearchString).ToList();
            return Page();
        }
        public IActionResult OnPostIdFilter()
        {
            Items = _itemService.IdFilter(MaxId, MinId).ToList();
            return Page();
        }
    }
}
