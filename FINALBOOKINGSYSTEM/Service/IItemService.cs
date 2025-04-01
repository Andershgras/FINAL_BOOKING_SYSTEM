using Bookingsystem.Models;
using Bookingsystem.Pages.Items;

namespace Bookingsystem.Service
{
    public interface IItemService
    {
        List<Item> GetItems();

        public void AddItem(Item item)
        {
            _items.Add(item);
        }

    }
}
