namespace DemoOOPGym.Classes
{
    public class Instructor
    {
        public string Name { get; set; }
        public List <SessionType> SessionTypes { get; set; } = new List<SessionType>();

        public Instructor(string name, List<SessionType> sessionTypes)
        {
            Name = name;
            SessionTypes = sessionTypes;
        }

        public void Save() 
        {

        }
        public void Delete()
        {

        }
        public void Update()
        {

        }
        public void Edit()
        {

        }
    }
}
