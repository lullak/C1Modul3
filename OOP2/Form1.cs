using OOP2.Classes;
namespace OOP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Course course = null;
        private void setValues()
        {
            course = new Course(textBoxCourse.Text, int.Parse(textBoxPoints.Text), dateTimePickerStart.Value,
                                       dateTimePickerEnd.Value);
        }

        private void textBoxShow_Click(object sender, EventArgs e)
        {
            setValues();
            string message = $"Kurs: {course.Name}\nPoäng: {course.Points}\nStartdatum: {course.StartDate.ToString("yyyy-MM-dd")}\n" +
                             $"Slutdatum: {course.EndDate.ToString("yyyy-MM-dd")}";
            MessageBox.Show(message);
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            setValues();
            MessageBox.Show($"Kursen pågår i {course.CalculateCourseDays():##} dagar.");
        }

        private void buttonCalculatePoints_Click(object sender, EventArgs e)
        {
            setValues();
            MessageBox.Show($"Antal poäng per dag på kursen är {course.PointsPerCourseDay():##.##}.");
        }
    }
}
