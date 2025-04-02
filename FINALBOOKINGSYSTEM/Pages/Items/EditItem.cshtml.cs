using FINALBOOKINGSYSTEM.Models;
using FINALBOOKINGSYSTEM.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FINALBOOKINGSYSTEM.Pages.Items
{
    public class EditItemModel : PageModel
    {
        private ItemService _itemService;

        [BindProperty]
        public Models.Item Item { get; set; }

        public EditItemModel(ItemService itemService)
        {
            _itemService = itemService;
        }
        public IActionResult OnGet(int id)
        {
            Item = _itemService.GetItem(id);
            if (Item == null)
            {
                return RedirectToPage("/NotFound"); //NotFound ikke defineret endnu
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (Item.Id == null || Item.Id == 0)
            {
                // Assign a new Id if it's a new item
                Item.Id = _itemService.GetItems().Max(i => i.Id) + 1 ?? 1;
                _itemService.AddItem(Item);
            }
            else
            {
                _itemService.UpdateItem(Item);
            }

            return RedirectToPage("CreateAllItems");
            _itemService.UpdateItem(Item);
        }
    }
}
