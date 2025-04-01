using FINALBOOKINGSYSTEM.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FINALBOOKINGSYSTEM.Pages.Items
{
    public class GetAllItemsModel : PageModel
    {
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
    }
}
