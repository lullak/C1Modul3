using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Classes
{
    public class Course
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        

        public Course(string name, int points, DateTime startDate, DateTime endDate)
        {
            Name = name;
            Points = points;
            StartDate = startDate;
            EndDate = endDate;
        }

        public void Save()
        {
            FileHandler fileHandler = new FileHandler("kurs.txt");
        }
        public double CalculateCourseDays() 
        {
            return (EndDate - StartDate).TotalDays;        
        }
        public float PointsPerCourseDay() 
        {
            return (float)CalculateCourseDays()/Points;

        }
    }
}
