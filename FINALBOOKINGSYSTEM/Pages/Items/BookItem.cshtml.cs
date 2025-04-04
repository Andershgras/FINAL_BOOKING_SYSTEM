using FINALBOOKINGSYSTEM.Models;
using FINALBOOKINGSYSTEM.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FINALBOOKINGSYSTEM.Pages.Items
{
    public class BookItemModel : PageModel
    {
        private readonly ItemService _itemService;

        public BookItemModel(ItemService itemService)
        {
            _itemService = itemService;
        }
        [BindProperty]
        public Item Item { get; set; }

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
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var item = _itemService.GetItem(Item.Id.Value);
            if (item != null)
            {
                item.IsBooked = true;
                item.BookingDate = Item.BookingDate;
                item.BookingTime = Item.BookingTime;
                item.Kommentar = Item.Kommentar;
                _itemService.UpdateItem(item);
            }

            return RedirectToPage("/Items/CreateAllItems");
        }
    }
}
