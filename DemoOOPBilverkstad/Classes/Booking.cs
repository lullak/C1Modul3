using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOPBilverkstad.Classes
{
    public class Booking
    {
        public Car BookedCar { get; set; }
        public Service Service { get; set; }
        public DateTime Date { get; set; }
        public void Save() { }
        public void Update() { }
        public void Delete() { }
        public void Edit() { }
    }
}
