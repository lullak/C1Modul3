using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOPBilverkstad.Classes
{
    public class Car
    {
        public string RegNumber { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public Customer Owner { get; set; }

        public Car(string regNumber, string color, string model, int year, Customer owner)
        {
            RegNumber = regNumber;
            Color = color;
            Model = model;
            Year = year;
            Owner = owner;
        }

        public void Save() { }
        public void Update() { }
        public void Delete() { }
        public void Edit() { }
    }
}
