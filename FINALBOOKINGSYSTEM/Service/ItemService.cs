using Bookingsystem.Models;
using Bookingsystem.Pages.Items;

namespace Bookingsystem.Service
{
    public class ItemService : IItemService
    {
        //Properties der refererer til MockItems
        List<Item> Items { get; set; } = MockData.MockItems.GetMockItems().ToList();

        //Constructor initialisere Items med Mock-Data
        public List<Item> GetItems()
        {
            return MockData.MockItems.GetMockItems();
        }
    }
}
