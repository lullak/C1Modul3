using frmBookCourt.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace frmBookCourt
{
    public partial class BookCourt : Form
    {
        private List<Court> courts;
        private List<Customer> customer;
        public BookCourt()
        {
            InitializeComponent();

            courts = new List<Court>
            {
                new Court(1, "Tennis"),
                new Court(2, "Squash"),
                new Court(3, "Badminton")
            };
            customer = new List<Customer>();
        }


    }
}
