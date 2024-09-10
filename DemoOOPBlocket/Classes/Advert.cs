namespace DemoOOPBlocket.Classes
{
    public class Advert
    {
        public string Headline { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }

        public Advert() { }

        public Advert(string headline, int price, DateTime date)
        {
            Headline = headline;
            Price = price;
            Date = date;
        }
    }
}
