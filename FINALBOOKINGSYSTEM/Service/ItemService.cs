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
        public IEnumerable<Item> IdFilter(int maxKapacitet, int minKapacitet = 0)
        {
            List<Item> filterList = new List<Item>();
            foreach (Item item in Items)
            { //hvorfor minId == 0?
                if ((minKapacitet == 0 && item.Kapacitet <= maxKapacitet) || (maxKapacitet == 0 && item.Kapacitet >= minKapacitet) || (item.Kapacitet >= minKapacitet && item.Kapacitet <= maxKapacitet))
                {
                    filterList.Add(item);
                }
            }
            return filterList;
        }
        public void UpdateItem(Item item)
        {
            if(item != null)
            {
                foreach (Item i in Items)
                {
                    if (i.Id == item.Id)
                    {
                        i.Name = item.Name;
                        i.Id = item.Id;
                        i.Kapacitet = item.Kapacitet;
                        i.Kommentar = item.Kommentar;
                        i.IsBooked = item.IsBooked;
                        i.HasWhiteBoard = item.HasWhiteBoard;
                    }
                }
            }
        }
        public Item GetItem(int id)
        {
            foreach (Item item in Items)
            {
                if(item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }
        public Item DeleteItem(int? itemId)
        {
            foreach (Item item in Items)
            {
                if (item.Id == itemId)
                {
                    Items.Remove(item);
                    return item;
                }
            }
            return null;
        }
        public Item BookItem(int? itemId)
        {
            foreach (Item item in Items)
            {
                if (item.Id == itemId)
                {
                    return item;
                }
            }
            return null;
        }
        public void SwitchBookStatus(int id)
        {
            var item = GetItem(id);
            if (item != null)
            {
                item.IsBooked = !item.IsBooked;
            }
        }
        public void SwitchWhiteBoardStatus(int id)
        {
            var item = GetItem(id);
            if (item != null)
            {
                item.HasWhiteBoard = !item.HasWhiteBoard;
            }
        }
    }

}
