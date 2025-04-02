using FINALBOOKINGSYSTEM.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FINALBOOKINGSYSTEM.Pages.Items
{
    public class DeleteItemModel : PageModel
    {
        private ItemService _itemService;

        [BindProperty]
        public Models.Item Item { get; set; }
        public DeleteItemModel(ItemService itemService)
        {
            _itemService = itemService;
        }
        public IActionResult OnGet(int id)
        {
            Item = _itemService.GetItem(id);
            if(Item == null)
            {
                return RedirectToPage("/NotFound");
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            Models.Item deletedItem = _itemService.DeleteItem(Item.Id);
            if (deletedItem == null)
            {
                return RedirectToPage("/NotFound");
            }
            return RedirectToPage("CreateAllItems");
        }
    }
}
