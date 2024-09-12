using OOP2.Classes;
namespace OOP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxShow_Click(object sender, EventArgs e)
        {
            Course course = new Course(textBoxCourse.Text, int.Parse(textBoxPoints.Text), dateTimePickerStart.Value,
                                       dateTimePickerEnd.Value);
            string message = $"Kurs: {course.Name}\nPoäng: {course.Points}\nStartdatum: {course.StartDate.ToString()}\n" +
                             $"Slutdatum: {course.EndDate.ToString()}";
            MessageBox.Show(message);
        }
    }
}
