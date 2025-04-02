using FINALBOOKINGSYSTEM.Models;

namespace FINALBOOKINGSYSTEM.Service
{
    public interface IItemService
    {
        List<Item> GetItems();

        public void AddItem(Item item);
        IEnumerable<Item> NameSearch(string str);

        IEnumerable<Item> IdFilter(int maxId, int minId = 0);
    }
}
