using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDemo1.Classes
{
    public class User
    {
        //För att skapa en property finns en sk snippet prop + tab + tab
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        //Snippet för att skapa en tom konstruktor är ctor
        public User()
        {
            
        }
        // ctrl + . för att generare ctor med värden
        public User(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
        }

        public void Save()
        {
            //här skriver vi värden till en textfil
        }
    }
}
