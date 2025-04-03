namespace FINALBOOKINGSYSTEM.MockData
{
    public class MockItems
    {
        private static List<Models.Item> Items { get; set; } = new List<Models.Item>()
        {
            new Models.Item(1, "Lokale1", 1),
            new Models.Item(2, "Lokale2", 3),
            new Models.Item(3, "Lokale3", 5)
        };
        public static List<Models.Item> GetMockItems()
        {
            return Items;
        }
    }
}
