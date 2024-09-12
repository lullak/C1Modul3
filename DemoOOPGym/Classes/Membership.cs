namespace DemoOOPGym.Classes
{
    public class Membership
    {
        public int Price { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }

        public Membership(int price, string type, string name)
        {
            Price = price;
            Type = type;
            Name = name;
        }
    }
}
