using WinFormsDemo1.Classes;
namespace WinFormsDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.Username = textBoxUsername.Text;
            user.Password = textBoxPassword.Text;
            user.Email = textBoxEmail.Text;
            user.Save();
            User user2 = new User(textBoxUsername.Text, textBoxPassword.Text, textBoxEmail.Text);
            user.Save();
        }
    }
}