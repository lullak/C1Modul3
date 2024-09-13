using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStudent5.Classes
{
    public class Teacher
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }


        public string[] ResponsibleTeacher() 
        {
            return GetCourses();
        }

        private string[] GetCourses()
        {
            return new string[] { "Front-end programmering", "Webb introduktion", "Programmering C#" };
        }
    }
}
