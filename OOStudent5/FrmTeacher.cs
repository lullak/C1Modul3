using OOStudent5.Classes;

namespace OOStudent5
{
    public partial class FrmTeacher : Form
    {
        public FrmTeacher()
        {
            InitializeComponent();
        }

        private void buttonShowResponsible_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.FullName = textBox1.Text;
            teacher.Email = textBox2.Text;
            teacher.Phone = textBox3.Text;
            string[] courses = teacher.ResponsibleTeacher();
            string addCourse = "";
            foreach (var course in courses)
            {
                addCourse += course + "\n";
            }
            MessageBox.Show(addCourse);
        }
    }
}
