namespace FINALBOOKINGSYSTEM.MockData
{
    public class MockItems
    {
        private static List<Models.Item> Items { get; set; } = new List<Models.Item>()
        {
            new Models.Item(1, "Lokale1", false),
            new Models.Item(2, "Lokale2", false),
            new Models.Item(3, "Lokale3", false)
        };
        public static List<Models.Item> GetMockItems()
        {
            return Items;
        }
    }
}
