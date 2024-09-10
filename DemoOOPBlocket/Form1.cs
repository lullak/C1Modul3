using DemoOOPBlocket.Classes;
namespace DemoOOPBlocket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string condition = textBoxSearchCondition.Text;
            List<Advert> data = GetData();

            FillSearchList(data, condition);

            //Samma kod på en rad
            //FillSearchList(GetData(), textBoxSearchCondition.Text);
        }

        private List<Advert> GetData()
        {
            List<Advert> adverts = new List<Advert>();
            adverts.Add(new Advert { Headline = "Cykel i fint skick", Price = 250, Date = DateTime.Parse("2024-09-01") });
            adverts.Add(new Advert { Headline = "Iphone 14", Price = 4500, Date = DateTime.Parse("2024-09-08") });
            adverts.Add(new Advert { Headline = "IKEA byrå Malm", Price = 550, Date = DateTime.Parse("2024-09-09") });
            adverts.Add(new Advert { Headline = "Samsun Galaxy X", Price = 3550, Date = DateTime.Parse("2024-08-09") });
            adverts.Add(new Advert { Headline = "Damcykel", Price = 550, Date = DateTime.Parse("2024-07-09") });
            adverts.Add(new Advert { Headline = "Barncykel", Price = 350, Date = DateTime.Parse("2024-09-15") });
            adverts.Add(new Advert { Headline = "Taylor Swift ståplatsbiljetter Fre 30/9", Price = 1000, Date = DateTime.Parse("2024-09-25") });
            adverts.Add(new Advert { Headline = "Spjälsäng", Price = 1400, Date = DateTime.Parse("2024-09-26") });
            adverts.Add(new Advert { Headline = "Billy bokhylla", Price = 200, Date = DateTime.Parse("2024-09-27") });
            
            return adverts;
        }

        private void FillSearchList(List<Advert> adverts, string searchCondition)
        {
            listBoxResult.Items.Clear();

            foreach (var advert in adverts)
            {
                if (advert.Headline.ToLower().Contains(searchCondition.ToLower()))
                {
                    listBoxResult.Items.Add(advert.Headline);
                }
            }
        }
    }
}
