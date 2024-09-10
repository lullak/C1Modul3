namespace OOP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }

    public class Course 
    {
        public string Name { get; set; }
        public string Points { get; set; }
        public string EndDate { get; set; }
        public string StartDate { get; set; }

        public void CalculateCourseDays() { }
        public void PointsPerCourseDay() { }
    }

    public class Student
    {
        public string Surname { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }

        public string GetGrades() 
        {
            return;
        }
    }
    public class Teacher
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public string CourseResponsibleTeacher()
        {
            return;
        }
    }
}
