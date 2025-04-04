using FINALBOOKINGSYSTEM.Models;
using FINALBOOKINGSYSTEM.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FINALBOOKINGSYSTEM.Pages
{
    public class MineBookingsModel : PageModel
    {
        private readonly ItemService _itemService;

        public MineBookingsModel(ItemService itemService)
        {
            _itemService = itemService;
        }

        public List<Item> Items { get; set; }

        public void OnGet()
        {
            Items = _itemService.GetItems().Where(i => i.IsBooked).ToList();
        }
    }
}
