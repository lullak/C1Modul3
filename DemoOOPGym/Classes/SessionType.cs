namespace DemoOOPGym.Classes
{
    public class SessionType
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public SessionType(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
