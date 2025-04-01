using FINALBOOKINGSYSTEM.Models;

namespace FINALBOOKINGSYSTEM.Service
{
    public interface IItemService
    {
        List<Item> GetItems();

        public void AddItem(Item item);
    }
}
