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
            Console.WriteLine($"Item.Id from form: {Item.Id}");

            if (!ModelState.IsValid)
            {
                Console.WriteLine("ModelState is INVALID");

                return Page();
            }
            Console.WriteLine($"OnPost called: Item ID = {Item.Id}");

            var item = _itemService.GetItem(Item.Id.Value);
            if (item != null)
            {
                Console.WriteLine("Item found before update");

                item.IsBooked = true;
                item.BookingDate = Item.BookingDate;
                item.BookingTime = Item.BookingTime;
                item.Kommentar = Item.Kommentar;
                _itemService.UpdateItem(item);
                Console.WriteLine("Item booked!");
            }
            else
            {
                Console.WriteLine("Item not found");
            }

            return RedirectToPage("/Items/CreateAllItems");
        }
    }
}
