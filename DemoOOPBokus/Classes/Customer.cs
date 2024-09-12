using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOPBokus.Classes
{
    public class Customer
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Customer(string name, string phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }

        public Customer()
        {
            
        }

        public void Save() 
        {
            FileHandler fileHandler = new FileHandler(@"C:\Code\pwc\C1Modul3\DemoOOPBokus\Customer.txt\");
            string text = $"{Name},{Email},{Phone}";
            fileHandler.WriteToFile(text);
        }
    }
}
