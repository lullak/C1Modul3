using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOPBokus.Classes
{
    public class Order
    {
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }
        public List<Book> Books { get; set; }
    }
}
