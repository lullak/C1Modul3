namespace WinFormsRepi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Metod för att kontrollera en inloggning mot en textfil
        /// Använder en StreamReader för detta
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool Login(string username, string password) 
        {
            bool login = false;
            string file = @"C:\Users\Birca\Desktop\Namnlista.txt";
            using (StreamReader reader = new StreamReader(file))
            {
                string row;
                while ((row = reader.ReadLine()) != null)
                {
                    //Här tar vi ut en array med alla värden som finns
                    string[] values = row.Split(",");
                    if (values[0]==username && values[1] == password) 
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (Login(textBoxUsername.Text, textBoxPassword.Text)) 
            {
                labelMessage.Text = "Inloggning lyckades";
            }
            else
            {
                labelMessage.Text = "Inloggning misslyckades.";
            }

        }
    }
}
