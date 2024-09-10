using DemoOOPBilverkstad.Classes;

namespace DemoOOPBilverkstad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Customer customer = new Customer("Dennis","076777777", "Kinggaten 136", "Dennis@gmail.com" );
            Car car = new Car("was333", "Red", "BMW", 2022, customer);

            string color = car.Color;
            string ownerName = car.Owner.Name;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
