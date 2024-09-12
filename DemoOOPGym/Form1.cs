using DemoOOPGym.Classes;

namespace DemoOOPGym
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Membership membership = new Membership(300,"Studentmedlem","Student");

            
            Member  member = new Member("Lisa","0700000000","Ankavägen12", membership);
            
            SessionType spinning = new SessionType("Spinning", "");
            SessionType bodyPump = new SessionType("Body Pump", "");
            List<SessionType> sessionTypes = new List<SessionType>(); 
            sessionTypes.Add(spinning);
            sessionTypes.Add(bodyPump);

            Instructor instructor = new Instructor("Kalle",sessionTypes);
            TraningSession session = new TraningSession(DateTime.Now.AddDays(1),DateTime.Now.AddDays(1).AddHours(1),
                                                        20, instructor,spinning);
        }
    }
}
