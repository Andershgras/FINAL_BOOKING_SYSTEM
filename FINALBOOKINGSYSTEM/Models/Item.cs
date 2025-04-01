namespace Bookingsystem.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsBooked { get; set; }

        public Item(int id, string name, bool isBooked)
        {
            this.Id = id;
            this.Name = name;
            this.IsBooked = isBooked;
        }
        public Item()
        {
            this.Id = 0;
            this.Name = "Lokale0";
            this.IsBooked = false;
        }
    }
}
