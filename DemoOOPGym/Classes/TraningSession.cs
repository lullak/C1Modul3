namespace DemoOOPGym.Classes
{
    public class TraningSession
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int MaxParticipants { get; set; }
        public Instructor Instructor { get; set; }
        public SessionType SessionType { get; set; }
        public List <Member> Members { get; set; }

        public TraningSession(DateTime startTime, DateTime endTime, int maxParticipants, 
                              Instructor instructor, SessionType sessionType)
        {
            StartTime = startTime;
            EndTime = endTime;
            MaxParticipants = maxParticipants;
            Instructor = instructor;
            SessionType = sessionType;
            
        }
    }
}
