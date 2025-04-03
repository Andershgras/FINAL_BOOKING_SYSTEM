using FINALBOOKINGSYSTEM.Models;
using FINALBOOKINGSYSTEM.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FINALBOOKINGSYSTEM.Pages.Items
{
    public class CreateItemModel : PageModel
    {
        private ItemService _itemService; //Instancefield: Så klassen kan benytte vores service og kan anvende listen af Item objekter.
        [BindProperty] //Dette angiver at der kan bindes til denne property fra html-siden
        public Models.Item Item { get; set; } //BindProperty: Sørger for at Item objektet kan bindes til vores formular.
        public List<Item> Items { get; set; }

        [BindProperty]
        public bool? HasWhiteBoard { get; set; }

        public CreateItemModel(ItemService itemService)
        {
            _itemService = itemService;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _itemService.AddItem(Item);
            return RedirectToPage("CreateAllItems");
        }
        public IActionResult OnPostWhiteBoardFilter()
        {
            if (HasWhiteBoard.HasValue && HasWhiteBoard.Value)
            {
                Items = _itemService.GetItems().Where(i => i.HasWhiteBoard).ToList();
            }
            else
            {
                Items = _itemService.GetItems();
            }
            return Page();
        }
    }
}
