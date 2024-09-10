namespace OOP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Message message = new Message();
            string printMessage = textBox1.Text;

            MessageBox.Show(message.ShowMessage(printMessage));
            

        }
    }

    public class Message 
    {
        public string Text { get; set; }


        public string ShowMessage(string message)
        {
            return $"Hello world {message}";    
        }
    }
}
