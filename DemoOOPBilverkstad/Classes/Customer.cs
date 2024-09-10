using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOPBilverkstad.Classes
{
    public class Customer
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }

        public Customer(string name, string phone, string address, string mail)
        {
            Name = name;
            Phone = phone;
            Address = address;
            Mail = mail;
        }

        public void Save() { }
        public void Update() { }
        public void Delete() { }
        public void Edit() { }

    }
}
