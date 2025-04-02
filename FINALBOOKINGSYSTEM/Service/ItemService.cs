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
        public IEnumerable<Item>NameSearch(string str)
        {
            List<Item> nameSearch = new List<Item>();
            foreach (Item item in Items)
            {
                if (item.Name.ToLower().Contains(str.ToLower()))
                {
                    nameSearch.Add(item);
                }
            //Fix crash ved søge med intet i søgefeltet
            }
            return nameSearch;
        }
        public IEnumerable<Item> IdFilter(int maxId, int minId = 0)
        {
            List<Item> filterList = new List<Item>();
            foreach (Item item in Items)
            { //hvorfor minId == 0?
                if ((minId == 0 && item.Id <= maxId) || (maxId == 0 && item.Id >= minId) || (item.Id >= minId && item.Id <= maxId))
                {
                    filterList.Add(item);
                }
            }
            return filterList;
        }
    }
}
