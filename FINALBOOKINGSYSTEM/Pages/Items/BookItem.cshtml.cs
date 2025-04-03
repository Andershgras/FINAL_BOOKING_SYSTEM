using FINALBOOKINGSYSTEM.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FINALBOOKINGSYSTEM.Pages.Items
{
    public class BookItemModel : PageModel
    {
        private ItemService _itemService;

        [BindProperty]
        public Models.Item Item { get; set; }
        public BookItemModel(ItemService itemService)
        {
            _itemService = itemService;
        }
        public IActionResult OnGet(int id)
        {
            Item = _itemService.GetItem(id);
            if (Item == null)
            {
                return RedirectToPage("/NotFound");
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            Models.Item bookedItem = _itemService.BookItem(Item.Id);
            if (bookedItem == null)
            {
                return RedirectToPage("/NotFound");
            }
            bookedItem.IsBooked = true;
            return RedirectToPage("CreateAllItems");
        }
    }
}
