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
            Course course = new Course(textBoxCourse.Text, textBoxPoints.Text, dateTimePickerStart.Text, dateTimePickerEnd.Text);
        }
    }
}
