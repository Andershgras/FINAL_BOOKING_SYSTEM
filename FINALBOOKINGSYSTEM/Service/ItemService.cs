using FINALBOOKINGSYSTEM.Models;

namespace FINALBOOKINGSYSTEM.Service
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
        public void AddItem(Item item)
        {
            Items.Add(item);
        }
    }
}
