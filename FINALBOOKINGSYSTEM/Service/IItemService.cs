using FINALBOOKINGSYSTEM.Models;
using Microsoft.AspNetCore.Mvc;

namespace FINALBOOKINGSYSTEM.Service
{
    public interface IItemService
    {
        List<Item> GetItems();

        public void AddItem(Item item);
        public Item GetItem(int id);
        public Item DeleteItem(int? itemId);
        public Item BookItem(int? itemId);

        public void SwitchBookStatus(int id);
        public void SwitchWhiteBoardStatus(int id);

        IEnumerable<Item> NameSearch(string str);

        IEnumerable<Item> IdFilter(int maxId, int minId = 0);


    }
}
